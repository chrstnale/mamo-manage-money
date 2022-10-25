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
            this.SuspendLayout();
            // 
            // tbNominal
            // 
            this.tbNominal.Location = new System.Drawing.Point(173, 82);
            this.tbNominal.Name = "tbNominal";
            this.tbNominal.Size = new System.Drawing.Size(400, 20);
            this.tbNominal.TabIndex = 0;
            // 
            // lblNominal
            // 
            this.lblNominal.AutoSize = true;
            this.lblNominal.Location = new System.Drawing.Point(82, 82);
            this.lblNominal.Name = "lblNominal";
            this.lblNominal.Size = new System.Drawing.Size(45, 13);
            this.lblNominal.TabIndex = 1;
            this.lblNominal.Text = "Nominal";
            this.lblNominal.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblKategori
            // 
            this.lblKategori.AutoSize = true;
            this.lblKategori.Location = new System.Drawing.Point(80, 149);
            this.lblKategori.Name = "lblKategori";
            this.lblKategori.Size = new System.Drawing.Size(46, 13);
            this.lblKategori.TabIndex = 2;
            this.lblKategori.Text = "Kategori";
            // 
            // lblCatatan
            // 
            this.lblCatatan.AutoSize = true;
            this.lblCatatan.Location = new System.Drawing.Point(80, 184);
            this.lblCatatan.Name = "lblCatatan";
            this.lblCatatan.Size = new System.Drawing.Size(44, 13);
            this.lblCatatan.TabIndex = 3;
            this.lblCatatan.Text = "Catatan";
            this.lblCatatan.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblTanggal
            // 
            this.lblTanggal.AutoSize = true;
            this.lblTanggal.Location = new System.Drawing.Point(80, 256);
            this.lblTanggal.Name = "lblTanggal";
            this.lblTanggal.Size = new System.Drawing.Size(46, 13);
            this.lblTanggal.TabIndex = 4;
            this.lblTanggal.Text = "Tanggal";
            // 
            // lblSumber
            // 
            this.lblSumber.AutoSize = true;
            this.lblSumber.Location = new System.Drawing.Point(82, 300);
            this.lblSumber.Name = "lblSumber";
            this.lblSumber.Size = new System.Drawing.Size(43, 13);
            this.lblSumber.TabIndex = 5;
            this.lblSumber.Text = "Sumber";
            // 
            // cbKategori
            // 
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
            this.cbKategori.Location = new System.Drawing.Point(173, 149);
            this.cbKategori.Name = "cbKategori";
            this.cbKategori.Size = new System.Drawing.Size(400, 21);
            this.cbKategori.TabIndex = 6;
            this.cbKategori.SelectedIndexChanged += new System.EventHandler(this.cbKategori_SelectedIndexChanged);
            // 
            // lblTransaksi
            // 
            this.lblTransaksi.AutoSize = true;
            this.lblTransaksi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransaksi.Location = new System.Drawing.Point(247, 32);
            this.lblTransaksi.Name = "lblTransaksi";
            this.lblTransaksi.Size = new System.Drawing.Size(206, 25);
            this.lblTransaksi.TabIndex = 9;
            this.lblTransaksi.Text = "Tambah Transaksi";
            this.lblTransaksi.Click += new System.EventHandler(this.lblWelcome_Click);
            // 
            // tbCatatan
            // 
            this.tbCatatan.Location = new System.Drawing.Point(173, 184);
            this.tbCatatan.MinimumSize = new System.Drawing.Size(0, 60);
            this.tbCatatan.Multiline = true;
            this.tbCatatan.Name = "tbCatatan";
            this.tbCatatan.Size = new System.Drawing.Size(400, 60);
            this.tbCatatan.TabIndex = 10;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(173, 256);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(158, 20);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // cbSumber
            // 
            this.cbSumber.FormattingEnabled = true;
            this.cbSumber.Items.AddRange(new object[] {
            "Cash",
            "Bank",
            "Gopay",
            "Shopee",
            "Dana",
            "Lainnya"});
            this.cbSumber.Location = new System.Drawing.Point(173, 292);
            this.cbSumber.Name = "cbSumber";
            this.cbSumber.Size = new System.Drawing.Size(400, 21);
            this.cbSumber.TabIndex = 14;
            // 
            // btnTambah
            // 
            this.btnTambah.Location = new System.Drawing.Point(197, 339);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(75, 23);
            this.btnTambah.TabIndex = 15;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = true;
            // 
            // btnBatal
            // 
            this.btnBatal.Location = new System.Drawing.Point(412, 339);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(75, 23);
            this.btnBatal.TabIndex = 16;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = true;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // cbJenis
            // 
            this.cbJenis.FormattingEnabled = true;
            this.cbJenis.Items.AddRange(new object[] {
            "Pemasukan",
            "Pengeluaran"});
            this.cbJenis.Location = new System.Drawing.Point(173, 111);
            this.cbJenis.Name = "cbJenis";
            this.cbJenis.Size = new System.Drawing.Size(400, 21);
            this.cbJenis.TabIndex = 18;
            // 
            // lblJenis
            // 
            this.lblJenis.AutoSize = true;
            this.lblJenis.Location = new System.Drawing.Point(82, 114);
            this.lblJenis.Name = "lblJenis";
            this.lblJenis.Size = new System.Drawing.Size(31, 13);
            this.lblJenis.TabIndex = 17;
            this.lblJenis.Text = "Jenis";
            this.lblJenis.Click += new System.EventHandler(this.lblJenis_Click);
            // 
            // Transaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 413);
            this.Controls.Add(this.cbJenis);
            this.Controls.Add(this.lblJenis);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.cbSumber);
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
            this.Name = "Transaksi";
            this.Text = "Transaksi";
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
    }
}