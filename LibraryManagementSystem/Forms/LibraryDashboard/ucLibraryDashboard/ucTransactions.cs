using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ColegioLibrarySystem.Helpers;
using ColegioLibrarySystem.Models;

namespace LibraryManagementSystem.Forms.LibraryDashboard.ucLibraryDashboard
{
    public partial class ucTransactions : UserControl
    {
        private DatabaseHelper dbhelper;

        public ucTransactions()
        {
            InitializeComponent();
            dbhelper = new DatabaseHelper();
            LoadHistory();
        }

        private void LoadHistory()
        {
           
            DataTable dtHistory = dbhelper.GetTransactionHistory(Session.UserID);
            dataGridView1.DataSource = dtHistory;
        }

        
        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Action")
            {
                string status = e.Value?.ToString();

                if (status == "Borrow")
                {
                    
                    e.CellStyle.ForeColor = Color.SeaGreen;
                    e.CellStyle.Font = new Font(dataGridView1.Font, FontStyle.Bold);
                }
                else if (status == "Returned")
                {
                    
                    e.CellStyle.ForeColor = Color.Gray;
                }
            }
        }
    }
}