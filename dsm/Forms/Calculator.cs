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
        object parent1;
        object parent2;

        object leftItem;
        object rightItem;

        private int indexID;
        private int outputType;

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

        private void populateCombos()
        {
            if (parent1 != null) {
                if (parent1 is DataTemplate) {
                    comboBoxLeft.Items.Clear();
                    foreach (string[] item in (parent1 as DataTemplate).getData()) {
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

        private void comboBoxModifier_SelectedIndexChanged(object sender, EventArgs e)
        {
            string option = comboBoxModifier.Text;
            leftOutput.Text = "" + option;
            indexID = comboBoxModifier.SelectedIndex;
            calculatevalue.setModifier(indexID);
            updateAll();
        }

        private void comboBoxOutput_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.outputType = comboBoxOutput.SelectedIndex;
            updateAll();
        }

        private void checkValues()
        {
            if (comboBoxLeft.SelectedItem == null || comboBoxRight.SelectedItem == null || indexID < 0 || indexID > 5)
            {
                outputWarning.Text = "Incorrecte data, is alles correct ingevuld?";
            }
            else
            {
                outputWarning.Text = "";
            }
        }

        private void doubleOutput()
        {
            this.output = calculatevalue.calcDouble();
        }

        private void integerOutput()
        {
            this.output = calculatevalue.calcInteger();
        }

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

        public object getOutput()
        {
            return output;
        }

        private void Calculator_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Visible = false;
        }

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
            TypeCheck typecheck1 = new TypeCheck();
            typecheck1.typeCheck(leftItem.ToString());

            double double1 = typecheck1.getDouble();
            int integer1 = typecheck1.getInteger();

            calculatevalue.setDouble1(double1);
            calculatevalue.setInteger1(integer1);

            calculatevalue.setString1(leftItem.ToString());

            updateAll();
        }

        private void calcRight()
        {
            TypeCheck typecheck2 = new TypeCheck();
            typecheck2.typeCheck(rightItem.ToString());

            double double2 = typecheck2.getDouble();
            int integer2 = typecheck2.getInteger();

            calculatevalue.setDouble2(double2);
            calculatevalue.setInteger2(integer2);

            calculatevalue.setString2(rightItem.ToString());

            updateAll();
        }
    }
}
