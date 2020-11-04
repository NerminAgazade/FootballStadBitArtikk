namespace FootballStadion
{
    partial class WorkersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkersForm));
            this.dtgworker = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtfullname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.btnaddworker = new System.Windows.Forms.Button();
            this.btndeletworker = new System.Windows.Forms.Button();
            this.btneditworker = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblerror = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgworker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgworker
            // 
            this.dtgworker.BackgroundColor = System.Drawing.Color.BurlyWood;
            this.dtgworker.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgworker.Location = new System.Drawing.Point(1, 317);
            this.dtgworker.Name = "dtgworker";
            this.dtgworker.RowHeadersWidth = 51;
            this.dtgworker.RowTemplate.Height = 24;
            this.dtgworker.Size = new System.Drawing.Size(1261, 370);
            this.dtgworker.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fullname";
            // 
            // txtfullname
            // 
            this.txtfullname.Location = new System.Drawing.Point(12, 53);
            this.txtfullname.Name = "txtfullname";
            this.txtfullname.Size = new System.Drawing.Size(163, 22);
            this.txtfullname.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Info;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(382, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 38);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(376, 53);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(163, 22);
            this.txtpassword.TabIndex = 5;
            // 
            // btnaddworker
            // 
            this.btnaddworker.BackColor = System.Drawing.Color.Lime;
            this.btnaddworker.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddworker.Location = new System.Drawing.Point(246, 162);
            this.btnaddworker.Name = "btnaddworker";
            this.btnaddworker.Size = new System.Drawing.Size(165, 72);
            this.btnaddworker.TabIndex = 6;
            this.btnaddworker.Text = "Add";
            this.btnaddworker.UseVisualStyleBackColor = false;
            this.btnaddworker.Click += new System.EventHandler(this.btnaddworker_Click);
            // 
            // btndeletworker
            // 
            this.btndeletworker.BackColor = System.Drawing.Color.Red;
            this.btndeletworker.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndeletworker.Location = new System.Drawing.Point(351, 162);
            this.btndeletworker.Name = "btndeletworker";
            this.btndeletworker.Size = new System.Drawing.Size(181, 72);
            this.btndeletworker.TabIndex = 7;
            this.btndeletworker.Text = "Delete";
            this.btndeletworker.UseVisualStyleBackColor = false;
            this.btndeletworker.Visible = false;
            this.btndeletworker.Click += new System.EventHandler(this.btndeletworker_Click);
            // 
            // btneditworker
            // 
            this.btneditworker.BackColor = System.Drawing.Color.Tan;
            this.btneditworker.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneditworker.Location = new System.Drawing.Point(135, 162);
            this.btneditworker.Name = "btneditworker";
            this.btneditworker.Size = new System.Drawing.Size(165, 72);
            this.btneditworker.TabIndex = 8;
            this.btneditworker.Text = "Edit";
            this.btneditworker.UseVisualStyleBackColor = false;
            this.btneditworker.Visible = false;
            this.btneditworker.Click += new System.EventHandler(this.btneditworker_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(766, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(496, 280);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblerror
            // 
            this.lblerror.AutoSize = true;
            this.lblerror.BackColor = System.Drawing.Color.Red;
            this.lblerror.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblerror.Location = new System.Drawing.Point(449, 120);
            this.lblerror.Name = "lblerror";
            this.lblerror.Size = new System.Drawing.Size(40, 18);
            this.lblerror.TabIndex = 11;
            this.lblerror.Text = "error";
            this.lblerror.Visible = false;
            // 
            // WorkersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 685);
            this.Controls.Add(this.lblerror);
            this.Controls.Add(this.btneditworker);
            this.Controls.Add(this.btndeletworker);
            this.Controls.Add(this.btnaddworker);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtfullname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dtgworker);
            this.Name = "WorkersForm";
            this.Text = "WorkersForm";
            this.Load += new System.EventHandler(this.WorkersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgworker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgworker;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtfullname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Button btnaddworker;
        private System.Windows.Forms.Button btndeletworker;
        private System.Windows.Forms.Button btneditworker;
        private System.Windows.Forms.Label lblerror;
    }
}