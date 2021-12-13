
namespace kurs_08122021_88_FormKontrolleriInceleme
{
    partial class FrmOnIzlemeKayit
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
            this.TxtTelefonNumara = new System.Windows.Forms.TextBox();
            this.TxtEmailAdres = new System.Windows.Forms.TextBox();
            this.TxtSoyisim = new System.Windows.Forms.TextBox();
            this.TxtIsim = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtTelefonNumara
            // 
            this.TxtTelefonNumara.Location = new System.Drawing.Point(318, 158);
            this.TxtTelefonNumara.Name = "TxtTelefonNumara";
            this.TxtTelefonNumara.Size = new System.Drawing.Size(100, 20);
            this.TxtTelefonNumara.TabIndex = 15;
            // 
            // TxtEmailAdres
            // 
            this.TxtEmailAdres.Location = new System.Drawing.Point(318, 131);
            this.TxtEmailAdres.Name = "TxtEmailAdres";
            this.TxtEmailAdres.Size = new System.Drawing.Size(100, 20);
            this.TxtEmailAdres.TabIndex = 14;
            // 
            // TxtSoyisim
            // 
            this.TxtSoyisim.Location = new System.Drawing.Point(318, 105);
            this.TxtSoyisim.Name = "TxtSoyisim";
            this.TxtSoyisim.Size = new System.Drawing.Size(100, 20);
            this.TxtSoyisim.TabIndex = 13;
            // 
            // TxtIsim
            // 
            this.TxtIsim.Location = new System.Drawing.Point(318, 79);
            this.TxtIsim.Name = "TxtIsim";
            this.TxtIsim.Size = new System.Drawing.Size(100, 20);
            this.TxtIsim.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(200, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Telefon Numarası: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(234, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Email Adres:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(258, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Soyisim:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(278, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "İsim:";
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnKaydet.Location = new System.Drawing.Point(318, 215);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(75, 23);
            this.BtnKaydet.TabIndex = 16;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.UseVisualStyleBackColor = true;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // FrmOnIzlemeKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnKaydet);
            this.Controls.Add(this.TxtTelefonNumara);
            this.Controls.Add(this.TxtEmailAdres);
            this.Controls.Add(this.TxtSoyisim);
            this.Controls.Add(this.TxtIsim);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmOnIzlemeKayit";
            this.Text = "Kayıt Önizleme Ekranı";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtTelefonNumara;
        private System.Windows.Forms.TextBox TxtEmailAdres;
        private System.Windows.Forms.TextBox TxtSoyisim;
        private System.Windows.Forms.TextBox TxtIsim;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnKaydet;
    }
}