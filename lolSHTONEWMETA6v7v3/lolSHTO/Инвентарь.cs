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
using System.Resources;

namespace lolSHTO
{
    public partial class Инвентарь : Form
    {
        string item;
        public Инвентарь()
        {
            InitializeComponent();
        }

        private void Инвентарь_Load(object sender, EventArgs e)
        {
           



            if (Pers.Images == "Изображение1")
            {
                groupBox1.BackgroundImage = Res.Personage.Изображение1;
            }
            if (Pers.Images == "Изображение2")
            {
                groupBox1.BackgroundImage = Res.Personage.Изображение2;
            }
            if (Pers.Images == "Изображение3")
            {
                groupBox1.BackgroundImage = Res.Personage.Изображение3;
            }
            if (Pers.Images == "Изображение4")
            {
                groupBox1.BackgroundImage = Res.Personage.Изображение4;
            }
            if (Pers.Images == "Изображение5")
            {
                groupBox1.BackgroundImage = Res.Personage.Изображение5;
            }
            if (Pers.Images == "Изображение6")
            {
                groupBox1.BackgroundImage = Res.Personage.Изображение6;
            }
            if (Pers.Images == "Изображение7")
            {
                groupBox1.BackgroundImage = Res.Personage.Изображение7;
            }


            listBox1.Items[0] = Pers.WeaponItem;
            listBox1.Items[1] = Pers.HelmetItem;
            listBox1.Items[2] = Pers.ArmorItem;
            listBox1.Items[3] = Pers.BootsItem;

            using (StreamReader sr = new StreamReader($"{Pers.Name}/INVENTAR.txt"))
            {
                string line;              
                while ((line = sr.ReadLine()) != null)
                {
                    listBox2.Items.Add(line);
                }
                sr.Close();
            }


            Armor.Enabled = true;

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Armor_Tick(object sender, EventArgs e)
        {




        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            item = listBox2.SelectedItem.ToString();

            use.Enabled = true;
            Armor.Enabled = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {


            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < Inventar.Weapon.Length; j++)
                {
                    if (listBox1.Items[0].ToString() == "")
                    {


                        if (item == Inventar.Weapon[j])
                        {
                            listBox1.Items[0] = Convert.ToString(listBox2.SelectedItem);

                            listBox2.Items.Remove(listBox2.SelectedItem);


                            use.Enabled = false;

                        }
                    }
                }
                for (int o = 0; o < Inventar.Header.Length; o++)
                {
                    if (listBox1.Items[1].ToString() == "")
                    {
                        if (item == Inventar.Header[o])
                        {
                            listBox1.Items[1] = Convert.ToString(listBox2.SelectedItem);
                            listBox2.Items.Remove(listBox2.SelectedItem);

                            use.Enabled = false;
                        }
                    }
                }
                for (int p = 0; p < Inventar.Main.Length; p++)
                {

                    if (listBox1.Items[2].ToString() == "")
                    {
                        if (item == Inventar.Main[p])
                        {
                            listBox1.Items[2] = Convert.ToString(listBox2.SelectedItem);
                            listBox2.Items.Remove(listBox2.SelectedItem);

                            use.Enabled = false;
                        }
                    }
                }
                for (int u = 0; u < Inventar.Footer.Length; u++)
                {
                    if (listBox1.Items[3].ToString() == "")
                    {
                        if (item == Inventar.Footer[u])
                        {

                            listBox1.Items[3] = Convert.ToString(listBox2.SelectedItem);
                            listBox2.Items.Remove(listBox2.SelectedItem);

                            use.Enabled = false;

                        }
                    }
                }
            }
            use.Enabled = false;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Инвентарь_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (ЯЯсеневыйЛес.YLes != null)
            {
                ЯЯсеневыйЛес.YLes.button4.Enabled = true;
                ЯЯсеневыйЛес.YLes.uPADTE.Enabled = true;
                ЯЯсеневыйЛес.YLes.Armor.Enabled = true;
            }
            if(ТемныеБерега.DC !=null)
            {
                ТемныеБерега.DC.button4.Enabled = true;
                
                ТемныеБерега.DC.Armor.Enabled = true;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                item = listBox2.SelectedItem.ToString();

                use.Enabled = true;
                Armor.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Выберите вещь");
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem.ToString() == listBox1.Items[0].ToString())
            {
                listBox2.Items.Add(Convert.ToString(listBox1.SelectedItem));
                listBox1.Items[0] = "";
            }
            if (listBox1.SelectedItem.ToString() == listBox1.Items[1].ToString())
            {
                listBox2.Items.Add(Convert.ToString(listBox1.SelectedItem));
                listBox1.Items[1] = "";
            }
            if (listBox1.SelectedItem.ToString() == listBox1.Items[2].ToString())
            {
                listBox2.Items.Add(Convert.ToString(listBox1.SelectedItem));
                listBox1.Items[2] = "";
            }
            if (listBox1.SelectedItem.ToString() == listBox1.Items[3].ToString())
            {
                listBox2.Items.Add(Convert.ToString(listBox1.SelectedItem));
                listBox1.Items[3] = "";
            }
            Armor.Enabled = true;
        }

