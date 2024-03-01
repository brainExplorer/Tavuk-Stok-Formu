namespace StokDenekFormu
{
    partial class UserControlWarehouse
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
            this.dgvDepolar = new System.Windows.Forms.DataGridView();
            this.tbDepoID = new System.Windows.Forms.TextBox();
            this.tbDepoAdı = new System.Windows.Forms.TextBox();
            this.tbDepoAdres = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnDüzenle = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepolar)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDepolar
            // 
            this.dgvDepolar.AllowUserToAddRows = false;
            this.dgvDepolar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDepolar.Location = new System.Drawing.Point(3, 249);
            this.dgvDepolar.Name = "dgvDepolar";
            this.dgvDepolar.RowHeadersWidth = 51;
            this.dgvDepolar.RowTemplate.Height = 24;
            this.dgvDepolar.Size = new System.Drawing.Size(989, 528);
            this.dgvDepolar.StandardTab = true;
            this.dgvDepolar.TabIndex = 0;
            this.dgvDepolar.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDepolar_CellMouseClick);
            // 
            // tbDepoID
            // 
            this.tbDepoID.BackColor = System.Drawing.Color.Snow;
            this.tbDepoID.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbDepoID.Location = new System.Drawing.Point(364, 32);
            this.tbDepoID.Name = "tbDepoID";
            this.tbDepoID.Size = new System.Drawing.Size(330, 28);
            this.tbDepoID.TabIndex = 1;
            // 
            // tbDepoAdı
            // 
            this.tbDepoAdı.BackColor = System.Drawing.Color.Snow;
            this.tbDepoAdı.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbDepoAdı.Location = new System.Drawing.Point(364, 80);
            this.tbDepoAdı.Name = "tbDepoAdı";
            this.tbDepoAdı.Size = new System.Drawing.Size(330, 28);
            this.tbDepoAdı.TabIndex = 2;
            // 
            // tbDepoAdres
            // 
            this.tbDepoAdres.BackColor = System.Drawing.Color.Snow;
            this.tbDepoAdres.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbDepoAdres.Location = new System.Drawing.Point(365, 132);
            this.tbDepoAdres.Name = "tbDepoAdres";
            this.tbDepoAdres.Size = new System.Drawing.Size(329, 28);
            this.tbDepoAdres.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(254, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Depo ID   :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(254, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Depo Adı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(255, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Adres      :";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.AliceBlue;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tableLayoutPanel1.Controls.Add(this.btnEkle, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnDüzenle, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnSil, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(251, 166);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(446, 53);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.CadetBlue;
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
            this.btnSil.BackColor = System.Drawing.Color.CadetBlue;
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
            this.btnDüzenle.BackColor = System.Drawing.Color.CadetBlue;
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Beige;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.tbDepoID);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tbDepoAdı);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tbDepoAdres);
            this.panel1.Location = new System.Drawing.Point(3, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(989, 228);
            this.panel1.TabIndex = 8;
            // 
            // UserControlWarehouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvDepolar);
            this.Name = "UserControlWarehouse";
            this.Size = new System.Drawing.Size(995, 780);
            this.Load += new System.EventHandler(this.UserControlWarehouse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepolar)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDepolar;
        private System.Windows.Forms.TextBox tbDepoID;
        private System.Windows.Forms.TextBox tbDepoAdı;
        private System.Windows.Forms.TextBox tbDepoAdres;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnDüzenle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Panel panel1;
    }
}
