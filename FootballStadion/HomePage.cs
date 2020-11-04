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
    public partial class HomePage : Form
    {
        FootballStadiumEntities db = new FootballStadiumEntities();
        public HomePage()
        {
            InitializeComponent();
        }
        public void Isremember(string username, string password)
        {
            if (chekremember.Checked)
            {
                Properties.Settings.Default.Username = username;
                Properties.Settings.Default.Password = password;
                Properties.Settings.Default.isRemember = true;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.Username = "";
                Properties.Settings.Default.Password = "";
                Properties.Settings.Default.isRemember = false;
                Properties.Settings.Default.Save();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string username = txtusername.Text;
            string pas = txtpassword.Text;
            Admin selectedAdmin = db.Admins.FirstOrDefault(adm => adm.Username ==username);
            if (selectedAdmin != null)
            {
                if (selectedAdmin.Password == pas)
                {
                   AdminPageForm admp = new AdminPageForm();
                   admp.Show();
                    this.WindowState = FormWindowState.Minimized;
                }
            }

            Worker selectedWorker = db.Workers.FirstOrDefault(cs => cs.FullName == username);
            if (selectedWorker != null)
            {
                if (selectedWorker.Password == Excentios.HasMe(pas))
                {
                    Isremember(username, pas);
                    AdminPageForm admpg = new AdminPageForm();
                    admpg.ShowDialog();

                    this.WindowState = FormWindowState.Minimized;
                }
                else
                {
                    lblerror.Text = "Parolunuzu dogru qeyd edin!";
                    lblerror.Visible = true;
                }
            }
            else
            {
               lblerror.Text = "Istifadeci adinizi dogru qeyd edin!";
                lblerror.Visible = true;
            }
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.isRemember)
            {
               txtusername.Text = Properties.Settings.Default.Username;
               txtpassword.Text = Properties.Settings.Default.Password;
                chekremember.Checked = true;
            }
        }
    }
}
