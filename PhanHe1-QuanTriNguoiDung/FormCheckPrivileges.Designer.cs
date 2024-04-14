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
            ((System.ComponentModel.ISupportInitialize)(this.checkGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kiểm tra Quyền của User";
            // this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // checkGridView
            // 
            this.checkGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.checkGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.checkGridView.ColumnHeadersHeight = 29;
            this.checkGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.checkGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.checkGridView.Location = new System.Drawing.Point(0, 145);
            this.checkGridView.Name = "checkGridView";
            this.checkGridView.ReadOnly = true;
            this.checkGridView.RowHeadersWidth = 51;
            this.checkGridView.RowTemplate.Height = 24;
            this.checkGridView.Size = new System.Drawing.Size(1175, 600);
            this.checkGridView.TabIndex = 1;
            //this.checkGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.checkGridView_CellContentClick);
            // 
            // btnCheck
            // 
            this.btnCheck.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnCheck.Location = new System.Drawing.Point(19, 88);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(126, 41);
            this.btnCheck.TabIndex = 2;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            //this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // FormCheckPrivileges
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1175, 745);
            this.ControlBox = false;
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.checkGridView);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCheckPrivileges";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FormCheckPrivileges";
            //this.Load += new System.EventHandler(this.FormCheckPrivileges_Load);
            ((System.ComponentModel.ISupportInitialize)(this.checkGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView checkGridView;
        private System.Windows.Forms.Button btnCheck;
      //  private System.Windows.Forms.Button btnRefresh;
      //  private System.Windows.Forms.Button btnDelete;
    }
}