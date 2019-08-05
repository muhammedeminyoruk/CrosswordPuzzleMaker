using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace kare_bulmaca_winform
{
    public partial class Aktivasyon : Form
    {
        public Aktivasyon()
        {
            InitializeComponent();
        }

        RegistryKey anahtar = Registry.CurrentUser;
        private void Aktivasyon_Load(object sender, EventArgs e)
        {
            anahtar = anahtar.CreateSubKey("Software\\TekBulmaca");

            if ((anahtar.GetValue("Aktif") != null))
            {
                CrosswordCreator.Form1 anaForm = new CrosswordCreator.Form1();
                anaForm.ShowDialog();
            }
            else
            {
                if (anahtar.GetValue("Sonkullanma") == null)
                {
                    bilgi.Text = "Deneme sürümünün bitmesine 20 gün kaldı.";
                    anahtar.SetValue("Sonkullanma", DateTime.Now.Date, RegistryValueKind.String);
                    anahtar.Flush();
                }
                else
                {
                    DateTime dt1 = Convert.ToDateTime(anahtar.GetValue("Sonkullanma"));
                    DateTime dt2 = Convert.ToDateTime(DateTime.Now.Date);

                    TimeSpan fark = dt2 - dt1;

                    int sonuc = Convert.ToInt32(fark.Days);


                    if (dt2 < dt1 || sonuc >= 20)
                    {
                        denemeButon.Enabled = false;
                        bilgi.Text = "Lütfen Aktivasyon işlemini gerçekleştiriniz.";
                        aktivasyonKodu.Focus();
                    }
                    else
                    {
                        bilgi.Text = "Deneme sürümünün bitmesine " + Convert.ToString(20 - sonuc) + " gün kaldı.";
                    }
                }

            }
        }

        private void kaydetButon_Click(object sender, EventArgs e)
        {
            if (aktivasyonKodu.Text == "ARFT-EVCK-TZLE-PLSC-MTKX")
            {
                anahtar.SetValue("Aktif", 3, RegistryValueKind.String);
                anahtar.Flush();
                Application.Restart();
            }
            else
            {
                hataBilgisi.ForeColor = Color.DarkRed;
                hataBilgisi.Text = "Girilen aktivasyon kodu geçersiz.";
            }
        }

        private void denemeButon_Click(object sender, EventArgs e)
        {
            CrosswordCreator.Form1 anaForm = new CrosswordCreator.Form1();
            this.Hide();
            anaForm.Show();
        }

        private void Aktivasyon_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
