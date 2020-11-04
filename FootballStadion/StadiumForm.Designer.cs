namespace FootballStadion
{
    partial class StadiumForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtgstadium = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnadd = new System.Windows.Forms.Button();
            this.txtstadname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgstadium)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.dtgstadium);
            this.panel1.Location = new System.Drawing.Point(3, 257);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1022, 349);
            this.panel1.TabIndex = 0;
            // 
            // dtgstadium
            // 
            this.dtgstadium.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgstadium.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgstadium.Location = new System.Drawing.Point(0, 25);
            this.dtgstadium.Name = "dtgstadium";
            this.dtgstadium.RowHeadersWidth = 51;
            this.dtgstadium.RowTemplate.Height = 24;
            this.dtgstadium.Size = new System.Drawing.Size(1019, 306);
            this.dtgstadium.TabIndex = 0;
            this.dtgstadium.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgstadium_RowHeaderMouseDoubleClick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnadd);
            this.panel3.Controls.Add(this.txtstadname);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(3, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(867, 226);
            this.panel3.TabIndex = 2;
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Location = new System.Drawing.Point(370, 130);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(141, 64);
            this.btnadd.TabIndex = 6;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // txtstadname
            // 
            this.txtstadname.Location = new System.Drawing.Point(20, 56);
            this.txtstadname.Multiline = true;
            this.txtstadname.Name = "txtstadname";
            this.txtstadname.Size = new System.Drawing.Size(268, 38);
            this.txtstadname.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name of Stadium";
            // 
            // StadiumForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 600);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "StadiumForm";
            this.Text = "StadiumForm";
            this.Load += new System.EventHandler(this.StadiumForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgstadium)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtgstadium;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtstadname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnadd;
    }
}