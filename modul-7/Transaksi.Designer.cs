namespace modul_7
{
    partial class Transaksi
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Transaksi));
            this.tbNominal = new System.Windows.Forms.TextBox();
            this.lblNominal = new System.Windows.Forms.Label();
            this.lblKategori = new System.Windows.Forms.Label();
            this.lblCatatan = new System.Windows.Forms.Label();
            this.lblTanggal = new System.Windows.Forms.Label();
            this.lblSumber = new System.Windows.Forms.Label();
            this.cbKategori = new System.Windows.Forms.ComboBox();
            this.lblTransaksi = new System.Windows.Forms.Label();
            this.tbCatatan = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cbSumber = new System.Windows.Forms.ComboBox();
            this.btnTambah = new System.Windows.Forms.Button();
            this.btnBatal = new System.Windows.Forms.Button();
            this.cbJenis = new System.Windows.Forms.ComboBox();
            this.lblJenis = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTransaction = new System.Windows.Forms.Label();
            this.lblWallet = new System.Windows.Forms.Label();
            this.lblBudget = new System.Windows.Forms.Label();
            this.lblAnalysis = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.pbUserProfil = new System.Windows.Forms.PictureBox();
            this.lblLogout = new System.Windows.Forms.Label();
            this.lblUserProfile = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserProfil)).BeginInit();
            this.SuspendLayout();
            // 
            // tbNominal
            // 
            this.tbNominal.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbNominal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbNominal.Location = new System.Drawing.Point(345, 90);
            this.tbNominal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbNominal.Multiline = true;
            this.tbNominal.Name = "tbNominal";
            this.tbNominal.Size = new System.Drawing.Size(532, 23);
            this.tbNominal.TabIndex = 0;
            // 
            // lblNominal
            // 
            this.lblNominal.AutoSize = true;
            this.lblNominal.Font = new System.Drawing.Font("Mulish", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNominal.Location = new System.Drawing.Point(244, 90);
            this.lblNominal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNominal.Name = "lblNominal";
            this.lblNominal.Size = new System.Drawing.Size(76, 23);
            this.lblNominal.TabIndex = 1;
            this.lblNominal.Text = "Nominal";
            this.lblNominal.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblKategori
            // 
            this.lblKategori.AutoSize = true;
            this.lblKategori.Font = new System.Drawing.Font("Mulish", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKategori.Location = new System.Drawing.Point(244, 174);
            this.lblKategori.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKategori.Name = "lblKategori";
            this.lblKategori.Size = new System.Drawing.Size(76, 23);
            this.lblKategori.TabIndex = 2;
            this.lblKategori.Text = "Kategori";
            // 
            // lblCatatan
            // 
            this.lblCatatan.AutoSize = true;
            this.lblCatatan.Font = new System.Drawing.Font("Mulish", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCatatan.Location = new System.Drawing.Point(244, 216);
            this.lblCatatan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCatatan.Name = "lblCatatan";
            this.lblCatatan.Size = new System.Drawing.Size(74, 23);
            this.lblCatatan.TabIndex = 3;
            this.lblCatatan.Text = "Catatan";
            this.lblCatatan.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblTanggal
            // 
            this.lblTanggal.AutoSize = true;
            this.lblTanggal.Font = new System.Drawing.Font("Mulish", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTanggal.Location = new System.Drawing.Point(244, 309);
            this.lblTanggal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTanggal.Name = "lblTanggal";
            this.lblTanggal.Size = new System.Drawing.Size(73, 23);
            this.lblTanggal.TabIndex = 4;
            this.lblTanggal.Text = "Tanggal";
            // 
            // lblSumber
            // 
            this.lblSumber.AutoSize = true;
            this.lblSumber.Font = new System.Drawing.Font("Mulish", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSumber.Location = new System.Drawing.Point(244, 351);
            this.lblSumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSumber.Name = "lblSumber";
            this.lblSumber.Size = new System.Drawing.Size(71, 23);
            this.lblSumber.TabIndex = 5;
            this.lblSumber.Text = "Sumber";
            // 
            // cbKategori
            // 
            this.cbKategori.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbKategori.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbKategori.FormattingEnabled = true;
            this.cbKategori.Items.AddRange(new object[] {
            "Makanan & Minuman",
            "Belanja",
            "Transportasi",
            "Komunikasi",
            "Pendidikan",
            "Hiburan",
            "Perumahan",
            "Pajak",
            "Amal",
            "Lainnya"});
            this.cbKategori.Location = new System.Drawing.Point(345, 176);
            this.cbKategori.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbKategori.Name = "cbKategori";
            this.cbKategori.Size = new System.Drawing.Size(532, 24);
            this.cbKategori.TabIndex = 6;
            this.cbKategori.SelectedIndexChanged += new System.EventHandler(this.cbKategori_SelectedIndexChanged);
            // 
            // lblTransaksi
            // 
            this.lblTransaksi.AutoSize = true;
            this.lblTransaksi.Font = new System.Drawing.Font("Mulish", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransaksi.Location = new System.Drawing.Point(238, 28);
            this.lblTransaksi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTransaksi.Name = "lblTransaksi";
            this.lblTransaksi.Size = new System.Drawing.Size(256, 37);
            this.lblTransaksi.TabIndex = 9;
            this.lblTransaksi.Text = "Tambah Transaksi";
            this.lblTransaksi.Click += new System.EventHandler(this.lblWelcome_Click);
            // 
            // tbCatatan
            // 
            this.tbCatatan.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbCatatan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbCatatan.Font = new System.Drawing.Font("Mulish", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCatatan.Location = new System.Drawing.Point(345, 218);
            this.tbCatatan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbCatatan.MinimumSize = new System.Drawing.Size(4, 73);
            this.tbCatatan.Multiline = true;
            this.tbCatatan.Name = "tbCatatan";
            this.tbCatatan.Size = new System.Drawing.Size(532, 73);
            this.tbCatatan.TabIndex = 10;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(345, 311);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(209, 22);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // cbSumber
            // 
            this.cbSumber.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbSumber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbSumber.FormattingEnabled = true;
            this.cbSumber.Items.AddRange(new object[] {
            "Cash",
            "Bank",
            "Gopay",
            "Shopee",
            "Dana",
            "Lainnya"});
            this.cbSumber.Location = new System.Drawing.Point(345, 353);
            this.cbSumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbSumber.Name = "cbSumber";
            this.cbSumber.Size = new System.Drawing.Size(532, 24);
            this.cbSumber.TabIndex = 14;
            // 
            // btnTambah
            // 
            this.btnTambah.BackColor = System.Drawing.Color.Green;
            this.btnTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTambah.Font = new System.Drawing.Font("Mulish", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTambah.ForeColor = System.Drawing.Color.White;
            this.btnTambah.Location = new System.Drawing.Point(345, 417);
            this.btnTambah.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(164, 37);
            this.btnTambah.TabIndex = 15;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = false;
            // 
            // btnBatal
            // 
            this.btnBatal.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnBatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBatal.Font = new System.Drawing.Font("Mulish SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBatal.Location = new System.Drawing.Point(593, 417);
            this.btnBatal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(164, 37);
            this.btnBatal.TabIndex = 16;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = false;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // cbJenis
            // 
            this.cbJenis.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbJenis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbJenis.FormattingEnabled = true;
            this.cbJenis.Items.AddRange(new object[] {
            "Pemasukan",
            "Pengeluaran"});
            this.cbJenis.Location = new System.Drawing.Point(345, 134);
            this.cbJenis.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbJenis.Name = "cbJenis";
            this.cbJenis.Size = new System.Drawing.Size(532, 24);
            this.cbJenis.TabIndex = 18;
            // 
            // lblJenis
            // 
            this.lblJenis.AutoSize = true;
            this.lblJenis.Font = new System.Drawing.Font("Mulish", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJenis.Location = new System.Drawing.Point(244, 132);
            this.lblJenis.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblJenis.Name = "lblJenis";
            this.lblJenis.Size = new System.Drawing.Size(47, 23);
            this.lblJenis.TabIndex = 17;
            this.lblJenis.Text = "Jenis";
            this.lblJenis.Click += new System.EventHandler(this.lblJenis_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CalendarFont = new System.Drawing.Font("Mulish", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.CalendarForeColor = System.Drawing.Color.WhiteSmoke;
            this.dateTimePicker2.CalendarMonthBackground = System.Drawing.Color.WhiteSmoke;
            this.dateTimePicker2.Location = new System.Drawing.Point(345, 310);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(209, 22);
            this.dateTimePicker2.TabIndex = 13;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.ForestGreen;
            this.pictureBox1.Location = new System.Drawing.Point(-2, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(217, 519);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // lblTransaction
            // 
            this.lblTransaction.BackColor = System.Drawing.Color.DarkGreen;
            this.lblTransaction.Font = new System.Drawing.Font("Mulish", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransaction.ForeColor = System.Drawing.Color.White;
            this.lblTransaction.Image = ((System.Drawing.Image)(resources.GetObject("lblTransaction.Image")));
            this.lblTransaction.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTransaction.Location = new System.Drawing.Point(-2, 90);
            this.lblTransaction.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTransaction.Name = "lblTransaction";
            this.lblTransaction.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.lblTransaction.Size = new System.Drawing.Size(217, 55);
            this.lblTransaction.TabIndex = 20;
            this.lblTransaction.Text = "            Transaksi";
            this.lblTransaction.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblWallet
            // 
            this.lblWallet.BackColor = System.Drawing.Color.ForestGreen;
            this.lblWallet.Font = new System.Drawing.Font("Mulish", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWallet.ForeColor = System.Drawing.Color.White;
            this.lblWallet.Image = ((System.Drawing.Image)(resources.GetObject("lblWallet.Image")));
            this.lblWallet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblWallet.Location = new System.Drawing.Point(-2, 200);
            this.lblWallet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWallet.Name = "lblWallet";
            this.lblWallet.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.lblWallet.Size = new System.Drawing.Size(217, 55);
            this.lblWallet.TabIndex = 21;
            this.lblWallet.Text = "            Dompet";
            this.lblWallet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblBudget
            // 
            this.lblBudget.BackColor = System.Drawing.Color.ForestGreen;
            this.lblBudget.Font = new System.Drawing.Font("Mulish", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBudget.ForeColor = System.Drawing.Color.White;
            this.lblBudget.Image = ((System.Drawing.Image)(resources.GetObject("lblBudget.Image")));
            this.lblBudget.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblBudget.Location = new System.Drawing.Point(-2, 255);
            this.lblBudget.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBudget.Name = "lblBudget";
            this.lblBudget.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.lblBudget.Size = new System.Drawing.Size(217, 55);
            this.lblBudget.TabIndex = 22;
            this.lblBudget.Text = "            Anggaran";
            this.lblBudget.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblBudget.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblAnalysis
            // 
            this.lblAnalysis.BackColor = System.Drawing.Color.ForestGreen;
            this.lblAnalysis.Font = new System.Drawing.Font("Mulish", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnalysis.ForeColor = System.Drawing.Color.White;
            this.lblAnalysis.Image = ((System.Drawing.Image)(resources.GetObject("lblAnalysis.Image")));
            this.lblAnalysis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblAnalysis.Location = new System.Drawing.Point(-2, 310);
            this.lblAnalysis.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAnalysis.Name = "lblAnalysis";
            this.lblAnalysis.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.lblAnalysis.Size = new System.Drawing.Size(217, 55);
            this.lblAnalysis.TabIndex = 23;
            this.lblAnalysis.Text = "            Analisis";
            this.lblAnalysis.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCategory
            // 
            this.lblCategory.BackColor = System.Drawing.Color.ForestGreen;
            this.lblCategory.Font = new System.Drawing.Font("Mulish", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.ForeColor = System.Drawing.Color.White;
            this.lblCategory.Image = ((System.Drawing.Image)(resources.GetObject("lblCategory.Image")));
            this.lblCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCategory.Location = new System.Drawing.Point(-2, 145);
            this.lblCategory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.lblCategory.Size = new System.Drawing.Size(217, 55);
            this.lblCategory.TabIndex = 24;
            this.lblCategory.Text = "            Kategori";
            this.lblCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pbUserProfil
            // 
            this.pbUserProfil.Image = ((System.Drawing.Image)(resources.GetObject("pbUserProfil.Image")));
            this.pbUserProfil.Location = new System.Drawing.Point(12, 15);
            this.pbUserProfil.Name = "pbUserProfil";
            this.pbUserProfil.Size = new System.Drawing.Size(50, 50);
            this.pbUserProfil.TabIndex = 25;
            this.pbUserProfil.TabStop = false;
            // 
            // lblLogout
            // 
            this.lblLogout.AutoSize = true;
            this.lblLogout.BackColor = System.Drawing.Color.ForestGreen;
            this.lblLogout.Font = new System.Drawing.Font("Mulish SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogout.ForeColor = System.Drawing.Color.White;
            this.lblLogout.Location = new System.Drawing.Point(22, 467);
            this.lblLogout.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLogout.Name = "lblLogout";
            this.lblLogout.Size = new System.Drawing.Size(65, 23);
            this.lblLogout.TabIndex = 26;
            this.lblLogout.Text = "Logout";
            // 
            // lblUserProfile
            // 
            this.lblUserProfile.AutoSize = true;
            this.lblUserProfile.BackColor = System.Drawing.Color.ForestGreen;
            this.lblUserProfile.Font = new System.Drawing.Font("Mulish SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserProfile.ForeColor = System.Drawing.Color.White;
            this.lblUserProfile.Location = new System.Drawing.Point(79, 28);
            this.lblUserProfile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserProfile.Name = "lblUserProfile";
            this.lblUserProfile.Size = new System.Drawing.Size(100, 23);
            this.lblUserProfile.TabIndex = 27;
            this.lblUserProfile.Text = "User Profile";
            // 
            // Transaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(915, 508);
            this.Controls.Add(this.lblUserProfile);
            this.Controls.Add(this.lblLogout);
            this.Controls.Add(this.pbUserProfil);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lblAnalysis);
            this.Controls.Add(this.lblBudget);
            this.Controls.Add(this.lblWallet);
            this.Controls.Add(this.lblTransaction);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cbJenis);
            this.Controls.Add(this.lblJenis);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.cbSumber);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.tbCatatan);
            this.Controls.Add(this.lblTransaksi);
            this.Controls.Add(this.cbKategori);
            this.Controls.Add(this.lblSumber);
            this.Controls.Add(this.lblTanggal);
            this.Controls.Add(this.lblCatatan);
            this.Controls.Add(this.lblKategori);
            this.Controls.Add(this.lblNominal);
            this.Controls.Add(this.tbNominal);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Transaksi";
            this.Text = "Transaksi";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserProfil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNominal;
        private System.Windows.Forms.Label lblNominal;
        private System.Windows.Forms.Label lblKategori;
        private System.Windows.Forms.Label lblCatatan;
        private System.Windows.Forms.Label lblTanggal;
        private System.Windows.Forms.Label lblSumber;
        private System.Windows.Forms.ComboBox cbKategori;
        private System.Windows.Forms.Label lblTransaksi;
        private System.Windows.Forms.TextBox tbCatatan;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cbSumber;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.ComboBox cbJenis;
        private System.Windows.Forms.Label lblJenis;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTransaction;
        private System.Windows.Forms.Label lblWallet;
        private System.Windows.Forms.Label lblBudget;
        private System.Windows.Forms.Label lblAnalysis;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.PictureBox pbUserProfil;
        private System.Windows.Forms.Label lblLogout;
        private System.Windows.Forms.Label lblUserProfile;
    }
}