using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace CleverMove
{

    class ClassLogics
    {
        public static string currentPlace;

        public static bool rightsRight;
        public static bool rightsLeft;
        public static bool rightsUp;
        public static bool rightsDown;
        public static bool ch=false;

        public static int supportRightBox;
        public static int supportLeftBox;
        public static int supportUpBox;
        public static int supportDownBox;

        public static int TryToMove;

        public static int ppp = 0;

        private static int FindTheMax()    //1-down 2-right 3-up 4-left
        {

            int a = 0, q, w, e, r;
            q = supportDownBox;
            w = supportRightBox;
            e = supportUpBox;
            r = supportLeftBox;
            if (q==w && w==e && e==r && r==-999)
            {
                ch = true;
            }
            int max = supportDownBox;
            if (supportRightBox >= max) max = supportRightBox;
            if (supportUpBox >= max) max = supportUpBox;
            if (supportLeftBox >= max) max = supportLeftBox;
            if (max == q) a = 1;
            if (max == w) a = 2;
            if (max == e) a = 3;
            if (max == r) a = 4;
            return a;
        }

        public static void DoTheMove()
        {
            if (ClassRobot.currentLocation[0] == 0) rightsUp = false; else rightsUp = true;

            if (ClassRobot.currentLocation[1] == 0) rightsLeft = false; else rightsLeft = true;

            if (ClassRobot.currentLocation[0] == 4) rightsDown = false; else rightsDown = true;

            if (ClassRobot.currentLocation[1] == 4) rightsRight = false; else rightsRight = true;

            if (rightsRight)
            {
                if (ClassRoom.currentRoom[ClassRobot.currentLocation[0], ClassRobot.currentLocation[1] + 1])
                {
                    supportRightBox = ClassRobot.currentRoomForRobot[ClassRobot.currentLocation[0], ClassRobot.currentLocation[1] + 1];
                }
                else
                {
                    ClassRobot.currentRoomForRobot[ClassRobot.currentLocation[0], ClassRobot.currentLocation[1] + 1] = 1;
                    supportRightBox = -999;
                }
            }
            else supportRightBox = -999;

            if (rightsLeft)
            {
                if (ClassRoom.currentRoom[ClassRobot.currentLocation[0], ClassRobot.currentLocation[1] - 1])
                {
                    supportLeftBox = ClassRobot.currentRoomForRobot[ClassRobot.currentLocation[0], ClassRobot.currentLocation[1] - 1];
                }
                else
                {
                    ClassRobot.currentRoomForRobot[ClassRobot.currentLocation[0], ClassRobot.currentLocation[1] - 1] = 1;
                    supportLeftBox = -999;
                }
            }
            else supportLeftBox = -999;

            if (rightsDown)
            {
                if (ClassRoom.currentRoom[ClassRobot.currentLocation[0] + 1, ClassRobot.currentLocation[1]])
                {
                    supportDownBox = ClassRobot.currentRoomForRobot[ClassRobot.currentLocation[0] + 1, ClassRobot.currentLocation[1]];
                }
                else
                {
                    ClassRobot.currentRoomForRobot[ClassRobot.currentLocation[0] + 1, ClassRobot.currentLocation[1]] = 1;
                    supportDownBox = -999;
                }
            }
            else supportDownBox = -999;

            if (rightsUp)
            {
                if (ClassRoom.currentRoom[ClassRobot.currentLocation[0] - 1, ClassRobot.currentLocation[1]])
                {
                    supportUpBox = ClassRobot.currentRoomForRobot[ClassRobot.currentLocation[0] - 1, ClassRobot.currentLocation[1]];
                }
                else
                {
                    ClassRobot.currentRoomForRobot[ClassRobot.currentLocation[0] - 1, ClassRobot.currentLocation[1]] = 1;
                    supportUpBox = -999;
                }
            }
            else supportUpBox = -999;



            TryToMove = FindTheMax();

            switch (TryToMove)
            {
                case 1:
                    ClassRobot.currentLocation[0] += 1;
                    break;
                case 2:
                    ClassRobot.currentLocation[1] += 1;
                    break;
                case 3:
                    ClassRobot.currentLocation[0] -= 1;
                    break;
                case 4:
                    if (rightsLeft)
                        ClassRobot.currentLocation[1] -= 1;
                    break;
            }
            if (!ClassLogics.ch)
                PlaceWhereRobot();
            Thread.Sleep(1000);
        }

        public static void PlaceWhereRobot()
        {
            currentPlace = null;
            string x = ClassRobot.currentLocation[0].ToString();
            string y = ClassRobot.currentLocation[1].ToString();
            currentPlace = x + y;
            switch (currentPlace)
            {
                case "00":
                    ClassRobot.currentRoomForRobot[0, 0] -= 1;
                    break;
                case "01":
                    ClassRobot.currentRoomForRobot[0, 1] -= 1;
                    break;
                case "02":
                    ClassRobot.currentRoomForRobot[0, 2] -= 1;
                    break;
                case "03":
                    ClassRobot.currentRoomForRobot[0, 3] -= 1;
                    break;
                case "04":
                    ClassRobot.currentRoomForRobot[0, 4] -= 1;
                    break;
                case "10":
                    ClassRobot.currentRoomForRobot[1, 0] -= 1;
                    break;
                case "11":
                    ClassRobot.currentRoomForRobot[1, 1] -= 1;
                    break;
                case "12":
                    ClassRobot.currentRoomForRobot[1, 2] -= 1;
                    break;
                case "13":
                    ClassRobot.currentRoomForRobot[1, 3] -= 1;
                    break;
                case "14":
                    ClassRobot.currentRoomForRobot[1, 4] -= 1;
                    break;
                case "20":
                    ClassRobot.currentRoomForRobot[2, 0] -= 1;
                    break;
                case "21":
                    ClassRobot.currentRoomForRobot[2, 1] -= 1;
                    break;
                case "22":
                    ClassRobot.currentRoomForRobot[2, 2] -= 1;
                    break;
                case "23":
                    ClassRobot.currentRoomForRobot[2, 3] -= 1;
                    break;
                case "24":
                    ClassRobot.currentRoomForRobot[2, 4] -= 1;
                    break;
                case "30":
                    ClassRobot.currentRoomForRobot[3, 0] -= 1;
                    break;
                case "31":
                    ClassRobot.currentRoomForRobot[3, 1] -= 1;
                    break;
                case "32":
                    ClassRobot.currentRoomForRobot[3, 2] -= 1;
                    break;
                case "33":
                    ClassRobot.currentRoomForRobot[3, 3] -= 1;
                    break;
                case "34":
                    ClassRobot.currentRoomForRobot[3, 4] -= 1;
                    break;
                case "40":
                    ClassRobot.currentRoomForRobot[4, 0] -= 1;
                    break;
                case "41":
                    ClassRobot.currentRoomForRobot[4, 1] -= 1;
                    break;
                case "42":
                    ClassRobot.currentRoomForRobot[4, 2] -= 1;
                    break;
                case "43":
                    ClassRobot.currentRoomForRobot[4, 3] -= 1;
                    break;
                case "44":
                    ClassRobot.currentRoomForRobot[4, 4] -= 1;
                    break;
            }
        }
    }
}
