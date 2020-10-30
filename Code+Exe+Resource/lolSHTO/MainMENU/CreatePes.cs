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
    public partial class CreatePes : Form
    {

        public static int i;
        public CreatePes()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (StreamReader sr = new StreamReader("allPers.txt"))
            {
                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    listBox1.Items.Add(line);
                }
                sr.Close();
            }


            i = Convert.ToInt32(label8.Text);

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        //Распределение очков талантов
        private void timer1_Tick(object sender, EventArgs e)
        {

           
            if (Convert.ToInt32(label8.Text) > 0)
            {

                

                numericUpDown1.Maximum = Convert.ToInt32(label8.Text) + numericUpDown1.Value;
                numericUpDown2.Maximum = Convert.ToInt32(label8.Text) + numericUpDown2.Value; 
                numericUpDown3.Maximum = Convert.ToInt32(label8.Text) + numericUpDown3.Value; 
                numericUpDown4.Maximum = Convert.ToInt32(label8.Text) + numericUpDown4.Value;

            }

            if (Convert.ToInt32(label8.Text) >= 0)
            {
                if ((Convert.ToInt32(numericUpDown1.Text) + Convert.ToInt32(numericUpDown2.Text) + Convert.ToInt32(numericUpDown3.Text) + Convert.ToInt32(numericUpDown4.Text)) <= 20)
                {
                    label8.Text = Convert.ToString(i - (Convert.ToInt32(numericUpDown1.Text) + Convert.ToInt32(numericUpDown2.Text) + Convert.ToInt32(numericUpDown3.Text) + Convert.ToInt32(numericUpDown4.Text)));
                }
            }

            if (Convert.ToInt32(label8.Text) == 0)
            {
                numericUpDown1.Maximum = numericUpDown1.Value;
                numericUpDown2.Maximum = numericUpDown2.Value;
                numericUpDown3.Maximum = numericUpDown3.Value;
                numericUpDown4.Maximum = numericUpDown4.Value;
            }
            stats.Enabled = false;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            stats.Enabled = true;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            stats.Enabled = true;
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            stats.Enabled = true;
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            stats.Enabled = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            images.Enabled = true;
        }

        private void images_Tick(object sender, EventArgs e)
        {
            if(comboBox1.Text == "Изображение1")
            {
                pictureBox1.BackgroundImage = Res.Personage.Изображение1;
            }
            if (comboBox1.Text == "Изображение2")
            {
                pictureBox1.BackgroundImage = Res.Personage.Изображение2;
            }
            if (comboBox1.Text == "Изображение3")
            {
                pictureBox1.BackgroundImage = Res.Personage.Изображение3;
            }
            if (comboBox1.Text == "Изображение4")
            {
                pictureBox1.BackgroundImage = Res.Personage.Изображение4;
            }
            if (comboBox1.Text == "Изображение5")
            {
                pictureBox1.BackgroundImage = Res.Personage.Изображение5;
            }
            if (comboBox1.Text == "Изображение6")
            {
                pictureBox1.BackgroundImage = Res.Personage.Изображение6;
            }
            if (comboBox1.Text == "Изображение7")
            {
                pictureBox1.BackgroundImage = Res.Personage.Изображение7;
            }
            images.Enabled = false;
        }
        //Создание папки персонажа и записи в базе данных
        private void button1_Click_1(object sender, EventArgs e)
        {
            
            if (textBox1.Text != "")
            {
                if (Convert.ToInt32(label8.Text) == 0)
                {




                    


                    listBox1.Items.Add($"{textBox1.Text}");


                    var allPers = new StreamWriter("allPers.txt");
                    foreach (var item in listBox1.Items)
                    {
                        allPers.WriteLine(item);
                    }
                    allPers.Close();


                    



                    Directory.CreateDirectory($"{textBox1.Text}");                   
                    File.Create($"{textBox1.Text}/INVENTAR.txt");


                    StreamWriter GameSave = new StreamWriter($"{textBox1.Text}/GameSave.txt");
                    GameSave.WriteLine("");
                    GameSave.WriteLine(0);
                    GameSave.WriteLine("");
                    GameSave.WriteLine(0);
                    GameSave.WriteLine(0);
                    GameSave.WriteLine(0);
                    GameSave.WriteLine(0);
                    GameSave.WriteLine(0);
                    GameSave.Close();




                    Pers.Name = textBox1.Text;
                    Pers.Images = comboBox1.Text;

                    Pers.Strength = Convert.ToInt32(numericUpDown1.Value);
                    Pers.Agility = Convert.ToInt32(numericUpDown2.Value);
                    Pers.Intellect = Convert.ToInt32(numericUpDown3.Value);
                    Pers.Stamina = Convert.ToInt32(numericUpDown4.Value);

                    Pers.LVL = 1;
                    Pers.EXP = 0;

                    Pers.Location = "ЯЯсеневыйЛес";
                    Pers.Kletka = 14;

                    Pers.HP = 80 + (Convert.ToInt32(numericUpDown1.Value) * 5);

                    Pers.picX = 314;
                    Pers.picY = 272;

                    Pers.Gold = 15;

                    Pers.HPMax = 80 + (Convert.ToInt32(numericUpDown1.Value) * 5);
                    
                    Pers.DD = 5;
                    Pers.Armor = Pers.Armor + 3;
                    Pers.Armor = Pers.Armor + 5;
                    Pers.Armor = Pers.Armor + 2;

                    Pers.HelmetItem = "Голова1";
                    Pers.ArmorItem = "Броня1";
                    Pers.BootsItem = "Ноги1";
                    Pers.WeaponItem = "Оружие1";


                    Quest.QuestActive = "";
                    Quest.QuestActiveCondition = 0;
                    Quest.QuestTrue = "";
                    Quest.GotQuest[0] = 0;
                    Quest.GotQuest[1] = 0;
                    Quest.GotQuest[2] = 0;
                    Quest.GotQuest[3] = 0;
                    Quest.GotQuest[4] = 0;
                    Pers.Guild = "";
                    
                    DialogResult r = new DialogResult();
                    r = MessageBox.Show("Желаете пройти обучение?","Система",MessageBoxButtons.YesNo);
                    if (r == DialogResult.Yes)
                    {
                        Tutorial lol = new Tutorial();
                        lol.Show();
                    }
                    if(r == DialogResult.No) 
                    {
                        ЯЯсеневыйЛес Y = new ЯЯсеневыйЛес();
                        Y.Show();
                    }

                    Hide();
                }
                else
                {
                    MessageBox.Show("У вас еще остались не распределенные очки умений!");
                }
            }
            else
            {
                MessageBox.Show("Введите имя персонажа");
            }


        }

        private void персонажBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainMenu lol = new MainMenu();
            lol.Show();

            Hide();
        }
    }
}
