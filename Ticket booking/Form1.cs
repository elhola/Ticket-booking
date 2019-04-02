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
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        OleDbConnection conBookings = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\User\\source\repos\\Ticket booking\\Ticket booking\bd.mdb");
        public Form1()
        {
            InitializeComponent();
        }

       

        private void button1_Click_1(object sender, EventArgs e)
        {
            new frmMain().Show();
            this.Close();
        }
        private void metroButtonReg_Click(object sender, EventArgs e)
        {
            new Form3().Show();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)//login
        {
            OleDbDataAdapter da = new OleDbDataAdapter("Select Count(*)From tblCustomers where TelNumber='"+metroTextBox1.Text+
                "' and Password ='"+metroTextBox2.Text+"'",conBookings);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (metroTextBox1.Text == "11111" && metroTextBox2.Text == "admin")
            {
                new admin().Show();
                Close();
            }
            else
            {
                if (dt.Rows[0][0].ToString() == "1")
                {
                    new Form2().Show();
                    Close();
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Проверьте свое имя пользователя и пароль.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
