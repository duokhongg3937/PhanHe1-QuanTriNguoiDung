﻿using System;
using System.Windows.Forms;

namespace PhanHe1_QuanTriNguoiDung
{
    public partial class ManHinhChinh : Form
    {
        FormUsers formUsers;
        FormRoles formRoles;
        FormPrivileges formPrivileges;

        public ManHinhChinh()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ManHinhChinh_Load(object sender, EventArgs e)
        {
            btnUsers.PerformClick();
        }

        private void ManHinhChinh_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
            DatabaseHandler.Disconnect();
        }

        private void FormUsers_FormClosed(object sender, FormClosedEventArgs e)
        {
            formUsers = null;
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            if (formUsers == null || formUsers.IsDisposed)
            {
                formUsers = new FormUsers();
                formUsers.FormClosed += FormUsers_FormClosed;
            }

            showForm(formUsers);
        }

        private void btnRoles_Click(object sender, EventArgs e)
        {
            if (formRoles == null || formRoles.IsDisposed)
            {
                formRoles = new FormRoles();
                formRoles.FormClosed += FormRoles_FormClosed; ;
            }

            showForm(formRoles);
        }

        private void FormRoles_FormClosed(object sender, FormClosedEventArgs e)
        {
            formRoles = null;
        }

        private void btnPrivilege_Click(object sender, EventArgs e)
        {
            if (formPrivileges == null || formPrivileges.IsDisposed)
            {
                formPrivileges = new FormPrivileges();
                formPrivileges.FormClosed += FormPrivileges_FormClosed;
            }

            showForm(formPrivileges);
        }

        private void FormPrivileges_FormClosed(object sender, FormClosedEventArgs e)
        {
            formPrivileges = null;
        }

        private void showForm(Form form)
        {
            foreach (Form openForm in this.MdiChildren)
            {
                if (openForm != form)
                {
                    openForm.Close();
                }
            }

            if (form != null && !form.Visible)
            {
                form.MdiParent = this;
                form.Show();
            }
        }
    }
}