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
    public partial class Tutorial : Form
    {
        public static Tutorial T;
        public static int F, S;
        public Bitmap Perses;

        private Point _Target = Point.Empty;
        private Point Per = Point.Empty;

        PictureBox pic = new PictureBox();

        public Tutorial()
        {
            InitializeComponent();
            SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint, true);

            UpdateStyles();
        }

        private void Tutorial_Load(object sender, EventArgs e)
        {
            

         



            T = this;


            if (Pers.Images == "Изображение1")
            {
                Perses = Res.Personage.Персонаж1;
            }
            if (Pers.Images == "Изображение2")
            {
                Perses = Res.Personage.Персонаж2;
            }
            if (Pers.Images == "Изображение3")
            {
                Perses = Res.Personage.Персонаж3;
            }
            if (Pers.Images == "Изображение4")
            {
                Perses = Res.Personage.Персонаж4;
            }
            if (Pers.Images == "Изображение5")
            {
                Perses = Res.Personage.Персонаж5;
            }
            if (Pers.Images == "Изображение6")
            {
                Perses = Res.Personage.Персонаж6;
            }
            if (Pers.Images == "Изображение7")
            {
                Perses = Res.Personage.Персонаж7;
            }



            Per.X = 256;
            Per.Y = 173;

            MessageBox.Show("Добро пожаловать в обучение игры Dark Wordl!","Приветствие");
            MessageBox.Show("В этом обучении вас научат как перемещатся по карте, использовать инвентарь, торговать, и сражаться с противниками.","Описание");
            ParagraphH();
            
        }

        private void Tutorial_Paint(object sender, PaintEventArgs e)
        {
            _Target.X = pic.Location.X;
            _Target.Y = pic.Location.Y;


            Graphics g = e.Graphics;
            g.DrawImage(Perses, new Rectangle(Per.X, Per.Y, 60, 60));
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pic.Enabled = true;


            pic = pictureBox1;
            pic.Enabled = false;


            Persona.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Per.X < _Target.X)
            {
                if ((_Target.X - Per.X) >= 15)
                {
                    if (Per.X < _Target.X)
                    {
                        Per.X = Per.X + 15;
                    }
                }
                else if ((_Target.X - Per.X) >= 5)
                {
                    if (Per.X < _Target.X)
                    {
                        Per.X = Per.X + 5;
                    }
                }
                else if ((_Target.X - Per.X) >= 1)
                {
                    if (Per.X < _Target.X)
                    {
                        Per.X = Per.X + 1;
                    }
                }
            }


            if (Per.X > _Target.X)
            {
                if ((Per.X - _Target.X) >= 15)
                {
                    if (Per.X > _Target.X)
                    {
                        Per.X = Per.X - 15;
                    }
                }
                else if ((Per.X - _Target.X) >= 5)
                {
                    if (Per.X > _Target.X)
                    {
                        Per.X = Per.X - 5;
                    }
                }
                else if ((Per.X - _Target.X) >= 1)
                {
                    if (Per.X > _Target.X)
                    {
                        Per.X = Per.X - 1;
                    }
                }
            }

            if (Per.Y < _Target.Y)
            {
                if ((_Target.Y - Per.Y) >= 15)
                {
                    if (Per.Y < _Target.Y)
                    {
                        Per.Y = Per.Y + 15;
                    }
                }
                else if ((_Target.Y - Per.Y) >= 5)
                {
                    if (Per.Y < _Target.Y)
                    {
                        Per.Y = Per.Y + 5;
                    }
                }
                else if ((_Target.Y - Per.Y) >= 1)
                {
                    if (Per.Y < _Target.Y)
                    {
                        Per.Y = Per.Y + 1;
                    }
                }
            }

            if (Per.Y > _Target.Y)
            {
                if ((Per.Y - _Target.Y) >= 15)
                {
                    if (Per.Y > _Target.Y)
                    {
                        Per.Y = Per.Y - 15;
                    }
                }
                else if ((Per.Y - _Target.Y) >= 5)
                {
                    if (Per.Y > _Target.Y)
                    {
                        Per.Y = Per.Y - 5;
                    }
                }
                else if ((Per.Y - _Target.Y) >= 1)
                {
                    if (Per.Y > _Target.Y)
                    {
                        Per.Y = Per.Y - 1;
                    }
                }
            }

            if (Per == _Target)
            {
                
                
                
                
                Persona.Enabled = false;
                ParagraphH();
            }



            Refresh();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pic.Enabled = true;


            pic = pictureBox2;
            pic.Enabled = false;


            Persona.Enabled = true;
            
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pic.Enabled = true;


            pic = pictureBox4;
            pic.Enabled = false;


            Persona.Enabled = true;
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pic.Enabled = true;


            pic = pictureBox3;
            pic.Enabled = false;


            Persona.Enabled = true;
            
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            pic.Enabled = true;


            pic = pictureBox5;
            pic.Enabled = false;


            Persona.Enabled = true;
            
        }

        void ParagraphH()
        {
            if (Per.X == 256 && Per.Y == 173)
            {
                label1.Text = $@"Пункт первый. Перемещение по карте.
Для того что бы персонаж перемещался по карте, необходимо нажимать 
курсором на области карты, которые помечаны квадратами.
После нажатия персонаж начнет движение к выбранной точке.
Нажмите на локацию 2";


                pictureBox3.Enabled = false;
                pictureBox4.Enabled = false;
                pictureBox5.Enabled = false;
            }
            if (Per.X == 267 && Per.Y == 382)
            {
                pictureBox3.Enabled = true;
                pictureBox4.Enabled = true;
                pictureBox5.Enabled = true;

                Бой lol = new Бой();
                lol.Show();
                this.Enabled = false;

                label1.Text = $@"Перейдите в локацию 3.";


                pictureBox1.Enabled = false;
                pictureBox3.Enabled = false;
                pictureBox5.Enabled = false;


                
            }
            if (Per.X == 364 && Per.Y == 472)
            {
                pictureBox1.Enabled = true;
                pictureBox3.Enabled = true;
                pictureBox5.Enabled = true;

                TradeShop kek = new TradeShop();
                kek.Show();
                this.Enabled = false;


                label1.Text = $@"Перейдите в локацию 4.";


                pictureBox1.Enabled = false;
                pictureBox2.Enabled = false;
                pictureBox5.Enabled = false;

            }
            if (Per.X == 435 && Per.Y == 279)
            {
                pictureBox1.Enabled = true;
                pictureBox2.Enabled = true;
                pictureBox5.Enabled = true;



                label1.Text = $@"В таверне любой деревне вы сможете 
найти задания, за их прохождения вы 
сможете получить экипировку, золото и опыт.
Перейдите в локацию 5.";


                pictureBox1.Enabled = false;
                pictureBox2.Enabled = false;
                pictureBox4.Enabled = false;

            }


            if (Per.X == 573 && Per.Y == 558)
            {
                pictureBox1.Enabled = true;
                pictureBox2.Enabled = true;
                pictureBox4.Enabled = true;



                label1.Text = $@"";

                DialogResult r = new DialogResult();
                r = MessageBox.Show("Ваше обучение закончено. Далее вы отправитесь покарять дивный мир игры 'Dark wordl' ", "Завершение", MessageBoxButtons.OK);
                if (r == DialogResult.OK)
                {
                    Tutorial.T = null;
                    ЯЯсеневыйЛес kekol = new ЯЯсеневыйЛес();
                    kekol.Show();
                    Hide();
                }


                pictureBox1.Enabled = false;
                pictureBox2.Enabled = false;
                pictureBox3.Enabled = false;

            }
        }
        
    }
}
