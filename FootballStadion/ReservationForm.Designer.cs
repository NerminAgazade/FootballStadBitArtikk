namespace FootballStadion
{
    partial class ReservationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbcustomer = new System.Windows.Forms.ComboBox();
            this.cmbstadion = new System.Windows.Forms.ComboBox();
            this.cmbrooms = new System.Windows.Forms.ComboBox();
            this.dateplays = new System.Windows.Forms.DateTimePicker();
            this.datefromtime = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.datetotime = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.nmrcprice = new System.Windows.Forms.NumericUpDown();
            this.dtgrezerv = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.checkrooms = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.nmrcprice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrezerv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(186, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(487, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "REZERVATION  PAGE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(1, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(262, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Customer Fullname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(1, 549);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "From Time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Green;
            this.label4.Location = new System.Drawing.Point(1, 467);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 32);
            this.label4.TabIndex = 4;
            this.label4.Text = "Play Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Green;
            this.label5.Location = new System.Drawing.Point(1, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 32);
            this.label5.TabIndex = 5;
            this.label5.Text = "Rooms";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Green;
            this.label6.Location = new System.Drawing.Point(-5, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(195, 32);
            this.label6.TabIndex = 6;
            this.label6.Text = "Stadion Name";
            // 
            // cmbcustomer
            // 
            this.cmbcustomer.FormattingEnabled = true;
            this.cmbcustomer.Location = new System.Drawing.Point(1, 114);
            this.cmbcustomer.Name = "cmbcustomer";
            this.cmbcustomer.Size = new System.Drawing.Size(273, 24);
            this.cmbcustomer.TabIndex = 7;
            // 
            // cmbstadion
            // 
            this.cmbstadion.FormattingEnabled = true;
            this.cmbstadion.Location = new System.Drawing.Point(1, 203);
            this.cmbstadion.Name = "cmbstadion";
            this.cmbstadion.Size = new System.Drawing.Size(273, 24);
            this.cmbstadion.TabIndex = 8;
            // 
            // cmbrooms
            // 
            this.cmbrooms.FormattingEnabled = true;
            this.cmbrooms.Location = new System.Drawing.Point(-8, 300);
            this.cmbrooms.Name = "cmbrooms";
            this.cmbrooms.Size = new System.Drawing.Size(273, 24);
            this.cmbrooms.TabIndex = 9;
            this.cmbrooms.SelectedIndexChanged += new System.EventHandler(this.cmbrooms_SelectedIndexChanged);
            this.cmbrooms.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbrooms_KeyPress);
            // 
            // dateplays
            // 
            this.dateplays.Location = new System.Drawing.Point(-8, 502);
            this.dateplays.Name = "dateplays";
            this.dateplays.Size = new System.Drawing.Size(262, 22);
            this.dateplays.TabIndex = 10;
            this.dateplays.Value = new System.DateTime(2020, 10, 26, 17, 39, 9, 0);
            // 
            // datefromtime
            // 
            this.datefromtime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.datefromtime.Location = new System.Drawing.Point(-8, 584);
            this.datefromtime.Name = "datefromtime";
            this.datefromtime.Size = new System.Drawing.Size(262, 22);
            this.datefromtime.TabIndex = 11;
            this.datefromtime.Value = new System.DateTime(2020, 10, 26, 17, 39, 9, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Green;
            this.label7.Location = new System.Drawing.Point(1, 628);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 32);
            this.label7.TabIndex = 12;
            this.label7.Text = "To Time";
            // 
            // datetotime
            // 
            this.datetotime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.datetotime.Location = new System.Drawing.Point(-8, 663);
            this.datetotime.Name = "datetotime";
            this.datetotime.Size = new System.Drawing.Size(262, 22);
            this.datetotime.TabIndex = 13;
            this.datetotime.Value = new System.DateTime(2020, 10, 26, 17, 39, 9, 0);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Green;
            this.label8.Location = new System.Drawing.Point(31, 805);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 32);
            this.label8.TabIndex = 14;
            this.label8.Text = "Price";
            // 
            // nmrcprice
            // 
            this.nmrcprice.Location = new System.Drawing.Point(1, 840);
            this.nmrcprice.Name = "nmrcprice";
            this.nmrcprice.Size = new System.Drawing.Size(231, 22);
            this.nmrcprice.TabIndex = 15;
            // 
            // dtgrezerv
            // 
            this.dtgrezerv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgrezerv.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgrezerv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrezerv.Location = new System.Drawing.Point(426, 63);
            this.dtgrezerv.Name = "dtgrezerv";
            this.dtgrezerv.RowHeadersWidth = 51;
            this.dtgrezerv.RowTemplate.Height = 24;
            this.dtgrezerv.Size = new System.Drawing.Size(599, 461);
            this.dtgrezerv.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(383, 618);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 67);
            this.button1.TabIndex = 17;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkrooms
            // 
            this.checkrooms.CheckOnClick = true;
            this.checkrooms.FormattingEnabled = true;
            this.checkrooms.Location = new System.Drawing.Point(1, 331);
            this.checkrooms.Margin = new System.Windows.Forms.Padding(4);
            this.checkrooms.Name = "checkrooms";
            this.checkrooms.Size = new System.Drawing.Size(290, 106);
            this.checkrooms.TabIndex = 27;
            this.checkrooms.SelectedIndexChanged += new System.EventHandler(this.checkrooms_SelectedIndexChanged);
            // 
            // ReservationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(1066, 725);
            this.Controls.Add(this.checkrooms);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtgrezerv);
            this.Controls.Add(this.nmrcprice);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.datetotime);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.datefromtime);
            this.Controls.Add(this.dateplays);
            this.Controls.Add(this.cmbrooms);
            this.Controls.Add(this.cmbstadion);
            this.Controls.Add(this.cmbcustomer);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ReservationForm";
            this.Text = "ReservetionForm";
            this.Load += new System.EventHandler(this.ReservationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmrcprice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrezerv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbcustomer;
        private System.Windows.Forms.ComboBox cmbstadion;
        private System.Windows.Forms.ComboBox cmbrooms;
        private System.Windows.Forms.DateTimePicker dateplays;
        private System.Windows.Forms.DateTimePicker datefromtime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker datetotime;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nmrcprice;
        private System.Windows.Forms.DataGridView dtgrezerv;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckedListBox checkrooms;
    }
}