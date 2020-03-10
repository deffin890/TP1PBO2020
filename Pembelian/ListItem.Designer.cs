namespace Pembelian
{
    partial class ListItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblJudul = new System.Windows.Forms.Label();
            this.lblHarga = new System.Windows.Forms.Label();
            this.btnBeli = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblJudul
            // 
            this.lblJudul.AutoEllipsis = true;
            this.lblJudul.BackColor = System.Drawing.Color.Transparent;
            this.lblJudul.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblJudul.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJudul.ForeColor = System.Drawing.Color.Gray;
            this.lblJudul.Location = new System.Drawing.Point(180, 35);
            this.lblJudul.Name = "lblJudul";
            this.lblJudul.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblJudul.Size = new System.Drawing.Size(271, 32);
            this.lblJudul.TabIndex = 27;
            this.lblJudul.Text = "JUDUL";
            this.lblJudul.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblHarga
            // 
            this.lblHarga.AutoEllipsis = true;
            this.lblHarga.BackColor = System.Drawing.Color.Transparent;
            this.lblHarga.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblHarga.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHarga.ForeColor = System.Drawing.Color.Gray;
            this.lblHarga.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblHarga.Location = new System.Drawing.Point(180, 69);
            this.lblHarga.Name = "lblHarga";
            this.lblHarga.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblHarga.Size = new System.Drawing.Size(271, 30);
            this.lblHarga.TabIndex = 28;
            this.lblHarga.Text = "Harga";
            this.lblHarga.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnBeli
            // 
            this.btnBeli.AutoEllipsis = true;
            this.btnBeli.BackColor = System.Drawing.Color.Coral;
            this.btnBeli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBeli.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBeli.ForeColor = System.Drawing.Color.White;
            this.btnBeli.Location = new System.Drawing.Point(592, 51);
            this.btnBeli.Name = "btnBeli";
            this.btnBeli.Size = new System.Drawing.Size(125, 39);
            this.btnBeli.TabIndex = 34;
            this.btnBeli.Text = "B E L I";
            this.btnBeli.UseVisualStyleBackColor = false;
            this.btnBeli.Click += new System.EventHandler(this.btnBeli_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Coral;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(153, 159);
            this.panel1.TabIndex = 35;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(16, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 121);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // ListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnBeli);
            this.Controls.Add(this.lblHarga);
            this.Controls.Add(this.lblJudul);
            this.Name = "ListItem";
            this.Size = new System.Drawing.Size(753, 159);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblJudul;
        private System.Windows.Forms.Label lblHarga;
        private System.Windows.Forms.Button btnBeli;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
