using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dsm;

namespace dsm
{
    public partial class Calculator : Form
    {
        private object parent1; // eerste gekoppelde machine
        private object parent2; // tweede gekoppelde machine

        private object leftItem;
        private object rightItem;

        private int indexID;
        private int outputType; // 0 is double - 1 is integer

        private Object output;

        private CalculateValue calculatevalue;

        public Calculator()
        {
            InitializeComponent();
            checkValues();
            calculatevalue = new CalculateValue();
            comboBoxModifier.SelectedIndex = 0;
            comboBoxOutput.SelectedIndex = 1;
        }

        /// <summary>
        /// dropdown lijst van gegevens uit de gekoppelde machines vuillen
        /// </summary>
        private void populateCombos()
        {
            if (parent1 != null) {
                if (parent1 is DataTemplate) 
                {
                    comboBoxLeft.Items.Clear();
                    foreach (string[] item in (parent1 as DataTemplate).getData()) 
                    {
                        comboBoxLeft.Items.Add(item[0].ToString() + ": " + item[1]);
                    }
                }
                else {
                    comboBoxLeft.Text = parent1.ToString();
                    comboBoxLeft.DropDownStyle = ComboBoxStyle.Simple;
                    leftItem = parent1;
                    calcLeft();
                    leftOutput.Text = parent1.ToString();
                }
            }
            if (parent2 != null) {
                if (parent2 is DataTemplate) {
                    comboBoxRight.Items.Clear();
                    foreach (string[] item in (parent2 as DataTemplate).getData()) {
                        comboBoxRight.Items.Add(item[0].ToString() + ": " + item[1]);
                    }
                }
                else {
                    comboBoxRight.Visible = false;
                    comboBoxLeft.DropDownStyle = ComboBoxStyle.Simple;
                    rightItem = parent2;
                    calcRight();
                    rightOutput.Text = parent2.ToString();
                }
            }
        }

        /// <summary>
        /// Modifier voor de berekening
        /// </summary>
        private void comboBoxModifier_SelectedIndexChanged(object sender, EventArgs e)
        {
            string option = comboBoxModifier.Text;
            leftOutput.Text = "" + option;
            indexID = comboBoxModifier.SelectedIndex;
            calculatevalue.setModifier(indexID);
            updateAll();
        }

        /// <summary>
        /// Selecteren van de output type, double of integer
        /// </summary>
        private void comboBoxOutput_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.outputType = comboBoxOutput.SelectedIndex;
            updateAll();
        }

        /// <summary>
        /// Als comboBoxLeft of comboBoxRight is null of als indexID is kleiner 0 of groter 4 wordt er een melding geplaatst
        /// </summary>
        private void checkValues()
        {
            if (comboBoxLeft.SelectedItem == null || comboBoxRight.SelectedItem == null || indexID < 0 || indexID > 4)
            {
                outputWarning.Text = "Incorrecte data, is alles correct ingevuld?";
            }
            else
            {
                outputWarning.Text = "";
            }
        }

        /// <summary>
        /// Berekening voor de output
        /// </summary>
        private void doubleOutput()
        {
            this.output = calculatevalue.calcDouble();
        }
        /// <summary>
        /// Berekening voor de output
        /// </summary>
        private void integerOutput()
        {
            this.output = calculatevalue.calcInteger();
        }

        /// <summary>
        /// Output update
        /// </summary>
        private void updateAll()
        {
            checkValues();
            if (outputType == 0)
            {
                doubleOutput();
            }
            if (outputType == 1)
            {
                integerOutput();
            }
            outputShow.Text = "Output: " + Convert.ToString(this.output) + "";
            outputDetails.Text = calculatevalue.warningMessage();
        }

        /// <summary>
        /// Getter
        /// </summary>
        public object getOutput()
        {
            return output;
        }

        /// <summary>
        /// Form close event handler
        /// </summary>
        private void Calculator_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Visible = false;
        }

        /// <summary>
        /// Object vullen met gegevens van database
        /// </summary>
        /// <param name="template"></param>
        public void setParent(object template)
        {
            if (parent1 == null) {
                parent1 = template;
            }
            else if (parent2 == null) {
                parent2 = template;
            }
            populateCombos();
        }

        private void comboBox_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }


        private void comboBoxLeft_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = comboBoxLeft.SelectedItem.ToString();
            int splitIndex = selectedItem.IndexOf(':') + 2;
            string outputToCalculate = selectedItem.Substring(splitIndex, selectedItem.Length - splitIndex);
            label1.Text = outputToCalculate;
            leftItem = outputToCalculate;

            calcLeft();
        }

        private void comboBoxRight_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = comboBoxRight.SelectedItem.ToString();
            int splitIndex = selectedItem.IndexOf(':') + 2;
            string outputToCalculate = selectedItem.Substring(splitIndex, selectedItem.Length - splitIndex);
            rightOutput.Text = outputToCalculate;
            rightItem = outputToCalculate;

            calcRight();
        }

        private void calcLeft()
        {
            double double1 = 0.0;
            int integer1 = 0;

            try
            {
                double1 = Convert.ToDouble(leftItem.ToString());
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
            }

            try
            {
                integer1 = Convert.ToInt32(leftItem.ToString());
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
            }

            calculatevalue.setDouble1(double1);
            calculatevalue.setInteger1(integer1);

            calculatevalue.setString1(leftItem.ToString());

            updateAll();
        }

        private void calcRight()
        {
            double double2 = 0.0;
            int integer2 = 0;

            try
            {
                double2 = Convert.ToDouble(rightItem.ToString());
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
            }

            try
            {
                integer2 = Convert.ToInt32(rightItem.ToString());
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
            }

            calculatevalue.setDouble2(double2);
            calculatevalue.setInteger2(integer2);

            calculatevalue.setString2(rightItem.ToString());

            updateAll();
        }
    }
}
