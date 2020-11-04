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
    public partial class WorkersForm : Form
    {
        FootballStadiumEntities db = new FootballStadiumEntities();
        Worker selectedWorker;

        public WorkersForm()
        {
            InitializeComponent();
        }
        public void FillDataWorker()
        {
           dtgworker.DataSource = db.Workers.Select(x => new
            {
                x.Id,
                x.FullName,
               
                x.Password

            }).ToList();
            dtgworker.Columns[0].Visible = false;
        }

        private void btnaddworker_Click(object sender, EventArgs e)
        {
            
               
                string fullname= txtfullname.Text;
                string password =txtpassword.Text;
                if ( fullname != string.Empty && password != string.Empty)
                {
                Worker wrk = new Worker();
                    {
                  
                    };
                    db.Workers.Add(wrk);
                    db.SaveChanges();
                    MessageBox.Show("Worker add successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FillDataWorker();
                }
                else
                {
                    lblerror.Text = "You must fill all the field!";
                    lblerror.Visible = true;
                }
            }
        public void VisibiltyBtny(string txt)
        {
            if (txt == "edit")
            {
                btnaddworker.Visible = false;
                btneditworker.Visible = true;
                btndeletworker.Visible = true;
            }
            else
            {
                btnaddworker.Visible = true;
                btndeletworker.Visible = false;
                btneditworker.Visible = false;
            }
        }

        private void btneditworker_Click(object sender, EventArgs e)
        {

            VisibiltyBtny("add");
            string workerName = txtfullname.Text;
            string password = txtpassword.Text;
            if (workerName != string.Empty && password != string.Empty)
            {
                selectedWorker.FullName = workerName;
                selectedWorker.Password = password;
                db.SaveChanges();
                FillDataWorker();
            }
            else
            {
                lblerror.Text = "You must fill all the field!";
               lblerror.Visible = true;
            }
        }

        private void btndeletworker_Click(object sender, EventArgs e)
        {
            VisibiltyBtny("delet");
            DialogResult res = MessageBox.Show("Are you sure to delete this item?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (DialogResult.Yes == res)
            {
                db.Workers.Remove(selectedWorker);
                db.SaveChanges();
              FillDataWorker();

            }
        }

        private void WorkersForm_Load(object sender, EventArgs e)
        {

        }
    }
}

