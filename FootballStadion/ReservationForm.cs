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
    public partial class ReservationForm : Form 
    {
        FootballStadiumEntities db = new FootballStadiumEntities();
        public ReservationForm()
        {
            InitializeComponent();
        }
        public void FillRezerv()
        {
            dtgrezerv.DataSource = db.Rezerves.Select(x => new
            {
                x.Id,
                Customer_Name = x.Customer.Fullname,
                Stadium_Name=x.Stadium.Name,
                Rooms_Number=x.Rezerv_to_Rooms.Count,
              x.PlayDate,
              x.FromTime,
              x.ToTime,
              x.Price 
            }).ToList();
            dtgrezerv.Columns[0].Visible = false;
            db.SaveChanges();
        }
        public void FillCmbCustomer()
        {
            cmbcustomer.Items.AddRange(db.Customers.Select(c => c.Fullname).ToArray());
        }
        public void FillCmbStadion()
        {
            cmbstadion.Items.AddRange(db.Stadia.Select(c => c.Name).ToArray());
        }
        public void FillCmbRooms() 
        {
            cmbrooms.Items.AddRange(db.Rooms.Select(c => c.Number).ToArray());

        }

        private void ReservationForm_Load(object sender, EventArgs e)
        {
            FillCmbCustomer();
            FillCmbStadion();
            FillCmbRooms();
            FillRezerv();
        }
       

        private void button1_Click(object sender, EventArgs e)
        {

                string cstname = cmbcustomer.Text;
                string stadname = cmbstadion.Text;

                decimal price = nmrcprice.Value;
                DateTime datefrom = datefromtime.Value;
                DateTime todate = datetotime.Value;
                DateTime playdate =dateplays.Value;
                string[] myArr = new string[] { cstname, stadname };
                if (Excentios.IsEmpty(myArr, string.Empty)) 
                {
                    string roomname = cmbrooms.Text;
                Rezerve selectrooms = db.Rezerves.First(m => m.Rezerv_to_Rooms.Name == roomname);


                int stadId = db.Stadia.First(s => s.Name == stadname).Id;
                    int cstId = db.Customers.First(c => c.Fullname == cstname).Id;
                   Rezerve newRezerv = new Rezerve()
                    {
                       RoomId = selectrooms.Id,
                        StadiumId = stadId,
                        CustomerId = cstId,
                         PlayDate= dateplays,
                       FromTime = datefrom,
                       ToTime =datetotime,
                        Price = price
                    };
                    db.Rezerves.Add(newRezerv);
                    db.SaveChanges();
                    FillRezerv();
                BtnAddRooms();
                }
            }
        public void BtnAddRooms()
        {
            for (int i = checkrooms.Items.Count - 1; i >= 0; i--)
            {
                string roomsName =checkrooms.Items[i].ToString();
                Room selectedRoom = db.Rooms.FirstOrDefault(x => x.Number == roomsName);
                int roomsId;
                if (selectedRoom != null)
                {
                    roomsId = selectedRoom.Id;
                    db.Rezerves.Add(new Rezerve()
                    {

                        RoomsId = roomsId
                    });
                }
                db.SaveChanges();

            }
        }

        private void cmbrooms_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                string roomName = cmbrooms.Text;
                if (!checkrooms.Items.Contains(roomName))
                {
                   checkrooms.Items.Add(roomName);
                }
            }
        }

        private void checkrooms_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selected = checkrooms.SelectedIndex;
            if (selected != -1)
            {
                checkrooms.Items.RemoveAt(selected);
            }
        }
        public List<int> AddRoom()
        {
            List<int> roomListId = new List<int>();
            for (int i = checkrooms.Items.Count - 1; i >= 0; i--)
            {
                string RoomName = checkrooms.Items[i].ToString();
                Room selectedRoom = db.Rooms.FirstOrDefault(rm => rm.Number == RoomName);
                int RoomId;
                if (selectedRoom != null)
                {
                    RoomId = selectedRoom.Id;
                    roomListId.Add(RoomId);
                    db.Rezerv_to_Rooms.Add(new Rezerv_to_Rooms()
                    {
                        RoomsId = RoomId
                    });

                    db.Customer_to_Rooms.Add(new Customer_to_Rooms()
                    {
                        RoomsId =RoomId
                    });
                }

            }
            return roomListId;
        }

    }
}

