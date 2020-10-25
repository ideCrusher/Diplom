using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lolSHTO
{
    static class Program
    {

        
        
        public static Бой fight;

        public static int id,i = 0;
        public static string news = "Вы просыпаетесь в незнакомом доме.";
        public static string dev = "Вы находите кинжал и 5 золотых монет";       
        public static string YL = "Вы входите на локацию ясеневый лес";
        public static string stats;
        public static string VI = "Вы находите ";


        public static string osmotr11 = "пару золотых монет", osmotr12 = "несколько золотых монет", osmotr13 = "много золотых монет";
        public static string osmotr21 ="ничего", osmotr22 = "мусор", osmotr23 = "еду", osmotr24="Снаряжение"; 

        


        public static string YLshag11 = "Перемещение", YLshag12 = "Перемешение по лесу";
        public static string YLshag21 = "Вы находите Побитый сундук!", YLshag22 = "Вы находите Добротный сундук!",YLshag23 = "Вы находите Большой сундук!";
        public static string YLshag31 = "На вас напали разбойники!", YLshag32 = "На вас напал Медведь!", YLshag33 = "На вас напал Волк!";


        public static string Monstr,Location;


        
        
        


        public static int HPpers=100;

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainMenu());
        }
    }
}






















