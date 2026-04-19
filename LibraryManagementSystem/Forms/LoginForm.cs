using ColegioLibrarySystem.Helpers;
using ColegioLibrarySystem.Models;
using LibraryManagementSystem.Forms;
using LibraryManagementSystem.Forms.AdminDashboard;
using LibraryManagementSystem.Forms.UserDashboard;
using MySql.Data.MySqlClient;
using System.Data;

namespace LibraryManagementSystem
{
    public partial class LoginForm : Form
    {
        private DatabaseHelper dbHelper;
        private bool passwordVisible = false;
        public LoginForm()
        {
            dbHelper = new DatabaseHelper();
            InitializeComponent();
        }

        private void cnfrmbtn1_Click(object sender, EventArgs e)
        {
            string user = textBox1.Text.Trim();
            string pass = textBox2.Text.Trim();

            if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(pass))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            string query = "SELECT user_id, username, role, fullName FROM User WHERE username = @user AND password = @pass";
            MySqlParameter[] parameters = {
                new MySqlParameter("@user", user),
                new MySqlParameter("@pass", pass)
            };

            DataTable dt = dbHelper.ExecuteQuery(query, parameters);

            if (dt.Rows.Count > 0)
            {
                Session.UserID = Convert.ToInt32(dt.Rows[0]["user_id"]);
                Session.Username = dt.Rows[0]["username"].ToString();
                Session.Role = dt.Rows[0]["role"].ToString();
                Session.FullName = dt.Rows[0]["fullName"].ToString();

                MessageBox.Show($"Welcome {Session.FullName}!");

                if (Session.Role == "Admin")
                {
                    MainAdminDashboard adminForm = new MainAdminDashboard();
                    adminForm.Show();
                }
                else
                {
                    MainLibraryDashboard libraryForm = new MainLibraryDashboard();
                    libraryForm.Show();
                }
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.");
                textBox1.Clear();
                textBox2.Clear();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (AdminCode codewindow = new AdminCode())
            {
                if (codewindow.ShowDialog() == DialogResult.OK)
                {
                    AdminSignUpForm signUpForm = new AdminSignUpForm();
                    signUpForm.Show();
                    this.Close();

                    signUpForm.FormClosed += (s, args) =>
                    {
                        this.Show();
                    };
                }
            }

        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            passwordVisible = !passwordVisible;
            if (passwordVisible)
            {
                textBox2.PasswordChar = '\0';
                pictureBox2.Image = Image.FromFile("Images/eyeopen.png");
            }
            else
            {
                textBox2.PasswordChar = '●';
                pictureBox2.Image = Image.FromFile("Images/eyeclose.png");
            }
        }

        //protected override void OnFormClosed(FormClosedEventArgs e) { Application.Exit(); }
    }
}
