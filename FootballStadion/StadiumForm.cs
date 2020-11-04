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
    public partial class StadiumForm : Form
    {
        FootballStadiumEntities db = new FootballStadiumEntities();
        Stadium selectstad;
        public StadiumForm()
        {
            InitializeComponent();
        }

        public void FillDataStadium()
        {
            dtgstadium.DataSource = db.Stadia.Select(x => new
            {
                x.Id,
                x.Name
            }).ToList();
            dtgstadium.Columns[0].Visible = false;
            db.SaveChanges();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            string stadname = txtstadname.Text;
            if (stadname != string.Empty)
            {
                Stadium newSt = new Stadium
                {
                    Name = stadname
                };
                db.Stadia.Add(newSt);
                db.SaveChanges();
                FillDataStadium();
                ClearData();
            }

        }
        public void ClearData()
        {
            foreach (var stx in this.Controls)
            {
                if (stx is TextBox)
                {
                    TextBox t = (TextBox)stx;
                    t.Text = "";
                }
            }
        }

        private void dtgstadium_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnadd.Visible = false;
            int stadiumId = (int)dtgstadium.Rows[e.RowIndex].Cells[0].Value;
            selectstad= db.Stadia.First(x => x.Id == stadiumId);
            txtstadname.Text = selectstad.Name;
        }

        private void StadiumForm_Load(object sender, EventArgs e)
        {

        }
    }
}
