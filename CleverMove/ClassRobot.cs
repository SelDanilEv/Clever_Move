using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleverMove
{
    class ClassRobot
    {
        public static int[] currentLocation = new int[2];
        public static int[,] currentRoomForRobot = new int[5, 5];
        public static void StartRobot()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    currentRoomForRobot[i , j] = 0; 
                }
            }
            ClassLogics.PlaceWhereRobot();
        }
    }
}
