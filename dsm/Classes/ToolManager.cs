using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic.PowerPacks;
using iGreen.Controls.uControls.uLabelX;

namespace dsm
{
    class ToolManager
    {
        Panel mainPanel;
        Point lastMouseDrag;
        DragDropManager dragDropManager;
        ConnectManager connectionManager;

        //      Line Tool       //
        ShapeContainer sc;
        //      Hand Tool       //
        bool dragPlayground;
        bool handToolSelected;
        //      Shape Tools     //
        bool lineToolSelected;
        bool squareToolSelected;
        bool circleToolSelected;

        public ToolManager(Panel playground, DragDropManager dragDropManager)
        {
            this.mainPanel = playground;
            this.dragDropManager = dragDropManager;
            sc = new ShapeContainer();
            sc.Parent = this.mainPanel;
        }

        public ToolManager(Panel playground, DragDropManager dragDropManager, ConnectManager connectionManager)
        {
            this.mainPanel = playground;
            this.connectionManager = connectionManager;
            this.dragDropManager = dragDropManager;
            sc = new ShapeContainer();
            sc.Parent = this.mainPanel;
        }

        #region Move Panel(Handtool)
        /// <summary>
        /// drop and drag voor panels
        /// </summary>
        /// <param name="panel"></param>
        public void movePanel(Panel panel)
        {
            panel.MouseDown += playground_MouseDown;
            panel.MouseUp += playground_MouseUp;
            panel.MouseMove += playground_MouseMove;
        }

        public void handTool_click(object sender, EventArgs e)
        {
            handToolSelected = (sender as ToolStripButton).Checked;
        }
        #endregion Move Panel(Handtool)

