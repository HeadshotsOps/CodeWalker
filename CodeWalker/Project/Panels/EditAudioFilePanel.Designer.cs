namespace CodeWalker.Project.Panels
{
    partial class EditAudioFilePanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditAudioFilePanel));
            this.ProjectPathTextBox = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.FileLocationTextBox = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.UnkVersionUpDown = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.FileTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label23 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.UnkVersionUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // ProjectPathTextBox
            // 
            this.ProjectPathTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProjectPathTextBox.Location = new System.Drawing.Point(140, 195);
            this.ProjectPathTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ProjectPathTextBox.Name = "ProjectPathTextBox";
            this.ProjectPathTextBox.ReadOnly = true;
            this.ProjectPathTextBox.Size = new System.Drawing.Size(619, 26);
            this.ProjectPathTextBox.TabIndex = 66;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(21, 200);
            this.label30.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(98, 20);
            this.label30.TabIndex = 65;
            this.label30.Text = "Project path:";
            // 
            // FileLocationTextBox
            // 
            this.FileLocationTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FileLocationTextBox.Location = new System.Drawing.Point(140, 155);
            this.FileLocationTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FileLocationTextBox.Name = "FileLocationTextBox";
            this.FileLocationTextBox.ReadOnly = true;
            this.FileLocationTextBox.Size = new System.Drawing.Size(619, 26);
            this.FileLocationTextBox.TabIndex = 64;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(21, 160);
            this.label29.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(97, 20);
            this.label29.TabIndex = 63;
            this.label29.Text = "File location:";
            // 
            // UnkVersionUpDown
            // 
            this.UnkVersionUpDown.Location = new System.Drawing.Point(140, 83);
            this.UnkVersionUpDown.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UnkVersionUpDown.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.UnkVersionUpDown.Name = "UnkVersionUpDown";
            this.UnkVersionUpDown.Size = new System.Drawing.Size(186, 26);
            this.UnkVersionUpDown.TabIndex = 68;
            this.UnkVersionUpDown.ValueChanged += new System.EventHandler(this.UnkVersionUpDown_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 86);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 20);
            this.label6.TabIndex = 67;
            this.label6.Text = "Unk version:";
            // 
            // FileTypeComboBox
            // 
            this.FileTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FileTypeComboBox.FormattingEnabled = true;
            this.FileTypeComboBox.Items.AddRange(new object[] {
            "Dat4",
            "Dat10ModularSynth",
            "Dat15DynamicMixer",
            "Dat16Curves",
            "Dat22Categories",
            "Dat54DataEntries",
            "Dat149",
            "Dat150",
            "Dat151"});
            this.FileTypeComboBox.Location = new System.Drawing.Point(140, 42);
            this.FileTypeComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FileTypeComboBox.Name = "FileTypeComboBox";
            this.FileTypeComboBox.Size = new System.Drawing.Size(224, 28);
            this.FileTypeComboBox.TabIndex = 70;
            this.FileTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.FileTypeComboBox_SelectedIndexChanged);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(24, 46);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(72, 20);
            this.label23.TabIndex = 69;
            this.label23.Text = "File type:";
            // 
            // EditAudioFilePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 692);
            this.Controls.Add(this.FileTypeComboBox);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.UnkVersionUpDown);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ProjectPathTextBox);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.FileLocationTextBox);
            this.Controls.Add(this.label29);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "EditAudioFilePanel";
            this.Text = "Edit Audio File";
            ((System.ComponentModel.ISupportInitialize)(this.UnkVersionUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ProjectPathTextBox;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox FileLocationTextBox;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.NumericUpDown UnkVersionUpDown;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox FileTypeComboBox;
        private System.Windows.Forms.Label label23;
    }
}