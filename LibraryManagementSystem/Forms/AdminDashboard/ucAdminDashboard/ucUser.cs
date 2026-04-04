using ColegioLibrarySystem.Helpers;
using MySql.Data.MySqlClient;
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
    public partial class ucUser : UserControl
    {
        private DatabaseHelper dbhelper;
        public ucUser()
        {
            dbhelper = new DatabaseHelper();
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string fullName = textBox1.Text.Trim();
            string username = textBox2.Text.Trim();
            string password = textBox4.Text.Trim();
            string role = comboBox1.SelectedItem?.ToString();


            if (string.IsNullOrEmpty(fullName) || string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(role))
                {
                    MessageBox.Show("Please fill in all fields.");
                    return;
            }

            try
            {
                string query = "INSERT INTO User (fullName, username, password, role) VALUES (@fullName, @username, @password, '@role')";
                MySqlParameter[] parameters = {
                new MySqlParameter("@fullName", fullName),
                new MySqlParameter("@username", username),
                new MySqlParameter("@password", password),
                new MySqlParameter("@role", role)
                };
                dbhelper.ExecuteNonQuery(query, parameters);

                MessageBox.Show($"{role} Account created successfully! {fullName}");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong");
            }

        }
    }
}
