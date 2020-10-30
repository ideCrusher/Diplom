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
    public partial class MainMenu : Form
    {

        

        
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            Random o = new Random();
            int i = o.Next(1,4);

            if(i == 1)
            {
                this.BackgroundImage = MainMenuImage.Меню1;
            }
            if (i == 2)
            {
                this.BackgroundImage = MainMenuImage.Меню2;
            }
            if (i == 3)
            {
                this.BackgroundImage = MainMenuImage.Меню3;
            }
            if (i == 4)
            {
                this.BackgroundImage = MainMenuImage.Меню4;
            }



           
        }

        private void button1_Click(object sender, EventArgs e)
        {

            CreatePes lol = new CreatePes();
            lol.Show();

            Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Loading Loa = new Loading();
            Loa.Show();

            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (StreamReader sr = new StreamReader("ЛастСейв.txt"))
            {
                string line;
                // Read and display lines from the file until the end of  
                // the file is reached. 
                while ((line = sr.ReadLine()) != null)
                {
                    listBox1.Items.Add(line);
                }
                sr.Close();
            }


            Program.id = Convert.ToInt32(listBox1.Items[0]);

            Pers.Name = listBox1.Items[1].ToString();

            Pers.Images = listBox1.Items[2].ToString();

            Pers.Strength = Convert.ToInt32(listBox1.Items[3]);

            Pers.Agility = Convert.ToInt32(listBox1.Items[4]);

            Pers.Intellect = Convert.ToInt32(listBox1.Items[5]);

            Pers.Stamina = Convert.ToInt32(listBox1.Items[6]);

            Pers.LVL = Convert.ToInt32(listBox1.Items[7]);

            Pers.EXP = Convert.ToInt32(listBox1.Items[8]);

            Pers.Location = listBox1.Items[9].ToString();

            Pers.Kletka = Convert.ToInt32(listBox1.Items[10]);

            Pers.HP = Convert.ToInt32(listBox1.Items[11]);

            Pers.picX = Convert.ToInt32(listBox1.Items[12]);
            Pers.picY = Convert.ToInt32(listBox1.Items[13]);

            Pers.integer = Convert.ToInt32(listBox1.Items[14]);
            Pers.Gold = Convert.ToInt32(listBox1.Items[15]);

            if (Pers.Location == "ЯЯсеневыйЛес")
            {
                ЯЯсеневыйЛес YL = new ЯЯсеневыйЛес();
                YL.Show();
            }

            Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
