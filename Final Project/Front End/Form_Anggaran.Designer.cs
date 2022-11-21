
namespace Front_End
{
    partial class Form_Anggaran
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnRefreshBudget = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddBudget = new System.Windows.Forms.Button();
            this.lblDataTrans = new System.Windows.Forms.Label();
            this.dgvBudget = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBudget)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnRefreshBudget);
            this.panel2.Location = new System.Drawing.Point(174, 72);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(138, 42);
            this.panel2.TabIndex = 7;
            // 
            // btnRefreshBudget
            // 
            this.btnRefreshBudget.BackColor = System.Drawing.Color.White;
            this.btnRefreshBudget.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefreshBudget.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRefreshBudget.ForeColor = System.Drawing.Color.DimGray;
            this.btnRefreshBudget.Location = new System.Drawing.Point(-12, -11);
            this.btnRefreshBudget.Name = "btnRefreshBudget";
            this.btnRefreshBudget.Size = new System.Drawing.Size(155, 59);
            this.btnRefreshBudget.TabIndex = 5;
            this.btnRefreshBudget.Text = "Refresh";
            this.btnRefreshBudget.UseVisualStyleBackColor = false;
            this.btnRefreshBudget.Click += new System.EventHandler(this.btnRefreshBudget_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAddBudget);
            this.panel1.Location = new System.Drawing.Point(18, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(145, 42);
            this.panel1.TabIndex = 6;
            // 
            // btnAddBudget
            // 
            this.btnAddBudget.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAddBudget.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddBudget.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddBudget.ForeColor = System.Drawing.Color.White;
            this.btnAddBudget.Location = new System.Drawing.Point(-15, -8);
            this.btnAddBudget.Name = "btnAddBudget";
            this.btnAddBudget.Size = new System.Drawing.Size(176, 59);
            this.btnAddBudget.TabIndex = 4;
            this.btnAddBudget.Text = "Tambah";
            this.btnAddBudget.UseVisualStyleBackColor = false;
            // 
            // lblDataTrans
            // 
            this.lblDataTrans.AutoSize = true;
            this.lblDataTrans.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDataTrans.Location = new System.Drawing.Point(18, 17);
            this.lblDataTrans.Name = "lblDataTrans";
            this.lblDataTrans.Size = new System.Drawing.Size(248, 41);
            this.lblDataTrans.TabIndex = 5;
            this.lblDataTrans.Text = "Daftar Anggaran";
            // 
            // dgvBudget
            // 
            this.dgvBudget.BackgroundColor = System.Drawing.Color.White;
            this.dgvBudget.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBudget.Location = new System.Drawing.Point(18, 129);
            this.dgvBudget.Name = "dgvBudget";
            this.dgvBudget.RowHeadersWidth = 51;
            this.dgvBudget.RowTemplate.Height = 29;
            this.dgvBudget.Size = new System.Drawing.Size(999, 486);
            this.dgvBudget.TabIndex = 4;
            // 
            // Form_Anggaran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblDataTrans);
            this.Controls.Add(this.dgvBudget);
            this.Name = "Form_Anggaran";
            this.Size = new System.Drawing.Size(1036, 635);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBudget)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnRefreshBudget;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAddBudget;
        private System.Windows.Forms.Label lblDataTrans;
        private System.Windows.Forms.DataGridView dgvBudget;
    }
}
