using System;
using System.Windows.Forms;
using System.IO;

namespace lolSHTO
{
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();
        }

        private void Loading_Load(object sender, EventArgs e)
        {

            using (StreamReader sr = new StreamReader("allPers.txt"))
            {
                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    comboBox1.Items.Add(line);
                }
                sr.Close();
            }

        }
        //Сохранение данных персонажа в переменные и загрузка.
        private void button1_Click(object sender, EventArgs e)
        {


            using (StreamReader sr = new StreamReader($"{comboBox1.Text}/PersSave.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    listBox2.Items.Add(line);
                }
                sr.Close();
            }


            Pers.Name = Convert.ToString(listBox2.Items[0]);
            Pers.Images = Convert.ToString(listBox2.Items[1]);
            Pers.Strength =  Convert.ToInt32(listBox2.Items[2]);
            Pers.Agility  =  Convert.ToInt32(listBox2.Items[3]);
            Pers.Intellect=  Convert.ToInt32(listBox2.Items[4]);
            Pers.Stamina  =  Convert.ToInt32(listBox2.Items[5]);
            Pers.LVL      =  Convert.ToInt32(listBox2.Items[6]);
            Pers.EXP      =  Convert.ToInt32(listBox2.Items[7]);
            Pers.Location = Convert.ToString(listBox2.Items[8]);
            Pers.Kletka = Convert.ToInt32(listBox2.Items[9]); 
            Pers.HP     = Convert.ToInt32(listBox2.Items[10] );
            Pers.picX   = Convert.ToInt32(listBox2.Items[11]);
            Pers.picY   = Convert.ToInt32(listBox2.Items[12]);
            Pers.Gold   = Convert.ToInt32(listBox2.Items[13]);
            Pers.HPMax = Convert.ToInt32(listBox2.Items[14]);
            Pers.HelmetItem  = Convert.ToString(listBox2.Items[15]);
            Pers.ArmorItem   = Convert.ToString(listBox2.Items[16]);
            Pers.BootsItem   = Convert.ToString(listBox2.Items[17]);
            Pers.WeaponItem  = Convert.ToString(listBox2.Items[18]);


            using (StreamReader sr = new StreamReader($"{comboBox1.Text}/GameSave.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    listBox1.Items.Add(line);
                }
                sr.Close();
            }

            Quest.QuestActive = Convert.ToString(listBox1.Items[0]); ;
            Quest.QuestActiveCondition = Convert.ToInt32(listBox1.Items[1]); ;
            Quest.QuestTrue = Convert.ToString(listBox1.Items[2]);
            Quest.GotQuest[0] = Convert.ToInt32(listBox1.Items[3]);
            Quest.GotQuest[1] = Convert.ToInt32(listBox1.Items[4]);
            Quest.GotQuest[2] = Convert.ToInt32(listBox1.Items[5]);
            Quest.GotQuest[3] = Convert.ToInt32(listBox1.Items[6]);
            Quest.GotQuest[4] = Convert.ToInt32(listBox1.Items[7]);
            Pers.Guild = Convert.ToString(listBox1.Items[8]);
              

            if(Pers.Location == "ЯЯсеневыйЛес")
            {
                ЯЯсеневыйЛес YL = new ЯЯсеневыйЛес();
                YL.Show();
            }
            if(Pers.Location == "ТемныеБерега")
            {
                ТемныеБерега DC = new ТемныеБерега();
                DC.Show();
            }


            Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainMenu main = new MainMenu();
            main.Show();

            Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
    }
}
