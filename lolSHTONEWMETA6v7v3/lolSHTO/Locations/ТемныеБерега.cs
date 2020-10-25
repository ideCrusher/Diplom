using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace lolSHTO
{
    public partial class ТемныеБерега : Form
    {
        int[] MassLVL = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
        int[] MassLVLEXP = { 100, 110, 120, 130, 140, 150, 160, 170, 180, 190, 200, 210, 220, 230, 240, 250, 260, 270, 280, 290 };


        static int first = 0;
        public static ТемныеБерега DC;


        public Bitmap Perses;

        private Point _Target = Point.Empty;
        private Point Per = Point.Empty;

        PictureBox pic = new PictureBox();


        public ТемныеБерега()
        {
            InitializeComponent();
        }

        private void ТемныеБерега_Load(object sender, EventArgs e)
        {
             

            pictureBox8.BackgroundImage = Res.Icon.Tower;
            pictureBox9.BackgroundImage = Res.Icon.Castle;
            pictureBox1.BackgroundImage = Res.Icon.TransitionBot;
            pictureBox17.BackgroundImage = Res.Icon.Ship;




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




            Ashenvale.a = Pers.Kletka;

            Per.X = Pers.picX;
            Per.Y = Pers.picY;
            Armor.Enabled = true;



            if (Quest.GotQuest[0] == 1)
            {
                first = 1;
            }


            Qwe();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DC = this;
            Инвентарь lol = new Инвентарь();
            lol.Show();

            button4.Enabled = false;
        }



        

        public void ArmorTick_Tick(object sender, EventArgs e)
        {
            Pers.DD = 0;
            Pers.Armor = 0;

            for (int j = 0; j < Inventar.Weapon.Length; j++)
            {
                if (Pers.WeaponItem == Inventar.Weapon[j])
                {
                    if (Inventar.Weapon[j] == "Оружие1")
                    {

                        Pers.DD = 5;
                    }
                    if (Inventar.Weapon[j] == "Оружие2")
                    {

                        Pers.DD = 10;
                    }
                    if (Inventar.Weapon[j] == "Оружие3")
                    {

                        Pers.DD = 15;
                    }
                    if (Inventar.Weapon[j] == "Оружие4")
                    {
                        Pers.DD = 20;
                    }
                    if (Inventar.Weapon[j] == "Оружие5")
                    {

                        Pers.DD = 25;
                    }

                    if (Inventar.Weapon[j] == "")
                    {

                        Pers.DD = 0;
                    }
                }
            }
            for (int o = 0; o < Inventar.Header.Length; o++)
            {
                if (Pers.HelmetItem == Inventar.Header[o])
                {
                    if (Inventar.Header[o] == "Голова1")
                    {

                        Pers.Armor = Pers.Armor + 3;
                    }
                    if (Inventar.Header[o] == "Голова2")
                    {

                        Pers.Armor = Pers.Armor + 5;
                    }
                    if (Inventar.Header[o] == "Голова3")
                    {

                        Pers.Armor = Pers.Armor + 7;
                    }
                    if (Inventar.Header[o] == "Голова4")
                    {

                        Pers.Armor = Pers.Armor + 9;
                    }
                    if (Inventar.Header[o] == "Голова5")
                    {

                        Pers.Armor = Pers.Armor + 11;
                    }
                    if (Inventar.Header[o] == "")
                    {

                        Pers.Armor = Pers.Armor + 0;
                    }

                }

            }
            for (int p = 0; p < Inventar.Main.Length; p++)
            {
                if (Pers.ArmorItem == Inventar.Main[p])
                {
                    if (Inventar.Main[p] == "Броня1")
                    {

                        Pers.Armor = Pers.Armor + 5;
                    }
                    if (Inventar.Main[p] == "Броня2")
                    {

                        Pers.Armor = Pers.Armor + 8;
                    }
                    if (Inventar.Main[p] == "Броня3")
                    {

                        Pers.Armor = Pers.Armor + 11;
                    }
                    if (Inventar.Main[p] == "Броня4")
                    {

                        Pers.Armor = Pers.Armor + 14;
                    }
                    if (Inventar.Main[p] == "Броня5")
                    {

                        Pers.Armor = Pers.Armor + 17;
                    }

                    if (Inventar.Main[p] == "")
                    {

                        Pers.Armor = Pers.Armor + 0;
                    }
                }
            }
            for (int u = 0; u < Inventar.Footer.Length; u++)
            {
                if (Pers.BootsItem == Inventar.Footer[u])
                {
                    if (Inventar.Footer[u] == "Ноги1")
                    {

                        Pers.Armor = Pers.Armor + 2;
                    }
                    if (Inventar.Footer[u] == "Ноги2")
                    {

                        Pers.Armor = Pers.Armor + 4;
                    }
                    if (Inventar.Footer[u] == "Ноги3")
                    {

                        Pers.Armor = Pers.Armor + 6;
                    }
                    if (Inventar.Footer[u] == "Ноги4")
                    {

                        Pers.Armor = Pers.Armor + 8;
                    }
                    if (Inventar.Footer[u] == "Ноги5")
                    {

                        Pers.Armor = Pers.Armor + 10;
                    }
                    if (Inventar.Footer[u] == "")
                    {

                        Pers.Armor = Pers.Armor + 0;
                    }


                }
            }

            Armor.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            Персонаж lol = new Персонаж();
            DC = this;

            lol.Show();
        }

        private void ТемныеБерега_Paint(object sender, PaintEventArgs e)
        {
            _Target.X = pic.Location.X;
            _Target.Y = pic.Location.Y;





            Graphics g = e.Graphics;
            g.DrawImage(Perses, new Rectangle(Per.X, Per.Y, 50, 50));
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            pic.Enabled = true;

            pic = pictureBox10;
            pic.Enabled = false;

            Persona.Enabled = true;
        }

        private void picFALSE()
        {
            pictureBox1.Enabled = false;
            pictureBox2.Enabled = false;
            pictureBox3.Enabled = false;
            pictureBox4.Enabled = false;
            pictureBox5.Enabled = false;
            pictureBox6.Enabled = false;
            pictureBox7.Enabled = false;
            pictureBox8.Enabled = false;
            pictureBox9.Enabled = false;
            pictureBox10.Enabled = false;
            pictureBox11.Enabled = false;
            pictureBox12.Enabled = false;
            pictureBox13.Enabled = false;
            pictureBox14.Enabled = false;
            pictureBox15.Enabled = false;
            pictureBox16.Enabled = false;
            pictureBox17.Enabled = false;
            pictureBox18.Enabled = false;

        }

        private void picTRUE()
        {
            pictureBox1.Enabled = true;
            pictureBox2.Enabled = true;
            pictureBox3.Enabled = true;
            pictureBox4.Enabled = true;
            pictureBox5.Enabled = true;
            pictureBox6.Enabled = true;
            pictureBox7.Enabled = true;
            pictureBox8.Enabled = true;
            pictureBox9.Enabled = true;
            pictureBox10.Enabled = true;
            pictureBox11.Enabled = true;
            pictureBox12.Enabled = true;
            pictureBox13.Enabled = true;
            pictureBox14.Enabled = true;
            pictureBox15.Enabled = true;
            pictureBox16.Enabled = true;
            pictureBox17.Enabled = true;
            pictureBox18.Enabled = true;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            picFALSE();
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
                Qwe();
                picTRUE();
                Pers.picX = Per.X;
                Pers.picY = Per.Y;
                hod.Enabled = true;
                Persona.Enabled = false;
            }



            Refresh();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pic.Enabled = true;

            pic = pictureBox1;
            pic.Enabled = false;



            Persona.Enabled = true;

            
        }

        private void hod_Tick(object sender, EventArgs e)
        {
            Heal();
            Going();
        }

        private void Qwe()
        {


            listBox2.Items.Insert(0, Convert.ToString(Pers.Name));
            listBox2.Items.Insert(1, Convert.ToString(Pers.Images));
            listBox2.Items.Insert(2, Convert.ToString(Pers.Strength));
            listBox2.Items.Insert(3, Convert.ToString(Pers.Agility));
            listBox2.Items.Insert(4, Convert.ToString(Pers.Intellect));
            listBox2.Items.Insert(5, Convert.ToString(Pers.Stamina));
            listBox2.Items.Insert(6, Convert.ToString(Pers.LVL));
            listBox2.Items.Insert(7, Convert.ToString(Pers.EXP));
            listBox2.Items.Insert(8, Convert.ToString(Pers.Location));
            listBox2.Items.Insert(9, Convert.ToString(Pers.Kletka));
            listBox2.Items.Insert(10, Convert.ToString(Pers.HP));
            listBox2.Items.Insert(11, Convert.ToString(Pers.picX));
            listBox2.Items.Insert(12, Convert.ToString(Pers.picY));
            listBox2.Items.Insert(13, Convert.ToString(Pers.Gold));
            listBox2.Items.Insert(14, Convert.ToString(80 + (Pers.Strength * 5)));
            listBox2.Items.Insert(15, Convert.ToString(Pers.HelmetItem));
            listBox2.Items.Insert(16, Convert.ToString(Pers.ArmorItem));
            listBox2.Items.Insert(17, Convert.ToString(Pers.BootsItem));
            listBox2.Items.Insert(18, Convert.ToString(Pers.WeaponItem));

            StreamWriter SavevFile = new StreamWriter($"{Pers.Name}/PersSave.txt");
            foreach (var item in listBox2.Items)
            {
                SavevFile.WriteLine(item);
            }

            SavevFile.Close();
            listBox2.Items.Clear();


            listBox3.Items.Insert(0, Quest.QuestActive);
            listBox3.Items.Insert(1, Quest.QuestActiveCondition);
            listBox3.Items.Insert(2, Quest.QuestTrue);
            listBox3.Items.Insert(3, Quest.GotQuest[0]);
            listBox3.Items.Insert(4, Quest.GotQuest[1]);
            listBox3.Items.Insert(5, Quest.GotQuest[2]);
            listBox3.Items.Insert(6, Quest.GotQuest[3]);
            listBox3.Items.Insert(7, Quest.GotQuest[4]);
            listBox3.Items.Insert(8, Pers.Guild);


            StreamWriter SaveFile = new StreamWriter($"{Pers.Name}/GameSave.txt");
            foreach (var item in listBox3.Items)
            {
                SaveFile.WriteLine(item);
            }

            SaveFile.Close();


            listBox3.Items.Clear(); ;


            StreamWriter asdf = new StreamWriter("LostSave.txt");
            asdf.WriteLine(Pers.Name);
            asdf.Close();



        }

        private void Heal()
        {
            if (Pers.HP != Pers.HPMax)
            {
                if ((Pers.HPMax - Pers.HP) > 10)
                {
                    Pers.HP = Pers.HP + 10;
                }
                else if ((Pers.HPMax - Pers.HP) > 5)
                {
                    Pers.HP = Pers.HP + 5;
                }
                else if ((Pers.HPMax - Pers.HP) > 1)
                {
                    Pers.HP = Pers.HP + 5;
                }
            }
        }

        private void Going()
        {
            hod.Enabled = false;
            if (Per.X == 425 && Per.Y == 138)
            {
                DialogResult lol = new DialogResult();
                lol = MessageBox.Show("Поднятся в башню стражи?", "Переход", MessageBoxButtons.OKCancel);
                if (lol == DialogResult.OK)
                {
                    DC = this;

                    Tavern kek = new Tavern();
                    kek.Show();
                    this.Enabled = false;
                }
            }

            if (Per.X == 481 && Per.Y == 106)
            {
                if (first == 1)
                {
                    DialogResult lol = new DialogResult();
                    lol = MessageBox.Show("Зайти в город?", "Переход", MessageBoxButtons.OKCancel);
                    if (lol == DialogResult.OK)
                    {
                        Qwe();

                        CastleDC kek = new CastleDC();
                        kek.Show();
                        Hide();
                    }

                }
                else
                {
                    MessageBox.Show("Для прохода в город вам нужно пройти задания в Сторожевой башне!");
                    return;
                }
            }


            if (Per.X == 218 && Per.Y == 622)
            {
                DialogResult lol = new DialogResult();
                lol = MessageBox.Show("Вы хотите перейти на локацию Ясеневый лес?", "Переход", MessageBoxButtons.OKCancel);
                if (lol == DialogResult.OK)
                {
                    DC = null;
                    Pers.picX = 232;
                    Pers.picY = 46;
                    Pers.Location = "ЯЯсеневыйЛес";

                    ЯЯсеневыйЛес kek = new ЯЯсеневыйЛес();
                    kek.Show();

                    Hide();
                }
                return;
            }
            if(Per.X == 98 && Per.Y == 318)
            {
                DialogResult lol = new DialogResult();
                lol = MessageBox.Show("Вы хотите перейти на локацию Обломки корабля?", "Переход", MessageBoxButtons.OKCancel);
                if (lol == DialogResult.OK)
                {
                    WreckageShip pop = new WreckageShip();
                    pop.Show();

                    Hide();
                }
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            pic.Enabled = true;


            pic = pictureBox9;
            pic.Enabled = false;


            Persona.Enabled = true;
        }

        private void LVLING_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < MassLVL.Length; i++)
            {
                if (Pers.LVL == MassLVL[i])
                {
                    if (Pers.EXP >= MassLVLEXP[i])
                    {
                        Pers.EXP = Pers.EXP - MassLVLEXP[i];
                        Pers.LVL = Pers.LVL + 1;
                        Pers.Ochko = Pers.Ochko + 1;
                    }
                }
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            pic.Enabled = true;


            pic = pictureBox8;
            pic.Enabled = false;


            Persona.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Qwe();
            MainMenu lol = new MainMenu();
            lol.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pic.Enabled = true;


            pic = pictureBox2;
            pic.Enabled = false;


            Persona.Enabled = true;
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            pic.Enabled = true;


            pic = pictureBox11;
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

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pic.Enabled = true;


            pic = pictureBox4;
            pic.Enabled = false;


            Persona.Enabled = true;
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            pic.Enabled = true;


            pic = pictureBox13;
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

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            pic.Enabled = true;


            pic = pictureBox14;
            pic.Enabled = false;


            Persona.Enabled = true;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            pic.Enabled = true;


            pic = pictureBox6;
            pic.Enabled = false;


            Persona.Enabled = true;
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            pic.Enabled = true;


            pic = pictureBox15;
            pic.Enabled = false;


            Persona.Enabled = true;
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            pic.Enabled = true;


            pic = pictureBox18;
            pic.Enabled = false;


            Persona.Enabled = true;
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            pic.Enabled = true;


            pic = pictureBox16;
            pic.Enabled = false;


            Persona.Enabled = true;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            pic.Enabled = true;


            pic = pictureBox7;
            pic.Enabled = false;


            Persona.Enabled = true;
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            pic.Enabled = true;


            pic = pictureBox12;
            pic.Enabled = false;


            Persona.Enabled = true;
        }

        private void Transit_Tick(object sender, EventArgs e)
        {
            
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            pic.Enabled = true;


            pic = pictureBox17;
            pic.Enabled = false;


            Persona.Enabled = true;
        }
    }
}
