using LibraryManagementSystem.Forms.LibraryDashboard.ucLibraryDashboard;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem.Forms.UserDashboard
{
    public partial class MainLibraryDashboard : Form
    {
        public MainLibraryDashboard()
        {
            InitializeComponent();
            ucLibraryHome ucdefault = new ucLibraryHome();
            addUserControl(ucdefault);
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panel3.Controls.Clear();
            panel3.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ucLibraryHome uclibraryhome = new ucLibraryHome();
            uclibraryhome.Show();
            addUserControl(uclibraryhome);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ucBorrowed ucborrowed = new ucBorrowed();
            ucborrowed.Show();
            addUserControl(ucborrowed);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            ucTransactions uctransaction = new ucTransactions();
            uctransaction.Show();
            addUserControl(uctransaction);
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

    }
}