        #region Text Tool Events
        /// <summary>
        /// texttool drag en drop
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void textTool_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) {
                TextBox textBox = new TextBox();
                textBox.KeyDown += textBox_KeyDown;
                //      Make move-able      //
                dragDropManager.makeControlMove(textBox);
                dragDropManager.setActiveControl(textBox);

                //      Start dragging      //
                mainPanel.DoDragDrop(textBox, DragDropEffects.All);
            }
        }

        /// <summary>
        /// textbox veranderen naar label bij enter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                uLabelX label = new uLabelX();
                label.Text = (sender as TextBox).Text;
                label.Location = new Point((sender as TextBox).Location.X - 5, (sender as TextBox).Location.Y - 10);
                label.Size = new System.Drawing.Size(80, 40);
                label.LocationChanged += label_LocationChanged;

                dragDropManager.makeControlMove(label);
                label.DoubleClick += label_DoubleClick;

                mainPanel.Controls.Add(label);
                label.BringToFront();

                mainPanel.Controls.Remove(sender as TextBox);
                (sender as TextBox).Dispose();
            }
        }

        /// <summary>
        /// verplaatsen van label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label_LocationChanged(object sender, EventArgs e)
        {
            (sender as uLabelX).Hide();
            (sender as uLabelX).Show();
        }

        /// <summary>
        /// dubbel klikken verandert het weer terug in textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label_DoubleClick(object sender, EventArgs e)
        {
            TextBox textBox = new TextBox();
            textBox.Text = (sender as uLabelX).Text;
            textBox.Location = new Point((sender as uLabelX).Location.X + 5, (sender as uLabelX).Location.Y + 10);

            textBox.KeyDown += textBox_KeyDown;
            dragDropManager.makeControlMove(textBox);

            mainPanel.Controls.Add(textBox);
            textBox.BringToFront();

            mainPanel.Controls.Remove(sender as uLabelX);
            (sender as uLabelX).Dispose();
        }
        #endregion Text Tool Events

        #region Edit/View Mode
        //TODO uitwerken edit en view mode
        public void editModeButton_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            e.ClickedItem.OwnerItem.Text = e.ClickedItem.Text;
        }

        public bool isEditMode()
        {
            if (mainPanel.Controls["menuBar"].Controls["editModeButton"].Text == "Edit Mode") {
                return true;
            }
            return false;
        }
        #endregion Edit/View Mode

        #region Panel Events
        /// <summary>
        /// drag voor de tools
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void playground_MouseDown(object sender, MouseEventArgs e)
        {
            if (handToolSelected) {
                dragPlayground = true;
                lastMouseDrag = new Point(e.X, e.Y);
            }
            else if (lineToolSelected) {
                lastMouseDrag = new Point(e.X, e.Y);
            }
            else if (squareToolSelected) {
                lastMouseDrag = new Point(e.X, e.Y);
            }
            else if (circleToolSelected) {
                lastMouseDrag = new Point(e.X, e.Y);
            }
        }

        /// <summary>
        /// drop voor de tools
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void playground_MouseUp(object sender, MouseEventArgs e)
        {
            handToolSelected = false;
            dragPlayground = false;
            if (lineToolSelected) {
                LineShape line = new LineShape();
                line.X1 = lastMouseDrag.X;
                line.Y1 = lastMouseDrag.Y;
                line.X2 = e.X;
                line.Y2 = e.Y;

                line.Parent = sc;
                lineToolSelected = true;

                line.PreviewKeyDown += shape_PreviewKeyDown;
            }
            else if (squareToolSelected) {
                RectangleShape square = new RectangleShape();
                if (lastMouseDrag.X > e.X) {
                    square.Left = e.X;
                    square.Width = lastMouseDrag.X - e.X;
                }
                else {
                    square.Left = lastMouseDrag.X;
                    square.Width = e.X - lastMouseDrag.X;
                }

                if (lastMouseDrag.Y > e.Y) {
                    square.Top = e.Y;
                    square.Height = lastMouseDrag.Y - e.Y;
                }
                else {
                    square.Top = lastMouseDrag.Y;
                    square.Height = e.Y - lastMouseDrag.Y;
                }
                square.Parent = sc;
                squareToolSelected = true;
                square.PreviewKeyDown += shape_PreviewKeyDown;
            }
            else if (circleToolSelected) {
                OvalShape circle = new OvalShape();
                if (lastMouseDrag.X > e.X) {
                    circle.Left = e.X;
                    circle.Width = lastMouseDrag.X - e.X;
                }
                else {
                    circle.Left = lastMouseDrag.X;
                    circle.Width = e.X - lastMouseDrag.X;
                }

                if (lastMouseDrag.Y > e.Y) {
                    circle.Top = e.Y;
                    circle.Height = lastMouseDrag.Y - e.Y;
                }
                else {
                    circle.Top = lastMouseDrag.Y;
                    circle.Height = e.Y - lastMouseDrag.Y;
                }
                circle.Parent = sc;
                circleToolSelected = true;
                circle.PreviewKeyDown += shape_PreviewKeyDown;
            }
        }

        /// <summary>
        /// slepen van de tools
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void playground_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragPlayground) {
                foreach (Control C in (sender as Panel).Controls) {
                    Point dragDiff = new Point(C.Location.X + (e.X - lastMouseDrag.X), C.Location.Y + (e.Y - lastMouseDrag.Y));
                    C.Location = dragDiff;
                }
                lastMouseDrag = new Point(e.X, e.Y);
            }
        }
        #endregion Panel Events

        #region Shape Tools
        //tool selection in menubalk

        public void lineTool_Click(object sender, EventArgs e)
        {
            lineToolSelected = (sender as ToolStripButton).Checked;
        }

        public void squareTool_Click(object sender, EventArgs e)
        {
            squareToolSelected = (sender as ToolStripButton).Checked;
        }

        public void circleTool_Click(object sender, EventArgs e)
        {
            circleToolSelected = (sender as ToolStripButton).Checked;
        }

        private void shape_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Delete) {
                (sender as Microsoft.VisualBasic.PowerPacks.Shape).Dispose();
            }
        }
        #endregion Shape Tools

        #region Shape Events
        /// <summary>
        /// drag en drop van een image
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void shape_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) {
                PictureBox picBox = new PictureBox();
                picBox.Image = (sender as PictureBox).Image;
                picBox.Size = new Size(75, 75);
                picBox.SizeMode = PictureBoxSizeMode.StretchImage;
                //      Make move-able      //
                dragDropManager.makeControlMove(picBox);
                dragDropManager.setActiveControl(picBox);

                //      Start dragging      //
                mainPanel.DoDragDrop(picBox, DragDropEffects.All);
            }
        }
        #endregion Shape Events

        #region Logical Controls
        /// <summary>
        /// drag en drop van logical operators
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void outputTool_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) {
                Panel panel = new Panel();
                panel.BackColor = Color.Red;
                panel.Size = new System.Drawing.Size(100, 100);
                panel.Name = "OutputPanel";

                Label name = new Label();
                name.Text = "Output";
                name.AutoSize = true;
                name.Location = new Point((panel.Width / 2) - (name.Width / 4) + 5, 10);
                name.Click += connectionManager.panel_Click;

                Label output = new Label();
                output.Name = "output";
                output.AutoSize = true;
                output.Location = new Point(panel.Width / 2, 65);
                output.Click += connectionManager.panel_Click;

                panel.Controls.Add(name);
                panel.Controls.Add(output);
            //    panel.DoubleClick += panel_DoubleClick;
                panel.Click += connectionManager.panel_Click;
               
                //      Make move-able      //
                dragDropManager.makeControlMove(panel);
                dragDropManager.setActiveControl(panel);

                //      Start dragging      //
                mainPanel.DoDragDrop(panel, DragDropEffects.All);
            }
        }

        /// <summary>
        /// drag en drop van calculator
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void calcTool_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) {
                Panel panel = new Panel();
                panel.BackColor = Color.Orange;
                panel.Size = new System.Drawing.Size(100, 100);

                Label name = new Label();
                name.Text = "Calculator";
                name.AutoSize = true;
                name.Location = new Point((panel.Width / 2) - (name.Width / 4), 10);
                name.Click += connectionManager.panel_Click;

                Label output = new Label();
                output.Name = "output";
                output.AutoSize = true;
                output.Location = new Point((panel.Width / 2) - 10, 65);
                output.Click += connectionManager.panel_Click;

                panel.Controls.Add(name);
                panel.Controls.Add(output);
                panel.Tag = new Calculator();
                panel.DoubleClick += panel_DoubleClick;
                panel.Click += connectionManager.panel_Click;
                //      Make move-able      //
                dragDropManager.makeControlMove(panel);
                dragDropManager.setActiveControl(panel);

                //      Start dragging      //
                mainPanel.DoDragDrop(panel, DragDropEffects.All);
            }
        }

        private void panel_DoubleClick(object sender, EventArgs e)
        {
            ((sender as Control).Tag as Form).Show();
        }

        #endregion Logical Controls

        public void comboBox_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        public void panelShowDialog_DoubleClick(object sender, EventArgs e)
        {
            ((sender as Control).Tag as Form).ShowDialog();
        }

        /// <summary>
        /// selection van tool in menubalk
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void menuBar_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            foreach (ToolStripItem item in (sender as ToolStrip).Items) {
                if (item != e.ClickedItem && item is ToolStripButton) {
                    (item as ToolStripButton).Checked = false;
                }
            }
            handToolSelected = false;
            lineToolSelected = false;
            squareToolSelected = false;
            circleToolSelected = false;
        }

        public ShapeContainer getShapeContainer()
        {
            sc = new ShapeContainer();
            return sc;
        }
    }
}
