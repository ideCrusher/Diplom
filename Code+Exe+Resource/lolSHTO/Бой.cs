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
    public partial class Бой : Form
    {
        
        int o = 0;
        int A2=0, A3=0, A4=0;


        int ShmotD = 0;
        int DM = 0, Armor = 0;

        int HPbarEny, HPbarMe;



        public static Бой fight;
        public Бой()
        {
            InitializeComponent();
        }

        private void Бой_Load(object sender, EventArgs e)
        {
            label3.Text = Pers.Name;

            int i;
            Random rnd1 = new Random();         
            i = rnd1.Next(1, 4);
            if(i == 1)
            {
                pictureBox2.BackgroundImage = Res.Rouge.Бандит1;
            }
            if (i == 2)
            {
                pictureBox2.BackgroundImage = Res.Rouge.Бандит2;
            }
            if (i == 3)
            {
                pictureBox2.BackgroundImage = Res.Rouge.Бандит3;
            }
            if (i == 4)
            {
                pictureBox2.BackgroundImage = Res.Rouge.Бандит4;
            }

                
            

            if (ЯЯсеневыйЛес.YLes != null)
            {
                label2.Text = Convert.ToString(Разбойник.HP);
                pictureBox4.Width = Разбойник.HP;
                pictureBox6.Width = Разбойник.HP;
                HPbarEny = Разбойник.HP;
            }
            if (GameSave.Fight == "SW" && WreckageShip.WS != null)
            {
                label2.Text = Convert.ToString(Разбойник.HP/2);
                pictureBox4.Width = Разбойник.HP / 2;
                pictureBox6.Width = Разбойник.HP / 2;
                HPbarEny = Разбойник.HP / 2;
            }
            if ( WreckageShip.WS != null)
            {
                label2.Text = Convert.ToString(Разбойник.HP / 2);
                pictureBox4.Width = Разбойник.HP / 2;
                pictureBox6.Width = Разбойник.HP / 2;
                HPbarEny = Разбойник.HP / 2;
            }
            if( Tutorial.T != null)
            {
                button8.Enabled = false;
                button5.Enabled = false;
                Tutorial.F = 1;



                label2.Text = Convert.ToString(100);
                pictureBox4.Width = 5;
                pictureBox6.Width = 5;
                HPbarEny = 100;

                label5.Visible = true;
                label5.Text = $@"Сражайтесь с противником через кнопки атаки,
которые расположены нижи. Обычные атаки наносят 
урон который зависит от вашей силы.";
                this.ControlBox = true;
            }

            


            if (Pers.Images == "Изображение1")
            {
                pictureBox1.BackgroundImage = Res.Personage.Персонаж1;
            }
            if (Pers.Images == "Изображение2")
            {
                pictureBox1.BackgroundImage = Res.Personage.Персонаж2;
            }
            if (Pers.Images == "Изображение3")
            {
                pictureBox1.BackgroundImage = Res.Personage.Персонаж3;
            }
            if (Pers.Images == "Изображение4")
            {
                pictureBox1.BackgroundImage = Res.Personage.Персонаж4;
            }
            if (Pers.Images == "Изображение5")
            {
                pictureBox1.BackgroundImage = Res.Personage.Персонаж5;
            }
            if (Pers.Images == "Изображение6")
            {
                pictureBox1.BackgroundImage = Res.Personage.Персонаж6;
            }
            if (Pers.Images == "Изображение7")
            {
                pictureBox1.BackgroundImage = Res.Personage.Персонаж7;
            }


            label1.Text = Convert.ToString(Pers.HP);
            pictureBox3.Width = Pers.HP;
            pictureBox5.Width = Pers.HP;
            HPbarMe = Pers.HP;



            DM = (((Pers.Strength*10) * 14)/100) + Pers.DD + 5;
            Armor = (((Pers.Agility*10) * 12)/100) + (((Pers.Armor * 10) * 7)/100);
            

        }

        

        

        public void Button4_Click(object sender, EventArgs e)
        {
            if (label5.Visible == true)
            {
                label5.Text = $@"Обычные атаки наносят урон который 
зависит от вашей силы и урона оружия.";
            }



            button4.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;


           
            Атака.Enabled = true;


        }     

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (o==0)
            {

                int i = 0,j=0,h=0;
                
                Random rnd = new Random();

                j = rnd.Next(1,10);
                

                    if(j == 1)
                    {
                        i = rnd.Next(15, 25);

                        i = ((i*10) * 12)/100;
                        h = i - (((Pers.Armor * 10) * 7) / 100);
                        listBox1.Items.Insert(0, "Противник наносит критический удар " + h + " урона");
                        listBox1.Items.RemoveAt(10);
                    }
                    if(j == 2)
                    {
                        listBox1.Items.Insert(0, "Противник промазал");
                        listBox1.Items.RemoveAt(10);
                    }
                    if(j > 2)
                    {
                        i = rnd.Next(15, 25);
                        h = i - (((Pers.Armor * 10)*7)/ 100);

                        listBox1.Items.Insert(0, "Противник наносит "+h+" урона");
                        listBox1.Items.RemoveAt(10);
                    }

               

                label1.Text = Convert.ToString(Convert.ToInt32(label1.Text) - h);
                HPbarMe= HPbarMe - h;
                pictureBox5.Width = HPbarMe;
                pictureBox5.Refresh();



                if (A2 > 0)
                {
                    A2 = A2 - 1;
                }
                if (A3 > 0)
                {
                    A3 = A3 - 1;
                }
                if (A4 > 0)
                {
                    A4 = A4 - 1;
                }



                button4.Enabled = true;
                if (A2 == 0)
                {
                    button6.Enabled = true;
                }
                if (A3 == 0)
                {
                    button7.Enabled = true;
                }
                if (A4 == 0)
                {
                    button8.Enabled = true;
                }
                Противник.Enabled = false;


                if(Convert.ToInt32(label1.Text)<=0)
                {
                    
                    button4.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    listBox1.Enabled = false;


                    Поражение.Enabled = true;
                }
                if(Convert.ToInt32(label1.Text)>0)
                {
                    button4.Enabled = true;
                    if (A2 == 0)
                    {
                        button6.Enabled = true;
                    }
                    if (A3 == 0)
                    {
                        button7.Enabled = true;
                    }
                    if (A4 == 0)
                    {
                        button8.Enabled = true;
                    }
                    Противник.Enabled = false;

                }

            }
            if(o>0)
            {
                listBox1.Items.Insert(0, "Противник пропускает 1 ход");
                listBox1.Items.RemoveAt(10);
                o=o-1;


                if (A2 > 0)
                {
                    A2 = A2 - 1;
                }
                if (A3 > 0)
                {
                    A3 = A3 - 1;
                }
                if (A4 > 0)
                {
                    A4 = A4 - 1;
                }



                button4.Enabled = true;
                if (A2 == 0)
                {
                    button6.Enabled = true;
                }
                if (A3 == 0)
                {
                    button7.Enabled = true;
                }
                if (A4 == 0)
                {
                    button8.Enabled = true;
                }
                Противник.Enabled = false;
            }          
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            // Функция обычной атаки противника

            int d = 0, m=0;

            // Подсчет наносимого урона
            int min = ((DM * 100) / 125), max = ((DM * 100) / 75);
            Random ra = new Random();
            d = ra.Next(min,max) ;

            // Подсчет брони противника которая частично блокирует урон
            int Yron = d - (((Разбойник.Armor*10)*7)/100);
            Random rkf = new Random();

            //Выполнение условий нанесения урона\критического урона\промаха
            m = rkf.Next(1, 10);
            if (m > 2)
            {
                label2.Text = Convert.ToString(Convert.ToInt32(label2.Text) - Yron);
                HPbarEny = HPbarEny - Yron;
                pictureBox6.Width = HPbarEny;
                pictureBox6.Refresh();
                listBox1.Items.Insert(0, $"Вы наносите { Yron } урона");
                listBox1.Items.RemoveAt(10);
            }
            if (m == 1)
            {
                Yron = ((Yron * 10) * 12) / 100;
                label2.Text = Convert.ToString(Convert.ToInt32(label2.Text) - Yron);
                HPbarEny = HPbarEny - Yron;
                pictureBox6.Width = HPbarEny;
                pictureBox6.Refresh();
                listBox1.Items.Insert(0, $"Вы наносите критический удар { Yron } урона");
                listBox1.Items.RemoveAt(10);
            }
            if (m == 2)
            {
                
                listBox1.Items.Insert(0, $"Вы промахиваетесь");
                listBox1.Items.RemoveAt(10);
            }



            if (Convert.ToInt32(label2.Text) <= 0)
            {
                Атака.Enabled = false;
                Победа.Enabled = true;
            }
            if (Convert.ToInt32(label2.Text)>0)
            {
                Атака.Enabled = false;
                Противник.Enabled = true;
            }
            
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            if (label5.Visible == true)
            {
                label5.Text = $@"Коварный удра наносит повышеный урон,
но перезарежается 1 ход.";
            }

            button4.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;

            A2 = A2 + 3;

            КоварныйУдар.Enabled = true;
        }

        private void Timer3_Tick(object sender, EventArgs e)
        {
            int d = 0, m = 0;
            int min = ((DM * 100) / 125)+5, max = ((DM * 100) / 75)+5;
            Random ra = new Random();
            d = ra.Next(min, max);

            int Yron = d - (((Разбойник.Armor * 10) * 7) / 100);
            Random rkf = new Random();

            m = rkf.Next(1, 10);
            if (m > 2)
            {
                label2.Text = Convert.ToString(Convert.ToInt32(label2.Text) - Yron);
                HPbarEny = HPbarEny - Yron;
                pictureBox6.Width = HPbarEny;
                pictureBox6.Refresh();
                listBox1.Items.Insert(0, $"Вы наносите { Yron } урона");
                listBox1.Items.RemoveAt(10);
            }
            if (m == 1)
            {
                Yron = ((Yron * 10) * 12) / 100;
                label2.Text = Convert.ToString(Convert.ToInt32(label2.Text) - Yron);
                HPbarEny = HPbarEny - Yron;
                pictureBox6.Width = HPbarEny;
                pictureBox6.Refresh();
                listBox1.Items.Insert(0, $"Вы наносите критический удар { Yron } урона");
                listBox1.Items.RemoveAt(10);
            }
            if (m == 2)
            {

                listBox1.Items.Insert(0, $"Вы промахиваетесь");
                listBox1.Items.RemoveAt(10);
            }



            if (Convert.ToInt32(label2.Text) <= 0)
            {
                КоварныйУдар.Enabled = false;
                Победа.Enabled = true;
            }
            if (Convert.ToInt32(label2.Text) > 0)
            {
                КоварныйУдар.Enabled = false;
                Противник.Enabled = true;
            }          
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            if (label5.Visible == true)
            {
                label5.Text = $@"Парализует противника на 2 хода, 
противник пропустит 2 хода.";
            }
            button4.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;

            A3 = A3 + 4;

            ПарализующийУдар.Enabled = true;
        }

        private void Button8_Click(object sender, EventArgs e)
        {

        }

        private void Победа_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = true;

            
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;

            listBox1.Enabled = false;


            Pers.HP = Convert.ToInt32(label1.Text);

            DialogResult lol = new DialogResult();
            lol = MessageBox.Show("Вы выйграли. Ваша награда: 10 опыта и 5 золотых монет.","Победа",MessageBoxButtons.OK);
            if(lol==DialogResult.OK)
            {

                Random Gold = new Random();
                Random Exp = new Random();

                Pers.Gold = Pers.Gold + Gold.Next(7, 15);
                Pers.EXP = Pers.EXP + (Exp.Next(6, 11));
                if (ЯЯсеневыйЛес.YLes != null && SawmillYL.SW == null)
                {
                    ЯЯсеневыйЛес.YLes.Enabled = true;
                }
                if(SawmillYL.SW != null)
                {
                    Quest.QuestActiveCondition = Quest.QuestActiveCondition + 1 ;
                    SawmillYL.SW.Enabled = true;
                    SawmillYL.pic.Visible = false;
                    SawmillYL.pic = null;
                    GameSave.Fight = "";
                    for(int i =0; i<Quest.QuestYL.Length;i++ )
                    {
                        if(Quest.QuestYL[i]==Quest.QuestActive)
                        {
                            if(Quest.QuestActiveCondition == Quest.QuestCondition[i])
                            {
                                Quest.QuestTrue = Quest.QuestActive;
                                Quest.QuestActive = "";
                            }
                        }


                    }
                }
                if(WreckageShip.WS != null)
                {
                    WreckageShip.WS.Enabled = true;
                    Quest.QuestActiveCondition = Quest.QuestActiveCondition + 1;
                    WreckageShip.WS.Enemy.Items.RemoveAt(WreckageShip.WS.Enemy.Items.Count-1);
                    
                }

                if (Tutorial.T != null)
                {
                    Pers.HP = Pers.HPMax;


                    Tutorial.T.Enabled = true;
                }


                Hide();
            }                               
        }

        private void Поражение_Tick(object sender, EventArgs e)
        {

            timer1.Enabled = true;

            
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;

            listBox1.Enabled = false;


            

            DialogResult lol = new DialogResult();
            lol = MessageBox.Show("Вы проиграли. Ваша награда: 2 опыта", "Поражение", MessageBoxButtons.OK);
            if (lol == DialogResult.OK)
            {
               
                Random Exp = new Random();
               
                Pers.EXP = Pers.EXP + (Exp.Next(2, 4));
                Pers.HP = 10;
                if (GameSave.Fight != "SW")
                {
                    ЯЯсеневыйЛес.YLes.Enabled = true;
                }
                if (GameSave.Fight == "SW")
                {
                    SawmillYL.SW.Enabled = true;
                    SawmillYL.pic = null;
                    GameSave.Fight = "";
                }

                Hide();
            }
        }

        private void Timer1_Tick_1(object sender, EventArgs e)
        {
            Победа.Enabled = false;
            Поражение.Enabled = false;

          
            timer1.Enabled = false;
        }

        private void Бой_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Tutorial.T != null)
            {
                Tutorial.T.Enabled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

            DialogResult lol = new DialogResult();
            lol = MessageBox.Show("Вы точно хотите сбежать?", "Поражение", MessageBoxButtons.YesNo);
            if (lol == DialogResult.Yes)
            {
                Поражение.Enabled = true;
            }
            if (lol == DialogResult.No)
            {
                
            }




            
        }

        private void ПарализующийУдар_Tick(object sender, EventArgs e)
        {
            int i = 2;
            Random rnd = new Random();
            int j = rnd.Next(1,99);
            if (j>25)
            {
                o =o+2;

                label2.Text = Convert.ToString(Convert.ToInt32(label2.Text) - i);
                listBox1.Items.Insert(0, "Вы парализуете врага и наносите " + i + " урона");
                listBox1.Items.RemoveAt(10);

                o = o - 1;
                ПарализующийУдар.Enabled = false;
                if (Convert.ToInt32(label2.Text) <= 0)
                {                  
                    Победа.Enabled = true;
                }
                if (Convert.ToInt32(label2.Text) > 0)
                {                                    
                    ПротивникСтан.Enabled = true;
                }              
            }
            
            if (j <= 25)
            {
                
                listBox1.Items.Insert(0, "Промах");
                listBox1.Items.RemoveAt(10);
                ПарализующийУдар.Enabled = false;
                Противник.Enabled = true;

            } 
        }

        private void ПротивникСтан_Tick(object sender, EventArgs e)
        {      
            listBox1.Items.Insert(0, "Противник пропускает 2 хода");
            listBox1.Items.RemoveAt(10);
            if (A2 > 0)
            {
                A2 = A2 - 1;
            }
            if (A3 > 0)
            {
                A3 = A3 - 1;
            }
            if (A4 > 0)
            {
                A4 = A4 - 1;
            }

            button4.Enabled = true;
            if (A2 == 0)
            {
                button6.Enabled = true;
            }
            if (A3 == 0)
            {
                button7.Enabled = true;
            }
            if (A4 == 0)
            {
                button8.Enabled = true;
            }
            ПротивникСтан.Enabled = false;
        }
    }
}
