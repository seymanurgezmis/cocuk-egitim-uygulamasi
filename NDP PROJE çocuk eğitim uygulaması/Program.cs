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
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Çocuk_Eğitim_Uygulaması
{
    static class Program
    {
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Kullanıcıya frmAnaForm adlı arayüz sunuldu.
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmAnaForm());
        }
    }
}
