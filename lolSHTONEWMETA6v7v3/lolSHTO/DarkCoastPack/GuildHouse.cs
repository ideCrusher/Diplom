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
    public partial class GuildHouse : Form
    {
        public GuildHouse()
        {
            InitializeComponent();
        }

        private void GuildHouse_Load(object sender, EventArgs e)
        {
            label1.Text = $@"В доме гильдий вы можете выбрать гильдию, которая 
будет давать постоянный бонус вышему персонажу. 
Бонусами могут быть очки выносливости, очки 
силы, очки ловкости или урон.
Выбор может быть только один, сменить 
гильдию невозможно.";

            pictureBox1.BackgroundImage = DarkCoastPack.ResDC.GuildHouseOpen;
            pictureBox2.BackgroundImage = DarkCoastPack.ResDC.Медведь;
            pictureBox3.BackgroundImage = DarkCoastPack.ResDC.Олень;
            pictureBox4.BackgroundImage = DarkCoastPack.ResDC.Бык;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if(Pers.LVL == 3)
            {
                DialogResult p = new DialogResult();
                p = MessageBox.Show("Вы точно хотите выбрать гильдию Медведя?","",MessageBoxButtons.YesNo);
                if(p == DialogResult.Yes)
                {
                    Pers.Guild = "Медведь";
                    Pers.Strength = Pers.Strength + 1;
                    Pers.DD = Pers.DD + 1;
                }
            }
            else
            {
                MessageBox.Show("Уровень персонада должен быть (3) или больше.");
            }
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            

            pictureBox2.BackColor = Color.Gray;
            pictureBox2.BackgroundImage = null;

            label3.Visible = true;
            label3.Text = $@"Гильдия медведя даст вам (+1) к силе,
и (+1) к урону.";
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = DarkCoastPack.ResDC.Медведь;
            label3.Visible = false;
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            pictureBox3.BackColor = Color.Gray;
            pictureBox3.BackgroundImage = null;

            label5.Visible = true;
            label5.Text = $@"Гильдия Оленя даст вам (+1) к ловскости,
и (+1) к урону.";
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.BackgroundImage = DarkCoastPack.ResDC.Олень;
            label5.Visible = false;
        }

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            pictureBox4.BackColor = Color.Gray;
            pictureBox4.BackgroundImage = null;

            label7.Visible = true;
            label7.Text = $@"Гильдия Быка даст вам (+1) к выносливости,
и (+1) к урону.";
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.BackgroundImage = DarkCoastPack.ResDC.Бык;
            label7.Visible = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (Pers.LVL == 3)
            {
                DialogResult p = new DialogResult();
                p = MessageBox.Show("Вы точно хотите выбрать гильдию Оленя?", "", MessageBoxButtons.YesNo);
                if (p == DialogResult.Yes)
                {
                    Pers.Guild = "Олень";
                    Pers.Agility = Pers.Agility + 1;
                    Pers.DD = Pers.DD + 1;
                }
            }
            else
            {
                MessageBox.Show("Уровень персонада должен быть (3) или больше.");
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (Pers.LVL == 3)
            {
                DialogResult p = new DialogResult();
                p = MessageBox.Show("Вы точно хотите выбрать гильдию Быка?", "", MessageBoxButtons.YesNo);
                if (p == DialogResult.Yes)
                {
                    Pers.Guild = "Бык";
                    Pers.Stamina = Pers.Stamina + 1;
                    Pers.DD = Pers.DD + 1;
                }
            }
            else
            {
                MessageBox.Show("Уровень персонада должен быть (3) или больше.");
            }
        }

        private void GuildHouse_FormClosed(object sender, FormClosedEventArgs e)
        {
            CastleDC kek = new CastleDC();
            kek.Show();
            Hide();
        }
    }
}
