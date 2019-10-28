using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleverMove
{
    class ClassRoom
    {
        public static bool[,] currentRoom = new bool[5, 5];
        public static bool startRobot = false;
        public static bool setRobot = false;
        public static void ResetRoom()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    currentRoom[i , j] = false;
                }
            }
        }

    }
}
