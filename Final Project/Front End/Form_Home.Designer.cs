
namespace Front_End
{
    partial class Form_Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Home));
            this.lblDataTrans = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDeskripsi = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDataTrans
            // 
            this.lblDataTrans.AutoSize = true;
            this.lblDataTrans.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDataTrans.Location = new System.Drawing.Point(27, 94);
            this.lblDataTrans.Name = "lblDataTrans";
            this.lblDataTrans.Size = new System.Drawing.Size(242, 41);
            this.lblDataTrans.TabIndex = 2;
            this.lblDataTrans.Text = "Selamat datang!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.ForestGreen;
            this.label1.Location = new System.Drawing.Point(19, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(554, 62);
            this.label1.TabIndex = 3;
            this.label1.Text = "MAMO: Manage Money";
            // 
            // lblDeskripsi
            // 
            this.lblDeskripsi.AutoSize = true;
            this.lblDeskripsi.BackColor = System.Drawing.Color.Transparent;
            this.lblDeskripsi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDeskripsi.Location = new System.Drawing.Point(28, 234);
            this.lblDeskripsi.Name = "lblDeskripsi";
            this.lblDeskripsi.Size = new System.Drawing.Size(745, 140);
            this.lblDeskripsi.TabIndex = 4;
            this.lblDeskripsi.Text = resources.GetString("lblDeskripsi.Text");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Front_End.Properties.Resources.Finance_app_Flatline;
            this.pictureBox1.Location = new System.Drawing.Point(572, 255);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(445, 381);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Form_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblDeskripsi);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDataTrans);
            this.Name = "Form_Home";
            this.Size = new System.Drawing.Size(1036, 635);
            this.Load += new System.EventHandler(this.Form_Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDataTrans;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDeskripsi;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
