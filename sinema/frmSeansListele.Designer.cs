namespace sinema
{
    partial class frmSeansListele
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTarihListele = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnTumSeans = new System.Windows.Forms.Button();
            this.dataGridSeansGoster = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSeansGoster)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTarihListele
            // 
            this.lblTarihListele.AutoSize = true;
            this.lblTarihListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTarihListele.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTarihListele.Location = new System.Drawing.Point(558, 26);
            this.lblTarihListele.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTarihListele.Name = "lblTarihListele";
            this.lblTarihListele.Size = new System.Drawing.Size(111, 15);
            this.lblTarihListele.TabIndex = 1;
            this.lblTarihListele.Text = "Tarihe Göre Listele";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(688, 21);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(121, 20);
            this.dateTimePicker1.TabIndex = 2;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // btnTumSeans
            // 
            this.btnTumSeans.BackColor = System.Drawing.Color.LightBlue;
            this.btnTumSeans.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTumSeans.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTumSeans.ForeColor = System.Drawing.Color.IndianRed;
            this.btnTumSeans.Location = new System.Drawing.Point(668, 357);
            this.btnTumSeans.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnTumSeans.Name = "btnTumSeans";
            this.btnTumSeans.Size = new System.Drawing.Size(141, 35);
            this.btnTumSeans.TabIndex = 3;
            this.btnTumSeans.Text = "Tüm Seanslar";
            this.btnTumSeans.UseVisualStyleBackColor = false;
            this.btnTumSeans.Click += new System.EventHandler(this.btnTumSeans_Click);
            // 
            // dataGridSeansGoster
            // 
            this.dataGridSeansGoster.BackgroundColor = System.Drawing.Color.PaleTurquoise;
            this.dataGridSeansGoster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridSeansGoster.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridSeansGoster.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridSeansGoster.Location = new System.Drawing.Point(133, 52);
            this.dataGridSeansGoster.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridSeansGoster.Name = "dataGridSeansGoster";
            this.dataGridSeansGoster.Size = new System.Drawing.Size(676, 290);
            this.dataGridSeansGoster.TabIndex = 4;
            // 
            // frmSeansListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(933, 450);
            this.Controls.Add(this.dataGridSeansGoster);
            this.Controls.Add(this.btnTumSeans);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblTarihListele);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmSeansListele";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seans Listeleme Sayfası";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmSeansListele_FormClosed);
            this.Load += new System.EventHandler(this.frmSeansListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSeansGoster)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTarihListele;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnTumSeans;
        private System.Windows.Forms.DataGridView dataGridSeansGoster;
    }
}