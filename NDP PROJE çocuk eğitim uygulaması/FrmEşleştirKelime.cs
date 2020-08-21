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
    //FrmEşleştirKelime adlı sınıf oluşturduk.
    public partial class FrmEşleştirKelime : Form
    {
        public FrmEşleştirKelime()
        {
            InitializeComponent();
        }

       

       

        private void FrmEşleştirKelime_Load(object sender, EventArgs e)
        {

        }
        //Butonlara text oluşturuyoruz.
        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Kedi";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "Köpek";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "At";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = "Kuş";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text = "İnek";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label2.Text = "Dog";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label2.Text = "Cow";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label2.Text = "Bird";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label2.Text = "Horse";
        }
        private void button10_Click(object sender, EventArgs e)
        {
            label2.Text = "Cat";
        }
        private void button11_Click(object sender, EventArgs e)
        {
          if(label1.Text=="Kedi"&& label2.Text == "Cat")
            {
                //Doğru eşleştirmeler yapıldığında eşleştirilen buton sarı renk alır.
                //Kedi ve cat butonuna basıp yanıtla butonuna basıldığında kedi ve cat butonları sarı renk alır.
                button1.Enabled = false;
                button10.Enabled = false;
                button1.BackColor = Color.Yellow;
                button10.BackColor = Color.Yellow;
            }
            if (label1.Text == "Köpek" && label2.Text == "Dog")
            {
                button2.Enabled = false;
                button6.Enabled = false;
                button2.BackColor = Color.Yellow;
                button6.BackColor = Color.Yellow;
            }
            if (label1.Text == "At" && label2.Text == "Horse")
            {
                button3.Enabled = false;
                button9.Enabled = false;
                button3.BackColor = Color.Yellow;
                button9.BackColor = Color.Yellow;
            }
            if (label1.Text == "Kuş" && label2.Text == "Bird")
            {
                button4.Enabled = false;
                button8.Enabled = false;
                button4.BackColor = Color.Yellow;
                button8.BackColor = Color.Yellow;
            }
            if (label1.Text == "İnek" && label2.Text == "Cow")
            {
                button5.Enabled = false;
                button7.Enabled = false;
                button5.BackColor = Color.Yellow;
                button7.BackColor = Color.Yellow;
            }

        }
    }
}
