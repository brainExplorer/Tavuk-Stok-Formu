namespace StokDenekFormu
{
    partial class UserControlProduct
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbDateTime = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvCokSatanlar = new System.Windows.Forms.DataGridView();
            this.lbMiktarazalmasi = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnDüzenle = new System.Windows.Forms.Button();
            this.pnlStokHareketleri = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbUrunAdi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbBirim = new System.Windows.Forms.TextBox();
            this.tbUrunKodu = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSatisFiyati = new System.Windows.Forms.TextBox();
            this.tbAlisFiyati = new System.Windows.Forms.TextBox();
            this.dgvUrunler = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cbUrunID = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCokSatanlar)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlStokHareketleri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunler)).BeginInit();
            this.SuspendLayout();
            // 
            // lbDateTime
            // 
            this.lbDateTime.AutoSize = true;
            this.lbDateTime.Font = new System.Drawing.Font("Calibri", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbDateTime.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbDateTime.Location = new System.Drawing.Point(735, 2);
            this.lbDateTime.Name = "lbDateTime";
            this.lbDateTime.Size = new System.Drawing.Size(54, 27);
            this.lbDateTime.TabIndex = 4;
            this.lbDateTime.Text = "time";
            this.lbDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FloralWhite;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.pnlStokHareketleri);
            this.panel1.Controls.Add(this.dgvUrunler);
            this.panel1.Location = new System.Drawing.Point(3, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(986, 740);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dgvCokSatanlar);
            this.panel2.Controls.Add(this.lbMiktarazalmasi);
            this.panel2.Location = new System.Drawing.Point(3, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(528, 332);
            this.panel2.TabIndex = 3;
            // 
            // dgvCokSatanlar
            // 
            this.dgvCokSatanlar.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvCokSatanlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCokSatanlar.Location = new System.Drawing.Point(3, 60);
            this.dgvCokSatanlar.Name = "dgvCokSatanlar";
            this.dgvCokSatanlar.RowHeadersWidth = 51;
            this.dgvCokSatanlar.RowTemplate.Height = 24;
            this.dgvCokSatanlar.Size = new System.Drawing.Size(520, 267);
            this.dgvCokSatanlar.TabIndex = 1;
            // 
            // lbMiktarazalmasi
            // 
            this.lbMiktarazalmasi.AutoSize = true;
            this.lbMiktarazalmasi.BackColor = System.Drawing.Color.Linen;
            this.lbMiktarazalmasi.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbMiktarazalmasi.Location = new System.Drawing.Point(161, 14);
            this.lbMiktarazalmasi.Name = "lbMiktarazalmasi";
            this.lbMiktarazalmasi.Size = new System.Drawing.Size(163, 24);
            this.lbMiktarazalmasi.TabIndex = 0;
            this.lbMiktarazalmasi.Text = "Çok Satan Ürünler";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.AliceBlue;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tableLayoutPanel1.Controls.Add(this.btnEkle, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnSil, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnDüzenle, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(537, 298);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(446, 53);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnEkle.FlatAppearance.BorderColor = System.Drawing.Color.Cornsilk;
            this.btnEkle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnEkle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aquamarine;
            this.btnEkle.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Location = new System.Drawing.Point(3, 3);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(145, 47);
            this.btnEkle.TabIndex = 0;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnSil.FlatAppearance.BorderColor = System.Drawing.Color.Cornsilk;
            this.btnSil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnSil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aquamarine;
            this.btnSil.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(154, 3);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(136, 47);
            this.btnSil.TabIndex = 1;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnDüzenle
            // 
            this.btnDüzenle.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnDüzenle.FlatAppearance.BorderColor = System.Drawing.Color.Cornsilk;
            this.btnDüzenle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnDüzenle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aquamarine;
            this.btnDüzenle.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDüzenle.Location = new System.Drawing.Point(296, 3);
            this.btnDüzenle.Name = "btnDüzenle";
            this.btnDüzenle.Size = new System.Drawing.Size(147, 47);
            this.btnDüzenle.TabIndex = 2;
            this.btnDüzenle.Text = "DÜZENLE";
            this.btnDüzenle.UseVisualStyleBackColor = false;
            this.btnDüzenle.Click += new System.EventHandler(this.btnDüzenle_Click);
            // 
            // pnlStokHareketleri
            // 
            this.pnlStokHareketleri.BackColor = System.Drawing.Color.Cornsilk;
            this.pnlStokHareketleri.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlStokHareketleri.Controls.Add(this.cbUrunID);
            this.pnlStokHareketleri.Controls.Add(this.label6);
            this.pnlStokHareketleri.Controls.Add(this.label4);
            this.pnlStokHareketleri.Controls.Add(this.tbUrunAdi);
            this.pnlStokHareketleri.Controls.Add(this.label3);
            this.pnlStokHareketleri.Controls.Add(this.label1);
            this.pnlStokHareketleri.Controls.Add(this.tbBirim);
            this.pnlStokHareketleri.Controls.Add(this.tbUrunKodu);
            this.pnlStokHareketleri.Controls.Add(this.label7);
            this.pnlStokHareketleri.Controls.Add(this.label5);
            this.pnlStokHareketleri.Controls.Add(this.label2);
            this.pnlStokHareketleri.Controls.Add(this.tbSatisFiyati);
            this.pnlStokHareketleri.Controls.Add(this.tbAlisFiyati);
            this.pnlStokHareketleri.Location = new System.Drawing.Point(537, 16);
            this.pnlStokHareketleri.Name = "pnlStokHareketleri";
            this.pnlStokHareketleri.Size = new System.Drawing.Size(446, 276);
            this.pnlStokHareketleri.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Linen;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(157, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 24);
            this.label6.TabIndex = 25;
            this.label6.Text = "Ürün Bilgileri Giriş";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(38, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 22);
            this.label4.TabIndex = 24;
            this.label4.Text = "Ürün Adı";
            // 
            // tbUrunAdi
            // 
            this.tbUrunAdi.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbUrunAdi.Location = new System.Drawing.Point(161, 96);
            this.tbUrunAdi.Name = "tbUrunAdi";
            this.tbUrunAdi.Size = new System.Drawing.Size(243, 29);
            this.tbUrunAdi.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(38, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 22);
            this.label3.TabIndex = 22;
            this.label3.Text = "Ürün Kodu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(38, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 22);
            this.label1.TabIndex = 21;
            this.label1.Text = "Alış Fiyatı";
            // 
            // tbBirim
            // 
            this.tbBirim.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbBirim.Location = new System.Drawing.Point(161, 166);
            this.tbBirim.Name = "tbBirim";
            this.tbBirim.Size = new System.Drawing.Size(243, 29);
            this.tbBirim.TabIndex = 20;
            // 
            // tbUrunKodu
            // 
            this.tbUrunKodu.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbUrunKodu.Location = new System.Drawing.Point(161, 131);
            this.tbUrunKodu.Name = "tbUrunKodu";
            this.tbUrunKodu.Size = new System.Drawing.Size(243, 29);
            this.tbUrunKodu.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(38, 239);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 22);
            this.label7.TabIndex = 18;
            this.label7.Text = "Satış Fiyatı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(38, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 22);
            this.label5.TabIndex = 17;
            this.label5.Text = "Birim";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(38, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 22);
            this.label2.TabIndex = 13;
            this.label2.Text = "Ürün ID";
            // 
            // tbSatisFiyati
            // 
            this.tbSatisFiyati.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbSatisFiyati.Location = new System.Drawing.Point(161, 236);
            this.tbSatisFiyati.Name = "tbSatisFiyati";
            this.tbSatisFiyati.Size = new System.Drawing.Size(243, 29);
            this.tbSatisFiyati.TabIndex = 11;
            // 
            // tbAlisFiyati
            // 
            this.tbAlisFiyati.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbAlisFiyati.Location = new System.Drawing.Point(161, 201);
            this.tbAlisFiyati.Name = "tbAlisFiyati";
            this.tbAlisFiyati.Size = new System.Drawing.Size(243, 29);
            this.tbAlisFiyati.TabIndex = 9;
            // 
            // dgvUrunler
            // 
            this.dgvUrunler.AllowUserToAddRows = false;
            this.dgvUrunler.AllowUserToOrderColumns = true;
            this.dgvUrunler.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUrunler.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUrunler.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUrunler.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvUrunler.Location = new System.Drawing.Point(0, 357);
            this.dgvUrunler.Name = "dgvUrunler";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUrunler.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvUrunler.RowHeadersWidth = 51;
            this.dgvUrunler.RowTemplate.Height = 24;
            this.dgvUrunler.Size = new System.Drawing.Size(983, 382);
            this.dgvUrunler.TabIndex = 0;
            this.dgvUrunler.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvUrunler_CellMouseClick);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // cbUrunID
            // 
            this.cbUrunID.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbUrunID.Location = new System.Drawing.Point(161, 60);
            this.cbUrunID.Name = "cbUrunID";
            this.cbUrunID.Size = new System.Drawing.Size(243, 29);
            this.cbUrunID.TabIndex = 26;
            // 
            // UserControlProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.Controls.Add(this.lbDateTime);
            this.Controls.Add(this.panel1);
            this.Name = "UserControlProduct";
            this.Size = new System.Drawing.Size(995, 780);
            this.Load += new System.EventHandler(this.UserControlProduct_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCokSatanlar)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pnlStokHareketleri.ResumeLayout(false);
            this.pnlStokHareketleri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbDateTime;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbMiktarazalmasi;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnDüzenle;
        private System.Windows.Forms.Panel pnlStokHareketleri;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSatisFiyati;
        private System.Windows.Forms.TextBox tbAlisFiyati;
        private System.Windows.Forms.DataGridView dgvUrunler;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbUrunAdi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbBirim;
        private System.Windows.Forms.TextBox tbUrunKodu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView dgvCokSatanlar;
        private System.Windows.Forms.TextBox cbUrunID;
    }
}
