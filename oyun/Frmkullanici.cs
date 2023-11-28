using GameLib;
using oyun;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oyun
{
    public partial class Frmkullanici : Form
    {
        public Frmkullanici()
        {
            InitializeComponent();
        }

        private void btnoyun_Click(object sender, EventArgs e)
        {

            if (txtad.Text == string.Empty || txtsoyad.Text == string.Empty)
            {
                MessageBox.Show("Ad veya Soyad zorunlu");
            }
            else
            {
                Level seviye;
                if (rdkolay.Checked == true)
                {
                    seviye = Level.Kolay;
                }
                else if (rdorta.Checked == true)
                {
                    seviye =Level.Orta;
                }
                else if (rdzor.Checked == true)
                {
                    seviye = Level.Zor;
                }
                else
                {
                    MessageBox.Show("Seviye seçiniz");
                    return;//methoddan çıkar. Çıktığı için form çalışmaz
                }
                //var info = new GameInfo();
                //info.Ad = txtad.Text.Trim();
                //info.Soyad= txtsoyad.Text.Trim();
                //info.Seviye= seviye;
                //Frmoyun frmoyun = new Frmoyun(info);
                Frmoyun frmoyun = new Frmoyun(new GameInfo { Ad = txtad.Text.Trim(),Soyad=txtsoyad.Text.Trim(),Seviye=seviye }) ;
                frmoyun.Show();
                }

            }
        }
    }
//veri taşımadan kesin soru gelir.