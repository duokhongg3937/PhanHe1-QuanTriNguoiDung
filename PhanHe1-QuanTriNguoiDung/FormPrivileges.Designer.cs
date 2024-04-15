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
            this.btnTableView = new System.Windows.Forms.Button();
            this.privsGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonRole = new System.Windows.Forms.Button();
            this.buttonUser = new System.Windows.Forms.Button();
            this.text1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.revokeBtn = new System.Windows.Forms.Button();
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
            // btnTableView
            // 
            this.btnTableView.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnTableView.Location = new System.Drawing.Point(14, 58);
            this.btnTableView.Margin = new System.Windows.Forms.Padding(2);
            this.btnTableView.Name = "btnTableView";
            this.btnTableView.Size = new System.Drawing.Size(94, 33);
            this.btnTableView.TabIndex = 7;
            this.btnTableView.Text = "Table/View";
            this.btnTableView.UseVisualStyleBackColor = true;
            this.btnTableView.Click += new System.EventHandler(this.btnAdd_Click);
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
            // revokeBtn
            // 
            this.revokeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.revokeBtn.Location = new System.Drawing.Point(438, 58);
            this.revokeBtn.Name = "revokeBtn";
            this.revokeBtn.Size = new System.Drawing.Size(96, 28);
            this.revokeBtn.TabIndex = 12;
            this.revokeBtn.Text = "Thu hồi";
            this.revokeBtn.UseVisualStyleBackColor = true;
            this.revokeBtn.Click += new System.EventHandler(this.revokePermBtn_clicked);
            // 
            // FormPrivileges
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 693);
            this.ControlBox = false;
            this.Controls.Add(this.revokeBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.text1);
            this.Controls.Add(this.buttonRole);
            this.Controls.Add(this.buttonUser);
            this.Controls.Add(this.btnCol);
            this.Controls.Add(this.btnTableView);
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
        private System.Windows.Forms.Button btnTableView;
        private System.Windows.Forms.DataGridView privsGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonRole;
        private System.Windows.Forms.Button buttonUser;
        private System.Windows.Forms.Label text1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button revokeBtn;
    }
}
