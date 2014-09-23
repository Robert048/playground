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
    public partial class LogicalOperator : Form
    {
        ToolManager toolManager;
        ConnectManager connectionManager;
        DragDropManager dragDropManager;

        public LogicalOperator(List<DataTemplate> templates)
        {
            //      Init Form       //
            InitializeComponent();
            this.Size = new System.Drawing.Size(SystemInformation.PrimaryMonitorSize.Width / 100 * 90, SystemInformation.PrimaryMonitorSize.Height / 100 * 90);
            this.Left = SystemInformation.VirtualScreen.Width / 100;
            this.Top = SystemInformation.VirtualScreen.Height / 100;
            menuBar.Width = this.Width;
            this.menuBar.Left = 0;

            //      Init Fields     //
            connectionManager = new ConnectManager();
            dragDropManager = new DragDropManager(connectionManager);
            toolManager = new ToolManager(logicalPanel, dragDropManager, connectionManager);
            dragDropManager.makePanelDraggable(logicalPanel);
            toolManager.movePanel(logicalPanel);

            //      Init Buttons        //
            handTool.Click += toolManager.handTool_click;
            textTool.MouseDown += toolManager.textTool_MouseDown;
            connectTool.Click += connectionManager.connectTool_Click;
            outputTool.MouseDown += toolManager.outputTool_MouseDown;
            calcButton.MouseDown += toolManager.calcTool_MouseDown;

            populateList(templates);
        }

        #region Form Events
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LogicalOperator_Activated(object sender, EventArgs e)
        {
            foreach (Control control in logicalPanel.Controls) {
                if (control is Panel && control.Tag is Calculator) {
                    control.Controls["output"].Text = (control.Tag as Calculator).getOutput().ToString();
                }
            }
        }

        private void menuBar_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            foreach (ToolStripItem item in (sender as ToolStrip).Items) {
                if (item != e.ClickedItem && item is ToolStripButton) {
                    (item as ToolStripButton).Checked = false;
                }
            }
            connectionManager.setConnectTool(false);
        }

        private void LogicalOperator_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Visible = false;
        }
        #endregion Form Events

        private void populateList(List<DataTemplate> templates)
        {
            for (int i = 0; i < templates.Count; i++) {
                ComboBox comboBox = new ComboBox();
                comboBox.Location = new System.Drawing.Point(5, i * 20);
                comboBox.Size = new System.Drawing.Size(200, 25);
                comboBox.Text = templates[i].getData()[0][1];
                comboBox.Tag = templates[i];
                comboBox.KeyDown += toolManager.comboBox_KeyDown;
                comboBox.MouseDown += dragDropManager.comboBox_MouseDown_panel;
                int j = 0;
                foreach (string[] item in templates[i].getData()) {
                    if (j != 0) {
                        comboBox.Items.Add(item[1]);
                    }
                    j++;
                }
                dataPanel.Controls.Add(comboBox);
            }
        }

        public object getOutput()
        {
            try {
                return logicalPanel.Controls["OutputPanel"].Tag;
            }
            catch {
                return "No output";
            }
        }
    }
}
