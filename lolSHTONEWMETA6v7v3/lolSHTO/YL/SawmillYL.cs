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
    public partial class SawmillYL : Form
    {
        
        public static PictureBox pic;
        public static SawmillYL SW;
        public SawmillYL()
        {
            InitializeComponent();
        }

        private void SawmillYL_Load(object sender, EventArgs e)
        {
            SW = this;

            Random lol = new Random();
            int o = lol.Next(1,3);
            if(o == 1)
            {
                this.BackgroundImage = Res.MapPicYL.Ashenvale;
            }
            else if(o == 2)
            {
                this.BackgroundImage = Res.MapPicYL.Ashenvale2jpg;
            }
            else if(o == 3)
            {
                this.BackgroundImage = Res.MapPicYL.Ashenvale3;
            }

            SawMill.Image = Res.Building.SawMill;
            Barracks.Image = Res.Building.Barracks;



            pictureBox6.Image = Res.Units.Captan;
            pictureBox7.Image = Res.Units.Footman;

            if (Quest.QuestActive == Quest.QuestYL[0])
            {
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;


                pictureBox1.Visible = true;
                pictureBox2.Visible = true;
                pictureBox3.Visible = true;
                pictureBox4.Visible = true;
                pictureBox5.Visible = true;

                

                pictureBox1.Image = Res.Rouge.QuestRouge;
                pictureBox2.Image = Res.Rouge.QuestRouge;
                pictureBox3.Image = Res.Rouge.QuestRouge;
                pictureBox4.Image = Res.Rouge.QuestRouge;
                pictureBox5.Image = Res.Rouge.QuestRouge;
            }
        }

        

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            pic = pictureBox5;
            GameSave.Fight = "SW";
            Program.Monstr = Program.YLshag31;
            Бой lol = new Бой();
            lol.Show();

            this.Enabled = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pic = pictureBox2;
            GameSave.Fight = "SW";
            Program.Monstr = Program.YLshag31;
            Бой lol = new Бой();
            lol.Show();

            this.Enabled = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pic = pictureBox3;
            GameSave.Fight = "SW";
            Program.Monstr = Program.YLshag31;
            Бой lol = new Бой();
            lol.Show();

            this.Enabled = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pic = pictureBox1;
            GameSave.Fight = "SW";
            Program.Monstr = Program.YLshag31;
            Бой lol = new Бой();
            lol.Show();

            this.Enabled = false;
        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            pic = pictureBox4;
            GameSave.Fight = "SW";
            Program.Monstr = Program.YLshag31;
            Бой lol = new Бой();
            lol.Show();

            this.Enabled = false;
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            Персонаж lol = new Персонаж();
            

            lol.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SW = null;
            ЯЯсеневыйЛес lol = new ЯЯсеневыйЛес();            
            lol.Show();
            
            Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }
    }
}
