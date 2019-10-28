using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace CleverMove
{
    public partial class FormMain : Form
    {
        Mes mes = new Mes();
        EventWaitHandle ew;

        public FormMain()
        {
            InitializeComponent();
            ew = new EventWaitHandle(false, EventResetMode.AutoReset);
        }

        public void SetRobot()
        {
            if (!ClassLogics.ch)
            {
                pictureRobot.Visible = true;
                int y = 65 + 100 * ClassRobot.currentLocation[0];
                int x = 65 + 100 * ClassRobot.currentLocation[1];
                pictureRobot.Location = new Point(x, y);
            }
        }

        private void button00_Click(object sender, EventArgs e)
        {
            if (ClassRoom.startRobot == false)
            {
                if (ClassRoom.setRobot == false)
                {
                    ClassRoom.currentRoom[0, 0] = !ClassRoom.currentRoom[0, 0];
                    if (ClassRoom.currentRoom[0, 0] == true) button00.BackColor = Color.Green;
                    else button00.BackColor = Color.Red;
                }
                else
                {
                    ClassRobot.currentLocation[0] = 0;
                    ClassRobot.currentLocation[1] = 0;
                    SetRobot();
                }
            }
        }

        private void button01_Click(object sender, EventArgs e)
        {
            if (ClassRoom.startRobot == false)
            {
                if (ClassRoom.setRobot == false)
                {
                    ClassRoom.currentRoom[0, 1] = !ClassRoom.currentRoom[0, 1];
                    if (ClassRoom.currentRoom[0, 1] == true) button01.BackColor = Color.Green;
                    else button01.BackColor = Color.Red;
                }
                else
                {
                    ClassRobot.currentLocation[0] = 0;
                    ClassRobot.currentLocation[1] = 1;
                    SetRobot();
                }
            }
        }

        private void button02_Click(object sender, EventArgs e)
        {
            if (ClassRoom.startRobot == false)
            {
                if (ClassRoom.setRobot == false)
                {
                    ClassRoom.currentRoom[0, 2] = !ClassRoom.currentRoom[0, 2];
                    if (ClassRoom.currentRoom[0, 2] == true) button02.BackColor = Color.Green;
                    else button02.BackColor = Color.Red;
                }
                else
                {
                    ClassRobot.currentLocation[0] = 0;
                    ClassRobot.currentLocation[1] = 2;
                    SetRobot();
                }
            }
        }

        private void button03_Click(object sender, EventArgs e)
        {
            if (ClassRoom.startRobot == false)
            {
                if (ClassRoom.setRobot == false)
                {
                    ClassRoom.currentRoom[0, 3] = !ClassRoom.currentRoom[0, 3];
                    if (ClassRoom.currentRoom[0, 3] == true) button03.BackColor = Color.Green;
                    else button03.BackColor = Color.Red;
                }
                else
                {
                    ClassRobot.currentLocation[0] = 0;
                    ClassRobot.currentLocation[1] = 3;
                    SetRobot();
                }
            }
        }

        private void button04_Click(object sender, EventArgs e)
        {
            if (ClassRoom.startRobot == false)
            {
                if (ClassRoom.setRobot == false)
                {
                    ClassRoom.currentRoom[0, 4] = !ClassRoom.currentRoom[0, 4];
                    if (ClassRoom.currentRoom[0, 4] == true) button04.BackColor = Color.Green;
                    else button04.BackColor = Color.Red;
                }
                else
                {
                    ClassRobot.currentLocation[0] = 0;
                    ClassRobot.currentLocation[1] = 4;
                    SetRobot();
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (ClassRoom.startRobot == false)
            {
                if (ClassRoom.setRobot == false)
                {
                    ClassRoom.currentRoom[1, 0] = !ClassRoom.currentRoom[1, 0];
                    if (ClassRoom.currentRoom[1, 0] == true) button10.BackColor = Color.Green;
                    else button10.BackColor = Color.Red;
                }
                else
                {
                    ClassRobot.currentLocation[0] = 1;
                    ClassRobot.currentLocation[1] = 0;
                    SetRobot();
                }
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (ClassRoom.startRobot == false)
            {
                if (ClassRoom.setRobot == false)
                {
                    ClassRoom.currentRoom[1, 1] = !ClassRoom.currentRoom[1, 1];
                    if (ClassRoom.currentRoom[1, 1] == true) button11.BackColor = Color.Green;
                    else button11.BackColor = Color.Red;
                }
                else
                {
                    ClassRobot.currentLocation[0] = 1;
                    ClassRobot.currentLocation[1] = 1;
                    SetRobot();
                }
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (ClassRoom.startRobot == false)
            {
                if (ClassRoom.setRobot == false)
                {
                    ClassRoom.currentRoom[1, 2] = !ClassRoom.currentRoom[1, 2];
                    if (ClassRoom.currentRoom[1, 2] == true) button12.BackColor = Color.Green;
                    else button12.BackColor = Color.Red;
                }
                else
                {
                    ClassRobot.currentLocation[0] = 1;
                    ClassRobot.currentLocation[1] = 2;
                    SetRobot();
                }
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (ClassRoom.startRobot == false)
            {
                if (ClassRoom.setRobot == false)
                {
                    ClassRoom.currentRoom[1, 3] = !ClassRoom.currentRoom[1, 3];
                    if (ClassRoom.currentRoom[1, 3] == true) button13.BackColor = Color.Green;
                    else button13.BackColor = Color.Red;
                }
                else
                {
                    ClassRobot.currentLocation[0] = 1;
                    ClassRobot.currentLocation[1] = 3;
                    SetRobot();
                }
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (ClassRoom.startRobot == false)
            {
                if (ClassRoom.setRobot == false)
                {
                    ClassRoom.currentRoom[1, 4] = !ClassRoom.currentRoom[1, 4];
                    if (ClassRoom.currentRoom[1, 4] == true) button14.BackColor = Color.Green;
                    else button14.BackColor = Color.Red;
                }
                else
                {
                    ClassRobot.currentLocation[0] = 1;
                    ClassRobot.currentLocation[1] = 4;
                    SetRobot();
                }
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (ClassRoom.startRobot == false)
            {
                if (ClassRoom.setRobot == false)
                {
                    ClassRoom.currentRoom[2, 0] = !ClassRoom.currentRoom[2, 0];
                    if (ClassRoom.currentRoom[2, 0] == true) button20.BackColor = Color.Green;
                    else button20.BackColor = Color.Red;
                }
                else
                {
                    ClassRobot.currentLocation[0] = 2;
                    ClassRobot.currentLocation[1] = 0;
                    SetRobot();
                }
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (ClassRoom.startRobot == false)
            {
                if (ClassRoom.setRobot == false)
                {
                    ClassRoom.currentRoom[2, 1] = !ClassRoom.currentRoom[2, 1];
                    if (ClassRoom.currentRoom[2, 1] == true) button21.BackColor = Color.Green;
                    else button21.BackColor = Color.Red;
                }
                else
                {
                    ClassRobot.currentLocation[0] = 2;
                    ClassRobot.currentLocation[1] = 1;
                    SetRobot();
                }
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (ClassRoom.startRobot == false)
            {
                if (ClassRoom.setRobot == false)
                {
                    ClassRoom.currentRoom[2, 2] = !ClassRoom.currentRoom[2, 2];
                    if (ClassRoom.currentRoom[2, 2] == true) button22.BackColor = Color.Green;
                    else button22.BackColor = Color.Red;
                }
                else
                {
                    ClassRobot.currentLocation[0] = 2;
                    ClassRobot.currentLocation[1] = 2;
                    SetRobot();
                }
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (ClassRoom.startRobot == false)
            {
                if (ClassRoom.setRobot == false)
                {
                    ClassRoom.currentRoom[2, 3] = !ClassRoom.currentRoom[2, 3];
                    if (ClassRoom.currentRoom[2, 3] == true) button23.BackColor = Color.Green;
                    else button23.BackColor = Color.Red;
                }
                else
                {
                    ClassRobot.currentLocation[0] = 2;
                    ClassRobot.currentLocation[1] = 3;
                    SetRobot();
                }
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (ClassRoom.startRobot == false)
            {
                if (ClassRoom.setRobot == false)
                {
                    ClassRoom.currentRoom[2, 4] = !ClassRoom.currentRoom[2, 4];
                    if (ClassRoom.currentRoom[2, 4] == true) button24.BackColor = Color.Green;
                    else button24.BackColor = Color.Red;
                }
                else
                {
                    ClassRobot.currentLocation[0] = 2;
                    ClassRobot.currentLocation[1] = 4;
                    SetRobot();
                }
            }
        }

        private void button30_Click(object sender, EventArgs e)
        {
            if (ClassRoom.startRobot == false)
            {
                if (ClassRoom.setRobot == false)
                {
                    ClassRoom.currentRoom[3, 0] = !ClassRoom.currentRoom[3, 0];
                    if (ClassRoom.currentRoom[3, 0] == true) button30.BackColor = Color.Green;
                    else button30.BackColor = Color.Red;
                }
                else
                {
                    ClassRobot.currentLocation[0] = 3;
                    ClassRobot.currentLocation[1] = 0;
                    SetRobot();
                }
            }
        }

        private void button31_Click(object sender, EventArgs e)
        {
            if (ClassRoom.startRobot == false)
            {
                if (ClassRoom.setRobot == false)
                {
                    ClassRoom.currentRoom[3, 1] = !ClassRoom.currentRoom[3, 1];
                    if (ClassRoom.currentRoom[3, 1] == true) button31.BackColor = Color.Green;
                    else button31.BackColor = Color.Red;
                }
                else
                {
                    ClassRobot.currentLocation[0] = 3;
                    ClassRobot.currentLocation[1] = 1;
                    SetRobot();
                }
            }
        }

        private void button32_Click(object sender, EventArgs e)
        {
            if (ClassRoom.startRobot == false)
            {
                if (ClassRoom.setRobot == false)
                {
                    ClassRoom.currentRoom[3, 2] = !ClassRoom.currentRoom[3, 2];
                    if (ClassRoom.currentRoom[3, 2] == true) button32.BackColor = Color.Green;
                    else button32.BackColor = Color.Red;
                }
                else
                {
                    ClassRobot.currentLocation[0] = 3;
                    ClassRobot.currentLocation[1] = 2;
                    SetRobot();
                }
            }
        }

        private void button33_Click(object sender, EventArgs e)
        {
            if (ClassRoom.startRobot == false)
            {
                if (ClassRoom.setRobot == false)
                {
                    ClassRoom.currentRoom[3, 3] = !ClassRoom.currentRoom[3, 3];
                    if (ClassRoom.currentRoom[3, 3] == true) button33.BackColor = Color.Green;
                    else button33.BackColor = Color.Red;
                }
                else
                {
                    ClassRobot.currentLocation[0] = 3;
                    ClassRobot.currentLocation[1] = 3;
                    SetRobot();
                }
            }
        }

        private void button34_Click(object sender, EventArgs e)
        {
            if (ClassRoom.startRobot == false)
            {
                if (ClassRoom.setRobot == false)
                {
                    ClassRoom.currentRoom[3, 4] = !ClassRoom.currentRoom[3, 4];
                    if (ClassRoom.currentRoom[3, 4] == true) button34.BackColor = Color.Green;
                    else button34.BackColor = Color.Red;
                }
                else
                {
                    ClassRobot.currentLocation[0] = 3;
                    ClassRobot.currentLocation[1] = 4;
                    SetRobot();
                }
            }
        }

        private void button40_Click(object sender, EventArgs e)
        {
            if (ClassRoom.startRobot == false)
            {
                if (ClassRoom.setRobot == false)
                {
                    ClassRoom.currentRoom[4, 0] = !ClassRoom.currentRoom[4, 0];
                    if (ClassRoom.currentRoom[4, 0] == true) button40.BackColor = Color.Green;
                    else button40.BackColor = Color.Red;
                }
                else
                {
                    ClassRobot.currentLocation[0] = 4;
                    ClassRobot.currentLocation[1] = 0;
                    SetRobot();
                }
            }
        }

        private void button41_Click(object sender, EventArgs e)
        {
            if (ClassRoom.startRobot == false)
            {
                if (ClassRoom.setRobot == false)
                {
                    ClassRoom.currentRoom[4, 1] = !ClassRoom.currentRoom[4, 1];
                    if (ClassRoom.currentRoom[4, 1] == true) button41.BackColor = Color.Green;
                    else button41.BackColor = Color.Red;
                }
                else
                {
                    ClassRobot.currentLocation[0] = 4;
                    ClassRobot.currentLocation[1] = 1;
                    SetRobot();
                }
            }
        }

        private void button42_Click(object sender, EventArgs e)
        {
            if (ClassRoom.startRobot == false)
            {
                if (ClassRoom.setRobot == false)
                {
                    ClassRoom.currentRoom[4, 2] = !ClassRoom.currentRoom[4, 2];
                    if (ClassRoom.currentRoom[4, 2] == true) button42.BackColor = Color.Green;
                    else button42.BackColor = Color.Red;
                }
                else
                {
                    ClassRobot.currentLocation[0] = 4;
                    ClassRobot.currentLocation[1] = 2;
                    SetRobot();
                }
            }
        }


        private void button43_Click(object sender, EventArgs e)
        {
            if (ClassRoom.startRobot == false)
            {
                if (ClassRoom.setRobot == false)
                {
                    ClassRoom.currentRoom[4, 3] = !ClassRoom.currentRoom[4, 3];
                    if (ClassRoom.currentRoom[4, 3] == true) button43.BackColor = Color.Green;
                    else button43.BackColor = Color.Red;
                }
                else
                {
                    ClassRobot.currentLocation[0] = 4;
                    ClassRobot.currentLocation[1] = 3;
                    SetRobot();
                }
            }
        }

        private void button44_Click(object sender, EventArgs e)
        {
            if (ClassRoom.startRobot == false)
            {
                if (ClassRoom.setRobot == false)
                {
                    ClassRoom.currentRoom[4, 4] = !ClassRoom.currentRoom[4, 4];
                    if (ClassRoom.currentRoom[4, 4] == true) button44.BackColor = Color.Green;
                    else button44.BackColor = Color.Red;
                }
                else
                {
                    ClassRobot.currentLocation[0] = 4;
                    ClassRobot.currentLocation[1] = 4;
                    SetRobot();
                }
            }
        }
        

        private void main_Load(object sender, EventArgs e)
        {
            ClassRoom.ResetRoom();
            button00.BackColor =
            button00.BackColor =
            button01.BackColor =
            button02.BackColor =
            button03.BackColor =
            button04.BackColor =
            button10.BackColor =
            button11.BackColor =
            button12.BackColor =
            button13.BackColor =
            button14.BackColor =
            button20.BackColor =
            button21.BackColor =
            button22.BackColor =
            button23.BackColor =
            button24.BackColor =
            button30.BackColor =
            button31.BackColor =
            button32.BackColor =
            button33.BackColor =
            button34.BackColor =
            button40.BackColor =
            button41.BackColor =
            button42.BackColor =
            button43.BackColor =
            button44.BackColor = Color.Red;
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbSetRobot_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            if (checkBox.Checked == true)
            {
                ClassRoom.setRobot = true;
            }
            else
            {
                ClassRoom.setRobot = false;
            }
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            SetRobot();
            if (ClassRoom.currentRoom[ClassRobot.currentLocation[0], ClassRobot.currentLocation[1]] == true)
            {
                ClassRoom.startRobot = true;
                button00.BackColor =
                button00.BackColor =
                button01.BackColor =
                button02.BackColor =
                button03.BackColor =
                button04.BackColor =
                button10.BackColor =
                button11.BackColor =
                button12.BackColor =
                button13.BackColor =
                button14.BackColor =
                button20.BackColor =
                button21.BackColor =
                button22.BackColor =
                button23.BackColor =
                button24.BackColor =
                button30.BackColor =
                button31.BackColor =
                button32.BackColor =
                button33.BackColor =
                button34.BackColor =
                button40.BackColor =
                button41.BackColor =
                button42.BackColor =
                button43.BackColor =
                button44.BackColor = Color.Gray;
                ClassRobot.StartRobot();
                PigmentRoom();
                ClassLogics.DoTheMove();
            }
            else
            {
                MessageBox.Show("Установите робота на землю");
            }
        }

        private void Mess()
        {
            if (ClassLogics.ppp == 0)
            {
                var w = new Form() { /*Size = new Size(0,0)*/ Visible = false };
                Task.Delay(TimeSpan.FromMilliseconds(100))
                    .ContinueWith((t) => w.Close(), TaskScheduler.FromCurrentSynchronizationContext());

                MessageBox.Show(w, "", "");
                ClassLogics.ppp++;
            }
            else
            {
                var w = new Form() { /*Size = new Size(0, 0);*/ Visible = false };
                Task.Delay(TimeSpan.FromMilliseconds(100))
                    .ContinueWith((t) => w.Close(), TaskScheduler.FromCurrentSynchronizationContext());

                MessageBox.Show(w, "", "");
            }
        }

        public void PigmentRoomSecond()
        {
            SetRobot();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {

                    string x = i.ToString();
                    string y = j.ToString();
                    string currentPlace = x + y;
                    if (ClassRobot.currentRoomForRobot[i, j] < 0)
                    {
                        switch (currentPlace)
                        {
                            case "00":
                                button00.BackColor = Color.Green;
                                break;
                            case "01":
                                button01.BackColor = Color.Green;
                                break;
                            case "02":
                                button02.BackColor = Color.Green;
                                break;
                            case "03":
                                button03.BackColor = Color.Green;
                                break;
                            case "04":
                                button04.BackColor = Color.Green;
                                break;
                            case "10":
                                button10.BackColor = Color.Green;
                                break;
                            case "11":
                                button11.BackColor = Color.Green;
                                break;
                            case "12":
                                button12.BackColor = Color.Green;
                                break;
                            case "13":
                                button13.BackColor = Color.Green;
                                break;
                            case "14":
                                button14.BackColor = Color.Green;
                                break;
                            case "20":
                                button20.BackColor = Color.Green;
                                break;
                            case "21":
                                button21.BackColor = Color.Green;
                                break;
                            case "22":
                                button22.BackColor = Color.Green;
                                break;
                            case "23":
                                button23.BackColor = Color.Green;
                                break;
                            case "24":
                                button24.BackColor = Color.Green;
                                break;
                            case "30":
                                button30.BackColor = Color.Green;
                                break;
                            case "31":
                                button31.BackColor = Color.Green;
                                break;
                            case "32":
                                button32.BackColor = Color.Green;
                                break;
                            case "33":
                                button33.BackColor = Color.Green;
                                break;
                            case "34":
                                button34.BackColor = Color.Green;
                                break;
                            case "40":
                                button40.BackColor = Color.Green;
                                break;
                            case "41":
                                button41.BackColor = Color.Green;
                                break;
                            case "42":
                                button42.BackColor = Color.Green;
                                break;
                            case "43":
                                button43.BackColor = Color.Green;
                                break;
                            case "44":
                                button44.BackColor = Color.Green;
                                break;
                        }
                    }
                    if (ClassRobot.currentRoomForRobot[i, j] == 1)
                    {
                        switch (currentPlace)
                        {
                            case "00":
                                button00.BackColor = Color.Red;
                                break;
                            case "01":
                                button01.BackColor = Color.Red;
                                break;
                            case "02":
                                button02.BackColor = Color.Red;
                                break;
                            case "03":
                                button03.BackColor = Color.Red;
                                break;
                            case "04":
                                button04.BackColor = Color.Red;
                                break;
                            case "10":
                                button10.BackColor = Color.Red;
                                break;
                            case "11":
                                button11.BackColor = Color.Red;
                                break;
                            case "12":
                                button12.BackColor = Color.Red;
                                break;
                            case "13":
                                button13.BackColor = Color.Red;
                                break;
                            case "14":
                                button14.BackColor = Color.Red;
                                break;
                            case "20":
                                button20.BackColor = Color.Red;
                                break;
                            case "21":
                                button21.BackColor = Color.Red;
                                break;
                            case "22":
                                button22.BackColor = Color.Red;
                                break;
                            case "23":
                                button23.BackColor = Color.Red;
                                break;
                            case "24":
                                button24.BackColor = Color.Red;
                                break;
                            case "30":
                                button30.BackColor = Color.Red;
                                break;
                            case "31":
                                button31.BackColor = Color.Red;
                                break;
                            case "32":
                                button32.BackColor = Color.Red;
                                break;
                            case "33":
                                button33.BackColor = Color.Red;
                                break;
                            case "34":
                                button34.BackColor = Color.Red;
                                break;
                            case "40":
                                button40.BackColor = Color.Red;
                                break;
                            case "41":
                                button41.BackColor = Color.Red;
                                break;
                            case "42":
                                button42.BackColor = Color.Red;
                                break;
                            case "43":
                                button43.BackColor = Color.Red;
                                break;
                            case "44":
                                button44.BackColor = Color.Red;
                                break;
                        }
                    }
                }
            }
        }

        private bool CheckFinish()
        {
            int f = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (ClassRobot.currentRoomForRobot[i, j] != 0)
                    {
                        f++;
                        if (ClassRobot.currentRoomForRobot[i, j] == -8)
                        {
                            ClassLogics.ch = true;
                        }
                    }
                }
            }
            if (f == 25) ClassLogics.ch = true;
            return ClassLogics.ch;
        }

        private void SuppotrTime()
        {
            Thread.Sleep(3000);
            SendKeys.Send("{enter}");
        }

        public void PigmentRoom()
        {
            PigmentRoomSecond();
            Mess();
            //Thread thread = new Thread(SuppotrTime);
            //mes.ShowDialog();
            CheckFinish();
            if (!CheckFinish())
                HelpFunc();
            else
                MessageBox.Show("Комната построена");
        }

        private void HelpFunc()
        {
            if(!ClassLogics.ch)ClassLogics.DoTheMove();
            PigmentRoom();
            //MessageBox.Show(ClassLogics.supportLeftBox.ToString() + " " + ClassLogics.supportUpBox.ToString() + " " + ClassLogics.supportRightBox.ToString() + " " + ClassLogics.supportDownBox.ToString() +"\n"
            //    +ClassRobot.currentLocation[0].ToString() + " " +ClassRobot.currentLocation[1].ToString() + "\n"
            //    + ClassLogics.currentPlace);
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            pictureRobot.Location = new Point(0, 0);
            pictureRobot.Visible = false;
            main_Load(sender, e);
            ClassRoom.startRobot = false;
            ClassLogics.ch = false;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    ClassRobot.currentRoomForRobot[i, j] = 0;
                    ClassRoom.currentRoom[i, j] = false;
                }
            }
        }
    }
}
