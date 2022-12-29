using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();       
        }
        static int count = 0;
        #region
        bool btn1IsFiled = false;
        bool btn2IsFiled = false;
        bool btn3IsFiled = false;
        bool btn4IsFiled = false;
        bool btn5IsFiled = false;
        bool btn6IsFiled = false;
        bool btn7IsFiled = false;
        bool btn8IsFiled = false;
        bool btn9IsFiled = false;


        static byte status1 = 0;
        static byte status2 = 0;
        static byte status3 = 0;
        static byte status4 = 0;
        static byte status5 = 0;
        static byte status6 = 0;
        static byte status7 = 0;
        static byte status8 = 0;
        static byte status9 = 0;
        #endregion
        static char isWinner = '0';
        Image defoltimage = Image.FromFile("C:\\Users\\Admin\\Desktop\\Work\\C#\\tic_tac_toe\\Tic_Tac_Toe\\Defolt_BG.png");

        static void win()
        {
            if (status1 == status2 && status1 == status3 && status2 == status3 && status1 != 0)
            {
                if (status1 == 1)
                {
                    isWinner = '1';
                }
                else if (status1 == 2)
                {
                    isWinner = '2';
                }
            }
            if (status1 == status4 && status1 == status7 && status4 == status7 && status1 != 0)
            {
                if (status1 == 1)
                {
                    isWinner = '1';
                }
                else if (status1 == 2)
                {
                    isWinner = '2';
                }
            }
            if (status1 == status5 && status1 == status9 && status5 == status9 && status1 != 0)
            {
                if (status1 == 1)
                {
                    isWinner = '1';
                }
                else if (status1 == 2)
                {
                    isWinner = '2';
                }
            }
            if (status4 == status5 && status4 == status6 && status5 == status6 && status4 != 0)
            {
                if (status4 == 1)
                {
                    isWinner = '1';
                }
                else if (status4 == 2)
                {
                    isWinner = '2';
                }
            }
            if (status7 == status8 && status7 == status9 && status8 == status9 && status7 != 0)
            {
                if (status7 == 1)
                {
                    isWinner = '1';
                }
                else if (status7 == 2)
                {
                    isWinner = '2';
                }
            }
            if (status2 == status5 && status2 == status8 && status5 == status8 && status2 != 0)
            {
                if (status2 == 1)
                {
                    isWinner = '1';
                }
                else if (status2 == 2)
                {
                    isWinner = '2';
                }
            }
            if (status3 == status6 && status3 == status9 && status6 == status9 && status3 != 0)
            {
                if (status3 == 1)
                {
                    isWinner = '1';
                }
                else if (status3 == 2)
                {
                    isWinner = '2';
                }
            }
            if (status3 == status5 && status3 == status7 && status5 == status7 && status3 != 0)
            {
                if (status3 == 1)
                {
                    isWinner = '1';
                }
                else if (status3 == 2)
                {
                    isWinner = '2';
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (!btn1IsFiled)
            {
                if (count%2 == 0)
                {
                    Image image = Image.FromFile("C:\\Users\\Admin\\Desktop\\Work\\C#\\tic_tac_toe\\Tic_Tac_Toe\\cross.png");
                    button1.BackgroundImage= image;
                    count++;
                    status1 = 1;
                }
                else
                {
                    Image image = Image.FromFile("C:\\Users\\Admin\\Desktop\\Work\\C#\\tic_tac_toe\\Tic_Tac_Toe\\circle.png");
                    button1.BackgroundImage = image;
                    count++;
                    status1= 2;
                }
                btn1IsFiled= true;

                win();
                if (isWinner == '1')
                {
                    restart.Text = "Winner is крестик";
                    restart.Show();
                }
                else if (isWinner == '2')
                {
                    restart.Text = "Winner is нолик";
                    restart.Show();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!btn2IsFiled)
            {
                if (count % 2 == 0)
                {
                    Image image = Image.FromFile("C:\\Users\\Admin\\Desktop\\Work\\C#\\tic_tac_toe\\Tic_Tac_Toe\\cross.png");
                    button2.BackgroundImage = image;
                    count++;
                    status2 = 1;
                }
                else
                {
                    Image image = Image.FromFile("C:\\Users\\Admin\\Desktop\\Work\\C#\\tic_tac_toe\\Tic_Tac_Toe\\circle.png");
                    button2.BackgroundImage = image;
                    count++;
                    status2 = 2;
                }
                btn2IsFiled = true;
                win();
                if (isWinner == '1')
                {
                    restart.Text = "Winner is крестик";
                    restart.Show();
                }
                else if (isWinner == '2')
                {
                    restart.Text = "Winner is нолик";
                    restart.Show();
                }
            }            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!btn3IsFiled)
            {
                if (count % 2 == 0)
                {
                    Image image = Image.FromFile("C:\\Users\\Admin\\Desktop\\Work\\C#\\tic_tac_toe\\Tic_Tac_Toe\\cross.png");
                    button3.BackgroundImage = image;
                    count++;
                    status3 = 1;
                }
                else
                {
                    Image image = Image.FromFile("C:\\Users\\Admin\\Desktop\\Work\\C#\\tic_tac_toe\\Tic_Tac_Toe\\circle.png");
                    button3.BackgroundImage = image;
                    count++;
                    status3 = 2;
                }
                btn3IsFiled = true;
                win();
                if (isWinner == '1')
                {
                    restart.Text = "Winner is крестик";
                    restart.Show();
                }
                else if (isWinner == '2')
                {
                    restart.Text = "Winner is нолик";
                    restart.Show();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!btn4IsFiled)
            {
                if (count % 2 == 0)
                {
                    Image image = Image.FromFile("C:\\Users\\Admin\\Desktop\\Work\\C#\\tic_tac_toe\\Tic_Tac_Toe\\cross.png");
                    button4.BackgroundImage = image;
                    count++;
                    status4 = 1;
                }
                else
                {
                    Image image = Image.FromFile("C:\\Users\\Admin\\Desktop\\Work\\C#\\tic_tac_toe\\Tic_Tac_Toe\\circle.png");
                    button4.BackgroundImage = image;
                    count++;
                    status4 = 2;
                }
                btn4IsFiled = true;
                win();
                if (isWinner == '1')
                {
                    restart.Text = "Winner is крестик";
                    restart.Show();
                }
                else if (isWinner == '2')
                {
                    restart.Text = "Winner is нолик";
                    restart.Show();
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!btn5IsFiled)
            {
                if (count % 2 == 0)
                {
                    Image image = Image.FromFile("C:\\Users\\Admin\\Desktop\\Work\\C#\\tic_tac_toe\\Tic_Tac_Toe\\cross.png");
                    button5.BackgroundImage = image;
                    count++;
                    status5 = 1;
                }
                else
                {
                    Image image = Image.FromFile("C:\\Users\\Admin\\Desktop\\Work\\C#\\tic_tac_toe\\Tic_Tac_Toe\\circle.png");
                    button5.BackgroundImage = image;
                    count++;
                    status5 = 2;
                }
                btn5IsFiled = true;
                win();
                if (isWinner == '1')
                {
                    restart.Text = "Winner is крестик";
                    restart.Show();
                }
                else if (isWinner == '2')
                {
                    restart.Text = "Winner is нолик";
                    restart.Show();
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (!btn6IsFiled)
            {
                if (count % 2 == 0)
                {
                    Image image = Image.FromFile("C:\\Users\\Admin\\Desktop\\Work\\C#\\tic_tac_toe\\Tic_Tac_Toe\\cross.png");
                    button6.BackgroundImage = image;
                    count++;
                    status6 = 1;
                }
                else
                {
                    Image image = Image.FromFile("C:\\Users\\Admin\\Desktop\\Work\\C#\\tic_tac_toe\\Tic_Tac_Toe\\circle.png");
                    button6.BackgroundImage = image;
                    count++;
                    status6 = 2;
                }
                btn6IsFiled = true;
                win();
                if (isWinner == '1')
                {
                    restart.Text = "Winner is крестик";
                    restart.Show();
                }
                else if (isWinner == '2')
                {
                    restart.Text = "Winner is нолик";
                    restart.Show();
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (!btn7IsFiled)
            {
                if (count % 2 == 0)
                {
                    Image image = Image.FromFile("C:\\Users\\Admin\\Desktop\\Work\\C#\\tic_tac_toe\\Tic_Tac_Toe\\cross.png");
                    button7.BackgroundImage = image;
                    count++;
                    status7 = 1;
                }
                else
                {
                    Image image = Image.FromFile("C:\\Users\\Admin\\Desktop\\Work\\C#\\tic_tac_toe\\Tic_Tac_Toe\\circle.png");
                    button7.BackgroundImage = image;
                    count++;
                    status7 = 2;
                }
                btn7IsFiled = true;
                win();
                if (isWinner == '1')
                {
                    restart.Text = "Winner is крестик";
                    restart.Show();
                }
                else if (isWinner == '2')
                {
                    restart.Text = "Winner is нолик";
                    restart.Show();
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (!btn8IsFiled)
            {
                if (count % 2 == 0)
                {
                    Image image = Image.FromFile("C:\\Users\\Admin\\Desktop\\Work\\C#\\tic_tac_toe\\Tic_Tac_Toe\\cross.png");
                    button8.BackgroundImage = image;
                    count++;
                    status8 = 1;
                }
                else
                {
                    Image image = Image.FromFile("C:\\Users\\Admin\\Desktop\\Work\\C#\\tic_tac_toe\\Tic_Tac_Toe\\circle.png");
                    button8.BackgroundImage = image;
                    count++;
                    status8 = 2;
                }
                btn8IsFiled = true;
                win();
                if (isWinner == '1')
                {
                    restart.Text = "Winner is крестик";
                    restart.Show();
                }
                else if (isWinner == '2')
                {
                    restart.Text = "Winner is нолик";
                    restart.Show();
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (!btn9IsFiled)
            {
                if (count % 2 == 0)
                {
                    Image image = Image.FromFile("C:\\Users\\Admin\\Desktop\\Work\\C#\\tic_tac_toe\\Tic_Tac_Toe\\cross.png");
                    button9.BackgroundImage = image;
                    count++;
                    status9 = 1;
                }
                else
                {
                    Image image = Image.FromFile("C:\\Users\\Admin\\Desktop\\Work\\C#\\tic_tac_toe\\Tic_Tac_Toe\\circle.png");
                    button9.BackgroundImage = image;
                    count++;
                    status9 = 2;
                }
                btn9IsFiled = true;
                win();
                if (isWinner == '1')
                {
                    restart.Text = "Winner is крестик";
                    restart.Show();
                }
                else if (isWinner == '2')
                {
                    restart.Text = "Winner is нолик";
                    restart.Show();
                }
            }
        }

        private void restart_Click(object sender, EventArgs e)
        {
            count = 0;
            btn1IsFiled = false;
            btn2IsFiled = false;
            btn3IsFiled = false;
            btn4IsFiled = false;
            btn5IsFiled = false;
            btn6IsFiled = false;
            btn7IsFiled = false;
            btn8IsFiled = false;
            btn9IsFiled = false;

            status1 = 0;
            status2 = 0;
            status3 = 0;
            status4 = 0;
            status5 = 0;
            status6 = 0;
            status7 = 0;
            status8 = 0;
            status9 = 0;

            button1.BackgroundImage = defoltimage;
            button2.BackgroundImage = defoltimage;
            button3.BackgroundImage = defoltimage;
            button4.BackgroundImage = defoltimage;
            button5.BackgroundImage = defoltimage;
            button6.BackgroundImage = defoltimage;
            button7.BackgroundImage = defoltimage;
            button8.BackgroundImage = defoltimage;
            button9.BackgroundImage = defoltimage;
            isWinner = '0';

            restart.Hide();
        }
    }
}
