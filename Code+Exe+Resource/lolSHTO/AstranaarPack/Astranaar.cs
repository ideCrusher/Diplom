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
    public partial class Astranaar : Form
    {
        public static Astranaar Ast;
        public Astranaar()
        {
            InitializeComponent();
        }

        private void Tavern_Click(object sender, EventArgs e)
        {
            


        }

        private void TradeShop_Click(object sender, EventArgs e)
        {
            this.Enabled = false;

            TradeShop lol = new TradeShop();
            lol.Show();
        }

        private void Astranaar_Load(object sender, EventArgs e)
        {
            Ast = this;

            pictureBox1.BackgroundImage = AstranaarPack.AstPIC.MainAstranaar;
            label4.Text = $@"Астранаар - центр Ясеневого леса, свободная деревня которая не пренадлежит 
никакому государству, но это не значит что тут позволено все что угодно.";

            Tavern.BackgroundImage = AstranaarPack.AstPIC.Tavern;
            TradeShop.BackgroundImage = AstranaarPack.AstPIC.TradeShop;
            TownHall.BackgroundImage = AstranaarPack.AstPIC.TownHall;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            Astranaar.Ast = null;
            ЯЯсеневыйЛес lol = new ЯЯсеневыйЛес();
            lol.Show();
            Hide();
        }

        private void Astranaar_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Enabled = false;

            ЯЯсеневыйЛес lol = new ЯЯсеневыйЛес();
            lol.Show();           
        }

        private void TownHall_Click(object sender, EventArgs e)
        {
            this.Enabled = false;

            Tavern lol = new Tavern();
            lol.Show();
            

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Tavern_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void Tavern_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void Tavern_MouseEnter(object sender, EventArgs e)
        {
            Tavern.Width = Tavern.Width + 15;
            Tavern.Height = Tavern.Height + 15;

            Tavern.BackColor = Color.Gray;
            Tavern.BackgroundImage = null;
            label5.Visible = true;
            label5.Text = $@"В таверне можно 
отдохнуть и закупится 
припасами.";
        }

        private void Tavern_MouseLeave(object sender, EventArgs e)
        {
            Tavern.Width = Tavern.Width - 15;
            Tavern.Height = Tavern.Height - 15;
            label5.Visible = false;
            Tavern.BackColor = Color.Transparent;
            Tavern.BackgroundImage = AstranaarPack.AstPIC.Tavern;
        }

        private void TradeShop_MouseEnter(object sender, EventArgs e)
        {
            TradeShop.Width = TradeShop.Width + 15;
            TradeShop.Height = TradeShop.Height + 15;

            TradeShop.BackColor = Color.Gray;
            TradeShop.BackgroundImage = null;

            label6.Visible = true;
            label6.Text = $@"В торговой лавке 
вы можете преобрести 
новые доспехи 
или оружие.";
        }

        private void TradeShop_MouseLeave(object sender, EventArgs e)
        {
            TradeShop.Width = TradeShop.Width - 15;
            TradeShop.Height = TradeShop.Height - 15;

            label6.Visible = false;
            TradeShop.BackColor = Color.Transparent;
            TradeShop.BackgroundImage = AstranaarPack.AstPIC.TradeShop;
        }

        private void TownHall_MouseEnter(object sender, EventArgs e)
        {

            TownHall.Width = TownHall.Width + 15;
            TownHall.Height = TownHall.Height + 15;

            TownHall.BackColor = Color.Gray;
            TownHall.BackgroundImage = null;

            label7.Visible = true;
            label7.Text = $@"В Ратуше вы можете 
взять задания.";

        }

        private void TownHall_MouseLeave(object sender, EventArgs e)
        {
            TownHall.Width = TownHall.Width - 15;
            TownHall.Height = TownHall.Height - 15;
            label7.Visible = false;
            TownHall.BackColor = Color.Transparent;
            TownHall.BackgroundImage = AstranaarPack.AstPIC.TownHall;
        }
    }
}
