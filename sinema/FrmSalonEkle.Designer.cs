namespace sinema
{
    partial class frmSalonEkle
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
            this.lblSalonAdi = new System.Windows.Forms.Label();
            this.txtSalonAdi = new System.Windows.Forms.TextBox();
            this.btnSalonEkle = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // lblSalonAdi
            // 
            this.lblSalonAdi.AutoSize = true;
            this.lblSalonAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSalonAdi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSalonAdi.Location = new System.Drawing.Point(59, 78);
            this.lblSalonAdi.Name = "lblSalonAdi";
            this.lblSalonAdi.Size = new System.Drawing.Size(74, 16);
            this.lblSalonAdi.TabIndex = 0;
            this.lblSalonAdi.Text = "Salon Adı";
            // 
            // txtSalonAdi
            // 
            this.txtSalonAdi.Location = new System.Drawing.Point(153, 78);
            this.txtSalonAdi.Name = "txtSalonAdi";
            this.txtSalonAdi.Size = new System.Drawing.Size(129, 20);
            this.txtSalonAdi.TabIndex = 1;
            // 
            // btnSalonEkle
            // 
            this.btnSalonEkle.BackColor = System.Drawing.Color.LightBlue;
            this.btnSalonEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalonEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSalonEkle.ForeColor = System.Drawing.Color.IndianRed;
            this.btnSalonEkle.Location = new System.Drawing.Point(206, 104);
            this.btnSalonEkle.Name = "btnSalonEkle";
            this.btnSalonEkle.Size = new System.Drawing.Size(76, 36);
            this.btnSalonEkle.TabIndex = 2;
            this.btnSalonEkle.Text = "Ekle";
            this.btnSalonEkle.UseVisualStyleBackColor = false;
            this.btnSalonEkle.Click += new System.EventHandler(this.btnSalonEkle_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.ımageList1.ImageSize = new System.Drawing.Size(21, 21);
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // frmSalonEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(385, 259);
            this.Controls.Add(this.btnSalonEkle);
            this.Controls.Add(this.txtSalonAdi);
            this.Controls.Add(this.lblSalonAdi);
            this.Name = "frmSalonEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Salon Ekleme Sayfası";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSalonEkle_FormClosing);
            this.Load += new System.EventHandler(this.frmSalonEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSalonAdi;
        private System.Windows.Forms.TextBox txtSalonAdi;
        private System.Windows.Forms.Button btnSalonEkle;
        private System.Windows.Forms.ImageList ımageList1;
    }
}