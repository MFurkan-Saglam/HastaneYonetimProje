namespace Hastane_Yonetim_Proje
{
    partial class FrmDoktorPaneli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDoktorPaneli));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDoktorEkle = new System.Windows.Forms.Button();
            this.btnDoktorSil = new System.Windows.Forms.Button();
            this.btnDoktorGuncelle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtDoktorAd = new System.Windows.Forms.TextBox();
            this.txtDoktorSoyad = new System.Windows.Forms.TextBox();
            this.cmbDoktorBrans = new System.Windows.Forms.ComboBox();
            this.mskTC = new System.Windows.Forms.MaskedTextBox();
            this.txtParola = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ebrima", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(41, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "AD:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ebrima", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(11, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "SOYAD:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Ebrima", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "BRANŞ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Ebrima", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(44, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "TC:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Ebrima", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(23, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "SİFRE:";
            // 
            // btnDoktorEkle
            // 
            this.btnDoktorEkle.BackColor = System.Drawing.Color.Salmon;
            this.btnDoktorEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoktorEkle.Font = new System.Drawing.Font("Ebrima", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDoktorEkle.Location = new System.Drawing.Point(58, 163);
            this.btnDoktorEkle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDoktorEkle.Name = "btnDoktorEkle";
            this.btnDoktorEkle.Size = new System.Drawing.Size(121, 36);
            this.btnDoktorEkle.TabIndex = 5;
            this.btnDoktorEkle.Text = "EKLE";
            this.btnDoktorEkle.UseVisualStyleBackColor = false;
            this.btnDoktorEkle.Click += new System.EventHandler(this.btnDoktorEkle_Click);
            // 
            // btnDoktorSil
            // 
            this.btnDoktorSil.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnDoktorSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoktorSil.Font = new System.Drawing.Font("Ebrima", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDoktorSil.Location = new System.Drawing.Point(58, 203);
            this.btnDoktorSil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDoktorSil.Name = "btnDoktorSil";
            this.btnDoktorSil.Size = new System.Drawing.Size(121, 36);
            this.btnDoktorSil.TabIndex = 6;
            this.btnDoktorSil.Text = "SİL";
            this.btnDoktorSil.UseVisualStyleBackColor = false;
            this.btnDoktorSil.Click += new System.EventHandler(this.btnDoktorSil_Click);
            // 
            // btnDoktorGuncelle
            // 
            this.btnDoktorGuncelle.BackColor = System.Drawing.Color.Purple;
            this.btnDoktorGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoktorGuncelle.Font = new System.Drawing.Font("Ebrima", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDoktorGuncelle.Location = new System.Drawing.Point(58, 243);
            this.btnDoktorGuncelle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDoktorGuncelle.Name = "btnDoktorGuncelle";
            this.btnDoktorGuncelle.Size = new System.Drawing.Size(121, 35);
            this.btnDoktorGuncelle.TabIndex = 7;
            this.btnDoktorGuncelle.Text = "GÜNCELLE";
            this.btnDoktorGuncelle.UseVisualStyleBackColor = false;
            this.btnDoktorGuncelle.Click += new System.EventHandler(this.btnDoktorGuncelle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(217, -3);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(705, 318);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // txtDoktorAd
            // 
            this.txtDoktorAd.Font = new System.Drawing.Font("Ebrima", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDoktorAd.Location = new System.Drawing.Point(90, 4);
            this.txtDoktorAd.Name = "txtDoktorAd";
            this.txtDoktorAd.Size = new System.Drawing.Size(121, 28);
            this.txtDoktorAd.TabIndex = 9;
            // 
            // txtDoktorSoyad
            // 
            this.txtDoktorSoyad.Font = new System.Drawing.Font("Ebrima", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDoktorSoyad.Location = new System.Drawing.Point(90, 35);
            this.txtDoktorSoyad.Name = "txtDoktorSoyad";
            this.txtDoktorSoyad.Size = new System.Drawing.Size(121, 28);
            this.txtDoktorSoyad.TabIndex = 10;
            // 
            // cmbDoktorBrans
            // 
            this.cmbDoktorBrans.Font = new System.Drawing.Font("Ebrima", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbDoktorBrans.FormattingEnabled = true;
            this.cmbDoktorBrans.Location = new System.Drawing.Point(90, 69);
            this.cmbDoktorBrans.Name = "cmbDoktorBrans";
            this.cmbDoktorBrans.Size = new System.Drawing.Size(121, 28);
            this.cmbDoktorBrans.TabIndex = 11;
            // 
            // mskTC
            // 
            this.mskTC.Font = new System.Drawing.Font("Ebrima", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskTC.Location = new System.Drawing.Point(90, 99);
            this.mskTC.Mask = "00000000000";
            this.mskTC.Name = "mskTC";
            this.mskTC.Size = new System.Drawing.Size(121, 28);
            this.mskTC.TabIndex = 12;
            this.mskTC.ValidatingType = typeof(int);
            // 
            // txtParola
            // 
            this.txtParola.Font = new System.Drawing.Font("Ebrima", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtParola.Location = new System.Drawing.Point(90, 130);
            this.txtParola.Name = "txtParola";
            this.txtParola.Size = new System.Drawing.Size(121, 28);
            this.txtParola.TabIndex = 13;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.linkLabel1.Location = new System.Drawing.Point(73, 286);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(94, 17);
            this.linkLabel1.TabIndex = 14;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Sayfayı Yenile";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // FrmDoktorPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(923, 312);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.txtParola);
            this.Controls.Add(this.mskTC);
            this.Controls.Add(this.cmbDoktorBrans);
            this.Controls.Add(this.txtDoktorSoyad);
            this.Controls.Add(this.txtDoktorAd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnDoktorGuncelle);
            this.Controls.Add(this.btnDoktorSil);
            this.Controls.Add(this.btnDoktorEkle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmDoktorPaneli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doktor Paneli";
            this.Load += new System.EventHandler(this.FrmDoktorPaneli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDoktorEkle;
        private System.Windows.Forms.Button btnDoktorSil;
        private System.Windows.Forms.Button btnDoktorGuncelle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtDoktorAd;
        private System.Windows.Forms.TextBox txtDoktorSoyad;
        private System.Windows.Forms.ComboBox cmbDoktorBrans;
        private System.Windows.Forms.MaskedTextBox mskTC;
        private System.Windows.Forms.TextBox txtParola;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}