using FootballStadion.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FootballStadion
{
    public partial class CustomerForm : Form
    {
        FootballStadiumEntities db = new FootballStadiumEntities();
        public CustomerForm()
        {
            InitializeComponent();
        }
        public void FillDataCustomers()
        {
            dtgcustomer.DataSource = db.Customers.Select(x => new
            {
                x.Id,
                x.Fullname,
                x.Phone
            }).ToList();
            dtgcustomer.Columns[0].Visible = false;
            db.SaveChanges();
        }
        public void ClearAllDt()
        {
            foreach (var txtBox in this.Controls)
            {
                if (txtBox is TextBox)
                {
                    TextBox tx = (TextBox)txtBox;
                    tx.Text = "";
                }
            }
        }
        private void CustomerForm_Load(object sender, EventArgs e)
        {
            string fullname = textBox1.Text;

            string phone = textBox2.Text;
            string[] myArr = new string[] { fullname, phone };
            if (Excentios.IsEmpty(myArr, string.Empty))
            {
                Customer newCus = new Customer
                {
                    Fullname = fullname,

                    Phone = Convert.ToString(phone)

                };
                db.Customers.Add(newCus);
                db.SaveChanges();
                FillDataCustomers();
                ClearAllDt();
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if ((e.KeyChar < 48 || e.KeyChar > 57 || textBox2.Text.Length >= 10) && e.KeyChar != 9)
                {
                    e.Handled = true;

                }
            }
        }
    }
}

