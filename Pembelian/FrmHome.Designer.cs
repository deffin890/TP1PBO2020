namespace Pembelian
{
    partial class FrmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHome));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnKatalog = new System.Windows.Forms.Button();
            this.btnBeli = new System.Windows.Forms.Button();
            this.PnlUtama = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(370, 123);
            this.panel1.TabIndex = 29;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.Coral;
            this.txtName.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.txtName.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.White;
            this.txtName.Location = new System.Drawing.Point(19, 76);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(348, 32);
            this.txtName.TabIndex = 28;
            this.txtName.Text = "Selamat Datang Customer";
            this.txtName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Coral;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(102, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 54);
            this.label1.TabIndex = 27;
            this.label1.Text = "MIXER STORE";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Pembelian.Properties.Resources.icons8_mixer_logo_100;
            this.pictureBox1.Location = new System.Drawing.Point(8, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(88, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(100)))), ((int)(((byte)(66)))));
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Image = global::Pembelian.Properties.Resources.icons8_export_100;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLogout.Location = new System.Drawing.Point(790, 22);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(177, 121);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLogout.UseMnemonic = false;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.UseWaitCursor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnKatalog
            // 
            this.btnKatalog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKatalog.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnKatalog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(100)))), ((int)(((byte)(66)))));
            this.btnKatalog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKatalog.Font = new System.Drawing.Font("Segoe UI", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKatalog.ForeColor = System.Drawing.Color.White;
            this.btnKatalog.Image = global::Pembelian.Properties.Resources.icons8_bookmark_100;
            this.btnKatalog.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnKatalog.Location = new System.Drawing.Point(596, 22);
            this.btnKatalog.Name = "btnKatalog";
            this.btnKatalog.Size = new System.Drawing.Size(177, 121);
            this.btnKatalog.TabIndex = 5;
            this.btnKatalog.Text = "Menu Katalog";
            this.btnKatalog.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnKatalog.UseMnemonic = false;
            this.btnKatalog.UseVisualStyleBackColor = false;
            this.btnKatalog.UseWaitCursor = true;
            this.btnKatalog.Click += new System.EventHandler(this.btnKatalog_Click);
            // 
            // btnBeli
            // 
            this.btnBeli.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBeli.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBeli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(100)))), ((int)(((byte)(66)))));
            this.btnBeli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBeli.Font = new System.Drawing.Font("Segoe UI", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBeli.ForeColor = System.Drawing.Color.White;
            this.btnBeli.Image = global::Pembelian.Properties.Resources.icons8_buy_100;
            this.btnBeli.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBeli.Location = new System.Drawing.Point(400, 22);
            this.btnBeli.Name = "btnBeli";
            this.btnBeli.Size = new System.Drawing.Size(177, 121);
            this.btnBeli.TabIndex = 4;
            this.btnBeli.Text = "Menu Beli";
            this.btnBeli.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBeli.UseMnemonic = false;
            this.btnBeli.UseVisualStyleBackColor = false;
            this.btnBeli.UseWaitCursor = true;
            this.btnBeli.Click += new System.EventHandler(this.btnBeli_Click);
            // 
            // PnlUtama
            // 
            this.PnlUtama.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PnlUtama.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PnlUtama.BackColor = System.Drawing.Color.Coral;
            this.PnlUtama.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PnlUtama.BackgroundImage")));
            this.PnlUtama.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PnlUtama.Location = new System.Drawing.Point(-9, 168);
            this.PnlUtama.Name = "PnlUtama";
            this.PnlUtama.Size = new System.Drawing.Size(1003, 423);
            this.PnlUtama.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 591);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(988, 37);
            this.panel2.TabIndex = 30;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.OrangeRed;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(988, 37);
            this.label2.TabIndex = 29;
            this.label2.Text = "DEFFIN ACHMAD DIFA - 1800912";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(988, 628);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnKatalog);
            this.Controls.Add(this.btnBeli);
            this.Controls.Add(this.PnlUtama);
            this.Name = "FrmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnKatalog;
        private System.Windows.Forms.Button btnBeli;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel PnlUtama;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
    }
}