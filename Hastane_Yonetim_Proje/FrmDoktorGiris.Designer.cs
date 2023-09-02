namespace Hastane_Yonetim_Proje
{
    partial class FrmDoktorGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDoktorGiris));
            this.label1 = new System.Windows.Forms.Label();
            this.btnDoktorGiris = new System.Windows.Forms.Button();
            this.txtDoktorGirisParola = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mskDoktorGirisTC = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(27, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 33);
            this.label1.TabIndex = 7;
            this.label1.Text = "Doktor Giriş Sayfası";
            // 
            // btnDoktorGiris
            // 
            this.btnDoktorGiris.BackColor = System.Drawing.Color.DarkGray;
            this.btnDoktorGiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoktorGiris.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDoktorGiris.Location = new System.Drawing.Point(103, 220);
            this.btnDoktorGiris.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnDoktorGiris.Name = "btnDoktorGiris";
            this.btnDoktorGiris.Size = new System.Drawing.Size(133, 33);
            this.btnDoktorGiris.TabIndex = 12;
            this.btnDoktorGiris.Text = "Giriş Yap";
            this.btnDoktorGiris.UseVisualStyleBackColor = false;
            this.btnDoktorGiris.Click += new System.EventHandler(this.btnDoktorGiris_Click_1);
            // 
            // txtDoktorGirisParola
            // 
            this.txtDoktorGirisParola.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDoktorGirisParola.Location = new System.Drawing.Point(162, 169);
            this.txtDoktorGirisParola.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.txtDoktorGirisParola.Name = "txtDoktorGirisParola";
            this.txtDoktorGirisParola.Size = new System.Drawing.Size(112, 27);
            this.txtDoktorGirisParola.TabIndex = 11;
            this.txtDoktorGirisParola.Text = "furkan";
            this.txtDoktorGirisParola.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(87, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "Parola:";
            // 
            // mskDoktorGirisTC
            // 
            this.mskDoktorGirisTC.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskDoktorGirisTC.Location = new System.Drawing.Point(162, 113);
            this.mskDoktorGirisTC.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.mskDoktorGirisTC.Mask = "00000000000";
            this.mskDoktorGirisTC.Name = "mskDoktorGirisTC";
            this.mskDoktorGirisTC.Size = new System.Drawing.Size(112, 27);
            this.mskDoktorGirisTC.TabIndex = 10;
            this.mskDoktorGirisTC.Text = "42727400084";
            this.mskDoktorGirisTC.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(29, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "TC Kimlik No:";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Gray;
            this.linkLabel1.Location = new System.Drawing.Point(12, 9);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(83, 20);
            this.linkLabel1.TabIndex = 13;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Geri Dön";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // FrmDoktorGiris
            // 
            this.AcceptButton = this.btnDoktorGiris;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.ClientSize = new System.Drawing.Size(339, 340);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDoktorGiris);
            this.Controls.Add(this.txtDoktorGirisParola);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mskDoktorGirisTC);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Candara Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmDoktorGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doktor Giriş Panel";
            this.Load += new System.EventHandler(this.FrmDoktorGiris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDoktorGiris;
        private System.Windows.Forms.TextBox txtDoktorGirisParola;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mskDoktorGirisTC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}