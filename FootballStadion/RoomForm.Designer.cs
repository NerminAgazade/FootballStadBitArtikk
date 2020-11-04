namespace FootballStadion
{
    partial class RoomForm
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
            this.dtgrooms = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtnumber = new System.Windows.Forms.TextBox();
            this.btnroomadd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrooms)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgrooms
            // 
            this.dtgrooms.AllowUserToDeleteRows = false;
            this.dtgrooms.BackgroundColor = System.Drawing.Color.LightSeaGreen;
            this.dtgrooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrooms.Location = new System.Drawing.Point(1, 0);
            this.dtgrooms.Name = "dtgrooms";
            this.dtgrooms.RowHeadersWidth = 51;
            this.dtgrooms.RowTemplate.Height = 24;
            this.dtgrooms.Size = new System.Drawing.Size(1054, 355);
            this.dtgrooms.TabIndex = 0;
            this.dtgrooms.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrooms_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MintCream;
            this.label1.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label1.Location = new System.Drawing.Point(12, 409);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 49);
            this.label1.TabIndex = 1;
            this.label1.Text = "Number of Room";
            // 
            // txtnumber
            // 
            this.txtnumber.Location = new System.Drawing.Point(319, 409);
            this.txtnumber.Multiline = true;
            this.txtnumber.Name = "txtnumber";
            this.txtnumber.Size = new System.Drawing.Size(69, 49);
            this.txtnumber.TabIndex = 2;
            // 
            // btnroomadd
            // 
            this.btnroomadd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnroomadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnroomadd.Location = new System.Drawing.Point(351, 505);
            this.btnroomadd.Name = "btnroomadd";
            this.btnroomadd.Size = new System.Drawing.Size(137, 61);
            this.btnroomadd.TabIndex = 5;
            this.btnroomadd.Text = "Add";
            this.btnroomadd.UseVisualStyleBackColor = false;
            this.btnroomadd.Click += new System.EventHandler(this.btnroomadd_Click);
            // 
            // RoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 616);
            this.Controls.Add(this.btnroomadd);
            this.Controls.Add(this.txtnumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgrooms);
            this.Name = "RoomForm";
            this.Text = "RoomForm";
            this.Load += new System.EventHandler(this.RoomForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrooms)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgrooms;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnumber;
        private System.Windows.Forms.Button btnroomadd;
    }
}