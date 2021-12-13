
namespace kurs_08122021_88_FormKontrolleriInceleme
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtIsim = new System.Windows.Forms.TextBox();
            this.TxtSoyisim = new System.Windows.Forms.TextBox();
            this.TxtEmailAdres = new System.Windows.Forms.TextBox();
            this.TxtTelefonNumara = new System.Windows.Forms.TextBox();
            this.BtnOnizleme = new System.Windows.Forms.Button();
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.BtnTemizle = new System.Windows.Forms.Button();
            this.LstMusteriler = new System.Windows.Forms.ListBox();
            this.OnIzlemeKayit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(109, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "İsim:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(89, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyisim:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(65, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email Adres:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(31, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefon Numarası: ";
            // 
            // TxtIsim
            // 
            this.TxtIsim.Location = new System.Drawing.Point(149, 49);
            this.TxtIsim.Name = "TxtIsim";
            this.TxtIsim.Size = new System.Drawing.Size(100, 20);
            this.TxtIsim.TabIndex = 4;
            // 
            // TxtSoyisim
            // 
            this.TxtSoyisim.Location = new System.Drawing.Point(149, 75);
            this.TxtSoyisim.Name = "TxtSoyisim";
            this.TxtSoyisim.Size = new System.Drawing.Size(100, 20);
            this.TxtSoyisim.TabIndex = 5;
            // 
            // TxtEmailAdres
            // 
            this.TxtEmailAdres.Location = new System.Drawing.Point(149, 101);
            this.TxtEmailAdres.Name = "TxtEmailAdres";
            this.TxtEmailAdres.Size = new System.Drawing.Size(100, 20);
            this.TxtEmailAdres.TabIndex = 6;
            // 
            // TxtTelefonNumara
            // 
            this.TxtTelefonNumara.Location = new System.Drawing.Point(149, 128);
            this.TxtTelefonNumara.Name = "TxtTelefonNumara";
            this.TxtTelefonNumara.Size = new System.Drawing.Size(100, 20);
            this.TxtTelefonNumara.TabIndex = 7;
            // 
            // BtnOnizleme
            // 
            this.BtnOnizleme.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOnizleme.Location = new System.Drawing.Point(34, 187);
            this.BtnOnizleme.Name = "BtnOnizleme";
            this.BtnOnizleme.Size = new System.Drawing.Size(96, 23);
            this.BtnOnizleme.TabIndex = 8;
            this.BtnOnizleme.Text = "Ön İzleme Yap";
            this.BtnOnizleme.UseVisualStyleBackColor = true;
            this.BtnOnizleme.Click += new System.EventHandler(this.BtnOnizleme_Click);
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnKaydet.Location = new System.Drawing.Point(149, 187);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(75, 23);
            this.BtnKaydet.TabIndex = 9;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.UseVisualStyleBackColor = true;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // BtnTemizle
            // 
            this.BtnTemizle.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTemizle.Location = new System.Drawing.Point(250, 187);
            this.BtnTemizle.Name = "BtnTemizle";
            this.BtnTemizle.Size = new System.Drawing.Size(75, 23);
            this.BtnTemizle.TabIndex = 10;
            this.BtnTemizle.Text = "Temizle";
            this.BtnTemizle.UseVisualStyleBackColor = true;
            this.BtnTemizle.Click += new System.EventHandler(this.BtnTemizle_Click);
            // 
            // LstMusteriler
            // 
            this.LstMusteriler.FormattingEnabled = true;
            this.LstMusteriler.Location = new System.Drawing.Point(360, 46);
            this.LstMusteriler.Name = "LstMusteriler";
            this.LstMusteriler.Size = new System.Drawing.Size(163, 160);
            this.LstMusteriler.TabIndex = 11;
            // 
            // OnIzlemeKayit
            // 
            this.OnIzlemeKayit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OnIzlemeKayit.Location = new System.Drawing.Point(34, 237);
            this.OnIzlemeKayit.Name = "OnIzlemeKayit";
            this.OnIzlemeKayit.Size = new System.Drawing.Size(164, 28);
            this.OnIzlemeKayit.TabIndex = 12;
            this.OnIzlemeKayit.Text = "Ön İzleme Kaydet";
            this.OnIzlemeKayit.UseVisualStyleBackColor = true;
            this.OnIzlemeKayit.Click += new System.EventHandler(this.OnIzlemeKayit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 304);
            this.Controls.Add(this.OnIzlemeKayit);
            this.Controls.Add(this.LstMusteriler);
            this.Controls.Add(this.BtnTemizle);
            this.Controls.Add(this.BtnKaydet);
            this.Controls.Add(this.BtnOnizleme);
            this.Controls.Add(this.TxtTelefonNumara);
            this.Controls.Add(this.TxtEmailAdres);
            this.Controls.Add(this.TxtSoyisim);
            this.Controls.Add(this.TxtIsim);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Müşteri Uygulaması";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtIsim;
        private System.Windows.Forms.TextBox TxtSoyisim;
        private System.Windows.Forms.TextBox TxtEmailAdres;
        private System.Windows.Forms.TextBox TxtTelefonNumara;
        private System.Windows.Forms.Button BtnOnizleme;
        private System.Windows.Forms.Button BtnKaydet;
        private System.Windows.Forms.Button BtnTemizle;
        private System.Windows.Forms.ListBox LstMusteriler;
        private System.Windows.Forms.Button OnIzlemeKayit;
    }
}

