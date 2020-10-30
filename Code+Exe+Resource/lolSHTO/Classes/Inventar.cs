using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lolSHTO
{
    class Inventar
    {
        public static string[] Weapon = { "Оружие1", "Оружие2", "Оружие3", "Оружие4", "Оружие5", "" };
        public static string[] Header = { "Голова1", "Голова2", "Голова3", "Голова4", "Голова5", "" };
        public static string[] Main = { "Броня1", "Броня2", "Броня3", "Броня4", "Броня5", "" };
        public static string[] Footer = { "Ноги1", "Ноги2", "Ноги3", "Ноги4", "Ноги5", "" };
        public static string[] Foot = {"Молоко","Вода","Мясо","Хлеб","Сыр"};
        public static int[] Footint = {2,4,5,2,3};

        public static string[] Gear = {"Оружие1", "Оружие2", "Оружие3", "Оружие4", "Оружие5", "Голова1", "Голова2", "Голова3", "Голова4", "Голова5", "Броня1", "Броня2", "Броня3", "Броня4", "Броня5", "Ноги1", "Ноги2", "Ноги3", "Ноги4", "Ноги5", "Молоко", "Вода", "Мясо", "Хлеб", "Сыр" };
        public static int[] GearPrice = {5,10,20,30,40,10,14,20,25,30,15,25,35,50,60,7,13,17,21,25,4,2,6,4,5};

        public static string[] BuffCansName = {"Малый флакон здоровья","Броня","Сила","Ловкость","Интелект","Выносливость"};
        public static int[] BuffCansValue = {50,10,3,3,3,3};
        public static int[] BuffCansValueTime = { 0, 10, 10, 10, 10, 10 };
    }
}
