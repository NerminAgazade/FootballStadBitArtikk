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
    public partial class AdminPageForm : Form
    {
       

        public AdminPageForm()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            HomePage home = new HomePage();
            home.ShowDialog();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            RoomForm room = new RoomForm();
            room.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            StadiumForm stad = new StadiumForm();
            stad.ShowDialog();

        }

        private void label5_Click(object sender, EventArgs e)
        {
            CustomerForm cus = new CustomerForm();
            cus.ShowDialog();

        }

        private void label2_Click(object sender, EventArgs e)
        {
            ReservationForm rsrv = new ReservationForm();
            rsrv.ShowDialog();


        }

        private void label6_Click(object sender, EventArgs e)
        {
            WorkersForm worrker = new WorkersForm();
            worrker.ShowDialog();

        }
    }
}
