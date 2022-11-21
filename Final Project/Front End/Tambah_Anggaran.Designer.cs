
namespace Front_End
{
    partial class Tambah_Anggaran
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
            this.cbOpsiBudget = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnBatalTrans = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddTransBaru = new System.Windows.Forms.Button();
            this.cbKategoriBudget = new System.Windows.Forms.ComboBox();
            this.tbNominalBudget = new System.Windows.Forms.TextBox();
            this.lbJudulAddBudget = new System.Windows.Forms.Label();
            this.lbKategoriBudget = new System.Windows.Forms.Label();
            this.lbOpsiBudget = new System.Windows.Forms.Label();
            this.lbNominalBudget = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbOpsiBudget
            // 
            this.cbOpsiBudget.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOpsiBudget.FormattingEnabled = true;
            this.cbOpsiBudget.Items.AddRange(new object[] {
            "Mingguan",
            "Bulanan",
            "Tahunan"});
            this.cbOpsiBudget.Location = new System.Drawing.Point(130, 173);
            this.cbOpsiBudget.Name = "cbOpsiBudget";
            this.cbOpsiBudget.Size = new System.Drawing.Size(296, 28);
            this.cbOpsiBudget.TabIndex = 32;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnBatalTrans);
            this.panel2.Location = new System.Drawing.Point(233, 237);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(145, 42);
            this.panel2.TabIndex = 31;
            // 
            // btnBatalTrans
            // 
            this.btnBatalTrans.BackColor = System.Drawing.Color.White;
            this.btnBatalTrans.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBatalTrans.ForeColor = System.Drawing.Color.DimGray;
            this.btnBatalTrans.Location = new System.Drawing.Point(-15, -8);
            this.btnBatalTrans.Name = "btnBatalTrans";
            this.btnBatalTrans.Size = new System.Drawing.Size(176, 59);
            this.btnBatalTrans.TabIndex = 5;
            this.btnBatalTrans.Text = "Batal";
            this.btnBatalTrans.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAddTransBaru);
            this.panel1.Location = new System.Drawing.Point(73, 237);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(145, 42);
            this.panel1.TabIndex = 30;
            // 
            // btnAddTransBaru
            // 
            this.btnAddTransBaru.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAddTransBaru.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddTransBaru.ForeColor = System.Drawing.Color.White;
            this.btnAddTransBaru.Location = new System.Drawing.Point(-15, -8);
            this.btnAddTransBaru.Name = "btnAddTransBaru";
            this.btnAddTransBaru.Size = new System.Drawing.Size(176, 59);
            this.btnAddTransBaru.TabIndex = 4;
            this.btnAddTransBaru.Text = "Tambah";
            this.btnAddTransBaru.UseVisualStyleBackColor = false;
            this.btnAddTransBaru.Click += new System.EventHandler(this.btnAddTransBaru_Click);
            // 
            // cbKategoriBudget
            // 
            this.cbKategoriBudget.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKategoriBudget.FormattingEnabled = true;
            this.cbKategoriBudget.Items.AddRange(new object[] {
            "Amal",
            "Belanja",
            "Hiburan",
            "Komunikasi",
            "Makanan & Minuman",
            "Pajak",
            "Pendidikan",
            "Perumahan",
            "Transportasi"});
            this.cbKategoriBudget.Location = new System.Drawing.Point(130, 134);
            this.cbKategoriBudget.Name = "cbKategoriBudget";
            this.cbKategoriBudget.Size = new System.Drawing.Size(296, 28);
            this.cbKategoriBudget.TabIndex = 25;
            // 
            // tbNominalBudget
            // 
            this.tbNominalBudget.Location = new System.Drawing.Point(130, 90);
            this.tbNominalBudget.Name = "tbNominalBudget";
            this.tbNominalBudget.Size = new System.Drawing.Size(296, 27);
            this.tbNominalBudget.TabIndex = 23;
            // 
            // lbJudulAddBudget
            // 
            this.lbJudulAddBudget.AutoSize = true;
            this.lbJudulAddBudget.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbJudulAddBudget.Location = new System.Drawing.Point(97, 22);
            this.lbJudulAddBudget.Name = "lbJudulAddBudget";
            this.lbJudulAddBudget.Size = new System.Drawing.Size(250, 38);
            this.lbJudulAddBudget.TabIndex = 22;
            this.lbJudulAddBudget.Text = "Tambah Anggaran";
            // 
            // lbKategoriBudget
            // 
            this.lbKategoriBudget.AutoSize = true;
            this.lbKategoriBudget.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbKategoriBudget.Location = new System.Drawing.Point(24, 130);
            this.lbKategoriBudget.Name = "lbKategoriBudget";
            this.lbKategoriBudget.Size = new System.Drawing.Size(87, 28);
            this.lbKategoriBudget.TabIndex = 20;
            this.lbKategoriBudget.Text = "Kategori";
            // 
            // lbOpsiBudget
            // 
            this.lbOpsiBudget.AutoSize = true;
            this.lbOpsiBudget.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbOpsiBudget.Location = new System.Drawing.Point(24, 173);
            this.lbOpsiBudget.Name = "lbOpsiBudget";
            this.lbOpsiBudget.Size = new System.Drawing.Size(52, 28);
            this.lbOpsiBudget.TabIndex = 19;
            this.lbOpsiBudget.Text = "Opsi";
            // 
            // lbNominalBudget
            // 
            this.lbNominalBudget.AutoSize = true;
            this.lbNominalBudget.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbNominalBudget.Location = new System.Drawing.Point(24, 86);
            this.lbNominalBudget.Name = "lbNominalBudget";
            this.lbNominalBudget.Size = new System.Drawing.Size(87, 28);
            this.lbNominalBudget.TabIndex = 16;
            this.lbNominalBudget.Text = "Nominal";
            // 
            // Tambah_Anggaran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(442, 311);
            this.Controls.Add(this.cbOpsiBudget);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cbKategoriBudget);
            this.Controls.Add(this.tbNominalBudget);
            this.Controls.Add(this.lbJudulAddBudget);
            this.Controls.Add(this.lbKategoriBudget);
            this.Controls.Add(this.lbOpsiBudget);
            this.Controls.Add(this.lbNominalBudget);
            this.Name = "Tambah_Anggaran";
            this.Text = "Tambah Anggaran";
            this.Load += new System.EventHandler(this.Tambah_Anggaran_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnBatalTrans;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAddTransBaru;
        private System.Windows.Forms.ComboBox cbKategoriBudget;
        private System.Windows.Forms.TextBox tbNominalBudget;
        private System.Windows.Forms.Label lbJudulAddBudget;
        private System.Windows.Forms.Label lbKategoriBudget;
        private System.Windows.Forms.Label lbOpsiBudget;
        private System.Windows.Forms.Label lbNominalBudget;
        private System.Windows.Forms.ComboBox cbOpsiBudget;
    }
}