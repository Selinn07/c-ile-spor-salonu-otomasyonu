using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BasLabel.Text = "DEĞERLİ KULLANICIMIZ HOŞGELDİNİZ";
            YanLabel.Text = "Lütfen yapmak istediğiniz işlemi seçiniz";
            İslemgroupBox.Visible = false;
            Devambutton.Visible = false;
            SporButton.Text ="Spor";
            AntrenorButton.Text = "Antrenör";
            SporcuButton.Text = "Sporcu";
            pictureBox1.Image = Image.FromFile(@"C:\Users\Asus\Desktop\spor.jpg");
            pictureBox2.Image = Image.FromFile(@"C:\Users\Asus\Desktop\antrenör.jpg");
            pictureBox3.Image = Image.FromFile(@"C:\Users\Asus\Desktop\sporcu.jpg");
        }

        private void SporButton_Click(object sender, EventArgs e)
        {
            BasLabel.Text = "Sisteme giriş yapıldı";
            YanLabel.Text = "Lütfen yapmak istediğiniz işlemi seçiniz";
            İslemgroupBox.Visible = true;
            Devambutton.Visible = true;
            İslemgroupBox.Text = "işlemler";
            islemcomboBox.Items.Add("Kalori göster");
            islemcomboBox.Items.Add("Program göster");

        }

        private void AntrenorButton_Click(object sender, EventArgs e)
        {
            BasLabel.Text = "Antrenörler için sisteme giriş yapıldı";
            YanLabel.Text = "Lütfen yapmak istediğiniz işlemi seçiniz";
            İslemgroupBox.Visible = true;
            Devambutton.Visible = true;
            İslemgroupBox.Text = "işlemler";
            islemcomboBox.Items.Add("Antrenör ekle");
            islemcomboBox.Items.Add("Bilgi al");
            islemcomboBox.Items.Add("Maaş hesapla");
        }

        private void SporcuButton_Click(object sender, EventArgs e)
        {
            BasLabel.Text = "Sporcular için sisteme giriş yapıldı";
            YanLabel.Text = "Lütfen yapmak istediğiniz işlemi seçiniz";
            İslemgroupBox.Visible = true;
            Devambutton.Visible = true;
            islemcomboBox.Text = "işlemler";
            islemcomboBox.Items.Add("Sporcu ekle");
            islemcomboBox.Items.Add("Kalori hesapla");
            islemcomboBox.Items.Add("Ücret hesapla");
            islemcomboBox.Items.Add("Vücut yağ kontrolü");
            islemcomboBox.Items.Add("Vücut kas kontrolü");
        }


        private void Devambutton_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();

            if (islemcomboBox.Text == "Kalori göster")
            {
                f2.GüntextBox.Visible = false;
                f2.DevamButton2.Visible = false;
                f2.GosterButton.Visible = false;
                f2.GirdigroupBox.Visible = false;
                f2.BasLabel2.Text = "Sporların 1 saatteki kalori yakımları gösterilmektedir.";
                f2.ListBox.Items.Add("Fitness= 546 cal");
                f2.ListBox.Items.Add("Zumba = 536 cal");
                f2.ListBox.Items.Add("Kardiyo = 514 cal");
                f2.ListBox.Items.Add("Boks = 650 cal");
                f2.ListBox.Items.Add("Yüzme = 477 cal");
                f2.ListBox.Items.Add("Pilates = 220 cal");

                f2.ShowDialog();
            }
            else if (islemcomboBox.Text == "Program göster")
            {
                f2.GüntextBox.Visible = true;
                f2.GirdigroupBox.Visible = false;
                f2.GosterButton.Visible = false;
                f2.BasLabel2.Text = "Lütfen gün giriniz";
                f2.ShowDialog();
            }
            else if (islemcomboBox.Text == "Bilgi al")
            {
                f2.BasLabel2.Text = "Antrenör bilgileri listelenmiştir.";
                f2.GirdigroupBox.Visible = false;
                f2.DevamButton2.Visible = false;
                f2.GüntextBox.Visible = false;              
                f2.ListBox.Items.Add("Ad/Soyad: Fatih Keskin " + "  Branş: Yüzme " + "  Tecrübe :var(2 yıllık)\n");
                f2.ListBox.Items.Add("Ad/Soyad: Uraz Sayar " + "    Branş: Boks " + "   Tecrübe :var(5 yıllık)\n");
                f2.ListBox.Items.Add("Ad/Soyad: Kübra Çınar " + "   Branş: Pilates " + "Tecrübe :yok\n");
                f2.ListBox.Items.Add("Ad/Soyad: Arda Sönmez " + "   Branş: Kardiyo " + "Tecrübe :yok\n");
                f2.ListBox.Items.Add("Ad/Soyad: Açelya Tok " + "    Branş: Zumba " + "  Tecrübe :var(8 yıllık)\n");
                f2.ListBox.Items.Add("Ad/Soyad: Sergen Taşkın " + " Branş: Kardiyo " + "Tecrübe :var(3 yıllık)\n");
                f2.ListBox.Items.Add("Ad/Soyad: Sibel Sağlam " + "  Branş: Fitness " + "Tecrübe :yok\n");
                f2.ListBox.Items.Add("Ad/Soyad: Koray Yener " + "   Branş: Fitness " + "Tecrübe :var(5 yıllık)\n");
                f2.ListBox.Items.Add("Ad/Soyad: Çağla Deniz  " + "  Branş: Yüzme " + "  Tecrübe :var(4 yıllık)\n");
                f2.ListBox.Items.Add("Ad/Soyad: Bülent Korkmaz " + "Branş: Boks " + "   Tecrübe :var(3 yıllık)\n");
                f2.ListBox.Items.Add("Ad/Soyad: Kerem Demir" + "    Branş: Fitness " + "Tecrübe :var(10 yıllık)\n");
                f2.ListBox.Items.Add("Ad/Soyad: Ece Bakan " + "     Branş: Pilates " + "Tecrübe :var(7 yıllık)\n");
                f2.ListBox.Items.Add("Ad/Soyad: Poyraz Aras  " + "  Branş: Zumba " + "  Tecrübe :var(2 yıllık)");
                f2.ShowDialog();
            }
            else if(islemcomboBox.Text == "Maaş hesapla")
            {
                f2.GirdigroupBox.Visible = true;
                f2.DevamButton2.Visible = false;
                f2.GüntextBox.Visible = false;
                f2.textBox3.Visible = false;
                f2.label4.Visible = false;
                f2.textBox4.Visible = false;
                f2.BasLabel2.Text = "Maaş Hesap Sistemi";
                f2.label1.Text = "Çalışma saati";   //Haftalık
                f2.label2.Text = "Tecrübe(var/yok)";
                f2.label3.Visible = false;
                
                f2.ShowDialog();            
            }
            else if(islemcomboBox.Text == "Kalori hesapla")
            {
                f2.GirdigroupBox.Visible = true;
                f2.DevamButton2.Visible = false;
                f2.GüntextBox.Visible = false;
                f2.BasLabel2.Text = "Kalori Hesap Sistemi";
                f2.label1.Text = "Cinsiyet";
                f2.label2.Text = "Yaş";
                f2.label3.Text = "Boy";
                f2.label4.Text = "Kilo";

                f2.ShowDialog();
            }
            else if(islemcomboBox.Text == "Ücret hesapla")
            {
                f2.BasLabel2.Text = "Haftalık gidilecek gün sayısını giriniz.";
                f2.GirdigroupBox.Visible = false;
                f2.GosterButton.Visible = false;

                f2.ShowDialog();
            }
            else if(islemcomboBox.Text == "Vücut yağ kontrolü")
            {
                f2.BasLabel2.Text = "Vücut yağ kontrol sistemi";
                f2.GirdigroupBox.Visible = true;
                f2.DevamButton2.Visible = false;
                f2.GüntextBox.Visible = false;
                f2.label4.Visible = false;
                f2.textBox4.Visible = false;
                f2.label1.Text = "Cinsiyet";
                f2.label2.Text = "Yaş";
                f2.label3.Text = "Yağ oranı";
             
                f2.ShowDialog();
            }
            else if (islemcomboBox.Text == "Vücut kas kontrolü")
            {
                f2.BasLabel2.Text = "Vücut kas kontrol sistemi";
                f2.GirdigroupBox.Visible = true;
                f2.DevamButton2.Visible = false;
                f2.GüntextBox.Visible = false;
                f2.label4.Visible = false;
                f2.textBox4.Visible = false;
                f2.label1.Text = "Cinsiyet";
                f2.label2.Text = "Yaş";
                f2.label3.Text = "Kas oranı";

                f2.ShowDialog();
            }
            else if(islemcomboBox.Text == "Sporcu ekle")
            {
                Form3 f3 = new Form3();
               
                f3.KisilerListBox.Items.Add("Timuçin Özgür 28");
                f3.KisilerListBox.Items.Add("Asude Parlak 22");
                f3.KisilerListBox.Items.Add("Serap Taş 30");

                f3.Baslabel3.Text = "Kayıt Sistemi";
                f3.label1.Text = "AD";
                f3.label2.Text = "SOYAD";
                f3.label3.Text = "YAŞ";              

                f3.ShowDialog();              
            }
            else if(islemcomboBox.Text == "Antrenör ekle")
            {
                Form3 f3 = new Form3();

                f3.KisilerListBox.Items.Add("Fatih Keskin 25");
                f3.KisilerListBox.Items.Add("Uraz Sayar 29");
                f3.KisilerListBox.Items.Add("Kübra Çınar 31");
                f3.KisilerListBox.Items.Add("Arda Sönmez 20");
                f3.KisilerListBox.Items.Add("Açelya Tok 35");
                f3.KisilerListBox.Items.Add("Sergen Taşkın 27");
                f3.KisilerListBox.Items.Add("Sibel Sağlam 21");
                f3.KisilerListBox.Items.Add("Koray Yener 24");
                f3.KisilerListBox.Items.Add("Çağla Deniz 30");
                f3.KisilerListBox.Items.Add("Bülent Korkmaz 28");
                f3.KisilerListBox.Items.Add("Kerem Demir 37");
                f3.KisilerListBox.Items.Add("Ece Bakan 33");
                f3.KisilerListBox.Items.Add("Poyraz Aras 26");

                f3.Baslabel3.Text = "Kayıt Sistemi";
                f3.label1.Text = "AD";
                f3.label2.Text = "SOYAD";
                f3.label3.Text = "YAŞ";

                f3.ShowDialog();
            }

        }
        private void ÇıkısButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
