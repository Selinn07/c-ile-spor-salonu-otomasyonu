using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace projectForm
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }       

        private void DevamButton2_Click(object sender, EventArgs e)
        {
                      
                switch (GüntextBox.Text)    // Açılış: 08:00  kapanış:20.00
                {
                    case "pazartesi":
                        ListBox.Items.Add("Branş: Zumba  Saat: 09.00-15.00");
                        ListBox.Items.Add("Branş: Pilates  Saat: 14.00-18.00");
                        ListBox.Items.Add("Branş: Fitness  Saat: 10.00-19.00");
                        ListBox.Items.Add("Branş: Boks  Saat: 12.00-20.00");
                        break;
                    case "salı":
                        ListBox.Items.Add("Branş: Yüzme  Saat: 08.00-16.00");
                        ListBox.Items.Add("Branş: Kardiyo Saat: 11.00-17.00");
                        ListBox.Items.Add("Branş: Fitness  Saat: 10.00-19.00");
                        ListBox.Items.Add("Branş: Boks  Saat: 12.00-20.00");
                        break;
                    case "çarşamba":
                        ListBox.Items.Add("Branş: Zumba  Saat: 09.00-15.00\n");
                        ListBox.Items.Add("Branş: Pilates  Saat: 14.00-18.00\n");
                        ListBox.Items.Add("Branş: Fitness  Saat: 10.00-19.00\n");
                        ListBox.Items.Add("Branş: Kardiyo  Saat: 11.00-17.00");
                        break;
                    case "perşembe":
                        ListBox.Items.Add("Branş: Zumba  Saat: 09.00-15.00");
                        ListBox.Items.Add("Branş: Yüzme  Saat: 08.00-16.00");
                        ListBox.Items.Add("Branş: Fitness  Saat: 10.00-19.00");
                        break;
                    case "cuma":
                        ListBox.Items.Add("Branş: Pilates Saat: 14.00-18.00");
                        ListBox.Items.Add("Branş: Kardiyo  Saat: 11.00-17.00");
                        ListBox.Items.Add("Branş: Fitness  Saat: 10.00-19.00");
                        ListBox.Items.Add("Branş: Boks  Saat: 12.00-20.00");
                        break;
                    case "cumartesi":
                        ListBox.Items.Add("Branş: Yüzme  Saat: 08.00-16.00\n");
                        ListBox.Items.Add("Branş: Kardiyo  Saat: 11.00-17.00\n");
                        ListBox.Items.Add("Branş: Boks  Saat: 12.00-20.00");
                        break;
                    default:
                        ListBox.Items.Add(" ...");
                        break;
                }
               if (BasLabel2.Text == "Haftalık gidilecek gün sayısını giriniz.")
               {

                int günsayı = int.Parse(GüntextBox.Text);
                int haftalık = günsayı * 40;
                int aylık = (günsayı * 30) * 4;
                int senelik = (günsayı * 25) * 48;

                ListBox.Items.Add("Haftalık ücret:\n" + haftalık);
                ListBox.Items.Add("Aylık ücret:\n" + aylık);
                ListBox.Items.Add("Senelik ücret:\n" + senelik);
               }
        }
        private void GosterButton_Click(object sender, EventArgs e)
        {
            if (BasLabel2.Text == "Maaş Hesap Sistemi")
            {
                if (textBox2.Text == "var")
                {
                    int saat = int.Parse(textBox1.Text);
                    int maas = saat * 150 + 1000;
                    MessageBox.Show(string.Format(" Maaş: {0}", maas));
                }

                else if (textBox2.Text == "yok")
                {
                    int saat = int.Parse(textBox1.Text);
                    int maas = saat * 150;
                    MessageBox.Show(string.Format(" Maaş: {0}", maas));
                }
            }
            else if (BasLabel2.Text == "Kalori Hesap Sistemi")
            {
                string cinsiyet = textBox1.Text;
                int yas = int.Parse(textBox2.Text);
                double boy = double.Parse(textBox3.Text);
                double kilo = double.Parse(textBox4.Text);
                double kalori = 0;

                if (cinsiyet == "kadın")
                {
                    kalori = 665 + (9.6 * kilo) + (1.7 * boy) - (4.7 * yas);
                }
                else
                {
                    kalori = 66 + (9.6 * kilo) + (1.7 * boy) - (4.7 * yas);
                }
                MessageBox.Show(string.Format("Günlük kalori ihtiyacı: {0}", kalori));
            }
            else if (BasLabel2.Text == "Vücut yağ kontrol sistemi")
            {
                string cinsiyet1 = textBox1.Text;
                int yas1 = int.Parse(textBox2.Text);
                int yagoranı = int.Parse(textBox3.Text);


                if (cinsiyet1 == "kadın")
                {
                    if ((20 < yas1) && (yas1 < 39))
                    {
                        if (yagoranı < 21.0)
                        {
                            MessageBox.Show(string.Format(" Yağ oranınız idealden düşüktür. "));
                        }
                        else if ((21.0 < yagoranı) && (yagoranı < 32.9))
                        {
                            MessageBox.Show(string.Format(" Yağ oranınız ideal değerdedir. "));
                        }
                        else if ((33.0 < yagoranı) && (yagoranı < 38.9))
                        {
                            MessageBox.Show(string.Format(" Yağ oranınız idealden yüksek değerdedir. "));
                        }
                        else if (yagoranı > 39.0)
                        {
                            MessageBox.Show(string.Format(" Yağ oranınız idealden çok yüksektir. "));
                        }
                    }
                    else if ((40 < yas1) && (yas1 < 59))
                    {
                        if (yagoranı < 23.0)
                        {
                            MessageBox.Show(string.Format(" Yağ oranınız idealden düşüktür. "));
                        }
                        else if ((23.0 < yagoranı) && (yagoranı < 33.9))
                        {
                            MessageBox.Show(string.Format(" Yağ oranınız ideal değerdedir. "));
                        }
                        else if ((34.0 < yagoranı) && (yagoranı < 39.9))
                        {
                            MessageBox.Show(string.Format(" Yağ oranınız idealden yüksek değerdedir. "));
                        }
                        else if (yagoranı > 40.0)
                        {
                            MessageBox.Show(string.Format(" Yağ oranınız idealden çok yüksektir."));
                        }
                    }
                    else if ((60 < yas1) && (yas1 < 79))
                    {
                        if (yagoranı < 24.0)
                        {
                            MessageBox.Show(string.Format(" Yağ oranınız idealden düşüktür. "));
                        }
                        else if ((24.0 < yagoranı) && (yagoranı < 35.9))
                        {
                            MessageBox.Show(string.Format(" Yağ oranınız ideal değerdedir. "));
                        }
                        else if ((36.0 < yagoranı) && (yagoranı < 41.9))
                        {
                            MessageBox.Show(string.Format(" Yağ oranınız idealden yüksek değerdedir. "));
                        }
                        else if (yagoranı > 42.0)
                        {
                            MessageBox.Show(string.Format(" Yağ oranınız idealden çok yüksektir. "));
                        }
                    }
                }
            
                if (cinsiyet1 == "erkek")
                {
                    if ((18 < yas1) && (yas1 < 39))
                    {
                        if (yagoranı < 8.0)
                        {
                            MessageBox.Show(string.Format(" Yağ oranınız idealden düşüktür. "));
                        }
                        else if ((8.0 < yagoranı) && (yagoranı < 19.9))
                        {
                            MessageBox.Show(string.Format(" Yağ oranınız ideal değerdedir. "));
                        }
                        else if ((20.0 < yagoranı) && (yagoranı < 24.9))
                        {
                            MessageBox.Show(string.Format(" Yağ oranınız idealden yüksek değerdedir. "));
                        }
                        else if (yagoranı > 25.0)
                        {
                            MessageBox.Show(string.Format(" Yağ oranınız idealden çok yüksektir. "));
                        }
                    }
                    else if ((40 < yas1) && (yas1 < 59))
                    {
                        if (yagoranı < 11.0)
                        {
                            MessageBox.Show(string.Format(" Yağ oranınız idealden düşüktür. "));
                        }
                        else if ((11.0 < yagoranı) && (yagoranı < 21.9))
                        {
                            MessageBox.Show(string.Format(" Yağ oranınız ideal değerdedir. "));
                        }
                        else if ((22.0 < yagoranı) && (yagoranı < 27.9))
                        {
                            MessageBox.Show(string.Format(" Yağ oranınız idealden yüksek değerdedir. "));
                        }
                        else if (yagoranı > 28.0)
                        {
                            MessageBox.Show(string.Format(" Yağ oranınız idealden çok yüksektir."));
                        }
                    }
                    else if ((60 < yas1) && (yas1 < 79))
                    {
                        if (yagoranı < 13.0)
                        {
                            MessageBox.Show(string.Format(" Yağ oranınız idealden düşüktür. "));
                        }
                        else if ((13.0 < yagoranı) && (yagoranı < 24.9))
                        {
                            MessageBox.Show(string.Format(" Yağ oranınız ideal değerdedir. "));
                        }
                        else if ((25.0 < yagoranı) && (yagoranı < 29.9))
                        {
                            MessageBox.Show(string.Format(" Yağ oranınız idealden yüksek değerdedir. "));
                        }
                        else if (yagoranı > 30.0)
                        {
                            MessageBox.Show(string.Format(" Yağ oranınız idealden çok yüksektir. "));
                        }
                    }
                }
            }
            else if (BasLabel2.Text == "Vücut kas kontrol sistemi")
            {
                string cinsiyet2 = textBox1.Text;
                int yas2 = int.Parse(textBox2.Text);
                int kasoranı = int.Parse(textBox3.Text);


                if (cinsiyet2 == "kadın")
                {
                    if ((20 < yas2) && (yas2 < 39))
                    {
                        if (kasoranı < 21.0)
                        {
                            MessageBox.Show(string.Format(" Kas oranınız idealden düşüktür. "));
                        }
                        else if ((21.0 < kasoranı) && (kasoranı < 32.9))
                        {
                            MessageBox.Show(string.Format(" Kas oranınız ideal değerdedir. "));
                        }
                        else if ((33.0 < kasoranı) && (kasoranı < 38.9))
                        {
                            MessageBox.Show(string.Format(" Kas oranınız idealden yüksek değerdedir. "));
                        }
                        else if (kasoranı > 39.0)
                        {
                            MessageBox.Show(string.Format(" Kas oranınız idealden çok yüksektir. "));
                        }
                    }
                    else if ((40 < yas2) && (yas2 < 59))
                    {
                        if (kasoranı < 23.0)
                        {
                            MessageBox.Show(string.Format(" Kas oranınız idealden düşüktür. "));
                        }
                        else if ((23.0 < kasoranı) && (kasoranı < 33.9))
                        {
                            MessageBox.Show(string.Format(" Kas oranınız ideal değerdedir. "));
                        }
                        else if ((34.0 < kasoranı) && (kasoranı < 39.9))
                        {
                            MessageBox.Show(string.Format(" Kas oranınız idealden yüksek değerdedir. "));
                        }
                        else if (kasoranı > 40.0)
                        {
                            MessageBox.Show(string.Format(" Kas oranınız idealden çok yüksektir."));
                        }
                    }
                    else if ((60 < yas2) && (yas2 < 79))
                    {
                        if (kasoranı < 24.0)
                        {
                            MessageBox.Show(string.Format(" Kas oranınız idealden düşüktür. "));
                        }
                        else if ((24.0 < kasoranı) && (kasoranı < 35.9))
                        {
                            MessageBox.Show(string.Format(" Kas oranınız ideal değerdedir. "));
                        }
                        else if ((36.0 < kasoranı) && (kasoranı < 41.9))
                        {
                            MessageBox.Show(string.Format(" Kas oranınız idealden yüksek değerdedir. "));
                        }
                        else if (kasoranı > 42.0)
                        {
                            MessageBox.Show(string.Format(" Kas oranınız idealden çok yüksektir. "));
                        }
                    }
                }
                if (cinsiyet2 == "erkek")
                {
                    if ((18 < yas2) && (yas2 < 39))
                    {
                        if (kasoranı < 8.0)
                        {
                            MessageBox.Show(string.Format(" Kas oranınız idealden düşüktür. "));
                        }
                        else if ((8.0 < kasoranı) && (kasoranı < 19.9))
                        {
                            MessageBox.Show(string.Format(" Kas oranınız ideal değerdedir. "));
                        }
                        else if ((20.0 < kasoranı) && (kasoranı < 24.9))
                        {
                            MessageBox.Show(string.Format(" Kas oranınız idealden yüksek değerdedir. "));
                        }
                        else if (kasoranı > 25.0)
                        {
                            MessageBox.Show(string.Format(" Kas oranınız idealden çok yüksektir. "));
                        }
                    }
                    else if ((40 < yas2) && (yas2 < 59))
                    {
                        if (kasoranı < 11.0)
                        {
                            MessageBox.Show(string.Format(" Kas oranınız idealden düşüktür. "));
                        }
                        else if ((11.0 < kasoranı) && (kasoranı < 21.9))
                        {
                            MessageBox.Show(string.Format(" Kas oranınız ideal değerdedir. "));
                        }
                        else if ((22.0 < kasoranı) && (kasoranı < 27.9))
                        {
                            MessageBox.Show(string.Format(" Kas oranınız idealden yüksek değerdedir. "));
                        }
                        else if (kasoranı > 28.0)
                        {
                            MessageBox.Show(string.Format(" Kas oranınız idealden çok yüksektir."));
                        }
                    }
                    else if ((60 < yas2) && (yas2 < 79))
                    {
                        if (kasoranı < 13.0)
                        {
                            MessageBox.Show(string.Format(" Kas oranınız idealden düşüktür. "));
                        }
                        else if ((13.0 < kasoranı) && (kasoranı < 24.9))
                        {
                            MessageBox.Show(string.Format(" Kas oranınız ideal değerdedir. "));
                        }
                        else if ((25.0 < kasoranı) && (kasoranı < 29.9))
                        {
                            MessageBox.Show(string.Format(" Kas oranınız idealden yüksek değerdedir. "));
                        }
                        else if (kasoranı > 30.0)
                        {
                            MessageBox.Show(string.Format(" Kas oranınız idealden çok yüksektir. "));
                        }
                    }
                }            
            }
        }
        private void çıkısButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
