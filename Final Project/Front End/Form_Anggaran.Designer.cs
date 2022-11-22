
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnEditBudget = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnDeleteBudget = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBudget)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
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
            this.btnAddBudget.Click += new System.EventHandler(this.btnAddBudget_Click);
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
            this.dgvBudget.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBudget_CellClick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnEditBudget);
            this.panel3.Location = new System.Drawing.Point(323, 72);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(138, 42);
            this.panel3.TabIndex = 8;
            // 
            // btnEditBudget
            // 
            this.btnEditBudget.BackColor = System.Drawing.Color.White;
            this.btnEditBudget.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditBudget.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEditBudget.ForeColor = System.Drawing.Color.DimGray;
            this.btnEditBudget.Location = new System.Drawing.Point(-12, -11);
            this.btnEditBudget.Name = "btnEditBudget";
            this.btnEditBudget.Size = new System.Drawing.Size(155, 59);
            this.btnEditBudget.TabIndex = 5;
            this.btnEditBudget.Text = "Edit";
            this.btnEditBudget.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnDeleteBudget);
            this.panel4.Location = new System.Drawing.Point(472, 72);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(138, 42);
            this.panel4.TabIndex = 9;
            // 
            // btnDeleteBudget
            // 
            this.btnDeleteBudget.BackColor = System.Drawing.Color.White;
            this.btnDeleteBudget.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteBudget.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteBudget.ForeColor = System.Drawing.Color.DimGray;
            this.btnDeleteBudget.Location = new System.Drawing.Point(-12, -11);
            this.btnDeleteBudget.Name = "btnDeleteBudget";
            this.btnDeleteBudget.Size = new System.Drawing.Size(155, 59);
            this.btnDeleteBudget.TabIndex = 5;
            this.btnDeleteBudget.Text = "Delete";
            this.btnDeleteBudget.UseVisualStyleBackColor = false;
            this.btnDeleteBudget.Click += new System.EventHandler(this.btnDeleteBudget_Click);
            // 
            // Form_Anggaran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblDataTrans);
            this.Controls.Add(this.dgvBudget);
            this.Name = "Form_Anggaran";
            this.Size = new System.Drawing.Size(1036, 635);
            this.Load += new System.EventHandler(this.Form_Anggaran_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBudget)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnEditBudget;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnDeleteBudget;
    }
}
