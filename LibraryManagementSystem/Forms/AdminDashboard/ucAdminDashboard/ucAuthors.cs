using ColegioLibrarySystem.Helpers;
using MySql.Data.MySqlClient;
using System.Data;

namespace LibraryManagementSystem.Forms.AdminDashboard
{
    public partial class ucAuthors : UserControl
    {
        private DatabaseHelper dbHelper;
        private int selectedauthorid = -1;
        public ucAuthors()
        {
            InitializeComponent();
            dbHelper = new DatabaseHelper();
            LoadAuthors();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string authorName = textBox1.Text.Trim();
            string description = textBox2.Text.Trim();

            if (string.IsNullOrEmpty(authorName) || string.IsNullOrEmpty(description))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }
            try
            {
                string query = "INSERT INTO Author (author_name, description) VALUES (@authName, @desc)";
                MySqlParameter[] parameters = {
                    new MySqlParameter("@authName", authorName),
                    new MySqlParameter("@desc", description)
                };
                dbHelper.ExecuteNonQuery(query, parameters);
                MessageBox.Show($"Author '{authorName}' added successfully!");
                LoadAuthors();
                textBox1.Clear();
                textBox2.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong: " + ex.Message);
            }
        }
        private void LoadAuthors(string searchQueary = "")
        {
            DataTable dtAuthor = dbHelper.GetAuthors(searchQueary);
            dataGridView1.DataSource = dtAuthor;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            string search = textBox3.Text.Trim();
            LoadAuthors(search);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            LoadAuthors();
        }

        //Delete
        private void button6_Click(object sender, EventArgs e)
        {
            if (selectedauthorid == -1)
            {
                MessageBox.Show("Select an author to delete");
                return;
            }
            var result = MessageBox.Show("Are you sure you want to delete this book?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                if (dbHelper.DeleteAuthors(selectedauthorid))
                {
                    MessageBox.Show("Author deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadAuthors();
                }
                else
                {
                    MessageBox.Show("Failed to delete book. It may be linked to existing transactions.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                selectedauthorid = Convert.ToInt32(row.Cells["Author ID"].Value);
                textBox1.Text = row.Cells["Author"].Value.ToString();
                textBox2.Text = row.Cells["Description"].Value.ToString();

            }
        }
        //Update
        private void button7_Click(object sender, EventArgs e)
        {
            if (selectedauthorid == -1)
            {
                MessageBox.Show("Please select an author from the list to update.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string authorname = textBox1.Text.Trim();
            string authordescription = textBox2.Text.Trim();

            var confirm = MessageBox.Show("Save changes to this author?", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                if (dbHelper.UpdateAuthors(selectedauthorid, authorname, authordescription))
                {
                    MessageBox.Show("Author updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadAuthors();
                }
                else
                {
                    MessageBox.Show("Failed to update the author. Please check your data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            string search = textBox3.Text.Trim();
            LoadAuthors(search);
        }
    }
}
