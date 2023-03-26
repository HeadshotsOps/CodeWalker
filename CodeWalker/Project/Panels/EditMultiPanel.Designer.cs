namespace CodeWalker.Project.Panels
{
    partial class EditMultiPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditMultiPanel));
            this.ScaleTextBox = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.PositionTextBox = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.ItemsListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RotationQuatBox = new CodeWalker.WinForms.QuaternionBox();
            this.flags3 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.RoomId = new System.Windows.Forms.Label();
            this.roomIdUpDown = new System.Windows.Forms.NumericUpDown();
            this.txtBlenderScript = new System.Windows.Forms.RichTextBox();
            this.btnMinimapProps = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.flags3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomIdUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // ScaleTextBox
            // 
            this.ScaleTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ScaleTextBox.Location = new System.Drawing.Point(112, 98);
            this.ScaleTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ScaleTextBox.Name = "ScaleTextBox";
            this.ScaleTextBox.Size = new System.Drawing.Size(715, 26);
            this.ScaleTextBox.TabIndex = 18;
            this.ScaleTextBox.TextChanged += new System.EventHandler(this.ScaleTextBox_TextChanged);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(48, 103);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(53, 20);
            this.label23.TabIndex = 17;
            this.label23.Text = "Scale:";
            // 
            // PositionTextBox
            // 
            this.PositionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PositionTextBox.Location = new System.Drawing.Point(112, 18);
            this.PositionTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PositionTextBox.Name = "PositionTextBox";
            this.PositionTextBox.Size = new System.Drawing.Size(715, 26);
            this.PositionTextBox.TabIndex = 14;
            this.PositionTextBox.TextChanged += new System.EventHandler(this.PositionTextBox_TextChanged);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(28, 63);
            this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(74, 20);
            this.label24.TabIndex = 15;
            this.label24.Text = "Rotation:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(33, 23);
            this.label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(69, 20);
            this.label25.TabIndex = 13;
            this.label25.Text = "Position:";
            // 
            // ItemsListBox
            // 
            this.ItemsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ItemsListBox.FormattingEnabled = true;
            this.ItemsListBox.ItemHeight = 20;
            this.ItemsListBox.Location = new System.Drawing.Point(112, 166);
            this.ItemsListBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ItemsListBox.Name = "ItemsListBox";
            this.ItemsListBox.Size = new System.Drawing.Size(301, 544);
            this.ItemsListBox.TabIndex = 21;
            this.ItemsListBox.SelectedIndexChanged += new System.EventHandler(this.ItemsListBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 168);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Items:";
            // 
            // RotationQuatBox
            // 
            this.RotationQuatBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RotationQuatBox.Location = new System.Drawing.Point(112, 55);
            this.RotationQuatBox.Margin = new System.Windows.Forms.Padding(0);
            this.RotationQuatBox.Name = "RotationQuatBox";
            this.RotationQuatBox.Size = new System.Drawing.Size(717, 37);
            this.RotationQuatBox.TabIndex = 16;
            this.RotationQuatBox.ValueChanged += new System.EventHandler(this.RotationQuatBox_ValueChanged);
            // 
            // flags3
            // 
            this.flags3.Location = new System.Drawing.Point(569, 168);
            this.flags3.Name = "flags3";
            this.flags3.Size = new System.Drawing.Size(120, 26);
            this.flags3.TabIndex = 22;
            this.flags3.ValueChanged += new System.EventHandler(this.flags3_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(471, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "Pathflags";
            // 
            // RoomId
            // 
            this.RoomId.AutoSize = true;
            this.RoomId.Location = new System.Drawing.Point(475, 258);
            this.RoomId.Name = "RoomId";
            this.RoomId.Size = new System.Drawing.Size(73, 20);
            this.RoomId.TabIndex = 24;
            this.RoomId.Text = "Room ID";
            // 
            // roomIdUpDown
            // 
            this.roomIdUpDown.Location = new System.Drawing.Point(569, 258);
            this.roomIdUpDown.Name = "roomIdUpDown";
            this.roomIdUpDown.Size = new System.Drawing.Size(120, 26);
            this.roomIdUpDown.TabIndex = 25;
            this.roomIdUpDown.ValueChanged += new System.EventHandler(this.roomIdUpDown_ValueChanged);
            // 
            // txtBlenderScript
            // 
            this.txtBlenderScript.Location = new System.Drawing.Point(475, 361);
            this.txtBlenderScript.Name = "txtBlenderScript";
            this.txtBlenderScript.Size = new System.Drawing.Size(288, 349);
            this.txtBlenderScript.TabIndex = 26;
            this.txtBlenderScript.Text = "";
            // 
            // btnMinimapProps
            // 
            this.btnMinimapProps.Location = new System.Drawing.Point(475, 309);
            this.btnMinimapProps.Name = "btnMinimapProps";
            this.btnMinimapProps.Size = new System.Drawing.Size(229, 31);
            this.btnMinimapProps.TabIndex = 27;
            this.btnMinimapProps.Text = "Generate Minimap Props";
            this.btnMinimapProps.UseVisualStyleBackColor = true;
            this.btnMinimapProps.Click += new System.EventHandler(this.btnMinimapProps_Click);
            // 
            // EditMultiPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 777);
            this.Controls.Add(this.btnMinimapProps);
            this.Controls.Add(this.txtBlenderScript);
            this.Controls.Add(this.roomIdUpDown);
            this.Controls.Add(this.RoomId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.flags3);
            this.Controls.Add(this.RotationQuatBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ItemsListBox);
            this.Controls.Add(this.ScaleTextBox);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.PositionTextBox);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label25);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "EditMultiPanel";
            this.Text = "EditMultiPanel";
            ((System.ComponentModel.ISupportInitialize)(this.flags3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomIdUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ScaleTextBox;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox PositionTextBox;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.ListBox ItemsListBox;
        private System.Windows.Forms.Label label1;
        private WinForms.QuaternionBox RotationQuatBox;
        private System.Windows.Forms.NumericUpDown flags3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label RoomId;
        private System.Windows.Forms.NumericUpDown roomIdUpDown;
        private System.Windows.Forms.RichTextBox txtBlenderScript;
        private System.Windows.Forms.Button btnMinimapProps;
    }
}