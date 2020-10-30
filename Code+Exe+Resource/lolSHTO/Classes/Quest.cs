using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lolSHTO
{
    class Quest
    {

        public static string[] QuestYL = { "1.Разведка", "2.Гонец на Темные берега", "3.Доверие", "4.Плата за проход", "5.Доклад" };
        public static int[] QuestCondition = {5,1,2,50,0};
        public static int[] QuestYLEXP = {50,65,80,95,110};
        public static int[] QuestYLGOLD = {20,20,20,20,50};


        public static string QuestActive = "";
        public static int QuestActiveCondition = 0;
        public static string QuestTrue = "";
        public static int[] GotQuest = { 0, 0, 0, 0, 0 };




                
    }
}
