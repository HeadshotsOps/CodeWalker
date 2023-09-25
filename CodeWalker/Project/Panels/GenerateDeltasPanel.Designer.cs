namespace CodeWalker.Project.Panels
{
    partial class GenerateDeltasPanel
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
            this.label1 = new System.Windows.Forms.Label();
            this.lstbx_LoadedFiles = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_SelectFiles = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_ScriptOutput = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(535, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "This tool allows you to diff edited vanilla ymaps and generate a patch script.\r\nA" +
    "llowing no more conflicting resources in FiveM.\r\n";
            // 
            // lstbx_LoadedFiles
            // 
            this.lstbx_LoadedFiles.FormattingEnabled = true;
            this.lstbx_LoadedFiles.ItemHeight = 20;
            this.lstbx_LoadedFiles.Location = new System.Drawing.Point(17, 137);
            this.lstbx_LoadedFiles.Name = "lstbx_LoadedFiles";
            this.lstbx_LoadedFiles.Size = new System.Drawing.Size(222, 544);
            this.lstbx_LoadedFiles.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Input";
            // 
            // btn_SelectFiles
            // 
            this.btn_SelectFiles.Location = new System.Drawing.Point(80, 91);
            this.btn_SelectFiles.Name = "btn_SelectFiles";
            this.btn_SelectFiles.Size = new System.Drawing.Size(159, 40);
            this.btn_SelectFiles.TabIndex = 3;
            this.btn_SelectFiles.Text = "Select Files";
            this.btn_SelectFiles.UseVisualStyleBackColor = true;
            this.btn_SelectFiles.Click += new System.EventHandler(this.btn_SelectFiles_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 7;
            // 
            // txt_ScriptOutput
            // 
            this.txt_ScriptOutput.Location = new System.Drawing.Point(346, 137);
            this.txt_ScriptOutput.Name = "txt_ScriptOutput";
            this.txt_ScriptOutput.Size = new System.Drawing.Size(385, 490);
            this.txt_ScriptOutput.TabIndex = 6;
            this.txt_ScriptOutput.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(346, 641);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 40);
            this.button1.TabIndex = 8;
            this.button1.Text = "Generate Script";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(548, 641);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(183, 40);
            this.button2.TabIndex = 9;
            this.button2.Text = "Save Script";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 42);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(228, 24);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "Comment archetypeNames";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox4);
            this.groupBox1.Controls.Add(this.checkBox3);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Location = new System.Drawing.Point(737, 137);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(284, 490);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Export Options";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(7, 73);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(158, 24);
            this.checkBox2.TabIndex = 11;
            this.checkBox2.Text = "Print errors on fail";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(7, 103);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(210, 24);
            this.checkBox3.TabIndex = 12;
            this.checkBox3.Text = "Scale < 0.0001 = remove";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(7, 133);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(243, 24);
            this.checkBox4.TabIndex = 13;
            this.checkBox4.Text = "Diff archetypename = remove";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // GenerateDeltasPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 724);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_ScriptOutput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_SelectFiles);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstbx_LoadedFiles);
            this.Controls.Add(this.label1);
            this.Name = "GenerateDeltasPanel";
            this.Text = "GenerateDeltasPanel";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstbx_LoadedFiles;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_SelectFiles;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox txt_ScriptOutput;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
    }
}