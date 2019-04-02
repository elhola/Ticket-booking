using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Ticket_booking
{
    public partial class Price : MetroFramework.Forms.MetroForm
    {
        List<Panel> listPanel = new List<Panel>();
        int index;
        public Price()
        {
            InitializeComponent();
        }

      
        private void Price_Load(object sender, EventArgs e)
        {
            listPanel.Add(panel1);
            listPanel.Add(panel2);
            listPanel[index].BringToFront();

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.paypal.com/checkoutnow?token=EC-3S5229784R399264B");
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            MetroFramework.MetroMessageBox.Show(this, "Транзакция выполнена успешно . Спасибо за покупку!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            new Form2().Show();
            this.Close();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {

            MetroFramework.MetroMessageBox.Show(this, "Транзакция выполнена успешно . Спасибо за покупку!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            new Form2().Show();
            this.Close();
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (metroComboBox1.Text=="1")
            {
                metroTextBox1.Text = "75 грн";
            }
            if (metroComboBox1.Text == "2")
            {
                metroTextBox1.Text = "150 грн";
            }
            if (metroComboBox1.Text == "3")
            {
                metroTextBox1.Text = "225 грн";
            }
            if (metroComboBox1.Text == "4")
            {
                metroTextBox1.Text = "300 грн";
            }
            if (metroComboBox1.Text == "5")
            {
                metroTextBox1.Text = "375 грн";
            }
            if (metroComboBox1.Text == "6")
            {
                metroTextBox1.Text = "450 грн";
            }
            if (metroComboBox1.Text == "7")
            {
                metroTextBox1.Text = "525 грн";
            }
            if (metroComboBox1.Text == "8")
            {
                metroTextBox1.Text = "600 грн";
            }
            if (metroComboBox1.Text == "9")
            {
                metroTextBox1.Text = "675 грн";
            }
            if (metroComboBox1.Text == "10")
            {
                metroTextBox1.Text = "750 грн";
            }
        }

        private void metroComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (metroComboBox2.Text == "1")
            {
                metroTextBox3.Text = "75 грн";
            }
            if (metroComboBox2.Text == "2")
            {
                metroTextBox3.Text = "150 грн";
            }
            if (metroComboBox2.Text == "3")
            {
                metroTextBox3.Text = "225 грн";
            }
            if (metroComboBox2.Text == "4")
            {
                metroTextBox3.Text = "300 грн";
            }
            if (metroComboBox2.Text == "5")
            {
                metroTextBox3.Text = "375 грн";
            }
            if (metroComboBox2.Text == "6")
            {
                metroTextBox3.Text = "450 грн";
            }
            if (metroComboBox2.Text == "7")
            {
                metroTextBox3.Text = "525 грн";
            }
            if (metroComboBox2.Text == "8")
            {
                metroTextBox3.Text = "600 грн";
            }
            if (metroComboBox2.Text == "9")
            {
                metroTextBox3.Text = "675 грн";
            }
            if (metroComboBox2.Text == "10")
            {
                metroTextBox3.Text = "750 грн";
            }
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            if (index < listPanel.Count - 1)
                listPanel[++index].BringToFront();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            if (index > 0)
                listPanel[--index].BringToFront();
        }
    }
}