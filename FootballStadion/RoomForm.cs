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
    public partial class RoomForm : Form
    {
        FootballStadiumEntities db = new FootballStadiumEntities();
        public RoomForm()
        {
            InitializeComponent();
        }

       public void FillDataRooms()
        {
            dtgrooms.DataSource = db.Rooms.Select(x => new
            {
             x.Id,
             x.Number
            }).ToList();
            dtgrooms.Columns[0].Visible = false;
            db.SaveChanges();
        }
        public void ClearAllData()
        {
            foreach (var trm in this.Controls)
            {
                if (trm is TextBox)
                {
                    TextBox tx = (TextBox)trm;
                    tx.Text = "";
                }
            }

        }

        private void btnroomadd_Click(object sender, EventArgs e)
        {
           int RoomsNumber = txtnumber.;

            Room newRoom = new Room
            {
                Number = RoomsNumber
                
            };
            db.Rooms.Add(newRoom);
            db.SaveChanges();
            FillDataRooms();
            ClearAllData();
        }

        private void RoomForm_Load(object sender, EventArgs e)
        {

        }

        private void dtgrooms_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
