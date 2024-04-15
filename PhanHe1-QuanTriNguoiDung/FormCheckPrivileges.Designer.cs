namespace PhanHe1_QuanTriNguoiDung
{
    partial class FormCheckPrivileges
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
            this.checkGridView = new System.Windows.Forms.DataGridView();
            this.btnCheck = new System.Windows.Forms.Button();
            this.userComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.revokeBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.checkGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kiểm tra Quyền của User/Role";
            // 
            // checkGridView
            // 
            this.checkGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.checkGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.checkGridView.ColumnHeadersHeight = 29;
            this.checkGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.checkGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.checkGridView.Location = new System.Drawing.Point(0, 117);
            this.checkGridView.Margin = new System.Windows.Forms.Padding(2);
            this.checkGridView.Name = "checkGridView";
            this.checkGridView.ReadOnly = true;
            this.checkGridView.RowHeadersWidth = 51;
            this.checkGridView.RowTemplate.Height = 24;
            this.checkGridView.Size = new System.Drawing.Size(881, 488);
            this.checkGridView.TabIndex = 1;
            this.checkGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cellContentPriv_clicked);
            // 
            // btnCheck
            // 
            this.btnCheck.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnCheck.Location = new System.Drawing.Point(586, 66);
            this.btnCheck.Margin = new System.Windows.Forms.Padding(2);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(94, 33);
            this.btnCheck.TabIndex = 2;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.confirmGrantBtn_clicked);
            // 
            // userComboBox
            // 
            this.userComboBox.FormattingEnabled = true;
            this.userComboBox.Location = new System.Drawing.Point(152, 80);
            this.userComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.userComboBox.Name = "userComboBox";
            this.userComboBox.Size = new System.Drawing.Size(215, 21);
            this.userComboBox.TabIndex = 3;
            this.userComboBox.DropDown += new System.EventHandler(this.userComboBox_DropDownOpened);
            this.userComboBox.SelectedIndexChanged += new System.EventHandler(this.userComboBox_selectionChanged);
            this.userComboBox.DropDownClosed += new System.EventHandler(this.userComboBox_DropDownClosed);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(42, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "User/Role: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(388, 76);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Type: ";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(460, 80);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(90, 21);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.DropDown += new System.EventHandler(this.comboBox1_DropDownOpened);
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_selectionChanged);
            this.comboBox1.DropDownClosed += new System.EventHandler(this.comboBox1_DropDownClosed);
            // 
            // revokeBtn
            // 
            this.revokeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.revokeBtn.Location = new System.Drawing.Point(750, 71);
            this.revokeBtn.Name = "revokeBtn";
            this.revokeBtn.Size = new System.Drawing.Size(96, 28);
            this.revokeBtn.TabIndex = 13;
            this.revokeBtn.Text = "Revoke";
            this.revokeBtn.UseVisualStyleBackColor = true;
            this.revokeBtn.Click += new System.EventHandler(this.revokePrivBtn_clicked);
            // 
            // FormCheckPrivileges
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(881, 605);
            this.ControlBox = false;
            this.Controls.Add(this.revokeBtn);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.userComboBox);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.checkGridView);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormCheckPrivileges";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FormCheckPrivileges";
            this.Load += new System.EventHandler(this.FormGrantPermissions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.checkGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView checkGridView;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.ComboBox userComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button revokeBtn;
        //  private System.Windows.Forms.Button btnRefresh;
        //  private System.Windows.Forms.Button btnDelete;
    }
}