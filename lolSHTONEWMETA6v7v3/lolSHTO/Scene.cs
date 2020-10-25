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
    public partial class Scene : Form
    {

        

        public Scene()
        {
            InitializeComponent();
        }

        private void Scene_Load(object sender, EventArgs e)
        {
            if(Quest.QuestActive == "2.Гонец на Темные берега")
            {
                pictureBox2.Visible = true;
                label1.Visible = true;
                label1.Text = $@"Здравствуй путник. 
Для того что бы новым людям попасть в город 
необходимо выполнить поручение и заплатить.";

                Quest.QuestTrue = "2.Гонец на Темные берега";
                Quest.QuestActive = "";

                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Quest.QuestActive == "2.Гонец на Темные берега")
            {
                

                Quest.QuestTrue = "2.Гонец на Темные берега";
                Quest.QuestActive = "";


            }
            if (Tavern.TV != null)
            {
                Tavern.TV.Enabled = true;
                Tavern.TV.Refresh();

            }
            Hide();
        }
    }
}
