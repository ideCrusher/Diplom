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
    public partial class WreckageShip : Form
    {
        public static WreckageShip WS;
        public WreckageShip()
        {
            InitializeComponent();
        }

        private void WreckageShip_Load(object sender, EventArgs e)
        {
            using (StreamReader sr = new StreamReader($"{Pers.Name}/INVENTAR.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    listBox1.Items.Add(line);
                }
                sr.Close();
            }



            WS = this;

            pictureBox1.BackgroundImage = DarkCoastPack.ResDC.Ship;

            label1.Text = $@"Одно из напоминаний о войне которая бушевала 
в этих краях 20 лет назад.Флагман Морской стражи 
был поврежден и терпел крушение 
Теперь его обломки служат убежищем путникам 
или бандитам.";


            Quest.QuestActive = "3.Доверие";


            if (Quest.QuestActive == "3.Доверие")
            {
                
                Enemy.Items.Add("Разбойник");
                Enemy.Items.Add("Разбойник");

                Loot.Items.Add("Учетная книга");


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Enemy.Visible == false)
            {
                Enemy.Visible = true;
                Loot.Visible = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Loot.Visible == false)
            {
                Loot.Visible = true;
                Enemy.Visible = false;
            }
        }

        public void Enemy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(Convert.ToString(Enemy.SelectedItem) == "Разбойник")
            {
                Text.Text = $@"Мерзкий тип";
                button3.Text = "Атаковать";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text == "Атаковать")
            {
                Бой lol = new Бой();
                lol.Show();
                this.Enabled = false;
            }
            if (Quest.QuestActiveCondition == 2)
            {
                if (button3.Text == "Взять")
                {
                    listBox1.Items.Add(Convert.ToString(Loot.SelectedItem));
                    Loot.Items.RemoveAt(Loot.SelectedIndex);
                    Quest.QuestTrue = "3.Доверие";

                    MessageBox.Show("Сначала перебейте всех разбойников!");
                }
            }
            else
            {
                if (button3.Text == "Взять")
                {
                    

                    MessageBox.Show("Сначала перебейте всех разбойников!");
                }
            }
        }

        private void WreckageShip_FormClosed(object sender, FormClosedEventArgs e)
        {
            StreamWriter SaveFile = new StreamWriter($"{Pers.Name}/INVENTAR.txt");
            foreach (var item in listBox1.Items)
            {
                SaveFile.WriteLine(item);
            }

            SaveFile.Close();

            WS = null;

            ТемныеБерега lol = new ТемныеБерега();
            lol.Show();
            Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            StreamWriter SaveFile = new StreamWriter($"{Pers.Name}/INVENTAR.txt");
            foreach (var item in listBox1.Items)
            {
                SaveFile.WriteLine(item);
            }

            SaveFile.Close();

            WS = null;

            ТемныеБерега lol = new ТемныеБерега();
            lol.Show();
            Hide();
        }

        private void Loot_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Convert.ToString(Loot.SelectedItem) == "Учетная книга")
            {
                Text.Text = $@"Потертая книга, заполнена 
какими-то записями.";
                
            }
            button3.Text = "Взять";
        }
    }
}
