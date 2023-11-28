using GameLib;
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
   
    public partial class Frmoyun : Form
    {
        Timer tmr1 = new Timer();
        int skor = 0;
        int saniye = 10;
        GameInfo gameinfo = new GameInfo();
        public Frmoyun(GameInfo gameinfo)
        {
            InitializeComponent();
            lblbilgi.Text = $"{gameinfo.Ad} {gameinfo.Soyad}";
            switch (gameinfo.Seviye)
            {
                case Level.Kolay:
                    this.Size = new Size(300, 300);
                    saniye = 30;
                    break;
                case Level.Orta:
                    this.Size = new Size(500, 500);
                    saniye = 20;
                    break;
                case Level.Zor:
                    this.Size = new Size(800, 800);
                    saniye = 10;
                    break;
                default:
                    break;
            }

            this.gameinfo = gameinfo;
        }

        private void btnyakala_MouseMove(object sender, MouseEventArgs e)
        {
            Button b = (Button)sender;
            var rnd = new Random();
            b.Location = new Point(rnd.Next(this.ClientSize.Width-b.Width-pnl.Width),rnd.Next(this.ClientSize.Height-b.Height));
            if (b.Name == "btnyakala")
            {
                skor++;
            }
            else
            {
                skor -= 5;
            } 
            lblskor.Text="Skor:"+skor.ToString();
            if (!tmr.Enabled)
            {
            tmr.Start();
            }
            if (skor%(saniye+1)==0)
            {
                var btn = new Button();
                btn.BackColor = System.Drawing.Color.Red;
                btn.Location= new Point(rnd.Next(this.ClientSize.Width - btn.Width - pnl.Width), rnd.Next(this.ClientSize.Height - btn.Height));
                this.Controls.Add(btn);
                btn.MouseMove += btnyakala_MouseMove;
            }
        }
        private void Frmoyun_SizeChanged(object sender, EventArgs e)
        {
            pnl.Location = new Point(this.ClientSize.Width-pnl.Width,0);
            pnl.Height = this.ClientSize.Height;
        }

        private void tmr_Tick(object sender, EventArgs e)
        {
            lblsure.Text = "Saniye:"+saniye.ToString();
            if (saniye==0)
            {
                tmr.Stop();

                MessageBox.Show("Süre Doldu!!");
                foreach (Control item in this.Controls)
                {
                    if (item is Button)
                    {
                        item.Enabled = false;
                    }
                }
            }
            saniye--;
        }
    }
}
