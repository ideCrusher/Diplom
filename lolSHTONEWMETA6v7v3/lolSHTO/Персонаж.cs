using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lolSHTO
{
    public partial class Персонаж : Form
    {
        public static int i;
        public Персонаж()
        {
            InitializeComponent();
        }

        private void Персонаж_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (ЯЯсеневыйЛес.YLes != null)
            {
                ЯЯсеневыйЛес.YLes.button1.Enabled = true;
                ЯЯсеневыйЛес.YLes.Save.Enabled = true;

                ЯЯсеневыйЛес.YLes = null;

                
            }
            if (SawmillYL.SW != null)
            {
                SawmillYL.SW.button1.Enabled = true;
                

                SawmillYL.SW = null;


            }
            if (ТемныеБерега.DC != null)
            {
                ТемныеБерега.DC.button1.Enabled = true;


                ТемныеБерега.DC = null;


            }

        }

        private void Персонаж_Load(object sender, EventArgs e)
        {
            
            if (Pers.Images == "Изображение1")
            {
                this.BackgroundImage = Res.Personage.Изображение1;
            }
            if (Pers.Images == "Изображение2")
            {
                this.BackgroundImage = Res.Personage.Изображение2;
            }
            if (Pers.Images == "Изображение3")
            {
                this.BackgroundImage = Res.Personage.Изображение3;
            }
            if (Pers.Images == "Изображение4")
            {
                this.BackgroundImage = Res.Personage.Изображение4;
            }
            if (Pers.Images == "Изображение5")
            {
                this.BackgroundImage = Res.Personage.Изображение5;
            }
            if (Pers.Images == "Изображение6")
            {
                this.BackgroundImage = Res.Personage.Изображение6;
            }
            if (Pers.Images == "Изображение7")
            {
                this.BackgroundImage = Res.Personage.Изображение7;
            }


            if (Pers.Ochko > 0)
            {
                button2.Visible = true;
                button3.Visible = true;
                button4.Visible = true;
                button5.Visible = true;

                label12.Visible = true;
                button1.Visible = true;
            }

            label8.Text = Convert.ToString(Pers.Stamina);
            label9.Text = Convert.ToString(Pers.Strength);
            label10.Text = Convert.ToString(Pers.Agility);
            label11.Text = Convert.ToString(Pers.Intellect);
            label15.Text = Convert.ToString(Pers.LVL);
            label14.Text = Convert.ToString(Pers.EXP);
            label13.Text = Convert.ToString(Pers.HP);
            label17.Text = Convert.ToString(Pers.Armor);
            label18.Text = Convert.ToString(Pers.DD);
            label20.Text = Convert.ToString(Pers.Gold);



            i = Pers.Ochko;

            this.Text = Pers.Name;
        }

        private void lvling_Tick(object sender, EventArgs e)
        {
            if(i==0)
            {
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
            }

            lvling.Enabled = false;
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            i = i - 1;
            label8.Text = Convert.ToString(Convert.ToInt32(label8.Text) + 1);

            lvling.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            i = i - 1;
            label9.Text = Convert.ToString(Convert.ToInt32(label9.Text) + 1);

            lvling.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {

            i = i - 1;
            label10.Text = Convert.ToString(Convert.ToInt32(label10.Text) + 1);

            lvling.Enabled = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            i = i - 1;
            label11.Text = Convert.ToString(Convert.ToInt32(label11.Text) + 1);

            lvling.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(i == 0)
            {
                Pers.Ochko = Pers.Ochko - Pers.Ochko;
                Pers.Stamina = Convert.ToInt32(label8.Text);
                Pers.Strength = Convert.ToInt32(label9.Text);
                Pers.Agility = Convert.ToInt32(label10.Text);
                Pers.Intellect = Convert.ToInt32(label11.Text);


                


                button2.Visible = false;
                button3.Visible = false;
                button4.Visible = false;
                button5.Visible = false;

                label12.Visible = false;
                button1.Visible = false;


                

            }


        }
    }
}
