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
    public partial class Form3 : MetroFramework.Forms.MetroForm
    {
        OleDbConnection conBookings = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\User\\source\repos\\Ticket booking\\Ticket booking\bd.mdb");

        public Form3()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            conBookings.Open();
            OleDbCommand cmd = conBookings.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into tblCustomers values('" + PasswordID_txt.Text + "','" + Name_txt.Text + "','" + Name1_txt.Text + "','" + Phone_txt.Text + "','" + Password_txt.Text + "')";
            cmd.ExecuteNonQuery();
            conBookings.Close();
            MetroFramework.MetroMessageBox.Show(this, "Вы успешно зарегестрированы.Нажмите ОК что бы продолжить!. Запомните свой  номер ID", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

        }
   
        private void button1_Click_1(object sender, EventArgs e)
        {
            new frmMain().Show();
            Close();
        }


        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bdDataSet1.tblBookings". При необходимости она может быть перемещена или удалена.

            this.tblCustomersTableAdapter.Fill(this.bdDataSet1.tblCustomers);
              PasswordID_txt.Text = (from DataGridViewRow row in dataGridView1.Rows
                                  where row.Cells[0].FormattedValue.ToString() != string.Empty
                                 select Convert.ToInt32(row.Cells[0].FormattedValue)).Max().ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            new Form2().Show();
            Close();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            new Form2().Show();
            Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
