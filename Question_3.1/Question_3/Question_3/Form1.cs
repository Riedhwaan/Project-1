using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Question_3
{
    public partial class Form1 : Form
    {
        int rounds = 3;
        int RoundTime = 6;
        Boolean Game_Over = false;

        string[] CPUchoiceList = {"rock","paper","scissors", "paper", "scissors", "rock"};

        int Num_Random = 0;
        Random rnd = new Random();

        string CPU_Choice;
        string Player_Choice;
        int Player_Score;
        int CPU_Score;



        public Form1()
        {
            InitializeComponent();

            CountdownTimer.Enabled = true;
            Player_Choice = "none";
            txtCount.Text = "5";
            

        }

        private void btn_Rock_Click(object sender, EventArgs e)
        {
            picture_Player.Image = Properties.Resources.rock;
            Player_Choice = "rock";
        }

        private void btn_Paper_Click(object sender, EventArgs e)
        {
            picture_Player.Image = Properties.Resources.paper;
            Player_Choice = "paper";
        }

        private void btn_Scissors_Click(object sender, EventArgs e)
        {
            picture_Player.Image = Properties.Resources.scissors;
            Player_Choice = "scissors";
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            Player_Score = 0;
            CPU_Score = 0;
            rounds = 3;
            txtScore.Text = "Player: " + Player_Score + " - " + "CPU: " + CPU_Score;
            Player_Choice = "none";
            CountdownTimer.Enabled = true;
            picture_Player.Image = Properties.Resources.Question;
            picture_CPU.Image = Properties.Resources.Question;
            Game_Over = false;
        }

        private void CountdownTimer_Tick(object sender, EventArgs e)
        {

            RoundTime -= 1;

            txtCount.Text = RoundTime.ToString();

            txtRound.Text = "Rounds: " + rounds;

            if (RoundTime < 1)
            {
                CountdownTimer.Enabled = false;
                RoundTime = 6;
                Num_Random = rnd.Next(0, CPUchoiceList.Length);
                CPU_Choice = CPUchoiceList[Num_Random];

                switch(CPU_Choice)
                {
                    case "rock":
                        picture_CPU.Image = Properties.Resources.rock;

                        break;
                    case "paper":
                        picture_CPU.Image = Properties.Resources.paper;

                        break;
                    case "scissors":
                        picture_CPU.Image = Properties.Resources.scissors;
                        break;
                    
                }

                if (rounds > 0)
                {
                    checkGame();
                }
                else
                {
                    if (Player_Score > CPU_Score)
                    {
                        MessageBox.Show("Player wins the game");
                    }
                    else
                    {
                        MessageBox.Show("CPU wins the game");
                    }
                }

                Game_Over = true;
            }

        }

        private void checkGame()
        {
            if(Player_Choice == "rock" && CPU_Choice == "paper")
            {
                CPU_Score += 1;
                rounds -= 1;
                MessageBox.Show("CPU Wins, Paper Covers Rock");
            }
            else if (Player_Choice == "paper" && CPU_Choice == "scissors")
            {
                CPU_Score += 1;
                rounds -= 1;
                MessageBox.Show("CPU Wins, Scissors Cuts Paper");
            }
            else if (Player_Choice == "scissors" && CPU_Choice == "rock")
            {
                CPU_Score += 1;
                rounds -= 1;
                MessageBox.Show("CPU Wins, Rock Breaks Scissors");
            }
            else if (Player_Choice == "rock" && CPU_Choice == "scissors")
            {
                Player_Score += 1;
                rounds -= 1;
                MessageBox.Show("Player Wins, Rock Breaks Scissors");
            }
            else if (Player_Choice == "paper" && CPU_Choice == "rock")
            {
                Player_Score += 1;
                rounds -= 1;
                MessageBox.Show("Player Wins, Paper Covers Rock");
            }
            else if (Player_Choice == "scissors" && CPU_Choice == "paper")
            {
                Player_Score += 1;
                rounds -= 1;
                MessageBox.Show("Player Wins, Scissors Cuts Paper");
            }
            else if (Player_Choice == "none")
            {
                MessageBox.Show("Choose");
            }
            else
            {
                MessageBox.Show("It's a Draw!!!");
            }

            beginNextRound();

        }
        private void beginNextRound()
        {
            if(Game_Over == true)
            {
                return;
            }

            txtScore.Text = "Player: " + Player_Score + " - " + "CPU: " + CPU_Score;
            Player_Choice = "none";
            CountdownTimer.Enabled = true;
            picture_Player.Image = Properties.Resources.Question;
            picture_CPU.Image = Properties.Resources.Question;
        }
    }
}
