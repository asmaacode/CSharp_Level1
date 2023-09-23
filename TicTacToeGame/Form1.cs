using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicTacToeGame.Properties;

namespace TicTacToeGame
{
    public partial class FrmTicToeGame : Form
    {
        public FrmTicToeGame()
        {
            InitializeComponent();
        }

        private void FrmTicToeGame_Paint(object sender, PaintEventArgs e)
        {
            Color color = Color.White;
            Pen pen = new Pen(color, 4);

            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            e.Graphics.DrawLine(pen, 450, 120, 450, 450);//First Ver
            e.Graphics.DrawLine(pen, 600, 120, 600, 450);//2nd Ver

            e.Graphics.DrawLine(pen, 300, 230, 750, 230);//1st Horz
            e.Graphics.DrawLine(pen, 300, 330, 750, 330);//1st Horz
        }
        private void SetPlayerPicture(object sender)
        {
            if (lblCurrentTurn.Tag.ToString() == "Player1")
            {
                ((PictureBox)sender).Image = Resources.X;
                ((PictureBox)sender).Tag = "X";
            }
            else
            {
                ((PictureBox)sender).Image = Resources.O;
                ((PictureBox)sender).Tag = "O";
            }

        }
        private void ShowWrongChoiceMsg()
        {
            MessageBox.Show("Wrong Choice !", "Ooops", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void ChangeTurn()
        {
            if (lblCurrentTurn.Tag.ToString() == "Player1")
            {
                lblCurrentTurn.Tag = "Player2";
                lblCurrentTurn.Text = "Player 2";
            }
            else
            {
                lblCurrentTurn.Tag = "Player1";
                lblCurrentTurn.Text = "Player 1";
            }

        }
        private string CheckWinner()
        {
            //Diagonal
            if (pb1.Tag.ToString() != " " && pb1.Tag.ToString() == pb5.Tag.ToString() && pb1.Tag.ToString() == pb9.Tag.ToString())
            {
                return "Diagonal1";
            }
            if (pb3.Tag.ToString() != " " && pb3.Tag.ToString() == pb5.Tag.ToString() && pb3.Tag.ToString() == pb7.Tag.ToString())
            {
                return "Diagonal2";
            }
            //Horizantial
            if (pb1.Tag.ToString() != " " && pb1.Tag.ToString() == pb2.Tag.ToString() && pb1.Tag.ToString() == pb3.Tag.ToString())
            {
                return "Horizantal1";
            }
            if (pb4.Tag.ToString() != " " && pb4.Tag.ToString() == pb5.Tag.ToString() && pb4.Tag.ToString() == pb6.Tag.ToString())
            {
                return "Horizantal2";
            }
            if (pb7.Tag.ToString() != " " && pb7.Tag.ToString() == pb8.Tag.ToString() && pb7.Tag.ToString() == pb9.Tag.ToString())
            {
                return "Horizantal3";
            }
            //Vertical
            if (pb1.Tag.ToString() != " " && pb1.Tag.ToString() == pb4.Tag.ToString() && pb1.Tag.ToString() == pb7.Tag.ToString())
            {
                return "Vertical1";
            }
            if (pb2.Tag.ToString() != " " && pb2.Tag.ToString() == pb5.Tag.ToString() && pb2.Tag.ToString() == pb8.Tag.ToString())
            {
                return "Vertical2";
            }
            if (pb3.Tag.ToString() != " " && pb3.Tag.ToString() == pb6.Tag.ToString() && pb3.Tag.ToString() == pb9.Tag.ToString())
            {
                return "Vertical3";
            }
            return "No Winner";
        }
        private bool CheckIsFull()
        {
            if (pb1.Tag.ToString() == " ")
                return false;
            if (pb2.Tag.ToString() == " ")
                return false;
            if (pb3.Tag.ToString() == " ")
                return false;
            if (pb4.Tag.ToString() == " ")
                return false;
            if (pb5.Tag.ToString() == " ")
                return false;
            if (pb6.Tag.ToString() == " ")
                return false;
            if (pb7.Tag.ToString() == " ")
                return false;
            if (pb8.Tag.ToString() == " ")
                return false;
            if (pb9.Tag.ToString() == " ")
                return false;
            return true;
        }
        private void EndGame()
        {
            panel1.Enabled = false;
            lblCurrentTurn.Tag = "Game Over";
            MessageBox.Show("Game Over", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void SetWinner()
        {
            lblWinnerValue.Text = lblCurrentTurn.Text;
        }
        private void SetDraw()
        {
            lblWinnerValue.Text = "    Draw  ";
        }
        private void ColorWinnerPictures(string winnerLocation)
        {
            switch (winnerLocation)
            {
                case "Diagonal1":
                    pb1.BackColor = pb5.BackColor = pb9.BackColor = Color.Green;
                    break;
                case "Diagonal2":
                    pb3.BackColor = pb5.BackColor = pb7.BackColor = Color.Green;
                    break;
                case "Horizantal1":
                    pb1.BackColor = pb2.BackColor = pb3.BackColor = Color.Green;
                    break;
                case "Horizantal2":
                    pb4.BackColor = pb5.BackColor = pb6.BackColor = Color.Green;
                    break;
                case "Horizantal3":
                    pb7.BackColor = pb8.BackColor = pb9.BackColor = Color.Green;
                    break;
                case "Vertical1":
                    pb1.BackColor = pb4.BackColor = pb7.BackColor = Color.Green;
                    break;
                case "Vertical2":
                    pb2.BackColor = pb5.BackColor = pb8.BackColor = Color.Green;
                    break;
                case "Vertical3":
                    pb3.BackColor = pb6.BackColor = pb9.BackColor = Color.Green;
                    break;

            }
        }
        private void HandleGameTurn(object sender)
        {
            SetPlayerPicture(sender);
            string winner = CheckWinner();
            if (winner == "No Winner")
            {
                if (CheckIsFull())
                {
                    SetDraw();
                    EndGame();
                }
                else
                    ChangeTurn();
            }
            else
            {
                ColorWinnerPictures(winner);
                SetWinner();
                EndGame();
            }
        }
        private void PictureBoxChanged(object sender)
        {
            if (((PictureBox)sender).Tag.ToString() != " ")
            {
                ShowWrongChoiceMsg();
                return;
            }
            else
            {
                HandleGameTurn(sender);
            }
        }
        private void pb1_Click(object sender, EventArgs e)
        {
            PictureBoxChanged(sender);
        }

        private void pb2_Click(object sender, EventArgs e)
        {
            PictureBoxChanged(sender);
        }

        private void pb3_Click(object sender, EventArgs e)
        {
            PictureBoxChanged(sender);
        }

        private void pb4_Click(object sender, EventArgs e)
        {
            PictureBoxChanged(sender);
        }

        private void pb5_Click(object sender, EventArgs e)
        {
            PictureBoxChanged(sender);
        }

        private void pb6_Click(object sender, EventArgs e)
        {
            PictureBoxChanged(sender);
        }

        private void pb7_Click(object sender, EventArgs e)
        {
            PictureBoxChanged(sender);
        }

        private void pb8_Click(object sender, EventArgs e)
        {
            PictureBoxChanged(sender);
        }

        private void pb9_Click(object sender, EventArgs e)
        {
            PictureBoxChanged(sender);
        }
        
        private void SetDefaultLabels() {
            lblCurrentTurn.Tag = "Player1";
            lblCurrentTurn.Text = "Player 1";
            lblWinnerValue.Text = "InProgress";
        } 
        private void SetDefaultTags() {
            pb1.Tag =
            pb2.Tag =
            pb3.Tag =
            pb4.Tag =
            pb5.Tag =
            pb6.Tag =
            pb7.Tag =
            pb8.Tag =
            pb9.Tag = " ";
        }
        private void SetDefaultPictures() {
            pb1.Image = 
            pb2.Image = 
            pb3.Image = 
            pb4.Image = 
            pb5.Image = 
            pb6.Image = 
            pb7.Image = 
            pb8.Image = 
            pb9.Image = Resources.question_mark;  
            pb1.BackColor = 
            pb2.BackColor = 
            pb3.BackColor = 
            pb4.BackColor = 
            pb5.BackColor = 
            pb6.BackColor = 
            pb7.BackColor = 
            pb8.BackColor = 
            pb9.BackColor = Color.Transparent;
        }
        private void btnRestart_Click(object sender, EventArgs e)
        {
            panel1.Enabled = true;
            SetDefaultLabels();
            SetDefaultTags();
            SetDefaultPictures();
        }
    }
}
