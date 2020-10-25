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
    public partial class Tavern : Form
    {
        public static Tavern TV;
        public Tavern()
        {
            InitializeComponent();
        }

        private void Description_Tick(object sender, EventArgs e)
        {



            listBox2.Items.Clear();
            string p;
            for (int i = 0; i < Quest.QuestYL.Length; i++)
            {
                p = Convert.ToString(listBox1.SelectedItem);
                if (p == Quest.QuestYL[i])
                {
                    using (StreamReader sr = new StreamReader($"QuestYL/{Quest.QuestYL[i]}.txt"))
                    {
                        string line;
                        while ((line = sr.ReadLine()) != null)
                        {
                            listBox2.Items.Add(line);
                        }
                        sr.Close();
                        return;
                    }

                }
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(Astranaar.Ast != null)
            {
                Astranaar.Ast.Enabled = true;
            }
            if(ТемныеБерега.DC != null)
            {
                ТемныеБерега.DC.Enabled = true;
            }


            StreamWriter SaveFile = new StreamWriter($"{Pers.Name}/INVENTAR.txt");
            foreach (var item in listBox3.Items)
            {
                SaveFile.WriteLine(item);
            }

            SaveFile.Close();

            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        { if (Quest.QuestActive == "")
            {
                Quest.QuestActive = Convert.ToString(listBox1.SelectedItem);
            }

        }


        private void Quests()
        {

            for (int i = 0; i < Quest.QuestYL.Length; i++)
            {
                if (Quest.GotQuest[i] != 1)
                {
                    listBox1.Items.Add(Quest.QuestYL[i]);

                    return;
                }
            }

        }

        private void Tavern_Load(object sender, EventArgs e)
        {
            using (StreamReader sr = new StreamReader($"{Pers.Name}/INVENTAR.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    listBox3.Items.Add(line);
                }
                sr.Close();
            }




            TV = this;
            if(Quest.QuestActive == "2.Гонец на Темные берега")
            {
                Scene lol = new Scene();
                lol.Show();
                this.Enabled = false;
            }


            Quests();

            
        }

        private void Update_Tick(object sender, EventArgs e)
        {
            for(int i =0; i<listBox1.Items.Count;i++)
            {
                if(listBox1.Items[i].ToString() == Quest.QuestActive)
                {
                    button2.Text = "ВЫПОЛНЯЕТЬСЯ";
                    button2.Enabled = false;
                    
                }
                if (listBox1.Items[i].ToString() != Quest.QuestActive)
                {
                    button2.Text = "Принять задание";
                    button2.Enabled = true;
                    
                }
                if (Quest.QuestTrue == listBox1.Items[i].ToString())
                {
                    button3.Enabled = true;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Quest.QuestYL.Length; i++)
            {
                if (Quest.QuestTrue == Quest.QuestYL[i])
                {
                    if (Quest.QuestTrue == "3.Доверие")
                    {
                        for(int d = 0; d<listBox3.Items.Count; i++)
                        {
                            if(Convert.ToString(listBox3.Items[d]) == "Учетная книга")
                            {
                                listBox3.Items.RemoveAt(d);
                            }
                        }
                    }
                    Quest.GotQuest[i] = 1;
                    Quest.QuestTrue = "";
                    Quest.QuestActiveCondition = 0;
                    MessageBox.Show($"Ваша награда за задание {Quest.QuestYLGOLD[i]} золота и {Quest.QuestYLEXP[i]} Опыта");
                    
                    Quests();
                }
            }
        }

        private void Tavern_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(Astranaar.Ast != null)
            {
                Astranaar.Ast.Enabled = true;
            }

            Hide();
        }
    }
}
