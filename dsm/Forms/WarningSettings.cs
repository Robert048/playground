using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dsm
{
    public partial class WarningSettings : Form
    {
        object parent1;
        object parent2;

        private int minInteger;
        private int maxInteger;

        public WarningSettings()
        {
            InitializeComponent();
            textBox1.Text = minInteger.ToString();
            textBox2.Text = maxInteger.ToString();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if (e.KeyChar == '.'
                && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            minInteger = Convert.ToInt32(textBox1.Text);
            maxInteger = Convert.ToInt32(textBox2.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        public bool checkValue(int output)
        {
            if (minInteger < output || maxInteger > output)
            {
                return false;
            }

            else
            {
                return true;
            }
        }

        private int getMinimum()
        {
            return maxInteger;
        }

        private int getmaximum()
        {
            return maxInteger;
        }

        private void WarningSettings_FormClosing(object sender, FormClosingEventArgs e)
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
        }
    }
}
