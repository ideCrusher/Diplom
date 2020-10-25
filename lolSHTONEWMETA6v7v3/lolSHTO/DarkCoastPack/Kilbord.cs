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
    public partial class CastleDC : Form
    {
        public static CastleDC KB;
        public CastleDC()
        {
            InitializeComponent();
        }

        private void CastleDC_Load(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = DarkCoastPack.ResDC.Klibord;

            label1.Text = $@"Славный город Килборд, город на самом севере границ Империи.
Одна из главных точек торговли на севере. Некогда пренадлежал ""Морской страже"", 
но после войны 20 лет назад Империя захватила Темные берега
и прогнала Морскую стражу с континент. ";

            KB = this;

            Tavernn.BackgroundImage = DarkCoastPack.ResDC.Tavern;
            TradeShopp.BackgroundImage = DarkCoastPack.ResDC.TradeShop;
            TownHalll.BackgroundImage = DarkCoastPack.ResDC.Castle;
            pictureBox2.BackgroundImage = DarkCoastPack.ResDC.GuildHouse;
        }

        private void Tavern_MouseEnter(object sender, EventArgs e)
        {
            Tavernn.Width = Tavernn.Width + 15;
            Tavernn.Height = Tavernn.Height + 15;

            Tavernn.BackColor = Color.Gray;
            Tavernn.BackgroundImage = null;
            label5.Visible = true;
            label5.Text = $@"В таверне можно 
отдохнуть и закупится 
припасами.";
        }

        private void Tavern_MouseLeave(object sender, EventArgs e)
        {
            Tavernn.Width = Tavernn.Width - 15;
            Tavernn.Height = Tavernn.Height - 15;
            label5.Visible = false;
            Tavernn.BackColor = Color.Transparent;
            Tavernn.BackgroundImage = DarkCoastPack.ResDC.Tavern;
        }

        private void TradeShopp_MouseEnter(object sender, EventArgs e)
        {
            TradeShopp.Width = TradeShopp.Width + 15;
            TradeShopp.Height = TradeShopp.Height + 15;

            TradeShopp.BackColor = Color.Gray;
            TradeShopp.BackgroundImage = null;

            label6.Visible = true;
            label6.Text = $@"В торговой лавке 
вы можете преобрести 
новые доспехи 
или оружие.";
        }

        private void TradeShopp_MouseLeave(object sender, EventArgs e)
        {
            TradeShopp.Width = TradeShopp.Width - 15;
            TradeShopp.Height = TradeShopp.Height - 15;

            label6.Visible = false;
            TradeShopp.BackColor = Color.Transparent;
            TradeShopp.BackgroundImage = DarkCoastPack.ResDC.TradeShop;
        }

        private void TownHalll_MouseEnter(object sender, EventArgs e)
        {
            TownHalll.Width = TownHalll.Width + 15;
            TownHalll.Height = TownHalll.Height + 15;

            TownHalll.BackColor = Color.Gray;
            TownHalll.BackgroundImage = null;

            label7.Visible = true;
            label7.Text = $@"В замке монжно взять 
задание или поговорить 
или присоединиться к королевству.";
        }

        private void TownHalll_MouseLeave(object sender, EventArgs e)
        {
            TownHalll.Width = TownHalll.Width - 15;
            TownHalll.Height = TownHalll.Height - 15;
            label7.Visible = false;
            TownHalll.BackColor = Color.Transparent;
            TownHalll.BackgroundImage = DarkCoastPack.ResDC.Castle;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ТемныеБерега kek = new ТемныеБерега();
            kek.Show();
            Hide();
        }

        private void TradeShopp_Click(object sender, EventArgs e)
        {
            
            this.Enabled = false;

            TradeShop lol = new TradeShop();
            lol.Show();
        }

        private void Tavernn_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2.Width = pictureBox2.Width + 15;
            pictureBox2.Height = pictureBox2.Height + 15;

            pictureBox2.BackColor = Color.Gray;
            pictureBox2.BackgroundImage = null;

            label8.Visible = true;
            label8.Text = $@"В Доме гильдий можно вступить в 
гильдию,которая будет давать 
бонусы к навыкам.";
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Width = pictureBox2.Width - 15;
            pictureBox2.Height = pictureBox2.Height - 15;
            label8.Visible = false;
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = DarkCoastPack.ResDC.GuildHouse;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            GuildHouse kek = new GuildHouse();
            kek.Show();

            Hide();
        }
    }
}
