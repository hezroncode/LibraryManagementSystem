using ColegioLibrarySystem.Helpers;
using MySql.Data.MySqlClient;


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
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
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
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong");
            }
        }
        //protected override void OnFormClosed(FormClosedEventArgs e) { Application.Exit(); }
    }
}
