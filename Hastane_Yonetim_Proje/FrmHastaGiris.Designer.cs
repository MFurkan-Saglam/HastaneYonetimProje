namespace Hastane_Yonetim_Proje
{
    partial class FrmHastaGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHastaGiris));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabelSignUp = new System.Windows.Forms.LinkLabel();
            this.btnGiris = new System.Windows.Forms.Button();
            this.HastaGiristxtSifre = new System.Windows.Forms.TextBox();
            this.hastagirisMaskedTC = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(428, 63);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hasta Giriş Paneli";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "TC Kimlik No:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(150, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Şifre:";
            // 
            // linkLabelSignUp
            // 
            this.linkLabelSignUp.AutoSize = true;
            this.linkLabelSignUp.BackColor = System.Drawing.Color.Gray;
            this.linkLabelSignUp.Font = new System.Drawing.Font("Bodoni MT Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelSignUp.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.linkLabelSignUp.Location = new System.Drawing.Point(287, 335);
            this.linkLabelSignUp.Name = "linkLabelSignUp";
            this.linkLabelSignUp.Size = new System.Drawing.Size(77, 19);
            this.linkLabelSignUp.TabIndex = 3;
            this.linkLabelSignUp.TabStop = true;
            this.linkLabelSignUp.Text = "Kayıt Ol";
            this.linkLabelSignUp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelSignUp_LinkClicked);
            // 
            // btnGiris
            // 
            this.btnGiris.BackColor = System.Drawing.Color.Silver;
            this.btnGiris.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnGiris.FlatAppearance.BorderSize = 3;
            this.btnGiris.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnGiris.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnGiris.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnGiris.Font = new System.Drawing.Font("Gabriola", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGiris.ForeColor = System.Drawing.Color.RosyBrown;
            this.btnGiris.Location = new System.Drawing.Point(258, 257);
            this.btnGiris.Margin = new System.Windows.Forms.Padding(10);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Padding = new System.Windows.Forms.Padding(5);
            this.btnGiris.Size = new System.Drawing.Size(135, 36);
            this.btnGiris.TabIndex = 3;
            this.btnGiris.Text = "Giriş Yap";
            this.btnGiris.UseVisualStyleBackColor = false;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // HastaGiristxtSifre
            // 
            this.HastaGiristxtSifre.Location = new System.Drawing.Point(258, 224);
            this.HastaGiristxtSifre.Name = "HastaGiristxtSifre";
            this.HastaGiristxtSifre.Size = new System.Drawing.Size(135, 20);
            this.HastaGiristxtSifre.TabIndex = 2;
            this.HastaGiristxtSifre.UseSystemPasswordChar = true;
            // 
            // hastagirisMaskedTC
            // 
            this.hastagirisMaskedTC.Location = new System.Drawing.Point(258, 184);
            this.hastagirisMaskedTC.Mask = "00000000000";
            this.hastagirisMaskedTC.Name = "hastagirisMaskedTC";
            this.hastagirisMaskedTC.Size = new System.Drawing.Size(135, 20);
            this.hastagirisMaskedTC.TabIndex = 1;
            this.hastagirisMaskedTC.ValidatingType = typeof(int);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Snow;
            this.label4.Location = new System.Drawing.Point(255, 303);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "----------veya----------";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Navy;
            this.linkLabel1.Location = new System.Drawing.Point(12, 20);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(97, 26);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Geri Dön";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // FrmHastaGiris
            // 
            this.AcceptButton = this.btnGiris;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(541, 397);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.hastagirisMaskedTC);
            this.Controls.Add(this.HastaGiristxtSifre);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.linkLabelSignUp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmHastaGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hasta Login Sayfası";
            this.Load += new System.EventHandler(this.FrmHastaGiris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLabelSignUp;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.TextBox HastaGiristxtSifre;
        private System.Windows.Forms.MaskedTextBox hastagirisMaskedTC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}