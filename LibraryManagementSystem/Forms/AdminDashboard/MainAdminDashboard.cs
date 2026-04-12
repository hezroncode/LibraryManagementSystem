using ColegioLibrarySystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem.Forms.AdminDashboard
{
    public partial class MainAdminDashboard : Form
    {
        public MainAdminDashboard()
        {
            InitializeComponent();

            ucHome homedefault = new ucHome();
            addUserControl(homedefault);

        }
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            pnlContainer.Controls.Clear();
            pnlContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ucBooks uc = new ucBooks();
            uc.Show();
            addUserControl(uc);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ucAuthors uc1 = new ucAuthors();
            uc1.Show();
            addUserControl(uc1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ucCategories uc2 = new ucCategories();
            uc2.Show();
            addUserControl(uc2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ucUser uc3 = new ucUser();
            uc3.Show();
            addUserControl(uc3);
        }

        private void MainAdminDashboard_Load(object sender, EventArgs e)
        {
            label2.Text = $"Welcome {Session.FullName}";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to go back to the login screen?",
                                 "Switch Account",
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Restart();
                Environment.Exit(0);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ucHome uc4 = new ucHome();
            uc4.Show();
            addUserControl(uc4);
        }
    }
}
