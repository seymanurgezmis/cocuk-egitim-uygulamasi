/**************************************************************************** **                                                                                                                            **                                                                SAKARYA ÜNİVERSİTESİ 
**                                                   BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
 **                                                  BİLİŞİM SİSTEMLERİ MÜHENDİSLİĞİ BÖLÜMÜ 
**                                                   NESNEYE DAYALI PROGRAMLAMA DERSİ
                                                              ** 2019-2020 YAZ DÖNEMİ **
 ** PROJE NUMARASI.........: 01
 ** ÖĞRENCİ ADI............:Şeyma Nur GEZMİŞ
 ** ÖĞRENCİ NUMARASI.......: b181200050
** DERSİN ALINDIĞI GRUP...: A ****************************************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Çocuk_Eğitim_Uygulaması
{
    //FrmAritmetik adlı sınıf oluşturduk.
    public partial class FrmAritmetik : Form
    {
        public FrmAritmetik()
        {
            InitializeComponent();
        }
        Random rastgele = new Random();
        //Kulanıcını doğru cevaplayacağı sorular int puan değişkeni atıyoruz.
        int puan = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            //Button1 e tıkladığımızda button2 aktif hale geliyor.
            button2.Enabled = true;
            button1.Enabled = false;

            int yanıtla;
            if (label1.Text == "+")
            {
                //Eğer işlemimiz + olursa label3 ve label2 deki değerler toplanıyor.
                yanıtla = Convert.ToInt32(label3.Text) + Convert.ToInt32(label2.Text);
                LblCevap.Text = yanıtla.ToString();

            }
            if (label1.Text == "-")
            {
                yanıtla = Convert.ToInt32(label3.Text) - Convert.ToInt32(label2.Text);
                LblCevap.Text = yanıtla.ToString();

            }
            if (label1.Text == "*")
            {
                yanıtla = Convert.ToInt32(label3.Text) * Convert.ToInt32(label2.Text);
                LblCevap.Text = yanıtla.ToString();

            }
            if (label1.Text == "%")
            {
                yanıtla = Convert.ToInt32(label3.Text) % Convert.ToInt32(label2.Text);
                LblCevap.Text = yanıtla.ToString();

            }
            if (LblCevap.Text == textBox1.Text)
            {
                //Kulanıcı doğru cevap verdiği sor başına 10 puan alır yanlış cevap verdiğinde puan almaz.
                puan = puan + 10;
                label6.Text = puan.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Button2 ye tıkladığımızda button1 aktif hale geliyor.
            button2.Enabled = false;
            button1.Enabled = true;

            //Soru getir ismli buttona tıkladığımızda textbox ın içi temizlenir.
            textBox1.Clear();

            //label2 için sayı1 label3 için sayı2  label1 için sonuc değişkenini atadık.
            int sayı1 = rastgele.Next(1, 10);
            int sayı2 = rastgele.Next(1, 10);
            int sonuc = rastgele.Next(1, 5);

            label2.Text = sayı1.ToString();
            label3.Text = sayı2.ToString();
            // label1 için 4 işlem atıyoruz.
            if (sonuc == 1)
            {
                label1.Text = "+";
            }
            if (sonuc == 2)
            {
                label1.Text = "-";
            }
            if (sonuc == 3)
            {
                label1.Text = "*";
            }
            if (sonuc == 4)
            {
                label1.Text = "%";
            }
        }
       
    }
}
