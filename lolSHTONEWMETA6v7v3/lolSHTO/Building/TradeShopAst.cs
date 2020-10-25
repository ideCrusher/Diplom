using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;
using System.IO;

namespace lolSHTO
{
    public partial class TradeShop : Form
    {
        
        public TradeShop()
        {
            InitializeComponent();
        }

        private void TradeShop_Load(object sender, EventArgs e)
        {
            
            
            pictureBox1.Image = AstranaarPack.AstPIC.АукционерМини;
            
 
            


            using (StreamReader sr = new StreamReader("TradeShopAst.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    listBox1.Items.Add(line);
                }
                sr.Close();
            }
            if (Tutorial.T == null)
            {
                label6.Text = Convert.ToString(Pers.Gold);
                label2.Text = Convert.ToString(Pers.Name);

                using (StreamReader sr = new StreamReader($"{Pers.Name}/INVENTAR.txt"))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        listBox2.Items.Add(line);
                    }
                    sr.Close();
                }
            }
            if (Tutorial.T != null)
            {
                Pers.Gold = 100;
                label6.Text = Convert.ToString(100);
                label2.Text = Convert.ToString(Pers.Name);

                label10.Visible = true;
                label10.Text = $@"Это Магазин, в нем у торговца можно прикупить новую 
экипировку. Выберите вещи из инвенторя торговца, 
после чего вам покажет его цену. Для того что бы 
купить предмет нажмите кнопку ""купить"", после 
чего предмет отправится к вам в инвентарь.";

                this.MaximizeBox = false;
                this.MinimizeBox = false;
                this.ControlBox = false;
            }
        }

        //Сохраннение перед выходом
        private void button3_Click(object sender, EventArgs e)
        {

            if (Tutorial.T == null)
            {
                StreamWriter SaveFile = new StreamWriter($"{Pers.Name}/INVENTAR.txt");
                foreach (var item in listBox2.Items)
                {
                    SaveFile.WriteLine(item);
                }

                SaveFile.Close();
            }
            else
            {
                Tutorial.T.Enabled = true;
                Pers.Gold = 20;
            }

            
            if (Astranaar.Ast != null)
            {
                ЯЯсеневыйЛес.YLes.Save.Enabled = true;
                Astranaar.Ast.Enabled = true;
            }
            if(CastleDC.KB != null)
            {
                CastleDC.KB.Enabled = true;
                
            }
            Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string p;
            for(int i = 0; i<Inventar.Gear.Length;i++)
            {
                p = Convert.ToString(listBox1.SelectedItem);
                if (p == Inventar.Gear[i])
                {
                    label3.Text = $"{Convert.ToString(Inventar.GearPrice[i])} ";
                }
            }
        }

        private void PersInv_Tick(object sender, EventArgs e)
        {
            string p;
            for (int i = 0; i < Inventar.Gear.Length; i++)
            {
                p = Convert.ToString(listBox2.SelectedItem);
                if (p == Inventar.Gear[i])
                {
                    label4.Text = $"{Convert.ToString((Inventar.GearPrice[i]/2))} ";
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Функция покупки предметов

            if(label10.Visible == true)
            {
                label10.Text = $@"Так же у торговца можно продать вещи,
выбрав ненужную вещь в вашем инвенторе 
и нажав кнопку ""Продать"". При продаже 
вы получите только пол суммы от той что 
вы заплатили за ее покупку.";
            }
            try
            {
                if (Pers.Gold >= Convert.ToInt32(label3.Text))
                {
                    listBox2.Items.Add(Convert.ToString(listBox1.SelectedItem));
                    listBox1.Items.RemoveAt(listBox1.SelectedIndex);

                    Pers.Gold = Pers.Gold - Convert.ToInt32(label3.Text);


                    label6.Text = Convert.ToString(Pers.Gold);
                }
                else
                {
                    MessageBox.Show("У вас не достаточно золота!");
                }

                label3.Text = "0";
            }
            catch
            {

            }

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Функция продажи предметов

            Pers.Gold = Pers.Gold + Convert.ToInt32(label4.Text);
            label6.Text = Convert.ToString(Pers.Gold);

            listBox1.Items.Add(Convert.ToString(listBox2.SelectedItem));
            listBox2.Items.RemoveAt(listBox2.SelectedIndex);

            

            label4.Text = "0";
        }

        private void TradeShop_FormClosed(object sender, FormClosedEventArgs e)
        {
             

            System.IO.StreamWriter SaveFile = new System.IO.StreamWriter($"{Pers.Name}/INVENTAR.txt");
            foreach (var item in listBox2.Items)
            {
                SaveFile.WriteLine(item);
            }

            SaveFile.Close();



            
            Hide();
        }
    }
}
