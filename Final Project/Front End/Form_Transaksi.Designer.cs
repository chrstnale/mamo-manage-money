
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
            this.dgvTransaction = new System.Windows.Forms.DataGridView();
            this.lblDataTrans = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddTrans = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnRefreshTrans = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransaction)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTransaction
            // 
            this.dgvTransaction.BackgroundColor = System.Drawing.Color.White;
            this.dgvTransaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransaction.Location = new System.Drawing.Point(18, 129);
            this.dgvTransaction.Name = "dgvTransaction";
            this.dgvTransaction.RowHeadersWidth = 51;
            this.dgvTransaction.RowTemplate.Height = 29;
            this.dgvTransaction.Size = new System.Drawing.Size(999, 486);
            this.dgvTransaction.TabIndex = 0;
            // 
            // lblDataTrans
            // 
            this.lblDataTrans.AutoSize = true;
            this.lblDataTrans.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDataTrans.Location = new System.Drawing.Point(18, 17);
            this.lblDataTrans.Name = "lblDataTrans";
            this.lblDataTrans.Size = new System.Drawing.Size(217, 41);
            this.lblDataTrans.TabIndex = 1;
            this.lblDataTrans.Text = "Data Transaksi";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAddTrans);
            this.panel1.Location = new System.Drawing.Point(18, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(145, 42);
            this.panel1.TabIndex = 2;
            // 
            // btnAddTrans
            // 
            this.btnAddTrans.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAddTrans.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddTrans.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddTrans.ForeColor = System.Drawing.Color.White;
            this.btnAddTrans.Location = new System.Drawing.Point(-15, -8);
            this.btnAddTrans.Name = "btnAddTrans";
            this.btnAddTrans.Size = new System.Drawing.Size(176, 59);
            this.btnAddTrans.TabIndex = 4;
            this.btnAddTrans.Text = "Tambah";
            this.btnAddTrans.UseVisualStyleBackColor = false;
            this.btnAddTrans.Click += new System.EventHandler(this.btnAddTrans_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnRefreshTrans);
            this.panel2.Location = new System.Drawing.Point(173, 72);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(140, 42);
            this.panel2.TabIndex = 3;
            // 
            // btnRefreshTrans
            // 
            this.btnRefreshTrans.BackColor = System.Drawing.Color.White;
            this.btnRefreshTrans.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefreshTrans.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRefreshTrans.ForeColor = System.Drawing.Color.DimGray;
            this.btnRefreshTrans.Location = new System.Drawing.Point(-21, -11);
            this.btnRefreshTrans.Name = "btnRefreshTrans";
            this.btnRefreshTrans.Size = new System.Drawing.Size(176, 59);
            this.btnRefreshTrans.TabIndex = 5;
            this.btnRefreshTrans.Text = "Refresh";
            this.btnRefreshTrans.UseVisualStyleBackColor = false;
            this.btnRefreshTrans.Click += new System.EventHandler(this.btnRefreshTrans_Click);
            // 
            // Form_Transaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblDataTrans);
            this.Controls.Add(this.dgvTransaction);
            this.Name = "Form_Transaksi";
            this.Size = new System.Drawing.Size(1113, 692);
            this.Load += new System.EventHandler(this.Form_Transaksi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransaction)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTransaction;
        private System.Windows.Forms.Label lblDataTrans;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAddTrans;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnRefreshTrans;
    }
}
