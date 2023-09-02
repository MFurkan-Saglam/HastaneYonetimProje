namespace Hastane_Yonetim_Proje
{
    partial class FrmDoktorBilgiDuzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDoktorBilgiDuzenle));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDoktorBilgiAd = new System.Windows.Forms.TextBox();
            this.txtDoktorBilgiSoyad = new System.Windows.Forms.TextBox();
            this.txtDoktorBilgiSifre = new System.Windows.Forms.TextBox();
            this.maskedDoktorBilgiTC = new System.Windows.Forms.MaskedTextBox();
            this.btnDoktorBilgi = new System.Windows.Forms.Button();
            this.comboDoktorBilgiBrans = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "AD:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "SOYAD:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "TC NO:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "ŞİFRE:";
            // 
            // txtDoktorBilgiAd
            // 
            this.txtDoktorBilgiAd.Location = new System.Drawing.Point(101, 70);
            this.txtDoktorBilgiAd.Name = "txtDoktorBilgiAd";
            this.txtDoktorBilgiAd.Size = new System.Drawing.Size(128, 26);
            this.txtDoktorBilgiAd.TabIndex = 4;
            // 
            // txtDoktorBilgiSoyad
            // 
            this.txtDoktorBilgiSoyad.Location = new System.Drawing.Point(100, 106);
            this.txtDoktorBilgiSoyad.Name = "txtDoktorBilgiSoyad";
            this.txtDoktorBilgiSoyad.Size = new System.Drawing.Size(128, 26);
            this.txtDoktorBilgiSoyad.TabIndex = 5;
            // 
            // txtDoktorBilgiSifre
            // 
            this.txtDoktorBilgiSifre.Location = new System.Drawing.Point(100, 211);
            this.txtDoktorBilgiSifre.Name = "txtDoktorBilgiSifre";
            this.txtDoktorBilgiSifre.Size = new System.Drawing.Size(128, 26);
            this.txtDoktorBilgiSifre.TabIndex = 6;
            // 
            // maskedDoktorBilgiTC
            // 
            this.maskedDoktorBilgiTC.Location = new System.Drawing.Point(100, 140);
            this.maskedDoktorBilgiTC.Mask = "00000000000";
            this.maskedDoktorBilgiTC.Name = "maskedDoktorBilgiTC";
            this.maskedDoktorBilgiTC.Size = new System.Drawing.Size(128, 26);
            this.maskedDoktorBilgiTC.TabIndex = 7;
            this.maskedDoktorBilgiTC.ValidatingType = typeof(int);
            // 
            // btnDoktorBilgi
            // 
            this.btnDoktorBilgi.BackColor = System.Drawing.Color.Yellow;
            this.btnDoktorBilgi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoktorBilgi.Location = new System.Drawing.Point(101, 258);
            this.btnDoktorBilgi.Name = "btnDoktorBilgi";
            this.btnDoktorBilgi.Size = new System.Drawing.Size(128, 31);
            this.btnDoktorBilgi.TabIndex = 8;
            this.btnDoktorBilgi.Text = "Bilgi Güncelle";
            this.btnDoktorBilgi.UseVisualStyleBackColor = false;
            this.btnDoktorBilgi.Click += new System.EventHandler(this.btnDoktorBilgi_Click);
            // 
            // comboDoktorBilgiBrans
            // 
            this.comboDoktorBilgiBrans.FormattingEnabled = true;
            this.comboDoktorBilgiBrans.Location = new System.Drawing.Point(100, 175);
            this.comboDoktorBilgiBrans.Name = "comboDoktorBilgiBrans";
            this.comboDoktorBilgiBrans.Size = new System.Drawing.Size(129, 27);
            this.comboDoktorBilgiBrans.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "BRANŞ:";
            // 
            // FrmDoktorBilgiDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(302, 404);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboDoktorBilgiBrans);
            this.Controls.Add(this.btnDoktorBilgi);
            this.Controls.Add(this.maskedDoktorBilgiTC);
            this.Controls.Add(this.txtDoktorBilgiSifre);
            this.Controls.Add(this.txtDoktorBilgiSoyad);
            this.Controls.Add(this.txtDoktorBilgiAd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimizeBox = false;
            this.Name = "FrmDoktorBilgiDuzenle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doktor Bilgi Düzenleme";
            this.Load += new System.EventHandler(this.FrmDoktorBilgiDuzenle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDoktorBilgiAd;
        private System.Windows.Forms.TextBox txtDoktorBilgiSoyad;
        private System.Windows.Forms.TextBox txtDoktorBilgiSifre;
        private System.Windows.Forms.MaskedTextBox maskedDoktorBilgiTC;
        private System.Windows.Forms.Button btnDoktorBilgi;
        private System.Windows.Forms.ComboBox comboDoktorBilgiBrans;
        private System.Windows.Forms.Label label5;
    }
}