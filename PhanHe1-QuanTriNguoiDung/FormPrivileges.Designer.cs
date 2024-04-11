namespace PhanHe1_QuanTriNguoiDung
{
    partial class FormPrivileges
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.userComboBox = new System.Windows.Forms.ComboBox();
            this.withGrantOptCheckBox = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.objPrivComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tablePrivComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.sysPrivComboBox = new System.Windows.Forms.ComboBox();
            this.rolePrivComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.selectCheckBox = new System.Windows.Forms.CheckBox();
            this.updateCheckBox = new System.Windows.Forms.CheckBox();
            this.colTablePrivComboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.colColPrivComboBox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(506, 59);
            this.label2.TabIndex = 1;
            this.label2.Text = "Grant Permissions For User";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "User:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // userComboBox
            // 
            this.userComboBox.AllowDrop = true;
            this.userComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.userComboBox.FormattingEnabled = true;
            this.userComboBox.ItemHeight = 20;
            this.userComboBox.Location = new System.Drawing.Point(211, 134);
            this.userComboBox.Name = "userComboBox";
            this.userComboBox.Size = new System.Drawing.Size(132, 26);
            this.userComboBox.TabIndex = 3;
            this.userComboBox.SelectedIndexChanged += new System.EventHandler(this.userComboBox_selectionChanged);
            // 
            // withGrantOptCheckBox
            // 
            this.withGrantOptCheckBox.Location = new System.Drawing.Point(440, 71);
            this.withGrantOptCheckBox.Name = "withGrantOptCheckBox";
            this.withGrantOptCheckBox.Size = new System.Drawing.Size(203, 33);
            this.withGrantOptCheckBox.TabIndex = 5;
            this.withGrantOptCheckBox.Text = "WITH GRANT OPTION";
            this.withGrantOptCheckBox.UseVisualStyleBackColor = true;
            this.withGrantOptCheckBox.CheckedChanged += new System.EventHandler(this.withGrantOptCheckBox_checkedChanged);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 38);
            this.label3.TabIndex = 6;
            this.label3.Text = "System privileges:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // objPrivComboBox
            // 
            this.objPrivComboBox.AllowDrop = true;
            this.objPrivComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.objPrivComboBox.FormattingEnabled = true;
            this.objPrivComboBox.ItemHeight = 20;
            this.objPrivComboBox.Location = new System.Drawing.Point(211, 293);
            this.objPrivComboBox.Name = "objPrivComboBox";
            this.objPrivComboBox.Size = new System.Drawing.Size(132, 26);
            this.objPrivComboBox.TabIndex = 9;
            this.objPrivComboBox.SelectedIndexChanged += new System.EventHandler(this.objPrivComboBox_selectionChanged);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 38);
            this.label4.TabIndex = 8;
            this.label4.Text = "Object privileges:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tablePrivComboBox
            // 
            this.tablePrivComboBox.AllowDrop = true;
            this.tablePrivComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.tablePrivComboBox.FormattingEnabled = true;
            this.tablePrivComboBox.ItemHeight = 20;
            this.tablePrivComboBox.Location = new System.Drawing.Point(211, 371);
            this.tablePrivComboBox.Name = "tablePrivComboBox";
            this.tablePrivComboBox.Size = new System.Drawing.Size(132, 26);
            this.tablePrivComboBox.TabIndex = 11;
            this.tablePrivComboBox.SelectedIndexChanged += new System.EventHandler(this.tablePrivComboBox_selectionChanged);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 360);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 38);
            this.label5.TabIndex = 10;
            this.label5.Text = "Table:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // sysPrivComboBox
            // 
            this.sysPrivComboBox.AllowDrop = true;
            this.sysPrivComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.sysPrivComboBox.FormattingEnabled = true;
            this.sysPrivComboBox.ItemHeight = 20;
            this.sysPrivComboBox.Location = new System.Drawing.Point(211, 209);
            this.sysPrivComboBox.Name = "sysPrivComboBox";
            this.sysPrivComboBox.Size = new System.Drawing.Size(132, 26);
            this.sysPrivComboBox.TabIndex = 12;
            this.sysPrivComboBox.SelectedIndexChanged += new System.EventHandler(this.sysPrivComboBox_selectionChanged);
            // 
            // rolePrivComboBox
            // 
            this.rolePrivComboBox.AllowDrop = true;
            this.rolePrivComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.rolePrivComboBox.FormattingEnabled = true;
            this.rolePrivComboBox.ItemHeight = 20;
            this.rolePrivComboBox.Location = new System.Drawing.Point(211, 452);
            this.rolePrivComboBox.Name = "rolePrivComboBox";
            this.rolePrivComboBox.Size = new System.Drawing.Size(132, 26);
            this.rolePrivComboBox.TabIndex = 14;
            this.rolePrivComboBox.SelectedIndexChanged += new System.EventHandler(this.rolePrivComboBox_selectionChanged);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 441);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 38);
            this.label6.TabIndex = 13;
            this.label6.Text = "Role:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(745, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(200, 33);
            this.label7.TabIndex = 15;
            this.label7.Text = "Permission on Column";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // selectCheckBox
            // 
            this.selectCheckBox.Location = new System.Drawing.Point(691, 330);
            this.selectCheckBox.Name = "selectCheckBox";
            this.selectCheckBox.Size = new System.Drawing.Size(203, 33);
            this.selectCheckBox.TabIndex = 16;
            this.selectCheckBox.Text = "SELECT";
            this.selectCheckBox.UseVisualStyleBackColor = true;
            this.selectCheckBox.CheckedChanged += new System.EventHandler(this.selectCheckBox_CheckedChanged);
            // 
            // updateCheckBox
            // 
            this.updateCheckBox.Location = new System.Drawing.Point(691, 385);
            this.updateCheckBox.Name = "updateCheckBox";
            this.updateCheckBox.Size = new System.Drawing.Size(203, 33);
            this.updateCheckBox.TabIndex = 17;
            this.updateCheckBox.Text = "UPDATE";
            this.updateCheckBox.UseVisualStyleBackColor = true;
            this.updateCheckBox.CheckedChanged += new System.EventHandler(this.updateCheckBox_CheckedChanged);
            // 
            // colTablePrivComboBox
            // 
            this.colTablePrivComboBox.AllowDrop = true;
            this.colTablePrivComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.colTablePrivComboBox.FormattingEnabled = true;
            this.colTablePrivComboBox.ItemHeight = 20;
            this.colTablePrivComboBox.Location = new System.Drawing.Point(847, 167);
            this.colTablePrivComboBox.Name = "colTablePrivComboBox";
            this.colTablePrivComboBox.Size = new System.Drawing.Size(132, 26);
            this.colTablePrivComboBox.TabIndex = 19;
            this.colTablePrivComboBox.SelectedIndexChanged += new System.EventHandler(this.colTablePrivComboBox_selectionChanged);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(687, 167);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 38);
            this.label8.TabIndex = 18;
            this.label8.Text = "Table:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // colColPrivComboBox
            // 
            this.colColPrivComboBox.AllowDrop = true;
            this.colColPrivComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.colColPrivComboBox.FormattingEnabled = true;
            this.colColPrivComboBox.ItemHeight = 20;
            this.colColPrivComboBox.Location = new System.Drawing.Point(847, 245);
            this.colColPrivComboBox.Name = "colColPrivComboBox";
            this.colColPrivComboBox.Size = new System.Drawing.Size(132, 26);
            this.colColPrivComboBox.TabIndex = 21;
            this.colColPrivComboBox.SelectedIndexChanged += new System.EventHandler(this.colColPrivComboBox_selectionChanged);
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(687, 234);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 38);
            this.label9.TabIndex = 20;
            this.label9.Text = "Column:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(847, 625);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 42);
            this.button1.TabIndex = 22;
            this.button1.Text = "CONFIRM ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.confirmGrantBtn_clicked);
            // 
            // FormPrivileges
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 693);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.colColPrivComboBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.colTablePrivComboBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.updateCheckBox);
            this.Controls.Add(this.selectCheckBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.rolePrivComboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.sysPrivComboBox);
            this.Controls.Add(this.tablePrivComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.objPrivComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.withGrantOptCheckBox);
            this.Controls.Add(this.userComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormPrivileges";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FormPrivileges";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox userComboBox;
        private System.Windows.Forms.CheckBox withGrantOptCheckBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox objPrivComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox tablePrivComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox sysPrivComboBox;
        private System.Windows.Forms.ComboBox rolePrivComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox selectCheckBox;
        private System.Windows.Forms.CheckBox updateCheckBox;
        private System.Windows.Forms.ComboBox colTablePrivComboBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox colColPrivComboBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
    }
}