using ColegioLibrarySystem.Helpers;
using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using System.Data;

namespace LibraryManagementSystem.Forms
{
    public partial class AdminSignUpForm : Form
    {
        private DatabaseHelper dbHelper;
        public AdminSignUpForm()
        {
            dbHelper = new DatabaseHelper();
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fullName = textBox1.Text.Trim();
            string username = textBox2.Text.Trim();
            string password = textBox3.Text.Trim();

            if (string.IsNullOrEmpty(fullName) || string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }
            if (Usernametaken(username))
            {
                MessageBox.Show("Username is already taken. Please choose another.", "Username Unavailable", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (password.Length < 3)
            {
                MessageBox.Show("Password is too short, at least 3 characters long", "Short password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            try
            {
                string query = "INSERT INTO User (fullName, username, password, role) VALUES (@fullName, @username, @password, 'Admin')";
                MySqlParameter[] parameters = {
                new MySqlParameter("@fullName", fullName),
                new MySqlParameter("@username", username),
                new MySqlParameter("@password", password)
                };
                dbHelper.ExecuteNonQuery(query, parameters);

                MessageBox.Show($"Admin account created successfully! {fullName}");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong");
            }
        }
        private bool Usernametaken(string username)
        {
            string query = "SELECT COUNT(*) FROM User WHERE username = @username";
            MySqlParameter[] parameters = {
                new MySqlParameter("@username", username)
            };

            DataTable dt = dbHelper.ExecuteQuery(query, parameters);

            if (dt.Rows.Count > 0)
            {
                int count = Convert.ToInt32(dt.Rows[0][0]);
                return count > 0;
            }

            return false;
        }
    }
}
