namespace dsm
{
    partial class PlayGround
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayGround));
            this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
            this.panelData = new System.Windows.Forms.Panel();
            this.panelShapes = new System.Windows.Forms.Panel();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.menuBar = new System.Windows.Forms.ToolStrip();
            this.handTool = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.lineTool = new System.Windows.Forms.ToolStripButton();
            this.squareTool = new System.Windows.Forms.ToolStripButton();
            this.circleTool = new System.Windows.Forms.ToolStripButton();
            this.textTool = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.lastUpdateLabel = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.updateTimeTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.refreshButton = new System.Windows.Forms.ToolStripButton();
            this.connectionLabel = new System.Windows.Forms.ToolStripLabel();
            this.editModeButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.viewModeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editModeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panelPlayground = new System.Windows.Forms.Panel();
            this.updateTimer = new System.Windows.Forms.Timer(this.components);
            this.viewGraphToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mainPlayground = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.createLogicEditoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addShapeButton = new System.Windows.Forms.Button();
            this.panelShapes.SuspendLayout();
            this.flowLayoutPanel.SuspendLayout();
            this.menuBar.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.mainPlayground.SuspendLayout();
            this.SuspendLayout();
            // 
            // BottomToolStripPanel
            // 
            this.BottomToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.BottomToolStripPanel.Name = "BottomToolStripPanel";
            this.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.BottomToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.BottomToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // TopToolStripPanel
            // 
            this.TopToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.TopToolStripPanel.Name = "TopToolStripPanel";
            this.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.TopToolStripPanel.RowMargin = new System.Windows.Forms.Padding(0);
            this.TopToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // RightToolStripPanel
            // 
            this.RightToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.RightToolStripPanel.Name = "RightToolStripPanel";
            this.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.RightToolStripPanel.RowMargin = new System.Windows.Forms.Padding(0);
            this.RightToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // LeftToolStripPanel
            // 
            this.LeftToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftToolStripPanel.Name = "LeftToolStripPanel";
            this.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.LeftToolStripPanel.RowMargin = new System.Windows.Forms.Padding(0);
            this.LeftToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // ContentPanel
            // 
            this.ContentPanel.Size = new System.Drawing.Size(150, 150);
            // 
            // panelData
            // 
            this.panelData.AutoScroll = true;
            this.panelData.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelData.Location = new System.Drawing.Point(0, 57);
            this.panelData.Name = "panelData";
            this.panelData.Size = new System.Drawing.Size(225, 324);
            this.panelData.TabIndex = 8;
            // 
            // panelShapes
            // 
            this.panelShapes.Controls.Add(this.addShapeButton);
            this.panelShapes.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelShapes.Location = new System.Drawing.Point(628, 57);
            this.panelShapes.Name = "panelShapes";
            this.panelShapes.Size = new System.Drawing.Size(200, 324);
            this.panelShapes.TabIndex = 11;
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.BackgroundImage = global::dsm.Properties.Resources.toolbar_bg;
            this.flowLayoutPanel.Controls.Add(this.menuBar);
            this.flowLayoutPanel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.flowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel.Location = new System.Drawing.Point(0, 21);
            this.flowLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.flowLayoutPanel.Size = new System.Drawing.Size(828, 36);
            this.flowLayoutPanel.TabIndex = 6;
            // 
            // menuBar
            // 
            this.menuBar.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.menuBar.AllowMerge = false;
            this.menuBar.AutoSize = false;
            this.menuBar.BackColor = System.Drawing.Color.Transparent;
            this.menuBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuBar.CanOverflow = false;
            this.menuBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.menuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.handTool,
            this.toolStripSeparator1,
            this.lineTool,
            this.squareTool,
            this.circleTool,
            this.textTool,
            this.toolStripButton2,
            this.lastUpdateLabel,
            this.toolStripSeparator2,
            this.updateTimeTextBox,
            this.toolStripLabel3,
            this.toolStripSeparator3,
            this.refreshButton,
            this.connectionLabel,
            this.editModeButton});
            this.menuBar.Location = new System.Drawing.Point(0, 2);
            this.menuBar.Name = "menuBar";
            this.menuBar.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuBar.ShowItemToolTips = false;
            this.menuBar.Size = new System.Drawing.Size(828, 31);
            this.menuBar.Stretch = true;
            this.menuBar.TabIndex = 0;
            this.menuBar.Text = "menuBar";
            // 
            // handTool
            // 
            this.handTool.AutoSize = false;
            this.handTool.AutoToolTip = false;
            this.handTool.BackColor = System.Drawing.Color.Transparent;
            this.handTool.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.handTool.CheckOnClick = true;
            this.handTool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.handTool.Image = ((System.Drawing.Image)(resources.GetObject("handTool.Image")));
            this.handTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.handTool.Margin = new System.Windows.Forms.Padding(0);
            this.handTool.Name = "handTool";
            this.handTool.Size = new System.Drawing.Size(28, 25);
            this.handTool.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.handTool.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // lineTool
            // 
            this.lineTool.AutoSize = false;
            this.lineTool.AutoToolTip = false;
            this.lineTool.BackColor = System.Drawing.Color.Transparent;
            this.lineTool.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.lineTool.CheckOnClick = true;
            this.lineTool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.lineTool.Image = ((System.Drawing.Image)(resources.GetObject("lineTool.Image")));
            this.lineTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.lineTool.Margin = new System.Windows.Forms.Padding(0);
            this.lineTool.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.lineTool.Name = "lineTool";
            this.lineTool.Size = new System.Drawing.Size(28, 25);
            this.lineTool.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lineTool.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // squareTool
            // 
            this.squareTool.AutoToolTip = false;
            this.squareTool.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.squareTool.CheckOnClick = true;
            this.squareTool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.squareTool.Image = ((System.Drawing.Image)(resources.GetObject("squareTool.Image")));
            this.squareTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.squareTool.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.squareTool.Name = "squareTool";
            this.squareTool.Size = new System.Drawing.Size(23, 28);
            this.squareTool.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // circleTool
            // 
            this.circleTool.AutoToolTip = false;
            this.circleTool.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.circleTool.CheckOnClick = true;
            this.circleTool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.circleTool.Image = ((System.Drawing.Image)(resources.GetObject("circleTool.Image")));
            this.circleTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.circleTool.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.circleTool.Name = "circleTool";
            this.circleTool.Size = new System.Drawing.Size(23, 28);
            this.circleTool.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // textTool
            // 
            this.textTool.AutoSize = false;
            this.textTool.AutoToolTip = false;
            this.textTool.BackColor = System.Drawing.Color.Transparent;
            this.textTool.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.textTool.CheckOnClick = true;
            this.textTool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.textTool.Image = ((System.Drawing.Image)(resources.GetObject("textTool.Image")));
            this.textTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.textTool.Margin = new System.Windows.Forms.Padding(0);
            this.textTool.Name = "textTool";
            this.textTool.Size = new System.Drawing.Size(27, 25);
            this.textTool.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.AutoSize = false;
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Enabled = false;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.toolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Margin = new System.Windows.Forms.Padding(0);
            this.toolStripButton2.MergeIndex = 0;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(6, 22);
            this.toolStripButton2.Text = "toolStripButton1";
            this.toolStripButton2.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            // 
            // lastUpdateLabel
            // 
            this.lastUpdateLabel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.lastUpdateLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastUpdateLabel.Name = "lastUpdateLabel";
            this.lastUpdateLabel.Size = new System.Drawing.Size(114, 28);
            this.lastUpdateLabel.Text = "Updated on 00:00:00";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // updateTimeTextBox
            // 
            this.updateTimeTextBox.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.updateTimeTextBox.Name = "updateTimeTextBox";
            this.updateTimeTextBox.Size = new System.Drawing.Size(25, 31);
            this.updateTimeTextBox.Text = "60";
            this.updateTimeTextBox.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.updateTimeTextBox.TextChanged += new System.EventHandler(this.updateTimeTextBox_TextChanged);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(79, 28);
            this.toolStripLabel3.Text = "Refresh Time:";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 31);
            // 
            // refreshButton
            // 
            this.refreshButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.refreshButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.refreshButton.Image = ((System.Drawing.Image)(resources.GetObject("refreshButton.Image")));
            this.refreshButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(23, 28);
            this.refreshButton.Text = "toolStripButton3";
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // connectionLabel
            // 
            this.connectionLabel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.connectionLabel.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.connectionLabel.Name = "connectionLabel";
            this.connectionLabel.Size = new System.Drawing.Size(116, 28);
            this.connectionLabel.Text = "Connection: Inactive";
            // 
            // editModeButton
            // 
            this.editModeButton.AutoSize = false;
            this.editModeButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.editModeButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editModeMenuItem,
            this.viewModeMenuItem});
            this.editModeButton.Image = ((System.Drawing.Image)(resources.GetObject("editModeButton.Image")));
            this.editModeButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.editModeButton.Name = "editModeButton";
            this.editModeButton.Size = new System.Drawing.Size(79, 28);
            this.editModeButton.Text = "Edit Mode";
            // 
            // viewModeMenuItem
            // 
            this.viewModeMenuItem.Name = "viewModeMenuItem";
            this.viewModeMenuItem.Size = new System.Drawing.Size(152, 22);
            this.viewModeMenuItem.Text = "View Mode";
            // 
            // editModeMenuItem
            // 
            this.editModeMenuItem.Name = "editModeMenuItem";
            this.editModeMenuItem.Size = new System.Drawing.Size(152, 22);
            this.editModeMenuItem.Text = "Edit Mode";
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menuStrip1.BackgroundImage")));
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(0);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.menuStrip1.Size = new System.Drawing.Size(828, 21);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 21);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewGraphToolStripMenuItem1,
            this.toolStripMenuItem1});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 21);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(166, 22);
            this.toolStripMenuItem1.Text = "Clear PlayGround";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.clearPlayGroundToolStripMenuItem_Click);
            // 
            // panelPlayground
            // 
            this.panelPlayground.AllowDrop = true;
            this.panelPlayground.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelPlayground.ContextMenuStrip = this.mainPlayground;
            this.panelPlayground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPlayground.Location = new System.Drawing.Point(225, 57);
            this.panelPlayground.Name = "panelPlayground";
            this.panelPlayground.Size = new System.Drawing.Size(403, 324);
            this.panelPlayground.TabIndex = 12;
            // 
            // updateTimer
            // 
            this.updateTimer.Enabled = true;
            this.updateTimer.Interval = 1;
            this.updateTimer.Tick += new System.EventHandler(this.updateTimer_Tick);
            // 
            // viewGraphToolStripMenuItem1
            // 
            this.viewGraphToolStripMenuItem1.Name = "viewGraphToolStripMenuItem1";
            this.viewGraphToolStripMenuItem1.Size = new System.Drawing.Size(166, 22);
            this.viewGraphToolStripMenuItem1.Text = "View Graph";
            this.viewGraphToolStripMenuItem1.Click += new System.EventHandler(this.viewGraphToolStripMenuItem1_Click);
            // 
            // mainPlayground
            // 
            this.mainPlayground.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createLogicEditoToolStripMenuItem});
            this.mainPlayground.Name = "mainPlayground";
            this.mainPlayground.Size = new System.Drawing.Size(175, 26);
            // 
            // createLogicEditoToolStripMenuItem
            // 
            this.createLogicEditoToolStripMenuItem.Name = "createLogicEditoToolStripMenuItem";
            this.createLogicEditoToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.createLogicEditoToolStripMenuItem.Text = "Create Logic Editor";
            this.createLogicEditoToolStripMenuItem.Click += new System.EventHandler(this.createLogicEditoToolStripMenuItem_Click);
            // 
            // addShapeButton
            // 
            this.addShapeButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.addShapeButton.Location = new System.Drawing.Point(0, 301);
            this.addShapeButton.Name = "addShapeButton";
            this.addShapeButton.Size = new System.Drawing.Size(200, 23);
            this.addShapeButton.TabIndex = 0;
            this.addShapeButton.Text = "Add a Shape";
            this.addShapeButton.UseVisualStyleBackColor = true;
            this.addShapeButton.Click += new System.EventHandler(this.addShapeButton_Click);
            // 
            // PlayGround
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 381);
            this.Controls.Add(this.panelPlayground);
            this.Controls.Add(this.panelShapes);
            this.Controls.Add(this.panelData);
            this.Controls.Add(this.flowLayoutPanel);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PlayGround";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Playground";
            this.Activated += new System.EventHandler(this.PlayGround_Activated);
            this.SizeChanged += new System.EventHandler(this.PlayGround_SizeChanged);
            this.panelShapes.ResumeLayout(false);
            this.flowLayoutPanel.ResumeLayout(false);
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.mainPlayground.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.Panel panelData;
        private System.Windows.Forms.Panel panelShapes;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.ToolStrip menuBar;
        private System.Windows.Forms.ToolStripButton handTool;
        private System.Windows.Forms.ToolStripButton lineTool;
        private System.Windows.Forms.ToolStripButton textTool;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.Panel panelPlayground;
        private System.Windows.Forms.Timer updateTimer;
        private System.Windows.Forms.ToolStripButton refreshButton;
        private System.Windows.Forms.ToolStripLabel connectionLabel;
        private System.Windows.Forms.ToolStripPanel BottomToolStripPanel;
        private System.Windows.Forms.ToolStripPanel TopToolStripPanel;
        private System.Windows.Forms.ToolStripPanel RightToolStripPanel;
        private System.Windows.Forms.ToolStripPanel LeftToolStripPanel;
        private System.Windows.Forms.ToolStripContentPanel ContentPanel;
        private System.Windows.Forms.ToolStripTextBox updateTimeTextBox;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel lastUpdateLabel;
        private System.Windows.Forms.ToolStripDropDownButton editModeButton;
        private System.Windows.Forms.ToolStripMenuItem viewModeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editModeMenuItem;
        private System.Windows.Forms.ToolStripButton squareTool;
        private System.Windows.Forms.ToolStripButton circleTool;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem viewGraphToolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip mainPlayground;
        private System.Windows.Forms.ToolStripMenuItem createLogicEditoToolStripMenuItem;
        private System.Windows.Forms.Button addShapeButton;
    }
}
