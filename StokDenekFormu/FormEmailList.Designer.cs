namespace StokDenekFormu
{
    partial class FormEmailList
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
            this.lvEmailListesi = new System.Windows.Forms.ListView();
            this.btnSec = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvEmailListesi
            // 
            this.lvEmailListesi.HideSelection = false;
            this.lvEmailListesi.Location = new System.Drawing.Point(12, 12);
            this.lvEmailListesi.Name = "lvEmailListesi";
            this.lvEmailListesi.Size = new System.Drawing.Size(386, 426);
            this.lvEmailListesi.TabIndex = 0;
            this.lvEmailListesi.UseCompatibleStateImageBehavior = false;
            this.lvEmailListesi.View = System.Windows.Forms.View.List;
            // 
            // btnSec
            // 
            this.btnSec.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSec.Location = new System.Drawing.Point(3, 444);
            this.btnSec.Name = "btnSec";
            this.btnSec.Size = new System.Drawing.Size(400, 51);
            this.btnSec.TabIndex = 1;
            this.btnSec.Text = "SEÇ";
            this.btnSec.UseVisualStyleBackColor = true;
            this.btnSec.Click += new System.EventHandler(this.btnSec_Click);
            // 
            // FormEmailList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 507);
            this.Controls.Add(this.btnSec);
            this.Controls.Add(this.lvEmailListesi);
            this.Name = "FormEmailList";
            this.Text = "FormEmailList";
            this.Load += new System.EventHandler(this.FormEmailList_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvEmailListesi;
        private System.Windows.Forms.Button btnSec;
    }
}