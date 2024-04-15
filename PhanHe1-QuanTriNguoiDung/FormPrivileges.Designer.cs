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
            this.btnCol = new System.Windows.Forms.Button();
            this.btnTableName = new System.Windows.Forms.Button();
            this.privsGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonRole = new System.Windows.Forms.Button();
            this.buttonUser = new System.Windows.Forms.Button();
            this.text1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.revokeBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.privsGridView)).BeginInit();
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
            this.btnTableName.Location = new System.Drawing.Point(12, 58);
            this.btnTableName.Margin = new System.Windows.Forms.Padding(2);
            this.btnTableName.Name = "btnTableName";
            this.btnTableName.Size = new System.Drawing.Size(94, 33);
            this.btnTableName.TabIndex = 7;
            this.btnTableName.Text = "Table_Name";
            this.btnTableName.UseVisualStyleBackColor = true;
            this.btnTableName.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // privsGridView
            // 
            this.privsGridView.AllowUserToAddRows = false;
            this.privsGridView.AllowUserToDeleteRows = false;
            this.privsGridView.AllowUserToOrderColumns = true;
            this.privsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.privsGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.privsGridView.ColumnHeadersHeight = 29;
            this.privsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.privsGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.privsGridView.Location = new System.Drawing.Point(0, 115);
            this.privsGridView.Margin = new System.Windows.Forms.Padding(2);
            this.privsGridView.Name = "privsGridView";
            this.privsGridView.ReadOnly = true;
            this.privsGridView.RowHeadersWidth = 51;
            this.privsGridView.RowTemplate.Height = 24;
            this.privsGridView.Size = new System.Drawing.Size(900, 578);
            this.privsGridView.TabIndex = 4;
            this.privsGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.privCell_clicked);
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
            this.buttonRole.Location = new System.Drawing.Point(773, 49);
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
            this.buttonUser.Location = new System.Drawing.Point(662, 49);
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
            this.text1.Location = new System.Drawing.Point(714, 93);
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(104, 13);
            this.text1.TabIndex = 10;
            this.text1.Text = "Mặc định chọn User";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Mặc định chọn TableName";
            // 
            // revokeBtn
            // 
            this.revokeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.revokeBtn.Location = new System.Drawing.Point(488, 51);
            this.revokeBtn.Name = "revokeBtn";
            this.revokeBtn.Size = new System.Drawing.Size(96, 28);
            this.revokeBtn.TabIndex = 12;
            this.revokeBtn.Text = "Thu hồi";
            this.revokeBtn.UseVisualStyleBackColor = true;
            this.revokeBtn.Click += new System.EventHandler(this.revokePermBtn_clicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(278, 17);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 24);
            this.label3.TabIndex = 14;
            this.label3.Text = "User/Role: ";
            // 
            // btnCheck
            // 
            this.btnCheck.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnCheck.Location = new System.Drawing.Point(662, 10);
            this.btnCheck.Margin = new System.Windows.Forms.Padding(2);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(94, 33);
            this.btnCheck.TabIndex = 15;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.usernameTextBox.Location = new System.Drawing.Point(386, 14);
            this.usernameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(198, 27);
            this.usernameTextBox.TabIndex = 16;
            this.usernameTextBox.TextChanged += new System.EventHandler(this.usernameTextBox_TextChanged);
            // 
            // FormPrivileges
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 693);
            this.ControlBox = false;
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.revokeBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.text1);
            this.Controls.Add(this.buttonRole);
            this.Controls.Add(this.buttonUser);
            this.Controls.Add(this.btnCol);
            this.Controls.Add(this.btnTableName);
            this.Controls.Add(this.privsGridView);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormPrivileges";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FormPrivileges";
            this.Load += new System.EventHandler(this.FormPrivileges_Load);
            ((System.ComponentModel.ISupportInitialize)(this.privsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCol;
        private System.Windows.Forms.Button btnTableName;
        private System.Windows.Forms.DataGridView privsGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonRole;
        private System.Windows.Forms.Button buttonUser;
        private System.Windows.Forms.Label text1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button revokeBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.TextBox usernameTextBox;
    }
}
