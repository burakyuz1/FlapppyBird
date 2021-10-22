using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlapppyBird
{
    public partial class Form1 : Form
    {
        int yerCekimi = 5; //Kuş hareketi için
        int hiz = 5;//borular için
        int score = 0;
        bool pbPipe1Control, pbPipe3Control;
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space && tmrGame.Enabled)
            {
                if (pcbBird.Top > 0)
                {
                    pcbBird.Top -= yerCekimi * 8;

                }
            }
        }

        private void tmrGame_Tick(object sender, EventArgs e)
        {
            pcbBird.Top += yerCekimi;
            pcbPipe1.Left -= hiz;
            pcbPipe2.Left -= hiz;
            pcbPipe3.Left -= hiz;
            pcbPipe4.Left -= hiz;
            if (pcbPipe1.Right < 0)
            {
                pcbPipe1.Left = ClientSize.Width + rnd.Next(200);
                pbPipe1Control = false;

            }
            if (pcbPipe2.Right < 0)
            {
                pcbPipe2.Left = ClientSize.Width + rnd.Next(200);

            }
            if (pcbPipe3.Right < 0)
            {
                pcbPipe3.Left = ClientSize.Width + rnd.Next(200);
                pbPipe3Control = false;


            }
            if (pcbPipe4.Right < 0)
            {
                pcbPipe4.Left = ClientSize.Width + rnd.Next(199);

            }

            if (pcbPipe1.Bounds.IntersectsWith(pcbBird.Bounds) || pcbPipe2.Bounds.IntersectsWith(pcbBird.Bounds) || pcbPipe3.Bounds.IntersectsWith(pcbBird.Bounds) || pcbPipe4.Bounds.IntersectsWith(pcbBird.Bounds) || pbGround.Bounds.IntersectsWith(pcbBird.Bounds))
            {
                tmrGame.Stop();
                 var dr =  MessageBox.Show($"Puan: {score}\nTekrar oynamak ister misiniz", "Flappy Bird" , MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    pcbBird.Left = 0;
                    pcbBird.Top = 140;
                    pcbPipe1.Left += ClientSize.Width;
                    pcbPipe2.Left += ClientSize.Width;
                    pcbPipe3.Left += ClientSize.Width;
                    pcbPipe4.Left += ClientSize.Width;

                    pbPipe1Control = false;
                    pbPipe3Control = false;
                    score = 0;
                    tmrGame.Start();
                }
                else
                {
                    Close();
                }
            }




            if (pcbBird.Right > pcbPipe1.Left && !pbPipe1Control)
            {
                score++;
                pbPipe1Control = true;
            }

            if (pcbBird.Right > pcbPipe3.Left && !pbPipe3Control)
            {
                score++;
                pbPipe3Control = true;
            }
            lblScore.Text = score.ToString();
        }
    }
}
