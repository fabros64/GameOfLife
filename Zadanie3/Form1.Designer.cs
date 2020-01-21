namespace Zadanie3
{
    partial class Form1
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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.generationButton = new System.Windows.Forms.Button();
            this.startPositionGB = new System.Windows.Forms.GroupBox();
            this.openButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.boardButton = new System.Windows.Forms.Button();
            this.SizeGB = new System.Windows.Forms.GroupBox();
            this.maxRb = new System.Windows.Forms.RadioButton();
            this.midRb = new System.Windows.Forms.RadioButton();
            this.minRb = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lockChBox = new System.Windows.Forms.CheckBox();
            this.AutomaticChBox = new System.Windows.Forms.CheckBox();
            this.startPositionGB.SuspendLayout();
            this.SizeGB.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainPanel.Location = new System.Drawing.Point(157, 12);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(451, 410);
            this.mainPanel.TabIndex = 0;
            // 
            // generationButton
            // 
            this.generationButton.Enabled = false;
            this.generationButton.Location = new System.Drawing.Point(6, 100);
            this.generationButton.Name = "generationButton";
            this.generationButton.Size = new System.Drawing.Size(96, 75);
            this.generationButton.TabIndex = 4;
            this.generationButton.Text = "Generate a generation";
            this.generationButton.UseVisualStyleBackColor = true;
            this.generationButton.Click += new System.EventHandler(this.generationButton_Click);
            // 
            // startPositionGB
            // 
            this.startPositionGB.Controls.Add(this.openButton);
            this.startPositionGB.Controls.Add(this.saveButton);
            this.startPositionGB.Location = new System.Drawing.Point(18, 301);
            this.startPositionGB.Name = "startPositionGB";
            this.startPositionGB.Size = new System.Drawing.Size(108, 95);
            this.startPositionGB.TabIndex = 5;
            this.startPositionGB.TabStop = false;
            this.startPositionGB.Text = "Start Position";
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(6, 59);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(96, 23);
            this.openButton.TabIndex = 1;
            this.openButton.Text = "Open";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Enabled = false;
            this.saveButton.Location = new System.Drawing.Point(6, 30);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(96, 23);
            this.saveButton.TabIndex = 0;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // boardButton
            // 
            this.boardButton.Location = new System.Drawing.Point(6, 19);
            this.boardButton.Name = "boardButton";
            this.boardButton.Size = new System.Drawing.Size(96, 75);
            this.boardButton.TabIndex = 6;
            this.boardButton.Text = "Generate a board";
            this.boardButton.UseVisualStyleBackColor = true;
            this.boardButton.Click += new System.EventHandler(this.boardButton_Click);
            // 
            // SizeGB
            // 
            this.SizeGB.Controls.Add(this.maxRb);
            this.SizeGB.Controls.Add(this.midRb);
            this.SizeGB.Controls.Add(this.minRb);
            this.SizeGB.Location = new System.Drawing.Point(12, 12);
            this.SizeGB.Name = "SizeGB";
            this.SizeGB.Size = new System.Drawing.Size(108, 95);
            this.SizeGB.TabIndex = 7;
            this.SizeGB.TabStop = false;
            this.SizeGB.Text = "Size";
            // 
            // maxRb
            // 
            this.maxRb.AutoSize = true;
            this.maxRb.Location = new System.Drawing.Point(6, 68);
            this.maxRb.Name = "maxRb";
            this.maxRb.Size = new System.Drawing.Size(60, 17);
            this.maxRb.TabIndex = 2;
            this.maxRb.Text = "15 x 15";
            this.maxRb.UseVisualStyleBackColor = true;
            // 
            // midRb
            // 
            this.midRb.AutoSize = true;
            this.midRb.Location = new System.Drawing.Point(6, 44);
            this.midRb.Name = "midRb";
            this.midRb.Size = new System.Drawing.Size(60, 17);
            this.midRb.TabIndex = 1;
            this.midRb.Text = "10 x 15";
            this.midRb.UseVisualStyleBackColor = true;
            // 
            // minRb
            // 
            this.minRb.AutoSize = true;
            this.minRb.Checked = true;
            this.minRb.Location = new System.Drawing.Point(6, 20);
            this.minRb.Name = "minRb";
            this.minRb.Size = new System.Drawing.Size(60, 17);
            this.minRb.TabIndex = 0;
            this.minRb.TabStop = true;
            this.minRb.Text = "10 x 10";
            this.minRb.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.boardButton);
            this.groupBox1.Controls.Add(this.generationButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 113);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(108, 182);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Generate";
            // 
            // lockChBox
            // 
            this.lockChBox.AutoSize = true;
            this.lockChBox.Location = new System.Drawing.Point(18, 402);
            this.lockChBox.Name = "lockChBox";
            this.lockChBox.Size = new System.Drawing.Size(50, 17);
            this.lockChBox.TabIndex = 8;
            this.lockChBox.Text = "Lock";
            this.lockChBox.UseVisualStyleBackColor = true;
            this.lockChBox.CheckedChanged += new System.EventHandler(this.lockChBox_CheckedChanged);
            // 
            // AutomaticChBox
            // 
            this.AutomaticChBox.AutoSize = true;
            this.AutomaticChBox.Location = new System.Drawing.Point(71, 402);
            this.AutomaticChBox.Name = "AutomaticChBox";
            this.AutomaticChBox.Size = new System.Drawing.Size(73, 17);
            this.AutomaticChBox.TabIndex = 9;
            this.AutomaticChBox.Text = "Automatic";
            this.AutomaticChBox.UseVisualStyleBackColor = true;
            this.AutomaticChBox.CheckedChanged += new System.EventHandler(this.AutomaticChBox_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(620, 434);
            this.Controls.Add(this.AutomaticChBox);
            this.Controls.Add(this.lockChBox);
            this.Controls.Add(this.startPositionGB);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.SizeGB);
            this.Controls.Add(this.mainPanel);
            this.Name = "Form1";
            this.Text = "Game Of Life";
            this.startPositionGB.ResumeLayout(false);
            this.SizeGB.ResumeLayout(false);
            this.SizeGB.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button generationButton;
        private System.Windows.Forms.GroupBox startPositionGB;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button boardButton;
        private System.Windows.Forms.GroupBox SizeGB;
        private System.Windows.Forms.RadioButton maxRb;
        private System.Windows.Forms.RadioButton midRb;
        private System.Windows.Forms.RadioButton minRb;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox lockChBox;
        private System.Windows.Forms.CheckBox AutomaticChBox;
    }
}

