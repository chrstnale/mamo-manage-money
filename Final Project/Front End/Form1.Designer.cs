
namespace Front_End
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAnggaran = new System.Windows.Forms.Button();
            this.lblLogout = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnTransaksi = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.form_Anggaran1 = new Front_End.Form_Anggaran();
            this.form_Transaksi1 = new Front_End.Form_Transaksi();
            this.form_Home1 = new Front_End.Form_Home();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.ForestGreen;
            this.panel1.Controls.Add(this.pbLogo);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lblLogout);
            this.panel1.Controls.Add(this.lblUsername);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(259, 633);
            this.panel1.TabIndex = 0;
            // 
            // pbLogo
            // 
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(12, 3);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(59, 69);
            this.pbLogo.TabIndex = 6;
            this.pbLogo.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnAnggaran);
            this.panel2.Location = new System.Drawing.Point(12, 214);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(247, 53);
            this.panel2.TabIndex = 4;
            // 
            // btnAnggaran
            // 
            this.btnAnggaran.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAnggaran.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnggaran.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen;
            this.btnAnggaran.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnggaran.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAnggaran.ForeColor = System.Drawing.Color.White;
            this.btnAnggaran.Image = global::Front_End.Properties.Resources.pie_chart__2_;
            this.btnAnggaran.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnggaran.Location = new System.Drawing.Point(-9, -10);
            this.btnAnggaran.Name = "btnAnggaran";
            this.btnAnggaran.Size = new System.Drawing.Size(266, 70);
            this.btnAnggaran.TabIndex = 3;
            this.btnAnggaran.Text = "Anggaran";
            this.btnAnggaran.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAnggaran.UseVisualStyleBackColor = false;
            this.btnAnggaran.Click += new System.EventHandler(this.btnAnggaran_Click);
            // 
            // lblLogout
            // 
            this.lblLogout.AutoSize = true;
            this.lblLogout.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLogout.ForeColor = System.Drawing.Color.White;
            this.lblLogout.Location = new System.Drawing.Point(24, 583);
            this.lblLogout.Name = "lblLogout";
            this.lblLogout.Size = new System.Drawing.Size(69, 25);
            this.lblLogout.TabIndex = 5;
            this.lblLogout.Text = "Logout";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(69, 18);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(120, 41);
            this.lblUsername.TabIndex = 4;
            this.lblUsername.Text = "MAMO";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnTransaksi);
            this.panel4.Location = new System.Drawing.Point(12, 155);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(247, 53);
            this.panel4.TabIndex = 3;
            // 
            // btnTransaksi
            // 
            this.btnTransaksi.BackColor = System.Drawing.Color.ForestGreen;
            this.btnTransaksi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTransaksi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen;
            this.btnTransaksi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransaksi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTransaksi.ForeColor = System.Drawing.Color.White;
            this.btnTransaksi.Image = global::Front_End.Properties.Resources.transfer__2_;
            this.btnTransaksi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTransaksi.Location = new System.Drawing.Point(-9, -13);
            this.btnTransaksi.Name = "btnTransaksi";
            this.btnTransaksi.Size = new System.Drawing.Size(266, 78);
            this.btnTransaksi.TabIndex = 2;
            this.btnTransaksi.Text = "Transaksi";
            this.btnTransaksi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTransaksi.UseVisualStyleBackColor = false;
            this.btnTransaksi.Click += new System.EventHandler(this.btnTransaksi_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnHome);
            this.panel3.Location = new System.Drawing.Point(12, 96);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(247, 53);
            this.panel3.TabIndex = 2;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.ForestGreen;
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = global::Front_End.Properties.Resources.home;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(-9, -11);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(266, 67);
            this.btnHome.TabIndex = 4;
            this.btnHome.Text = "Home";
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // form_Anggaran1
            // 
            this.form_Anggaran1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.form_Anggaran1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.form_Anggaran1.Location = new System.Drawing.Point(259, 0);
            this.form_Anggaran1.Name = "form_Anggaran1";
            this.form_Anggaran1.Size = new System.Drawing.Size(1036, 633);
            this.form_Anggaran1.TabIndex = 1;
            // 
            // form_Transaksi1
            // 
            this.form_Transaksi1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.form_Transaksi1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.form_Transaksi1.Location = new System.Drawing.Point(259, 0);
            this.form_Transaksi1.Name = "form_Transaksi1";
            this.form_Transaksi1.Size = new System.Drawing.Size(1036, 633);
            this.form_Transaksi1.TabIndex = 2;
            // 
            // form_Home1
            // 
            this.form_Home1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.form_Home1.Location = new System.Drawing.Point(259, 0);
            this.form_Home1.Name = "form_Home1";
            this.form_Home1.Size = new System.Drawing.Size(1036, 633);
            this.form_Home1.TabIndex = 3;
            this.form_Home1.Load += new System.EventHandler(this.form_Home1_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1295, 633);
            this.Controls.Add(this.form_Home1);
            this.Controls.Add(this.form_Transaksi1);
            this.Controls.Add(this.form_Anggaran1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Mamo - Manage Money";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblLogout;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnAnggaran;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnTransaksi;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnHome;
        private Form_Anggaran form_Anggaran1;
        private Form_Transaksi form_Transaksi1;
        private System.Windows.Forms.PictureBox pbLogo;
        private Form_Home form_Home1;
    }
}

