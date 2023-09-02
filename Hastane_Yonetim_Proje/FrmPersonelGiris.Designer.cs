namespace Hastane_Yonetim_Proje
{
    partial class FrmPersonelGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPersonelGiris));
            this.label2 = new System.Windows.Forms.Label();
            this.btnSekreterGiris = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.mskPersonelGirisTC = new System.Windows.Forms.MaskedTextBox();
            this.txtPersonelGirisSifre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(154, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "ŞİFRE:";
            // 
            // btnSekreterGiris
            // 
            this.btnSekreterGiris.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnSekreterGiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSekreterGiris.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSekreterGiris.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnSekreterGiris.Location = new System.Drawing.Point(186, 228);
            this.btnSekreterGiris.Name = "btnSekreterGiris";
            this.btnSekreterGiris.Size = new System.Drawing.Size(156, 42);
            this.btnSekreterGiris.TabIndex = 2;
            this.btnSekreterGiris.Text = "Giriş Yap";
            this.btnSekreterGiris.UseVisualStyleBackColor = false;
            this.btnSekreterGiris.Click += new System.EventHandler(this.btnSekreterGiris_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(151, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC NO:";
            // 
            // mskPersonelGirisTC
            // 
            this.mskPersonelGirisTC.BackColor = System.Drawing.Color.White;
            this.mskPersonelGirisTC.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskPersonelGirisTC.Location = new System.Drawing.Point(225, 119);
            this.mskPersonelGirisTC.Mask = "00000000000";
            this.mskPersonelGirisTC.Name = "mskPersonelGirisTC";
            this.mskPersonelGirisTC.Size = new System.Drawing.Size(135, 27);
            this.mskPersonelGirisTC.TabIndex = 3;
            this.mskPersonelGirisTC.Text = "00110011001";
            this.mskPersonelGirisTC.ValidatingType = typeof(int);
            // 
            // txtPersonelGirisSifre
            // 
            this.txtPersonelGirisSifre.BackColor = System.Drawing.Color.White;
            this.txtPersonelGirisSifre.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPersonelGirisSifre.Location = new System.Drawing.Point(225, 173);
            this.txtPersonelGirisSifre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPersonelGirisSifre.Name = "txtPersonelGirisSifre";
            this.txtPersonelGirisSifre.Size = new System.Drawing.Size(135, 27);
            this.txtPersonelGirisSifre.TabIndex = 4;
            this.txtPersonelGirisSifre.Text = "2100";
            this.txtPersonelGirisSifre.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Sitka Small", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(104, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(313, 40);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sekreter Giriş Sayfası";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.Maroon;
            this.linkLabel1.Location = new System.Drawing.Point(12, 9);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(82, 24);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Geri Dön";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // FrmPersonelGiris
            // 
            this.AcceptButton = this.btnSekreterGiris;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(486, 342);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPersonelGirisSifre);
            this.Controls.Add(this.mskPersonelGirisTC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSekreterGiris);
            this.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MaximizeBox = false;
            this.Name = "FrmPersonelGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel Giriş Panel";
            this.Load += new System.EventHandler(this.FrmPersonelGiris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSekreterGiris;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mskPersonelGirisTC;
        private System.Windows.Forms.TextBox txtPersonelGirisSifre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}