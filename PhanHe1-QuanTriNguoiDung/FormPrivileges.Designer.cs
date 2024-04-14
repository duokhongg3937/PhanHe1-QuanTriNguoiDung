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
            this.userComboBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.userComboBox.FormattingEnabled = true;
            this.userComboBox.ItemHeight = 20;
            this.userComboBox.Location = new System.Drawing.Point(141, 134);
            this.userComboBox.Name = "userComboBox";
            this.userComboBox.Size = new System.Drawing.Size(202, 26);
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
            this.tablePrivComboBox.Location = new System.Drawing.Point(733, 208);
            this.tablePrivComboBox.Name = "tablePrivComboBox";
            this.tablePrivComboBox.Size = new System.Drawing.Size(132, 26);
            this.tablePrivComboBox.TabIndex = 11;
            this.tablePrivComboBox.SelectedIndexChanged += new System.EventHandler(this.tablePrivComboBox_selectionChanged);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(558, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 38);
            this.label5.TabIndex = 10;
            this.label5.Text = "Table:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.rolePrivComboBox.Location = new System.Drawing.Point(211, 374);
            this.rolePrivComboBox.Name = "rolePrivComboBox";
            this.rolePrivComboBox.Size = new System.Drawing.Size(132, 26);
            this.rolePrivComboBox.TabIndex = 14;
            this.rolePrivComboBox.SelectedIndexChanged += new System.EventHandler(this.rolePrivComboBox_selectionChanged);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 374);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 38);
            this.label6.TabIndex = 13;
            this.label6.Text = "Role:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(627, 260);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(200, 33);
            this.label7.TabIndex = 15;
            this.label7.Text = "Permission on Column";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // colColPrivComboBox
            // 
            this.colColPrivComboBox.AllowDrop = true;
            this.colColPrivComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.colColPrivComboBox.FormattingEnabled = true;
            this.colColPrivComboBox.ItemHeight = 20;
            this.colColPrivComboBox.Location = new System.Drawing.Point(741, 304);
            this.colColPrivComboBox.Name = "colColPrivComboBox";
            this.colColPrivComboBox.Size = new System.Drawing.Size(132, 26);
            this.colColPrivComboBox.TabIndex = 21;
            this.colColPrivComboBox.SelectedIndexChanged += new System.EventHandler(this.colColPrivComboBox_selectionChanged);
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(558, 293);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 38);
            this.label9.TabIndex = 20;
            this.label9.Text = "Column:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(741, 581);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 42);
            this.button1.TabIndex = 22;
            this.button1.Text = "CONFIRM ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.confirmGrantBtn_clicked);

            this.btnCol = new System.Windows.Forms.Button();
            this.btnTableName = new System.Windows.Forms.Button();
            this.userGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonRole = new System.Windows.Forms.Button();
            this.buttonUser = new System.Windows.Forms.Button();
            this.text1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.userGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCol
            // 
            this.btnCol.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnCol.Location = new System.Drawing.Point(125, 58);
            this.btnCol.Margin = new System.Windows.Forms.Padding(2);
            this.btnCol.Name = "btnCol";
            this.btnCol.Size = new System.Drawing.Size(94, 33);
            this.btnCol.TabIndex = 6;
            this.btnCol.Text = "Column";
            this.btnCol.UseVisualStyleBackColor = true;
            this.btnCol.Click += new System.EventHandler(this.btnCol_Click);
            // 
            // btnTableName
            // 
            this.btnTableName.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnTableName.Location = new System.Drawing.Point(14, 58);
            this.btnTableName.Margin = new System.Windows.Forms.Padding(2);
            this.btnTableName.Name = "btnTableName";
            this.btnTableName.Size = new System.Drawing.Size(94, 33);
            this.btnTableName.TabIndex = 7;
            this.btnTableName.Text = "TableName";
            this.btnTableName.UseVisualStyleBackColor = true;
            this.btnTableName.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // userGridView
            // 
            this.userGridView.AllowUserToAddRows = false;
            this.userGridView.AllowUserToDeleteRows = false;
            this.userGridView.AllowUserToOrderColumns = true;
            this.userGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.userGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.userGridView.ColumnHeadersHeight = 29;
            this.userGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.userGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.userGridView.Location = new System.Drawing.Point(0, 115);
            this.userGridView.Margin = new System.Windows.Forms.Padding(2);
            this.userGridView.Name = "userGridView";
            this.userGridView.ReadOnly = true;
            this.userGridView.RowHeadersWidth = 51;
            this.userGridView.RowTemplate.Height = 24;
            this.userGridView.Size = new System.Drawing.Size(900, 578);
            this.userGridView.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "Danh sách quyền";
            // 
            // buttonRole
            // 
            this.buttonRole.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.buttonRole.Location = new System.Drawing.Point(745, 49);
            this.buttonRole.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRole.Name = "buttonRole";
            this.buttonRole.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonRole.Size = new System.Drawing.Size(94, 33);
            this.buttonRole.TabIndex = 8;
            this.buttonRole.Text = "ROLE";
            this.buttonRole.UseVisualStyleBackColor = true;
            this.buttonRole.Click += new System.EventHandler(this.buttonRole_Click);
            // 
            // buttonUser
            // 
            this.buttonUser.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.buttonUser.Location = new System.Drawing.Point(634, 49);
            this.buttonUser.Margin = new System.Windows.Forms.Padding(2);
            this.buttonUser.Name = "buttonUser";
            this.buttonUser.Size = new System.Drawing.Size(94, 33);
            this.buttonUser.TabIndex = 9;
            this.buttonUser.Text = "USER";
            this.buttonUser.UseVisualStyleBackColor = true;
            this.buttonUser.Click += new System.EventHandler(this.buttonUser_Click);
            // 
            // text1
            // 
            this.text1.AutoSize = true;
            this.text1.Location = new System.Drawing.Point(682, 30);
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(104, 13);
            this.text1.TabIndex = 10;
            this.text1.Text = "Mặc định chọn User";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(233, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Mặc định chọn TableName";

            // 
            // FormPrivileges
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;

            this.ClientSize = new System.Drawing.Size(918, 661);
            this.ControlBox = false;
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

            this.ClientSize = new System.Drawing.Size(900, 693);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.text1);
            this.Controls.Add(this.buttonRole);
            this.Controls.Add(this.buttonUser);
            this.Controls.Add(this.btnCol);
            this.Controls.Add(this.btnTableName);
            this.Controls.Add(this.userGridView);

            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

            this.ImeMode = System.Windows.Forms.ImeMode.On;

            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormPrivileges";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FormPrivileges";
            this.Load += new System.EventHandler(this.FormPrivileges_Load);

            ((System.ComponentModel.ISupportInitialize)(this.userGridView)).EndInit();

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
        private System.Windows.Forms.ComboBox colColPrivComboBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.Button btnCol;
        private System.Windows.Forms.Button btnTableName;
        private System.Windows.Forms.DataGridView userGridView;
        private System.Windows.Forms.Button buttonRole;
        private System.Windows.Forms.Button buttonUser;
        private System.Windows.Forms.Label text1;

    }
}