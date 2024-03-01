namespace StokDenekFormu
{
    partial class UserControlSettings
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tabControlAyarlar = new System.Windows.Forms.TabControl();
            this.tabPageKisisellestirme = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSelectColor = new System.Windows.Forms.Button();
            this.pnlShowSelectedColor = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnForecolor = new System.Windows.Forms.Button();
            this.pnlForecolor = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUygula = new System.Windows.Forms.Button();
            this.tabPageKullanicilar = new System.Windows.Forms.TabPage();
            this.tabPagePaylasim = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.tbKonu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbFullname = new System.Windows.Forms.TextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.tabControlAyarlar.SuspendLayout();
            this.tabPageKisisellestirme.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.pnlShowSelectedColor.SuspendLayout();
            this.pnlForecolor.SuspendLayout();
            this.tabPagePaylasim.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // tabControlAyarlar
            // 
            this.tabControlAyarlar.Controls.Add(this.tabPageKisisellestirme);
            this.tabControlAyarlar.Controls.Add(this.tabPageKullanicilar);
            this.tabControlAyarlar.Controls.Add(this.tabPagePaylasim);
            this.tabControlAyarlar.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabControlAyarlar.Location = new System.Drawing.Point(3, 3);
            this.tabControlAyarlar.Name = "tabControlAyarlar";
            this.tabControlAyarlar.SelectedIndex = 0;
            this.tabControlAyarlar.Size = new System.Drawing.Size(986, 773);
            this.tabControlAyarlar.TabIndex = 2;
            // 
            // tabPageKisisellestirme
            // 
            this.tabPageKisisellestirme.Controls.Add(this.flowLayoutPanel1);
            this.tabPageKisisellestirme.Location = new System.Drawing.Point(4, 30);
            this.tabPageKisisellestirme.Name = "tabPageKisisellestirme";
            this.tabPageKisisellestirme.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageKisisellestirme.Size = new System.Drawing.Size(978, 739);
            this.tabPageKisisellestirme.TabIndex = 2;
            this.tabPageKisisellestirme.Text = "Kişiselleştirme";
            this.tabPageKisisellestirme.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.Info;
            this.flowLayoutPanel1.Controls.Add(this.btnSelectColor);
            this.flowLayoutPanel1.Controls.Add(this.pnlShowSelectedColor);
            this.flowLayoutPanel1.Controls.Add(this.btnForecolor);
            this.flowLayoutPanel1.Controls.Add(this.pnlForecolor);
            this.flowLayoutPanel1.Controls.Add(this.btnUygula);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(6, 6);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(217, 366);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // btnSelectColor
            // 
            this.btnSelectColor.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnSelectColor.ForeColor = System.Drawing.Color.Azure;
            this.btnSelectColor.Location = new System.Drawing.Point(3, 3);
            this.btnSelectColor.Name = "btnSelectColor";
            this.btnSelectColor.Size = new System.Drawing.Size(211, 44);
            this.btnSelectColor.TabIndex = 2;
            this.btnSelectColor.Text = "Arkaplan Rengi";
            this.btnSelectColor.UseVisualStyleBackColor = false;
            this.btnSelectColor.Click += new System.EventHandler(this.btnSelectColor_Click);
            // 
            // pnlShowSelectedColor
            // 
            this.pnlShowSelectedColor.BackColor = System.Drawing.Color.Transparent;
            this.pnlShowSelectedColor.Controls.Add(this.label1);
            this.pnlShowSelectedColor.Location = new System.Drawing.Point(3, 53);
            this.pnlShowSelectedColor.Name = "pnlShowSelectedColor";
            this.pnlShowSelectedColor.Size = new System.Drawing.Size(211, 85);
            this.pnlShowSelectedColor.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(37, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 26);
            this.label1.TabIndex = 0;
            // 
            // btnForecolor
            // 
            this.btnForecolor.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnForecolor.ForeColor = System.Drawing.Color.Azure;
            this.btnForecolor.Location = new System.Drawing.Point(3, 144);
            this.btnForecolor.Name = "btnForecolor";
            this.btnForecolor.Size = new System.Drawing.Size(211, 44);
            this.btnForecolor.TabIndex = 4;
            this.btnForecolor.Text = "Yazı Rengi";
            this.btnForecolor.UseVisualStyleBackColor = false;
            this.btnForecolor.Click += new System.EventHandler(this.btnForecolor_Click);
            // 
            // pnlForecolor
            // 
            this.pnlForecolor.BackColor = System.Drawing.Color.Transparent;
            this.pnlForecolor.Controls.Add(this.label2);
            this.pnlForecolor.Location = new System.Drawing.Point(3, 194);
            this.pnlForecolor.Name = "pnlForecolor";
            this.pnlForecolor.Size = new System.Drawing.Size(211, 85);
            this.pnlForecolor.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(37, 42);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 26);
            this.label2.TabIndex = 0;
            // 
            // btnUygula
            // 
            this.btnUygula.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnUygula.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUygula.ForeColor = System.Drawing.Color.White;
            this.btnUygula.Location = new System.Drawing.Point(3, 285);
            this.btnUygula.Name = "btnUygula";
            this.btnUygula.Size = new System.Drawing.Size(211, 75);
            this.btnUygula.TabIndex = 6;
            this.btnUygula.Text = "UYGULA";
            this.btnUygula.UseVisualStyleBackColor = false;
            this.btnUygula.Click += new System.EventHandler(this.btnUygula_Click);
            // 
            // tabPageKullanicilar
            // 
            this.tabPageKullanicilar.Location = new System.Drawing.Point(4, 30);
            this.tabPageKullanicilar.Name = "tabPageKullanicilar";
            this.tabPageKullanicilar.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageKullanicilar.Size = new System.Drawing.Size(978, 739);
            this.tabPageKullanicilar.TabIndex = 0;
            this.tabPageKullanicilar.Text = "Kullanıcılar";
            this.tabPageKullanicilar.UseVisualStyleBackColor = true;
            // 
            // tabPagePaylasim
            // 
            this.tabPagePaylasim.Controls.Add(this.panel1);
            this.tabPagePaylasim.Location = new System.Drawing.Point(4, 30);
            this.tabPagePaylasim.Name = "tabPagePaylasim";
            this.tabPagePaylasim.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePaylasim.Size = new System.Drawing.Size(978, 739);
            this.tabPagePaylasim.TabIndex = 1;
            this.tabPagePaylasim.Text = "Paylaşım";
            this.tabPagePaylasim.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnKaydet);
            this.panel1.Controls.Add(this.tbKonu);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tbEmail);
            this.panel1.Controls.Add(this.tbFullname);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(423, 213);
            this.panel1.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 21);
            this.label6.TabIndex = 4;
            this.label6.Text = "Konu             :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ad Soyad      :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 21);
            this.label5.TabIndex = 3;
            this.label5.Text = "Email Adresi  :";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(171, 153);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(244, 52);
            this.btnKaydet.TabIndex = 2;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // tbKonu
            // 
            this.tbKonu.Location = new System.Drawing.Point(171, 119);
            this.tbKonu.Name = "tbKonu";
            this.tbKonu.Size = new System.Drawing.Size(244, 28);
            this.tbKonu.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(307, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Rapor Gönderim İçin Email Bilgi alanı";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(171, 85);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(244, 28);
            this.tbEmail.TabIndex = 1;
            // 
            // tbFullname
            // 
            this.tbFullname.Location = new System.Drawing.Point(171, 51);
            this.tbFullname.Name = "tbFullname";
            this.tbFullname.Size = new System.Drawing.Size(244, 28);
            this.tbFullname.TabIndex = 0;
            // 
            // UserControlSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.Controls.Add(this.tabControlAyarlar);
            this.Name = "UserControlSettings";
            this.Size = new System.Drawing.Size(992, 780);
            this.tabControlAyarlar.ResumeLayout(false);
            this.tabPageKisisellestirme.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.pnlShowSelectedColor.ResumeLayout(false);
            this.pnlShowSelectedColor.PerformLayout();
            this.pnlForecolor.ResumeLayout(false);
            this.pnlForecolor.PerformLayout();
            this.tabPagePaylasim.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TabControl tabControlAyarlar;
        private System.Windows.Forms.TabPage tabPageKullanicilar;
        private System.Windows.Forms.TabPage tabPagePaylasim;
        private System.Windows.Forms.TabPage tabPageKisisellestirme;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Panel pnlShowSelectedColor;
        private System.Windows.Forms.Button btnSelectColor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlForecolor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnForecolor;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnUygula;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.TextBox tbKonu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbFullname;
    }
}
