namespace Hastane_Yonetim_Proje
{
    partial class FrmHastaDetay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHastaDetay));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.lblTc = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lnkBilgiDuzen = new System.Windows.Forms.LinkLabel();
            this.btnRasndevuAl = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxDoktor = new System.Windows.Forms.ComboBox();
            this.comboBoxBrans = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridViewRandevuGecmis = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridViewAktifRandevu = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRandevuGecmis)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAktifRandevu)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblAdSoyad);
            this.groupBox1.Controls.Add(this.lblTc);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(229, 147);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hasta Bilgi";
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Location = new System.Drawing.Point(108, 71);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(101, 19);
            this.lblAdSoyad.TabIndex = 3;
            this.lblAdSoyad.Text = "Null Null Null";
            // 
            // lblTc
            // 
            this.lblTc.AutoSize = true;
            this.lblTc.Location = new System.Drawing.Point(108, 38);
            this.lblTc.Name = "lblTc";
            this.lblTc.Size = new System.Drawing.Size(108, 19);
            this.lblTc.TabIndex = 2;
            this.lblTc.Text = "00000000000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ad Soyad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtID);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lnkBilgiDuzen);
            this.groupBox2.Controls.Add(this.btnRasndevuAl);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.richTextBox1);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.comboBoxDoktor);
            this.groupBox2.Controls.Add(this.comboBoxBrans);
            this.groupBox2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(12, 156);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(229, 287);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hasta Randevu İşlemler";
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtID.Location = new System.Drawing.Point(73, 25);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(142, 26);
            this.txtID.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 19);
            this.label3.TabIndex = 10;
            this.label3.Text = "ID:";
            // 
            // lnkBilgiDuzen
            // 
            this.lnkBilgiDuzen.AutoSize = true;
            this.lnkBilgiDuzen.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lnkBilgiDuzen.Location = new System.Drawing.Point(2, 255);
            this.lnkBilgiDuzen.Name = "lnkBilgiDuzen";
            this.lnkBilgiDuzen.Size = new System.Drawing.Size(91, 14);
            this.lnkBilgiDuzen.TabIndex = 9;
            this.lnkBilgiDuzen.TabStop = true;
            this.lnkBilgiDuzen.Text = "Bilgileri Düzenle";
            this.lnkBilgiDuzen.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkBilgiDuzen_LinkClicked);
            // 
            // btnRasndevuAl
            // 
            this.btnRasndevuAl.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnRasndevuAl.Location = new System.Drawing.Point(99, 239);
            this.btnRasndevuAl.Name = "btnRasndevuAl";
            this.btnRasndevuAl.Size = new System.Drawing.Size(124, 42);
            this.btnRasndevuAl.TabIndex = 8;
            this.btnRasndevuAl.Text = "Randevu Al";
            this.btnRasndevuAl.UseVisualStyleBackColor = false;
            this.btnRasndevuAl.Click += new System.EventHandler(this.btnRasndevuAl_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 19);
            this.label7.TabIndex = 7;
            this.label7.Text = "Şikayet:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(73, 124);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(142, 96);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Doktor:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Branş:";
            // 
            // comboBoxDoktor
            // 
            this.comboBoxDoktor.FormattingEnabled = true;
            this.comboBoxDoktor.Location = new System.Drawing.Point(73, 91);
            this.comboBoxDoktor.Name = "comboBoxDoktor";
            this.comboBoxDoktor.Size = new System.Drawing.Size(142, 27);
            this.comboBoxDoktor.TabIndex = 1;
            this.comboBoxDoktor.SelectedIndexChanged += new System.EventHandler(this.comboBoxDoktor_SelectedIndexChanged);
            // 
            // comboBoxBrans
            // 
            this.comboBoxBrans.FormattingEnabled = true;
            this.comboBoxBrans.Location = new System.Drawing.Point(73, 58);
            this.comboBoxBrans.Name = "comboBoxBrans";
            this.comboBoxBrans.Size = new System.Drawing.Size(142, 27);
            this.comboBoxBrans.TabIndex = 0;
            this.comboBoxBrans.SelectedIndexChanged += new System.EventHandler(this.comboBoxBrans_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridViewRandevuGecmis);
            this.groupBox3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(241, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(774, 205);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Randevu Geçmişi";
            // 
            // dataGridViewRandevuGecmis
            // 
            this.dataGridViewRandevuGecmis.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewRandevuGecmis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRandevuGecmis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewRandevuGecmis.Location = new System.Drawing.Point(3, 22);
            this.dataGridViewRandevuGecmis.Name = "dataGridViewRandevuGecmis";
            this.dataGridViewRandevuGecmis.Size = new System.Drawing.Size(768, 180);
            this.dataGridViewRandevuGecmis.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridViewAktifRandevu);
            this.groupBox4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox4.Location = new System.Drawing.Point(241, 214);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(774, 229);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Aktif Randevular";
            // 
            // dataGridViewAktifRandevu
            // 
            this.dataGridViewAktifRandevu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAktifRandevu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAktifRandevu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewAktifRandevu.Location = new System.Drawing.Point(3, 22);
            this.dataGridViewAktifRandevu.Name = "dataGridViewAktifRandevu";
            this.dataGridViewAktifRandevu.Size = new System.Drawing.Size(768, 204);
            this.dataGridViewAktifRandevu.TabIndex = 1;
            this.dataGridViewAktifRandevu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAktifRandevu_CellClick);
            // 
            // FrmHastaDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1016, 455);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmHastaDetay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hasta Detayları";
            this.Load += new System.EventHandler(this.FrmHastaDetay_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRandevuGecmis)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAktifRandevu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.Label lblTc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRasndevuAl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxDoktor;
        private System.Windows.Forms.ComboBox comboBoxBrans;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridViewRandevuGecmis;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridViewAktifRandevu;
        private System.Windows.Forms.LinkLabel lnkBilgiDuzen;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label3;
    }
}