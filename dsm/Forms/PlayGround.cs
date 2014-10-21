using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Svg;
using System.Drawing;
using dsm;
using Microsoft.VisualBasic.PowerPacks;

namespace dsm
{
    public partial class PlayGround : Form
    {
        Data data;
        ToolManager toolManager;
        FolderManager folderManager;
        List<DataTemplate> templates;
        DragDropManager dragDropManager;

        public PlayGround()
        {
            InitializeComponent();
            
            data = new Data();
            dragDropManager = new DragDropManager();
            folderManager = new FolderManager();
            toolManager = new ToolManager(panelPlayground, dragDropManager);
            templates = new List<DataTemplate>();

            //      Init Form      //
            toolManager.movePanel(panelPlayground);
            dragDropManager.makePanelDraggable(panelPlayground);
            menuBar.Width = this.Width - 18;
            this.Size = new System.Drawing.Size((SystemInformation.PrimaryMonitorSize.Width / 100) * 90, (SystemInformation.PrimaryMonitorSize.Height / 100) * 90);

            //      Init Tools      //
            handTool.Click += toolManager.handTool_click;
            lineTool.Click += toolManager.lineTool_Click;
            squareTool.Click += toolManager.squareTool_Click;
            circleTool.Click += toolManager.circleTool_Click;
            textTool.MouseDown += toolManager.textTool_MouseDown;
            menuBar.ItemClicked += toolManager.menuBar_ItemClicked;
            editModeButton.DropDownItemClicked += toolManager.editModeButton_DropDownItemClicked;

            populateShapes();
        }

        #region Database Events
        /// <summary>
        /// Database update timer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void updateTimer_Tick(object sender, EventArgs e)
        {
            updateTimer.Enabled = false;
            bool connectionSucceeded = data.databaseConnection();
            drawDataCombo(string.Format("SELECT ST.*, FT.start, FT.eind, FT.Extruder FROM [dbo].[SecondTable] ST,[dbo].[Table] FT"));
            data.getConnection().Close();

            setConnectionLabel(connectionSucceeded);
            lastUpdateLabel.Text = "Updated on " + DateTime.Now.ToString("hh:mm:ss");
            updateTimeTextBox_TextChanged(updateTimeTextBox, e);
            updateTimer.Enabled = true;
        }

        /// <summary>
        /// Refresh van de timer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void refreshButton_Click(object sender, EventArgs e)
        {
            updateTimer_Tick(updateTimer, e);
        }

        /// <summary>
        /// Interval textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void updateTimeTextBox_TextChanged(object sender, EventArgs e)
        {
            int value;
            bool isNum = int.TryParse(updateTimeTextBox.Text, out value);
            if (isNum) {
                updateTimer.Interval = value * 60000;
                updateTimer.Stop();
                updateTimer.Start();
            }
        }

        /// <summary>
        /// Data uit database in combobox
        /// </summary>
        /// <param name="sql"></param>
        private void drawDataCombo(string sql)
        {
            List<DataRow> rows = data.executeQuery(sql);
            DataTable dataTable = data.getDatatable();
            ComboBox[] boxes = new ComboBox[rows.Count];
            try {
                for (int i = 0; i < rows.Count; i++) {
                    ComboBox comboBox = new ComboBox();
                    comboBox.Location = new System.Drawing.Point(5, i * 20);
                    comboBox.Size = new System.Drawing.Size(200, 25);
                    comboBox.Text = "TAG: " + rows[i].ItemArray[0].ToString();
                    comboBox.MouseDown += dragDropManager.comboBox_MouseDown_label;
                    comboBox.KeyDown += toolManager.comboBox_KeyDown;
                    templates.Add(new DataTemplate(rows[i], i));

                    for (int j = 0; j < rows[i].ItemArray.Length; j++) {
                        comboBox.Items.Add(dataTable.Columns[j].ColumnName.ToUpper() + ": " + rows[i].ItemArray[j]);
                    }
                    boxes[i] = comboBox;
                }
            }
            catch (Exception e) {
                Console.WriteLine("Error at creating comboBoxes | " + e.Message);
            }
            try {
                List<Control> oldControls = new List<Control>();
                foreach (Control c in panelData.Controls) {
                    oldControls.Add(c);
                }
                panelData.Controls.AddRange(boxes);
                foreach (Control c in oldControls) {
                    panelData.Controls.Remove(c);
                }
            }
            catch (Exception e) {
                Console.WriteLine("Error at removing comboBoxes | " + e.Message);
            }
        }

        /// <summary>
        /// Veranderen van label text
        /// </summary>
        /// <param name="value"></param>
        private void setConnectionLabel(bool value)
        {
            if (value) {
                connectionLabel.Text = "Connection: Sucessfull";
                connectionLabel.ForeColor = System.Drawing.Color.Green;
                lastUpdateLabel.Text = "Updated on " + DateTime.Now.ToString("hh:mm:ss");
            }
            else {
                connectionLabel.Text = "Connection: Failed";
                connectionLabel.ForeColor = System.Drawing.Color.Red;
            }
        }
        #endregion Database Events

