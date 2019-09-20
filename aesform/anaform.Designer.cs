namespace aesform
{
    partial class Anaform
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
            this.Txtanahtar1 = new System.Windows.Forms.TextBox();
            this.Txtmetin1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Txtsonuc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Txtsonuc2 = new System.Windows.Forms.TextBox();
            this.BtnSifrecoz = new System.Windows.Forms.Button();
            this.Txtanahtar2 = new System.Windows.Forms.TextBox();
            this.Txtmetin2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnSifrele = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Txtanahtar1
            // 
            this.Txtanahtar1.Location = new System.Drawing.Point(215, 48);
            this.Txtanahtar1.Name = "Txtanahtar1";
            this.Txtanahtar1.Size = new System.Drawing.Size(204, 22);
            this.Txtanahtar1.TabIndex = 19;
            this.Txtanahtar1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtanahtar1_KeyPress);
            // 
            // Txtmetin1
            // 
            this.Txtmetin1.Location = new System.Drawing.Point(215, 108);
            this.Txtmetin1.Name = "Txtmetin1";
            this.Txtmetin1.Size = new System.Drawing.Size(204, 22);
            this.Txtmetin1.TabIndex = 20;
            this.Txtmetin1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtmetin1_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 17);
            this.label1.TabIndex = 32;
            this.label1.Text = "Şifrelenek Metini Giriniz ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 17);
            this.label2.TabIndex = 31;
            this.label2.Text = "Anahtarı Giriniz";
            // 
            // Txtsonuc
            // 
            this.Txtsonuc.Location = new System.Drawing.Point(215, 216);
            this.Txtsonuc.Multiline = true;
            this.Txtsonuc.Name = "Txtsonuc";
            this.Txtsonuc.Size = new System.Drawing.Size(204, 94);
            this.Txtsonuc.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(490, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 17);
            this.label4.TabIndex = 30;
            this.label4.Text = "Çözümlenmiş Metin";
            // 
            // Txtsonuc2
            // 
            this.Txtsonuc2.Location = new System.Drawing.Point(625, 216);
            this.Txtsonuc2.Multiline = true;
            this.Txtsonuc2.Name = "Txtsonuc2";
            this.Txtsonuc2.Size = new System.Drawing.Size(204, 94);
            this.Txtsonuc2.TabIndex = 26;
            // 
            // BtnSifrecoz
            // 
            this.BtnSifrecoz.Location = new System.Drawing.Point(670, 151);
            this.BtnSifrecoz.Name = "BtnSifrecoz";
            this.BtnSifrecoz.Size = new System.Drawing.Size(125, 41);
            this.BtnSifrecoz.TabIndex = 25;
            this.BtnSifrecoz.Text = "Decrypt";
            this.BtnSifrecoz.UseVisualStyleBackColor = true;
            this.BtnSifrecoz.Click += new System.EventHandler(this.BtnSifrecoz_Click);
            // 
            // Txtanahtar2
            // 
            this.Txtanahtar2.Location = new System.Drawing.Point(625, 43);
            this.Txtanahtar2.Name = "Txtanahtar2";
            this.Txtanahtar2.Size = new System.Drawing.Size(204, 22);
            this.Txtanahtar2.TabIndex = 23;
            this.Txtanahtar2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtanahtar2_KeyPress);
            // 
            // Txtmetin2
            // 
            this.Txtmetin2.Location = new System.Drawing.Point(625, 103);
            this.Txtmetin2.Name = "Txtmetin2";
            this.Txtmetin2.Size = new System.Drawing.Size(204, 22);
            this.Txtmetin2.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(464, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 17);
            this.label5.TabIndex = 29;
            this.label5.Text = "Şifrelenek Metini Giriniz ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(514, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 17);
            this.label6.TabIndex = 28;
            this.label6.Text = "Anahtarı Giriniz";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 17);
            this.label3.TabIndex = 27;
            this.label3.Text = "Şifrelenmiş Metin";
            // 
            // BtnSifrele
            // 
            this.BtnSifrele.Location = new System.Drawing.Point(260, 151);
            this.BtnSifrele.Name = "BtnSifrele";
            this.BtnSifrele.Size = new System.Drawing.Size(125, 41);
            this.BtnSifrele.TabIndex = 21;
            this.BtnSifrele.Text = "Encrypt";
            this.BtnSifrele.UseVisualStyleBackColor = true;
            this.BtnSifrele.Click += new System.EventHandler(this.BtnSifrele_Click);
            // 
            // Anaform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 353);
            this.Controls.Add(this.Txtanahtar1);
            this.Controls.Add(this.Txtmetin1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Txtsonuc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Txtsonuc2);
            this.Controls.Add(this.BtnSifrecoz);
            this.Controls.Add(this.Txtanahtar2);
            this.Controls.Add(this.Txtmetin2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnSifrele);
            this.Name = "Anaform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AES Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txtanahtar1;
        private System.Windows.Forms.TextBox Txtmetin1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txtsonuc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txtsonuc2;
        private System.Windows.Forms.Button BtnSifrecoz;
        private System.Windows.Forms.TextBox Txtanahtar2;
        private System.Windows.Forms.TextBox Txtmetin2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnSifrele;
    }
}