        private void use_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < Inventar.Weapon.Length; j++)
                {
                    if (listBox1.Items[0].ToString() == "")
                    {


                        if (item == Inventar.Weapon[j])
                        {
                            listBox1.Items[0] = Convert.ToString(listBox2.SelectedItem);

                            listBox2.Items.Remove(listBox2.SelectedItem);


                            use.Enabled = false;

                        }
                    }
                }
                for (int o = 0; o < Inventar.Header.Length; o++)
                {
                    if (listBox1.Items[1].ToString() == "")
                    {
                        if (item == Inventar.Header[o])
                        {
                            listBox1.Items[1] = Convert.ToString(listBox2.SelectedItem);
                            listBox2.Items.Remove(listBox2.SelectedItem);

                            use.Enabled = false;
                        }
                    }
                }
                for (int p = 0; p < Inventar.Main.Length; p++)
                {

                    if (listBox1.Items[2].ToString() == "")
                    {
                        if (item == Inventar.Main[p])
                        {
                            listBox1.Items[2] = Convert.ToString(listBox2.SelectedItem);
                            listBox2.Items.Remove(listBox2.SelectedItem);

                            use.Enabled = false;
                        }
                    }
                }
                for (int u = 0; u < Inventar.Footer.Length; u++)
                {
                    if (listBox1.Items[3].ToString() == "")
                    {
                        if (item == Inventar.Footer[u])
                        {

                            listBox1.Items[3] = Convert.ToString(listBox2.SelectedItem);
                            listBox2.Items.Remove(listBox2.SelectedItem);

                            use.Enabled = false;

                        }
                    }
                }
            }
            use.Enabled = false;
        }

        private void Armor_Tick_1(object sender, EventArgs e)
        {
            Pers.Armor = 0;
            Pers.DD = 0;

            label3.Text = 0.ToString();
            label4.Text = 0.ToString();
            for (int j = 0; j < Inventar.Weapon.Length; j++)
            {
                if (listBox1.Items[0].ToString() == Inventar.Weapon[j])
                {
                    if (Inventar.Weapon[j] == "Оружие1")
                    {
                        pictureBox1.Image = Res.Weapon.Оружие1;
                        label4.Text = 5.ToString();
                    }
                    if (Inventar.Weapon[j] == "Оружие2")
                    {
                        pictureBox1.Image = Res.Weapon.Оружие2;
                        label4.Text = 10.ToString();
                    }
                    if (Inventar.Weapon[j] == "Оружие3")
                    {
                        pictureBox1.Image = Res.Weapon.Оружие3;
                        label4.Text = 15.ToString();
                    }
                    if (Inventar.Weapon[j] == "Оружие4")
                    {
                        pictureBox1.Image = Res.Weapon.Оружие4;
                        label4.Text = 20.ToString();
                    }
                    if (Inventar.Weapon[j] == "Оружие5")
                    {
                        pictureBox1.Image = Res.Weapon.Оружие5;
                        label4.Text = 25.ToString();
                    }

                    if (Inventar.Weapon[j] == "")
                    {
                        pictureBox1.Image = null;
                        label4.Text = 0.ToString();
                    }
                }
            }
            for (int o = 0; o < Inventar.Header.Length; o++)
            {
                if (listBox1.Items[1].ToString() == Inventar.Header[o])
                {
                    if (Inventar.Header[o] == "Голова1")
                    {
                        pictureBox4.Image = Res.Header.Голова1;
                        label3.Text = Convert.ToString(Convert.ToInt32(label3.Text) + 3);
                    }
                    if (Inventar.Header[o] == "Голова2")
                    {
                        pictureBox4.Image = Res.Header.Голова2;
                        label3.Text = Convert.ToString(Convert.ToInt32(label3.Text) + 5);
                    }
                    if (Inventar.Header[o] == "Голова3")
                    {
                        pictureBox4.Image = Res.Header.Голова3;
                        label3.Text = Convert.ToString(Convert.ToInt32(label3.Text) + 7);
                    }
                    if (Inventar.Header[o] == "Голова4")
                    {
                        pictureBox4.Image = Res.Header.Голова4;
                        label3.Text = Convert.ToString(Convert.ToInt32(label3.Text) + 9);
                    }
                    if (Inventar.Header[o] == "Голова5")
                    {
                        pictureBox4.Image = Res.Header.Голова5;
                        label3.Text = Convert.ToString(Convert.ToInt32(label3.Text) + 11);
                    }
                    if (Inventar.Header[o] == "")
                    {
                        pictureBox4.Image = null;
                        label3.Text = Convert.ToString(Convert.ToInt32(label3.Text) + 0);
                    }

                }

            }
            for (int p = 0; p < Inventar.Main.Length; p++)
            {
                if (listBox1.Items[2].ToString() == Inventar.Main[p])
                {
                    if (Inventar.Main[p] == "Броня1")
                    {
                        pictureBox2.Image = Res.Main.Броня1;
                        label3.Text = Convert.ToString(Convert.ToInt32(label3.Text) + 5);
                    }
                    if (Inventar.Main[p] == "Броня2")
                    {
                        pictureBox2.Image = Res.Main.Броня2;
                        label3.Text = Convert.ToString(Convert.ToInt32(label3.Text) + 8);
                    }
                    if (Inventar.Main[p] == "Броня3")
                    {
                        pictureBox2.Image = Res.Main.Броня3;
                        label3.Text = Convert.ToString(Convert.ToInt32(label3.Text) + 11);
                    }
                    if (Inventar.Main[p] == "Броня4")
                    {
                        pictureBox2.Image = Res.Main.Броня4;
                        label3.Text = Convert.ToString(Convert.ToInt32(label3.Text) + 14);
                    }
                    if (Inventar.Main[p] == "Броня5")
                    {
                        pictureBox2.Image = Res.Main.Броня5;
                        label3.Text = Convert.ToString(Convert.ToInt32(label3.Text) + 17);
                    }

                    if (Inventar.Main[p] == "")
                    {
                        pictureBox2.Image = null;
                        label3.Text = Convert.ToString(Convert.ToInt32(label3.Text) + 0);
                    }
                }
            }
            for (int u = 0; u < Inventar.Footer.Length; u++)
            {
                if (listBox1.Items[3].ToString() == Inventar.Footer[u])
                {
                    if (Inventar.Footer[u] == "Ноги1")
                    {
                        pictureBox3.Image = Res.Footer.Ноги1;
                        label3.Text = Convert.ToString(Convert.ToInt32(label3.Text) + 2);
                    }
                    if (Inventar.Footer[u] == "Ноги2")
                    {
                        pictureBox3.Image = Res.Footer.Ноги2;
                        label3.Text = Convert.ToString(Convert.ToInt32(label3.Text) + 4);
                    }
                    if (Inventar.Footer[u] == "Ноги3")
                    {
                        pictureBox3.Image = Res.Footer.Ноги3;
                        label3.Text = Convert.ToString(Convert.ToInt32(label3.Text) + 6);
                    }
                    if (Inventar.Footer[u] == "Ноги4")
                    {
                        pictureBox3.Image = Res.Footer.Ноги4;
                        label3.Text = Convert.ToString(Convert.ToInt32(label3.Text) + 8);
                    }
                    if (Inventar.Footer[u] == "Ноги5")
                    {
                        pictureBox3.Image = Res.Footer.Ноги5;
                        label3.Text = Convert.ToString(Convert.ToInt32(label3.Text) + 10);
                    }
                    if (Inventar.Footer[u] == "")
                    {
                        pictureBox3.Image = null;
                        label3.Text = Convert.ToString(Convert.ToInt32(label3.Text) + 0);
                    }


                }
            }


            Pers.WeaponItem = Convert.ToString(listBox1.Items[0]);
            Pers.HelmetItem = Convert.ToString(listBox1.Items[1]);
            Pers.ArmorItem = Convert.ToString(listBox1.Items[2]);
            Pers.BootsItem = Convert.ToString(listBox1.Items[3]);





            var f = new StreamWriter($"{Pers.Name}/INVENTAR.txt");

            foreach (var item in listBox2.Items)
            {
                f.WriteLine(item);
            }

            f.Close();



        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            DialogResult lol = new DialogResult();
            lol = MessageBox.Show("Вы хотите использовать этот предмет?", "Предупреждение", MessageBoxButtons.YesNo);
            if (lol == DialogResult.Yes)
            {

                for (int i = 0; i < Inventar.Foot.Length; i++)
                {
                    if (listBox2.SelectedItem.ToString() == Inventar.Foot[i])
                    {

                        Pers.hod = Pers.hod + Inventar.Footint[i];
                        listBox2.Items.Remove(listBox2.SelectedItem);
                    }

                }
              /*  for (int i = 0; i < Inventar.BuffCansName.Length; i++)
                {
                    if (listBox2.SelectedItem.ToString() == Inventar.BuffCansName[i])
                    {

                        if(listBox2.SelectedItem.ToString() == "Малый флакон здоровья")
                        {
                            Pers.HP = Pers.HP + Inventar.BuffCansValue[i];
                        }
                        if (listBox2.SelectedItem.ToString() == "Броня")
                        {
                            Pers.Armor = Pers.Armor + Inventar.BuffCansValue[i];
                            GameSave.Buff = Inventar.BuffCansValueTime[i];
                            GameSave.BuffStats = Inventar.BuffCansName[i];
                        }
                        if (GameSave.BuffStats != null)
                        {
                            if (listBox2.SelectedItem.ToString() == "Сила")
                            {
                                Pers.Strength = Pers.Strength + Inventar.BuffCansValue[i];
                                GameSave.Buff = Inventar.BuffCansValueTime[i];
                                GameSave.BuffStats = Inventar.BuffCansName[i];

                            }
                            if (listBox2.SelectedItem.ToString() == "Ловскость")
                            {
                                Pers.Agility = Pers.Agility + Inventar.BuffCansValue[i];
                                GameSave.Buff = Inventar.BuffCansValueTime[i];
                                GameSave.BuffStats = Inventar.BuffCansName[i];

                            }
                            if (listBox2.SelectedItem.ToString() == "Интелект")
                            {
                                Pers.Intellect = Pers.Intellect + Inventar.BuffCansValue[i];
                                GameSave.Buff = Inventar.BuffCansValueTime[i];
                                GameSave.BuffStats = Inventar.BuffCansName[i];

                            }
                            if (listBox2.SelectedItem.ToString() == "Выносливость")
                            {
                                Pers.Stamina = Pers.Stamina + Inventar.BuffCansValue[i];
                                GameSave.Buff = Inventar.BuffCansValueTime[i];
                                GameSave.BuffStats = Inventar.BuffCansName[i];

                            }
                        }
                        else
                        {
                            MessageBox.Show("Невозможно улучшийть больше одногой стататы");
                        }



                        listBox2.Items.Remove(listBox2.SelectedItem);
                    }

                }*/

            }
        }
    


        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult lol = new DialogResult();
            lol = MessageBox.Show("Вы точно хотите выбросить предмет? Вы удалите его без возможности возврата!", "Предупреждение", MessageBoxButtons.YesNo);
            if (lol == DialogResult.Yes)
            {
                
            }
        }

        

       
    }
}
