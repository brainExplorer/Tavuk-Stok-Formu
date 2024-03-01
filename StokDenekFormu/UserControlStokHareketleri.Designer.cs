namespace StokDenekFormu
{
    partial class UserControlStokHareketleri
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lbMiktarazalmasi = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnDüzenle = new System.Windows.Forms.Button();
            this.pnlStokHareketleri = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbHareketTuru = new System.Windows.Forms.TextBox();
            this.dtpHareketTarihi = new System.Windows.Forms.DateTimePicker();
            this.tbMiktar = new System.Windows.Forms.TextBox();
            this.cbTedarikciID = new System.Windows.Forms.ComboBox();
            this.cbDepoID = new System.Windows.Forms.ComboBox();
            this.cbUrunID = new System.Windows.Forms.ComboBox();
            this.cbHareketID = new System.Windows.Forms.ComboBox();
            this.dgvStokHareketleri = new System.Windows.Forms.DataGridView();
            this.lbDateTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlStokHareketleri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStokHareketleri)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FloralWhite;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.pnlStokHareketleri);
            this.panel1.Controls.Add(this.dgvStokHareketleri);
            this.panel1.Location = new System.Drawing.Point(0, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(995, 740);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.listBox1);
            this.panel2.Controls.Add(this.lbMiktarazalmasi);
            this.panel2.Location = new System.Drawing.Point(3, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(528, 332);
            this.panel2.TabIndex = 3;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(3, 51);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(517, 276);
            this.listBox1.TabIndex = 1;
            // 
            // lbMiktarazalmasi
            // 
            this.lbMiktarazalmasi.AutoSize = true;
            this.lbMiktarazalmasi.BackColor = System.Drawing.Color.Linen;
            this.lbMiktarazalmasi.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbMiktarazalmasi.Location = new System.Drawing.Point(98, 12);
            this.lbMiktarazalmasi.Name = "lbMiktarazalmasi";
            this.lbMiktarazalmasi.Size = new System.Drawing.Size(278, 24);
            this.lbMiktarazalmasi.TabIndex = 0;
            this.lbMiktarazalmasi.Text = "Miktarı Azalmakta Olan Ürünler";
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(455, 53);
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
            this.btnSil.Location = new System.Drawing.Point(157, 3);
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
            this.btnDüzenle.Location = new System.Drawing.Point(302, 3);
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
            this.pnlStokHareketleri.Controls.Add(this.label7);
            this.pnlStokHareketleri.Controls.Add(this.label5);
            this.pnlStokHareketleri.Controls.Add(this.label6);
            this.pnlStokHareketleri.Controls.Add(this.label3);
            this.pnlStokHareketleri.Controls.Add(this.label4);
            this.pnlStokHareketleri.Controls.Add(this.label2);
            this.pnlStokHareketleri.Controls.Add(this.label1);
            this.pnlStokHareketleri.Controls.Add(this.tbHareketTuru);
            this.pnlStokHareketleri.Controls.Add(this.dtpHareketTarihi);
            this.pnlStokHareketleri.Controls.Add(this.tbMiktar);
            this.pnlStokHareketleri.Controls.Add(this.cbTedarikciID);
            this.pnlStokHareketleri.Controls.Add(this.cbDepoID);
            this.pnlStokHareketleri.Controls.Add(this.cbUrunID);
            this.pnlStokHareketleri.Controls.Add(this.cbHareketID);
            this.pnlStokHareketleri.Location = new System.Drawing.Point(537, 16);
            this.pnlStokHareketleri.Name = "pnlStokHareketleri";
            this.pnlStokHareketleri.Size = new System.Drawing.Size(455, 276);
            this.pnlStokHareketleri.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(29, 237);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 22);
            this.label7.TabIndex = 18;
            this.label7.Text = "Hareket Türü";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(29, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 22);
            this.label5.TabIndex = 17;
            this.label5.Text = "Miktar";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(29, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 22);
            this.label6.TabIndex = 16;
            this.label6.Text = "Hareket Tarihi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(29, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 22);
            this.label3.TabIndex = 15;
            this.label3.Text = "Tedarikçi ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(29, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 22);
            this.label4.TabIndex = 14;
            this.label4.Text = "Depo ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(29, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 22);
            this.label2.TabIndex = 13;
            this.label2.Text = "Ürün ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(29, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 22);
            this.label1.TabIndex = 12;
            this.label1.Text = "Hareket ID";
            // 
            // tbHareketTuru
            // 
            this.tbHareketTuru.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbHareketTuru.Location = new System.Drawing.Point(161, 236);
            this.tbHareketTuru.Name = "tbHareketTuru";
            this.tbHareketTuru.Size = new System.Drawing.Size(243, 29);
            this.tbHareketTuru.TabIndex = 11;
            // 
            // dtpHareketTarihi
            // 
            this.dtpHareketTarihi.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpHareketTarihi.Location = new System.Drawing.Point(161, 164);
            this.dtpHareketTarihi.Name = "dtpHareketTarihi";
            this.dtpHareketTarihi.Size = new System.Drawing.Size(243, 29);
            this.dtpHareketTarihi.TabIndex = 10;
            // 
            // tbMiktar
            // 
            this.tbMiktar.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbMiktar.Location = new System.Drawing.Point(161, 200);
            this.tbMiktar.Name = "tbMiktar";
            this.tbMiktar.Size = new System.Drawing.Size(243, 29);
            this.tbMiktar.TabIndex = 9;
            // 
            // cbTedarikciID
            // 
            this.cbTedarikciID.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbTedarikciID.FormattingEnabled = true;
            this.cbTedarikciID.Location = new System.Drawing.Point(161, 126);
            this.cbTedarikciID.Name = "cbTedarikciID";
            this.cbTedarikciID.Size = new System.Drawing.Size(243, 30);
            this.cbTedarikciID.TabIndex = 8;
            // 
            // cbDepoID
            // 
            this.cbDepoID.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbDepoID.FormattingEnabled = true;
            this.cbDepoID.Location = new System.Drawing.Point(161, 88);
            this.cbDepoID.Name = "cbDepoID";
            this.cbDepoID.Size = new System.Drawing.Size(243, 30);
            this.cbDepoID.TabIndex = 7;
            // 
            // cbUrunID
            // 
            this.cbUrunID.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbUrunID.FormattingEnabled = true;
            this.cbUrunID.Location = new System.Drawing.Point(161, 50);
            this.cbUrunID.Name = "cbUrunID";
            this.cbUrunID.Size = new System.Drawing.Size(243, 30);
            this.cbUrunID.TabIndex = 6;
            // 
            // cbHareketID
            // 
            this.cbHareketID.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbHareketID.FormattingEnabled = true;
            this.cbHareketID.Location = new System.Drawing.Point(161, 12);
            this.cbHareketID.Name = "cbHareketID";
            this.cbHareketID.Size = new System.Drawing.Size(243, 30);
            this.cbHareketID.TabIndex = 5;
            // 
            // dgvStokHareketleri
            // 
            this.dgvStokHareketleri.AllowUserToAddRows = false;
            this.dgvStokHareketleri.AllowUserToOrderColumns = true;
            this.dgvStokHareketleri.AllowUserToResizeRows = false;
            this.dgvStokHareketleri.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStokHareketleri.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvStokHareketleri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStokHareketleri.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvStokHareketleri.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvStokHareketleri.Location = new System.Drawing.Point(0, 357);
            this.dgvStokHareketleri.Name = "dgvStokHareketleri";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStokHareketleri.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvStokHareketleri.RowHeadersWidth = 51;
            this.dgvStokHareketleri.RowTemplate.Height = 24;
            this.dgvStokHareketleri.Size = new System.Drawing.Size(992, 382);
            this.dgvStokHareketleri.TabIndex = 0;
            this.dgvStokHareketleri.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvStokHareketleri_CellMouseClick);
            // 
            // lbDateTime
            // 
            this.lbDateTime.AutoSize = true;
            this.lbDateTime.Font = new System.Drawing.Font("Calibri", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbDateTime.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbDateTime.Location = new System.Drawing.Point(745, 8);
            this.lbDateTime.Name = "lbDateTime";
            this.lbDateTime.Size = new System.Drawing.Size(54, 27);
            this.lbDateTime.TabIndex = 2;
            this.lbDateTime.Text = "time";
            this.lbDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // UserControlStokHareketleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.Controls.Add(this.lbDateTime);
            this.Controls.Add(this.panel1);
            this.Name = "UserControlStokHareketleri";
            this.Size = new System.Drawing.Size(995, 780);
            this.Load += new System.EventHandler(this.UserControlStokHareketleri_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pnlStokHareketleri.ResumeLayout(false);
            this.pnlStokHareketleri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStokHareketleri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlStokHareketleri;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbHareketTuru;
        private System.Windows.Forms.DateTimePicker dtpHareketTarihi;
        private System.Windows.Forms.TextBox tbMiktar;
        private System.Windows.Forms.ComboBox cbTedarikciID;
        private System.Windows.Forms.ComboBox cbDepoID;
        private System.Windows.Forms.ComboBox cbUrunID;
        private System.Windows.Forms.ComboBox cbHareketID;
        private System.Windows.Forms.DataGridView dgvStokHareketleri;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnDüzenle;
        private System.Windows.Forms.Label lbDateTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lbMiktarazalmasi;
    }
}
