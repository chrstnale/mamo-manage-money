
namespace Front_End
{
    partial class Form_Transaksi
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
            this.lblTransaksi = new System.Windows.Forms.Label();
            this.dgvTransaksi = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAddTrans = new System.Windows.Forms.Button();
            this.btnRefreshTrans = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransaksi)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTransaksi
            // 
            this.lblTransaksi.AutoSize = true;
            this.lblTransaksi.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTransaksi.Location = new System.Drawing.Point(29, 29);
            this.lblTransaksi.Name = "lblTransaksi";
            this.lblTransaksi.Size = new System.Drawing.Size(217, 41);
            this.lblTransaksi.TabIndex = 0;
            this.lblTransaksi.Text = "Data Transaksi";
            // 
            // dgvTransaksi
            // 
            this.dgvTransaksi.BackgroundColor = System.Drawing.Color.White;
            this.dgvTransaksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransaksi.Location = new System.Drawing.Point(29, 135);
            this.dgvTransaksi.Name = "dgvTransaksi";
            this.dgvTransaksi.RowHeadersWidth = 51;
            this.dgvTransaksi.RowTemplate.Height = 29;
            this.dgvTransaksi.Size = new System.Drawing.Size(1052, 529);
            this.dgvTransaksi.TabIndex = 1;
            this.dgvTransaksi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAddTrans);
            this.panel1.Location = new System.Drawing.Point(29, 86);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(129, 38);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnRefreshTrans);
            this.panel2.Location = new System.Drawing.Point(173, 86);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(129, 38);
            this.panel2.TabIndex = 3;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnAddTrans
            // 
            this.btnAddTrans.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAddTrans.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddTrans.ForeColor = System.Drawing.Color.White;
            this.btnAddTrans.Location = new System.Drawing.Point(-9, -15);
            this.btnAddTrans.Name = "btnAddTrans";
            this.btnAddTrans.Size = new System.Drawing.Size(147, 66);
            this.btnAddTrans.TabIndex = 4;
            this.btnAddTrans.Text = "Tambah";
            this.btnAddTrans.UseVisualStyleBackColor = false;
            // 
            // btnRefreshTrans
            // 
            this.btnRefreshTrans.BackColor = System.Drawing.Color.White;
            this.btnRefreshTrans.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRefreshTrans.ForeColor = System.Drawing.Color.DimGray;
            this.btnRefreshTrans.Location = new System.Drawing.Point(-9, -15);
            this.btnRefreshTrans.Name = "btnRefreshTrans";
            this.btnRefreshTrans.Size = new System.Drawing.Size(147, 66);
            this.btnRefreshTrans.TabIndex = 5;
            this.btnRefreshTrans.Text = "Refresh";
            this.btnRefreshTrans.UseVisualStyleBackColor = false;
            // 
            // Form_Transaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvTransaksi);
            this.Controls.Add(this.lblTransaksi);
            this.Name = "Form_Transaksi";
            this.Size = new System.Drawing.Size(1113, 692);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransaksi)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTransaksi;
        private System.Windows.Forms.DataGridView dgvTransaksi;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAddTrans;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnRefreshTrans;
    }
}
