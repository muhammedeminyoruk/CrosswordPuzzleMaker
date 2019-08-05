namespace kare_bulmaca_winform
{
    partial class Aktivasyon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Aktivasyon));
            this.bilgi = new System.Windows.Forms.TextBox();
            this.denemeButon = new System.Windows.Forms.Button();
            this.kaydetButon = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.aktivasyonKodu = new System.Windows.Forms.MaskedTextBox();
            this.hataBilgisi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bilgi
            // 
            this.bilgi.BackColor = System.Drawing.SystemColors.Control;
            this.bilgi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bilgi.Enabled = false;
            this.bilgi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bilgi.Location = new System.Drawing.Point(57, 27);
            this.bilgi.Name = "bilgi";
            this.bilgi.ReadOnly = true;
            this.bilgi.Size = new System.Drawing.Size(300, 13);
            this.bilgi.TabIndex = 14;
            this.bilgi.TabStop = false;
            this.bilgi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // denemeButon
            // 
            this.denemeButon.Location = new System.Drawing.Point(306, 107);
            this.denemeButon.Name = "denemeButon";
            this.denemeButon.Size = new System.Drawing.Size(98, 23);
            this.denemeButon.TabIndex = 12;
            this.denemeButon.TabStop = false;
            this.denemeButon.Text = "Deneme Sürümü";
            this.denemeButon.UseVisualStyleBackColor = true;
            this.denemeButon.Click += new System.EventHandler(this.denemeButon_Click);
            // 
            // kaydetButon
            // 
            this.kaydetButon.Location = new System.Drawing.Point(306, 78);
            this.kaydetButon.Name = "kaydetButon";
            this.kaydetButon.Size = new System.Drawing.Size(98, 23);
            this.kaydetButon.TabIndex = 13;
            this.kaydetButon.TabStop = false;
            this.kaydetButon.Text = "Kaydet";
            this.kaydetButon.UseVisualStyleBackColor = true;
            this.kaydetButon.Click += new System.EventHandler(this.kaydetButon_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Aktivasyon Kodu : ";
            // 
            // aktivasyonKodu
            // 
            this.aktivasyonKodu.Location = new System.Drawing.Point(114, 78);
            this.aktivasyonKodu.Mask = ">LLLL-LLLL-LLLL-LLLL-LLLL";
            this.aktivasyonKodu.Name = "aktivasyonKodu";
            this.aktivasyonKodu.Size = new System.Drawing.Size(186, 20);
            this.aktivasyonKodu.TabIndex = 10;
            this.aktivasyonKodu.TabStop = false;
            this.aktivasyonKodu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // hataBilgisi
            // 
            this.hataBilgisi.BackColor = System.Drawing.SystemColors.Control;
            this.hataBilgisi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.hataBilgisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hataBilgisi.ForeColor = System.Drawing.Color.DarkRed;
            this.hataBilgisi.Location = new System.Drawing.Point(114, 112);
            this.hataBilgisi.Name = "hataBilgisi";
            this.hataBilgisi.ReadOnly = true;
            this.hataBilgisi.Size = new System.Drawing.Size(186, 13);
            this.hataBilgisi.TabIndex = 15;
            this.hataBilgisi.TabStop = false;
            this.hataBilgisi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Aktivasyon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 154);
            this.Controls.Add(this.hataBilgisi);
            this.Controls.Add(this.bilgi);
            this.Controls.Add(this.denemeButon);
            this.Controls.Add(this.kaydetButon);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.aktivasyonKodu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(432, 193);
            this.MinimumSize = new System.Drawing.Size(432, 193);
            this.Name = "Aktivasyon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tek Bulmaca Deneme Sürümü";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Aktivasyon_FormClosed);
            this.Load += new System.EventHandler(this.Aktivasyon_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox bilgi;
        private System.Windows.Forms.Button denemeButon;
        private System.Windows.Forms.Button kaydetButon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox aktivasyonKodu;
        private System.Windows.Forms.TextBox hataBilgisi;
    }
}