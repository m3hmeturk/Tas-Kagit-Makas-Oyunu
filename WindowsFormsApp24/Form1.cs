using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp24
{
    public partial class Form1 : Form
    {
        int skor = 0;
        int bot = 0;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (skor == 3)
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                buttonTas.Enabled = false;
                buttonKagıt.Enabled = false;
                buttonMakas.Enabled = false;
                labelKazanan.Text = "Siz Kazandınız";
                labelSonuc.Text = "";
            }
            else if (bot == 3)
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                buttonTas.Enabled = false;
                buttonKagıt.Enabled = false;
                buttonMakas.Enabled = false;
                labelKazanan.Text = "Bot Kazandı";
                labelSonuc.Text = "";
            }
        }

        private void kagıt_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.White;
            button2.BackColor = Color.White;
            button3.BackColor = Color.White;

            Random random = new Random();
            int deger;
            deger = random.Next(1, 4);
            if(deger == 1)
            {
                labelSonuc.Text = "Kazandınız";
                button1.BackColor = Color.Green;
                skor++;
                labelmySkor.Text = skor.ToString();
            }
            else if(deger==2)
            {
                labelSonuc.Text = "Beraberlik";
                button2.BackColor = Color.Gray;
            }
            else
            {
                labelSonuc.Text = "Kaybetiniz";
                button1.BackColor = Color.Red;
                bot++;
                labelBotSkor.Text = bot.ToString();
            }
        }

        private void buttonTas_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.White;
            button2.BackColor = Color.White;
            button3.BackColor = Color.White;

            Random random = new Random();
            int deger;
            deger = random.Next(1, 4);
            if (deger == 1)
            {
                labelSonuc.Text = "Beraberlik";
                button1.BackColor = Color.Gray;
            }
            else if(deger == 2)
            {
                labelSonuc.Text = "Kaybettiniz";
                button2.BackColor = Color.Red;
                bot++;
                labelBotSkor.Text = bot.ToString();
            }
            else
            {
                labelSonuc.Text = "Kazandınız";
                button3.BackColor = Color.Green;
                skor++;
                labelmySkor.Text = skor.ToString();
            }
        }

        private void buttonMakas_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.White;
            button2.BackColor = Color.White;
            button3.BackColor = Color.White;

            Random random = new Random();
            int deger;
            deger = random.Next(1, 4);
            if (deger == 1) 
            {
                labelSonuc.Text = "Kaybettiniz";
                button1.BackColor = Color.Red;
                bot++;
                labelBotSkor.Text = bot.ToString();
            }
            else if(deger == 2) 
            {
                labelSonuc.Text = "Kazandınız";
                button2.BackColor = Color.Green;
                skor++;
                labelmySkor.Text = skor.ToString();
            }
            else
            {
                labelSonuc.Text = "Beraberlik";
                button3.BackColor = Color.Gray;
            }
        }
    }
}