        #region Form Events
        /// <summary>
        /// menuBar brede aanpassen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PlayGround_SizeChanged(object sender, EventArgs e)
        {
            menuBar.Width = this.Width - 18;
        }

        /// <summary>
        /// Veranderen van output tekst
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PlayGround_Activated(object sender, EventArgs e)
        {
            foreach (Control control in panelPlayground.Controls) {
                if (control is Panel && control.Tag is LogicalOperator) {
                    control.Controls["output"].Text = (control.Tag as LogicalOperator).getOutput().ToString();
                }
            }
        }
        #endregion Form Events

        #region Shape Events
        /// <summary>
        /// Toevoegen van picturebox in de rechte kant van PlayGround
        /// </summary>
        private void populateShapes()
        {
            int width = 10;
            int height = 10;
            int line = 0;
            foreach (string photoPath in folderManager.getImages()) {
                PictureBox picBox = new PictureBox();
                picBox.Load(photoPath);
                picBox.Location = new Point(width, height);
                picBox.SizeMode = PictureBoxSizeMode.StretchImage;
                picBox.Size = new System.Drawing.Size(75, 75);
                picBox.MouseDown += toolManager.shape_MouseDown;
                picBox.BringToFront();
                
                Label label = new Label();
                label.Text = getName(photoPath);
                label.Size = new System.Drawing.Size(95, 20);
                label.Location = new Point(width - 10, height + 75);
                label.TextAlign = ContentAlignment.MiddleCenter;
                label.BackColor = Color.LightGray;
                
                while (label.Width < System.Windows.Forms.TextRenderer.MeasureText(label.Text,
                    new Font(label.Font.FontFamily, label.Font.Size, label.Font.Style)).Width) {
                    label.Font = new Font(label.Font.FontFamily, label.Font.Size - 0.5f, label.Font.Style);
                }

                panelShapes.Controls.Add(label);
                panelShapes.Controls.Add(picBox);

                if (line == 0) {
                    width += 100;
                    line++;
                }
                else {
                    line = 0;
                    height += 110;
                    width -= 100;
                }
            } 
        }

        /// <summary>
        /// Parsing van de string
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        private string getName(string path)
        {
            return path.Substring(path.LastIndexOf(@"\") + 1, path.Length - path.LastIndexOf(@"\") - 5);
        }
        #endregion Shape Events
        
        #region Menu Events
        /// <summary>
        /// Alles verwijderen van playground
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clearPlayGroundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Wil je alles verwijderen?", "Waarschuwing",
            MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes) {
                panelPlayground.Controls.Clear();
                ShapeContainer sc = toolManager.getShapeContainer();
                panelPlayground.Controls.Add(sc);
            }
        }
        #endregion Menu Events

        /// <summary>
        /// Openen van de grafiek form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void viewGraphToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Grafiek secondForm = new Grafiek();
            secondForm.Show();
        }

        /// <summary>
        /// Aanmaken van de logical operator
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void createLogicEditoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LogicalOperator logicalOperator = new LogicalOperator(templates);
            logicalOperator.ShowDialog();

            Panel panel = new Panel();
            panel.BackColor = Color.LightBlue;
            panel.Size = new System.Drawing.Size(100, 100);
            Point test = (sender as ToolStripDropDownItem).GetCurrentParent().Location;
            panel.Location = panelPlayground.PointToClient(test);
            panel.Tag = logicalOperator;
            panel.DoubleClick += toolManager.panelShowDialog_DoubleClick;
            dragDropManager.makeControlMove(panel);

            Label name = new Label();
            name.Text = "Logic Operator";
            name.AutoSize = true;
            name.Location = new Point((panel.Width / 2) - (name.Width / 2) + 12, 10);

            Label output = new Label();
            output.Name = "output";
            output.AutoSize = true;
            output.Location = new Point((panel.Width / 2) - 10, 65);

            panel.Controls.Add(name);
            panel.Controls.Add(output);
            panelPlayground.Controls.Add(panel);

            try {
                output.Text = logicalOperator.getOutput().ToString();
            }
            catch { }
        }

        /// <summary>
        /// Nieuwe afbeelding toevoegen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addShapeButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Title = "Add a Shape";
            fileDialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (fileDialog.ShowDialog() == DialogResult.OK) {
                try {
                    folderManager.addImage(fileDialog.FileName);
                    Button addButton = panelShapes.Controls["addShapeButton"] as Button;
                    panelShapes.Controls.Clear();
                    panelShapes.Controls.Add(addButton);

                    populateShapes();
                }
                catch {
                }
            }
        }
    }
}