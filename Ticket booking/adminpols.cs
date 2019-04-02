using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Ticket_booking
{
    public partial class adminpols : MetroFramework.Forms.MetroForm
    {
        OleDbConnection conBookings = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\User\\source\repos\\Ticket booking\\Ticket booking\bd.mdb");
        public adminpols()
        {
            InitializeComponent();
        }

        private void adminpols_Load(object sender, EventArgs e)
        {
           
            this.tblCustomersTableAdapter.Fill(this.bdDataSet.tblCustomers);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bdDataSet.tblCustomers". При необходимости она может быть перемещена или удалена.
           
            PasswordID_txt.Text = (from DataGridViewRow row in dataGridView2.Rows
                                   where row.Cells[0].FormattedValue.ToString() != string.Empty
                                   select Convert.ToInt32(row.Cells[0].FormattedValue)).Max().ToString();
        }
    }
}
