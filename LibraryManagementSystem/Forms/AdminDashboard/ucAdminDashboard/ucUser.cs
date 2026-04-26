using ColegioLibrarySystem.Helpers;
using ColegioLibrarySystem.Models;
using MySql.Data.MySqlClient;
using System.Data;

namespace LibraryManagementSystem.Forms.AdminDashboard
{
    public partial class ucUser : UserControl
    {
        private DatabaseHelper dbhelper;
        private int selecteduserid = -1;
        public ucUser()
        {

            InitializeComponent();
            dbhelper = new DatabaseHelper();
            LoadUsers();

        }
        //Add users
        private void button5_Click(object sender, EventArgs e)
        {
            string fullName = textBox1.Text.Trim();
            string username = textBox2.Text.Trim();
            string password = textBox4.Text.Trim();
            string role = comboBox1.GetItemText(comboBox1.SelectedItem).Trim();

            if (role == "Admin")
            {
                AdminCodePrompt(role);
            }


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
        //Delete users
        private void button6_Click(object sender, EventArgs e)
        {
            if (selecteduserid == -1)
            {
                MessageBox.Show("Please select a user to delete");
                return;
            }
            if (textBox2.Text == Session.Username)
            {
                MessageBox.Show("You cannot delete your own account.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var result = MessageBox.Show("Are you sure you want to delete this user?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                if (dbhelper.DeleteUsers(selecteduserid))
                {
                    MessageBox.Show("User deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadUsers();
                }
                else
                {
                    MessageBox.Show("Failed to delete user. It may be linked to existing transactions.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        //Update users
        private void button7_Click(object sender, EventArgs e)
        {
            if (selecteduserid == -1)
            {
                MessageBox.Show("Please select a user from the list to update.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string fullName = textBox1.Text.Trim();
            string username = textBox2.Text.Trim();
            string password = textBox4.Text.Trim();
            string role = comboBox1.GetItemText(comboBox1.SelectedItem).Trim();

            var confirm = MessageBox.Show("Save changes to this user?", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                if (dbhelper.UpdateUsers(selecteduserid, fullName, username, password, role))
                {
                    MessageBox.Show("User updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadUsers();
                }
                else
                {
                    MessageBox.Show("Failed to update the user. Please check your data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        //Loads all users in the database for usage
        private void LoadUsers(string searchQueary = "")
        {
            DataTable dtUser = dbhelper.GetUsers(searchQueary);
            dataGridView1.DataSource = dtUser;
        }
        //Search
        private void button1_Click(object sender, EventArgs e)
        {
            string search = textBox3.Text.Trim();
            LoadUsers(search);
        }
        //Refresh
        private void button8_Click(object sender, EventArgs e)
        {
            LoadUsers();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                selecteduserid = Convert.ToInt32(row.Cells["User ID"].Value);
                textBox1.Text = row.Cells["Fullname"].Value.ToString();
                textBox2.Text = row.Cells["Username"].Value.ToString();
                textBox4.Text = row.Cells["Password"].Value.ToString();
                comboBox1.Text = row.Cells["Role"].Value.ToString();
            }
        }
        private void AdminCodePrompt(string role)
        {
            using (AdminCode codewindow = new AdminCode())
            {
                if (codewindow.ShowDialog() == DialogResult.OK)
                {
                    codewindow.Close();
                }
            }
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            string search = textBox3.Text.Trim();
            LoadUsers(search);
        }
    }
}
