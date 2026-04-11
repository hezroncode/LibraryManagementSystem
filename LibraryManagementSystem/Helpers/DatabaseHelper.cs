using MySql.Data.MySqlClient;
using System.Data;

namespace ColegioLibrarySystem.Helpers
{
    public class DatabaseHelper
    {
        // e adjust lang ang port if dili 3306 ang gamit sa inyong xampp
        private string connectionString = "Server=localhost;Database=librarymanagementdb;Uid=root;Pwd=;";

        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }

        // mga SELECT na queries
        public DataTable ExecuteQuery(string query, MySqlParameter[] parameters = null)
        {
            DataTable dt = new DataTable();
            using (MySqlConnection conn = GetConnection())
            {
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    if (parameters != null)
                        cmd.Parameters.AddRange(parameters);

                    try
                    {
                        conn.Open();
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            adapter.Fill(dt);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            return dt;
        }
        // mga INSERT, UPDATE, DELETE na queries
        public int ExecuteNonQuery(string query, MySqlParameter[] parameters = null)
        {
            int rowsAffected = 0;
            using (MySqlConnection conn = GetConnection())
            {
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    if (parameters != null)
                        cmd.Parameters.AddRange(parameters);

                    try
                    {
                        conn.Open();
                        rowsAffected = cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            return rowsAffected;
        }
        public DataTable GetBooks(string searchquery = "", int categoryId = 0, int authorID = 0)
        {
            string query = @"SELECT b.book_id AS 'BookID', b.title AS Title, a.author_name AS Author, c.category_name AS Category, b.yearpublished AS 'Year Published', b.total_copies AS 'Total Copies', b.available_copies AS 'Available Copies'
                           FROM book b
                           JOIN author a ON b.author_id = a.author_id
                           JOIN Category c ON b.category_id = c.category_id
                           WHERE (@search IS NULL OR b.title LIKE @search)
                           AND (@catId = 0 OR b.category_id = @catId) 
                           AND (@authId = 0 OR b.author_id = @authId)";
            MySqlParameter[] parameters = {
                new MySqlParameter("@search", string.IsNullOrEmpty(searchquery) ? (object)DBNull.Value : "%" + searchquery + "%"),
                new MySqlParameter("@catId", categoryId),
                new MySqlParameter("@authId", authorID)
                };
            return ExecuteQuery(query, parameters);
        }
        public DataTable GetAuthors(string searchquery = "")
        {
            string query = @"SELECT author_id, author_name FROM Author
                            WHERE (@search IS NULL OR author_name LIKE @search)
                            ORDER BY author_name ASC";
            MySqlParameter[] parameters = {
                new MySqlParameter("@search", string.IsNullOrEmpty(searchquery) ? (object)DBNull.Value : "%" + searchquery + "%")
            };
            return ExecuteQuery(query, parameters);

        }
        public DataTable GetCategories(string searchquery = "")
        {
            string query = @"SELECT category_id, category_name FROM Category
                           WHERE (@search IS NULL OR category_name LIKE @search)
                           ORDER BY category_id ASC";
            MySqlParameter[] parameters = {
                new MySqlParameter("@search", string.IsNullOrEmpty(searchquery) ? (object)DBNull.Value : "%" + searchquery + "%")
            };
            return ExecuteQuery(query, parameters);
        }
        public DataTable GetUsers(string searchquery = "")
        {
            string query = @"SELECT user_id AS 'User ID', fullname AS 'Fullname', username AS 'Username', role AS 'Role' FROM User
                           WHERE (@search IS NULL OR user_id = @search OR username = @search)";
            MySqlParameter[] parameters = {
                new MySqlParameter("@search", string.IsNullOrEmpty(searchquery) ? (object)DBNull.Value : "%" + searchquery + "%")
            };
            return ExecuteQuery(query, parameters);
        }
        public DataTable GetTransactions(string searchquery = "", int userID = 0, int bookID = 0)
        {
            string query = @"SELECT t.transaction_id AS 'ID', 
                           u.fullname AS 'Borrower', 
                           b.title AS 'Book Title', 
                           t.quantity AS 'Qty', 
                           t.borrow_date AS 'Borrowed', 
                           t.return_date AS 'Returned',
                           t.status AS 'Status'
                           FROM `transaction` t
                           JOIN User u ON t.user_id = u.user_id
                           JOIN book b ON t.book_id = b.book_id
                           WHERE (@search IS NULL OR u.fullname LIKE @search OR b.title LIKE @search)
                           ORDER BY t.borrow_date DESC";

            MySqlParameter[] parameters = {
            new MySqlParameter("@search", string.IsNullOrEmpty(searchquery) ? (object)DBNull.Value : "%" + searchquery + "%")
        };

            return ExecuteQuery(query, parameters);
        }

        public int GetActiveBorrowCount(int userId)
        {
                string query = "SELECT COUNT(*) FROM transaction WHERE user_id = @userId AND status = 'Borrow'";
                MySqlParameter[] parameters = {
            new MySqlParameter("@userId", userId)
        };
                using (MySqlConnection conn = GetConnection())
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddRange(parameters);
                    conn.Open();
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
        }

        public bool HasAlreadyBorrowed(int userId, int bookId)
        {
                string query = "SELECT COUNT(*) FROM `transaction` WHERE user_id = @userId AND book_id = @bookId AND status = 'Borrow'";
                MySqlParameter[] parameters = {
            new MySqlParameter("@userId", userId),
            new MySqlParameter("@bookId", bookId)
        };
                using (MySqlConnection conn = GetConnection())
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddRange(parameters);
                    conn.Open();
                    return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
                }
        }

        public (bool success, string message) BorrowBook(int userId, string userRole, int bookId)
        {
            if (userRole == "Student" && HasAlreadyBorrowed(userId, bookId))
                return (false, "Students can only borrow 1 copy per book.");

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlTransaction transaction = conn.BeginTransaction();
                try
                {
                    // Check available copies
                    string checkQuery = "SELECT available_copies FROM book WHERE book_id = @bookId";
                    MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn, transaction);
                    checkCmd.Parameters.AddWithValue("@bookId", bookId);
                    int available = Convert.ToInt32(checkCmd.ExecuteScalar());

                    if (available <= 0)
                        return (false, "This book is currently out of stock.");

                    // Deduct available copies
                    string updateBook = "UPDATE book SET available_copies = available_copies - 1 WHERE book_id = @bookId";
                    MySqlCommand updateCmd = new MySqlCommand(updateBook, conn, transaction);
                    updateCmd.Parameters.AddWithValue("@bookId", bookId);
                    updateCmd.ExecuteNonQuery();

                    // Insert transaction record (quantity = 1 for students, can be dynamic)
                    string insertQuery = @"INSERT INTO `transaction` (user_id, book_id, quantity, borrow_date, status) 
                                   VALUES (@userId, @bookId, 1, NOW(), 'Borrow')";
                    MySqlCommand insertCmd = new MySqlCommand(insertQuery, conn, transaction);
                    insertCmd.Parameters.AddWithValue("@userId", userId);
                    insertCmd.Parameters.AddWithValue("@bookId", bookId);
                    insertCmd.ExecuteNonQuery();

                    transaction.Commit();
                    return (true, "Book borrowed successfully!");
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    return (false, "Error: " + ex.Message);
                }
            }
        }

        public (bool success, string message) ReturnBook(int transactionId, int bookId)
        {
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlTransaction transaction = conn.BeginTransaction();
                try
                {
                    // Mark as returned
                    string updateTransaction = @"UPDATE transaction 
                                         SET return_date = NOW(), status = 'Returned'
                                         WHERE transaction_id = @transactionId";
                    MySqlCommand updateTxCmd = new MySqlCommand(updateTransaction, conn, transaction);
                    updateTxCmd.Parameters.AddWithValue("@transactionId", transactionId);
                    updateTxCmd.ExecuteNonQuery();

                    // Restore available copies
                    string updateBook = "UPDATE book SET available_copies = available_copies + 1 WHERE book_id = @bookId";
                    MySqlCommand updateBookCmd = new MySqlCommand(updateBook, conn, transaction);
                    updateBookCmd.Parameters.AddWithValue("@bookId", bookId);
                    updateBookCmd.ExecuteNonQuery();

                    transaction.Commit();
                    return (true, "Book returned successfully!");
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    return (false, "Error: " + ex.Message);
                }
            }
        }

        public DataTable GetBorrowedBooksByUser(int userId)
        {
            string query = @"SELECT t.transaction_id AS 'TransactionID',
                     b.book_id AS 'BookID',
                     b.title AS 'Title',
                     a.author_name AS 'Author',
                     t.borrow_date AS 'Borrow Date'
                     FROM transaction t
                     JOIN book b ON t.book_id = b.book_id
                     JOIN author a ON b.author_id = a.author_id
                     WHERE t.user_id = @userId AND t.status = 'Borrow'";
            MySqlParameter[] parameters = {
        new MySqlParameter("@userId", userId)
    };
            return ExecuteQuery(query, parameters);
        }
    }
}