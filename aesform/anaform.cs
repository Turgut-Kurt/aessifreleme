using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace aesform
{
    public partial class Anaform : Form
    {
        static string metin1;
        static string metin2;
        public Anaform()
        {
            InitializeComponent();
        }

        private void BtnSifrele_Click(object sender, EventArgs e)
        {
            if (Txtanahtar1.TextLength < 16 || Txtmetin1.TextLength < 16)// 
            {
                MessageBox.Show("Key veya Metin (text) alanına 16 karakter girilmelidir", "Hata Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                metin1 = Txtmetin1.Text;
                byte[] veri1 = Encoding.UTF8.GetBytes(metin1);
                string anahtar1 = Txtanahtar1.Text;
                byte[] key1 = StringToByte(anahtar1);
                byte[] enc = Sifrele(veri1, key1);
                Txtsonuc.Text = Convert.ToBase64String(enc);
            }
        }
        private void BtnSifrecoz_Click(object sender, EventArgs e)
        {
            if (Txtanahtar2.TextLength < 16)
            {
                MessageBox.Show("Key alanına 16 karakter girilmelidir", "Hata Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    metin2 = Txtmetin2.Text;
                    byte[] veri2 = Convert.FromBase64String(metin2);
                    string anahtar2 = Txtanahtar2.Text;
                    byte[] key2 = StringToByte(anahtar2);
                    byte[] dec = Sifrecoz(veri2, key2);
                    Txtsonuc2.Text = getString(dec);
                }
                catch (Exception)
                {
                    MessageBox.Show("Şifrelenmiş Metini yanlış Yanlış Girdiniz", "Hata Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        public static byte[] Sifrele(byte[] veri, byte[] anahtar)
        {
            if (String.IsNullOrEmpty(metin1))
            {
                MessageBox.Show("Metin Giriş Alanı Boş Bırakılamaz", "Hata Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return StringToByte("");
                //throw new ArgumentNullException("çözülmesi gereken metin alanı boş olamaz");
            }
            using (AesCryptoServiceProvider acsp = new AesCryptoServiceProvider())
            {
                acsp.Key = anahtar;
                acsp.Padding = PaddingMode.PKCS7;
                acsp.Mode = CipherMode.ECB;
                ICryptoTransform sifreleyici = acsp.CreateEncryptor();
                return sifreleyici.TransformFinalBlock(veri, 0, veri.Length);
            }
        }
        private static byte[] Sifrecoz(byte[] veri, byte[] anahtar)
        {
            if (String.IsNullOrEmpty(metin2))
            {
                MessageBox.Show("Metin Giriş Alanı Boş Bırakılamaz", "Hata Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return StringToByte("");
                //throw new ArgumentNullException("çözülmesi gereken metin alanı boş olamaz");
            }
            try
            {
                using (AesCryptoServiceProvider acsp = new AesCryptoServiceProvider())
                {
                    acsp.Key = anahtar;
                    acsp.Padding = PaddingMode.PKCS7;
                    acsp.Mode = CipherMode.ECB;
                    ICryptoTransform cozucu = acsp.CreateDecryptor();
                    try
                    {
                        return cozucu.TransformFinalBlock(veri, 0, veri.Length);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Lütfen Daha Önce Kullandığınız Anahtarı Kullanınız ", "Hata Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Şifrelenmiş Metini Yanlış Girdiniz", "Hata Penceresi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return StringToByte("");
        }
        private static string getString(byte[] b)
        {
            return Encoding.UTF8.GetString(b);
        }
        public static byte[] StringToByte(string deger)
        {
            UnicodeEncoding ByteConverter = new UnicodeEncoding();
            return ByteConverter.GetBytes(deger); //UnicodeEncoding.ASCII.GetBytes(deger); //
        }
        private void Txtanahtar1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Txtanahtar1.TextLength == 16)
            {
                e.Handled = true;
            }
        }
        private void Txtanahtar2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Txtanahtar2.TextLength == 16)
            {
                e.Handled = true;
            }
        }

        private void Txtmetin1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Txtmetin1.TextLength == 16)
            {
                e.Handled = true;
            }
        }
        

    }
}
