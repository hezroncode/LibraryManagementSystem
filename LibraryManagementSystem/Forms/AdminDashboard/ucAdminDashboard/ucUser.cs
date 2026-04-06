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

            InitializeComponent();
            dbhelper = new DatabaseHelper();
            LoadUsers();

        }
        private void button5_Click(object sender, EventArgs e)
        {
            string fullName = textBox1.Text.Trim();
            string username = textBox2.Text.Trim();
            string password = textBox4.Text.Trim();
            string role = comboBox1.GetItemText(comboBox1.SelectedItem).Trim();


            if (string.IsNullOrEmpty(fullName) || string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(role))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }
            try
            {
                string query = "INSERT INTO User (fullName, username, password, role) VALUES (@fullName, @username, @password, @role)";
                MySqlParameter[] parameters = {
                new MySqlParameter("@fullName", fullName),
                new MySqlParameter("@username", username),
                new MySqlParameter("@password", password),
                new MySqlParameter("@role", role)
                };
                dbhelper.ExecuteNonQuery(query, parameters);

                MessageBox.Show($"{role} Account created successfully! {fullName}");
                LoadUsers();
                textBox1.Clear();
                textBox2.Clear();
                textBox4.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong");
            }

        }
        private void LoadUsers(string searchQueary = "")
        {
            DataTable dtUser = dbhelper.GetUsers(searchQueary);
            dataGridView1.DataSource = dtUser;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string search = textBox3.Text.Trim();
            LoadUsers(search);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            LoadUsers();
        }
    }
}
