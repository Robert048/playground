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
    public partial class IfOperator : Form
    {
        object parent1;
        object parent2;

        public IfOperator()
        {
            InitializeComponent();
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
