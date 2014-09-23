namespace dsm
{
    partial class Calculator
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
            this.comboBoxModifier = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.leftOutput = new System.Windows.Forms.Label();
            this.rightOutput = new System.Windows.Forms.Label();
            this.outputWarning = new System.Windows.Forms.Label();
            this.comboBoxOutput = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.outputShow = new System.Windows.Forms.Label();
            this.outputDetails = new System.Windows.Forms.Label();
            this.comboBoxLeft = new System.Windows.Forms.ComboBox();
            this.comboBoxRight = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // comboBoxModifier
            // 
            this.comboBoxModifier.FormattingEnabled = true;
            this.comboBoxModifier.Items.AddRange(new object[] {
            "+",
            "-",
            "/",
            "*"});
            this.comboBoxModifier.Location = new System.Drawing.Point(119, 12);
            this.comboBoxModifier.Name = "comboBoxModifier";
            this.comboBoxModifier.Size = new System.Drawing.Size(54, 21);
            this.comboBoxModifier.TabIndex = 0;
            this.comboBoxModifier.SelectedIndexChanged += new System.EventHandler(this.comboBoxModifier_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 3;
            // 
            // leftOutput
            // 
            this.leftOutput.AutoSize = true;
            this.leftOutput.Location = new System.Drawing.Point(116, 62);
            this.leftOutput.Name = "leftOutput";
            this.leftOutput.Size = new System.Drawing.Size(0, 13);
            this.leftOutput.TabIndex = 4;
            // 
            // rightOutput
            // 
            this.rightOutput.AutoSize = true;
            this.rightOutput.Location = new System.Drawing.Point(180, 62);
            this.rightOutput.Name = "rightOutput";
            this.rightOutput.Size = new System.Drawing.Size(0, 13);
            this.rightOutput.TabIndex = 5;
            // 
            // outputWarning
            // 
            this.outputWarning.AutoSize = true;
            this.outputWarning.Location = new System.Drawing.Point(9, 89);
            this.outputWarning.Name = "outputWarning";
            this.outputWarning.Size = new System.Drawing.Size(35, 13);
            this.outputWarning.TabIndex = 6;
            this.outputWarning.Text = "label4";
            // 
            // comboBoxOutput
            // 
            this.comboBoxOutput.FormattingEnabled = true;
            this.comboBoxOutput.Items.AddRange(new object[] {
            "Double (comma getal)",
            "Integer (Hele getallen)"});
            this.comboBoxOutput.Location = new System.Drawing.Point(12, 169);
            this.comboBoxOutput.Name = "comboBoxOutput";
            this.comboBoxOutput.Size = new System.Drawing.Size(161, 21);
            this.comboBoxOutput.TabIndex = 7;
            this.comboBoxOutput.SelectedIndexChanged += new System.EventHandler(this.comboBoxOutput_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Output Type";
            // 
            // outputShow
            // 
            this.outputShow.AutoSize = true;
            this.outputShow.Location = new System.Drawing.Point(9, 203);
            this.outputShow.Name = "outputShow";
            this.outputShow.Size = new System.Drawing.Size(42, 13);
            this.outputShow.TabIndex = 9;
            this.outputShow.Text = "Output:";
            // 
            // outputDetails
            // 
            this.outputDetails.AutoSize = true;
            this.outputDetails.Location = new System.Drawing.Point(9, 114);
            this.outputDetails.Name = "outputDetails";
            this.outputDetails.Size = new System.Drawing.Size(35, 13);
            this.outputDetails.TabIndex = 10;
            this.outputDetails.Text = "label7";
            // 
            // comboBoxLeft
            // 
            this.comboBoxLeft.FormattingEnabled = true;
            this.comboBoxLeft.Location = new System.Drawing.Point(12, 12);
            this.comboBoxLeft.Name = "comboBoxLeft";
            this.comboBoxLeft.Size = new System.Drawing.Size(99, 21);
            this.comboBoxLeft.TabIndex = 11;
            this.comboBoxLeft.SelectedIndexChanged += new System.EventHandler(this.comboBoxLeft_SelectedIndexChanged);
            this.comboBoxLeft.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBox_KeyDown);
            // 
            // comboBoxRight
            // 
            this.comboBoxRight.FormattingEnabled = true;
            this.comboBoxRight.Location = new System.Drawing.Point(183, 12);
            this.comboBoxRight.Name = "comboBoxRight";
            this.comboBoxRight.Size = new System.Drawing.Size(100, 21);
            this.comboBoxRight.TabIndex = 12;
            this.comboBoxRight.SelectedIndexChanged += new System.EventHandler(this.comboBoxRight_SelectedIndexChanged);
            this.comboBoxRight.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBox_KeyDown);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 229);
            this.Controls.Add(this.comboBoxRight);
            this.Controls.Add(this.comboBoxLeft);
            this.Controls.Add(this.outputDetails);
            this.Controls.Add(this.outputShow);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxOutput);
            this.Controls.Add(this.outputWarning);
            this.Controls.Add(this.rightOutput);
            this.Controls.Add(this.leftOutput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxModifier);
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Calculator_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxModifier;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label leftOutput;
        private System.Windows.Forms.Label rightOutput;
        private System.Windows.Forms.Label outputWarning;
        private System.Windows.Forms.ComboBox comboBoxOutput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label outputShow;
        private System.Windows.Forms.Label outputDetails;
        private System.Windows.Forms.ComboBox comboBoxLeft;
        private System.Windows.Forms.ComboBox comboBoxRight;
    }
}