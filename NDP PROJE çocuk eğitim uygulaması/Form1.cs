/**************************************************************************** **                                                                                                                            **                                                                SAKARYA ÜNİVERSİTESİ 
**                                                   BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
 **                                                  BİLİŞİM SİSTEMLERİ MÜHENDİSLİĞİ BÖLÜMÜ 
**                                                   NESNEYE DAYALI PROGRAMLAMA DERSİ
                                                              ** 2019-2020 YAZ DÖNEMİ **
 ** PROJE NUMARASI.........: 01
 ** ÖĞRENCİ ADI............:Şeyma Nur GEZMİŞ
 ** ÖĞRENCİ NUMARASI.......: b181200050
** DERSİN ALINDIĞI GRUP...: A
* ****************************************************************************/

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
    //FrmAnaForm adlı sınıf oluşturuldu.
    public partial class FrmAnaForm : Form
    {
        public FrmAnaForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmAnaForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //Anasayfaya link verildi.
            FrmEşleştirKelime formkelimeeslestir = new FrmEşleştirKelime();
            formkelimeeslestir.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            FrmAritmetik islemFormu = new FrmAritmetik();
            islemFormu.Show();

        }
    }
}
