﻿namespace PhanHe1_QuanTriNguoiDung
{
    partial class FormGrantPermissions
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
            this.colColPrivComboBox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.funcComboBox = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.procedureComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(506, 59);
            this.label2.TabIndex = 1;
            this.label2.Text = "CẤP QUYỀN CHO USER/ROLE";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "User/Role:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // userComboBox
            // 
            this.userComboBox.AllowDrop = true;
            this.userComboBox.BackColor = System.Drawing.Color.White;
            this.userComboBox.ForeColor = System.Drawing.Color.Black;
            this.userComboBox.ItemHeight = 13;
            this.userComboBox.Location = new System.Drawing.Point(141, 134);
            this.userComboBox.MaxLength = 10;
            this.userComboBox.Name = "userComboBox";
            this.userComboBox.Size = new System.Drawing.Size(202, 21);
            this.userComboBox.TabIndex = 3;
            this.userComboBox.DropDown += new System.EventHandler(this.userComboBox_DropDownOpened);
            this.userComboBox.SelectedIndexChanged += new System.EventHandler(this.userComboBox_selectionChanged);
            this.userComboBox.DropDownClosed += new System.EventHandler(this.userComboBox_DropDownClosed);
            // 
            // withGrantOptCheckBox
            // 
            this.withGrantOptCheckBox.Location = new System.Drawing.Point(403, 71);
            this.withGrantOptCheckBox.Name = "withGrantOptCheckBox";
            this.withGrantOptCheckBox.Size = new System.Drawing.Size(203, 33);
            this.withGrantOptCheckBox.TabIndex = 5;
            this.withGrantOptCheckBox.Text = "WITH GRANT OPTION";
            this.withGrantOptCheckBox.UseVisualStyleBackColor = true;
            this.withGrantOptCheckBox.CheckedChanged += new System.EventHandler(this.withGrantOptCheckBox_checkedChanged);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.objPrivComboBox.FormattingEnabled = true;
            this.objPrivComboBox.ItemHeight = 13;
            this.objPrivComboBox.Location = new System.Drawing.Point(607, 139);
            this.objPrivComboBox.Name = "objPrivComboBox";
            this.objPrivComboBox.Size = new System.Drawing.Size(189, 21);
            this.objPrivComboBox.TabIndex = 9;
            this.objPrivComboBox.SelectedIndexChanged += new System.EventHandler(this.objPrivComboBox_selectionChanged);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(444, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 38);
            this.label4.TabIndex = 8;
            this.label4.Text = "Object privileges:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tablePrivComboBox
            // 
            this.tablePrivComboBox.AllowDrop = true;
            this.tablePrivComboBox.FormattingEnabled = true;
            this.tablePrivComboBox.ItemHeight = 13;
            this.tablePrivComboBox.Location = new System.Drawing.Point(612, 209);
            this.tablePrivComboBox.Name = "tablePrivComboBox";
            this.tablePrivComboBox.Size = new System.Drawing.Size(184, 21);
            this.tablePrivComboBox.TabIndex = 11;
            this.tablePrivComboBox.SelectedIndexChanged += new System.EventHandler(this.tablePrivComboBox_selectionChanged);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(444, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 38);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tables/Views:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // sysPrivComboBox
            // 
            this.sysPrivComboBox.AllowDrop = true;
            this.sysPrivComboBox.FormattingEnabled = true;
            this.sysPrivComboBox.ItemHeight = 13;
            this.sysPrivComboBox.Location = new System.Drawing.Point(154, 209);
            this.sysPrivComboBox.Name = "sysPrivComboBox";
            this.sysPrivComboBox.Size = new System.Drawing.Size(189, 21);
            this.sysPrivComboBox.TabIndex = 12;
            this.sysPrivComboBox.SelectedIndexChanged += new System.EventHandler(this.sysPrivComboBox_selectionChanged);
            // 
            // rolePrivComboBox
            // 
            this.rolePrivComboBox.AllowDrop = true;
            this.rolePrivComboBox.FormattingEnabled = true;
            this.rolePrivComboBox.ItemHeight = 13;
            this.rolePrivComboBox.Location = new System.Drawing.Point(154, 293);
            this.rolePrivComboBox.Name = "rolePrivComboBox";
            this.rolePrivComboBox.Size = new System.Drawing.Size(189, 21);
            this.rolePrivComboBox.TabIndex = 14;
            this.rolePrivComboBox.SelectedIndexChanged += new System.EventHandler(this.rolePrivComboBox_selectionChanged);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 38);
            this.label6.TabIndex = 13;
            this.label6.Text = "Role:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(450, 256);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(200, 33);
            this.label7.TabIndex = 15;
            this.label7.Text = "Permission on Column";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // colColPrivComboBox
            // 
            this.colColPrivComboBox.AllowDrop = true;
            this.colColPrivComboBox.FormattingEnabled = true;
            this.colColPrivComboBox.ItemHeight = 13;
            this.colColPrivComboBox.Location = new System.Drawing.Point(612, 292);
            this.colColPrivComboBox.Name = "colColPrivComboBox";
            this.colColPrivComboBox.Size = new System.Drawing.Size(184, 21);
            this.colColPrivComboBox.TabIndex = 21;
            this.colColPrivComboBox.SelectedIndexChanged += new System.EventHandler(this.colColPrivComboBox_selectionChanged);
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(450, 282);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 38);
            this.label9.TabIndex = 20;
            this.label9.Text = "Column:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(672, 476);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 42);
            this.button1.TabIndex = 22;
            this.button1.Text = "CONFIRM ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.confirmGrantBtn_clicked);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(548, 476);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 42);
            this.button2.TabIndex = 23;
            this.button2.Text = "CLEAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.clearBtn_clicked);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(101, 353);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(667, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "_________________________________________________________________________________" +
    "_____________________________";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(17, 399);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 16);
            this.label10.TabIndex = 25;
            this.label10.Text = "Funtions:";
            // 
            // funcComboBox
            // 
            this.funcComboBox.FormattingEnabled = true;
            this.funcComboBox.Location = new System.Drawing.Point(154, 404);
            this.funcComboBox.Name = "funcComboBox";
            this.funcComboBox.Size = new System.Drawing.Size(189, 21);
            this.funcComboBox.TabIndex = 26;
            this.funcComboBox.SelectedIndexChanged += new System.EventHandler(this.funcComboBox_selectionChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(488, 399);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 16);
            this.label11.TabIndex = 27;
            this.label11.Text = "Procedures:";
            // 
            // procedureComboBox
            // 
            this.procedureComboBox.FormattingEnabled = true;
            this.procedureComboBox.Location = new System.Drawing.Point(612, 394);
            this.procedureComboBox.Name = "procedureComboBox";
            this.procedureComboBox.Size = new System.Drawing.Size(184, 21);
            this.procedureComboBox.TabIndex = 28;
            this.procedureComboBox.SelectedIndexChanged += new System.EventHandler(this.procedureComboBox_slectionChanged);
            // 
            // FormGrantPermissions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 560);
            this.ControlBox = false;
            this.Controls.Add(this.procedureComboBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.funcComboBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.colColPrivComboBox);
            this.Controls.Add(this.label9);
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
            this.Name = "FormGrantPermissions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FormPrivileges";
            this.Load += new System.EventHandler(this.FormGrantPermissions_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.ComboBox colColPrivComboBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox funcComboBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox procedureComboBox;
    }
}