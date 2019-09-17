using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
 
    public partial class frmTicTacToe : Form
    {


        private List <PlayerModel> playersList = new List <PlayerModel>(2);
        private PlayerModel currentPlayer;
        private BoardModel internalBoardRep = new BoardModel();

        private string playerAName;
        private string playerBName;
        private Button[,] newButton = new Button[3, 3];

        int turnCount = 0; //count of turns taken. If reaches 9 and no winner then we have a draw
        int gameCount = 0; //number of games played

        public frmTicTacToe()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Component Based Software Design \nProject 1 Fall 2019 \nby Eric Friedman", "About");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Player 1 Naming
        private void btnNameOneOK_Click(object sender, EventArgs e)
        {
            playerAName = txtPlayerAName.Text;
            lblPlayerTwoName.Visible = true;
            txtPlayerBName.Visible = true;
            btnP1Edit.Visible = true;
            btnNameTwoOK.Visible = true;
            txtPlayerAName.Enabled = false;
            btnNameOneOK.Enabled = false;
            txtPlayerBName.Enabled = true;
            btnNameTwoOK.Enabled = true;
        }

        private void btnP1Edit_Click(object sender, EventArgs e)
        {
            lblPlayerTwoName.Visible = false;
            txtPlayerBName.Visible = false;
            btnP1Edit.Visible = false;
            btnNameTwoOK.Visible = false;
            txtPlayerAName.Enabled = true;
            btnNameOneOK.Enabled = true;
            txtPlayerAName.Focus();
            btnP2Edit.Visible = false;
            btnPlay.Visible = false;
        }

        //Player 2 Naming
        private void btnNameTwoOK_Click(object sender, EventArgs e)
        {
            playerBName = txtPlayerBName.Text;
            btnP2Edit.Visible = true;
            btnPlay.Visible = true;
            txtPlayerBName.Enabled = false;
            btnNameTwoOK.Enabled = false;
        }

        private void btnP2Edit_Click(object sender, EventArgs e)
        {
            txtPlayerBName.Enabled = true;
            btnNameTwoOK.Enabled = true;
            btnP2Edit.Visible = false;
            btnPlay.Visible = false;
        }

        //Play Button
        private void btnPlay_Click(object sender, EventArgs e)
        {
            if ((playerAName.Length > 0 && playerBName.Length > 0) && (playerAName != playerBName))
            {
                PlayerModel p;
                p = new PlayerModel(playerAName, 'X');
                playersList.Add(p);
                p = new PlayerModel(playerBName, 'O');
                playersList.Add(p);

                currentPlayer = playersList[0];
                pnlBoard.Visible = true;
            }
            else
            {
                MessageBox.Show("One or both names are blank or the names are the same. Reenter name(s).", "Entry Error!");
                playerAName = "";
                playerBName = "";
                txtPlayerAName.Focus();
                lblPlayerTwoName.Visible = false;
                txtPlayerBName.Visible = false;
                btnP1Edit.Visible = false;
                btnNameTwoOK.Visible = false;
                txtPlayerAName.Enabled = true;
                btnNameOneOK.Enabled = true;
                txtPlayerAName.Focus();
                btnP2Edit.Visible = false;
                btnPlay.Visible = false;
            }
            btnP1Edit.Enabled = false;
            btnP2Edit.Enabled = false;
        }

        private void createBoard()
        {
            pnlBoard.Visible = true;
            Size size = new Size(75, 75);
            Point location = new Point(0, 0);
            int padding = 25;
            int topMargin = 40;

            for (int row = 0; row <= 2; row++)
            {
                location.Y = topMargin + row * (size.Height + padding);
                int extraLeftPadding = 80;
                for (int column = 0; column <= 2; column++)
                {
                    Button newButton = new Button();
                    newButton.Location = new Point(extraLeftPadding + column * (size.Width + padding), location.Y);
                    newButton.Size = size;
                    newButton.Font = new Font("Arial", 48, FontStyle.Bold);
                    newButton.Text = "";
                    newButton.Enabled = true;
                    newButton.Name = "btn" + row + column;
                    newButton.Click += new EventHandler(Button_Click);
                    pnlBoard.Controls.Add(newButton);
                }
            }
         
        }

        private void Button_Click(object sender, EventArgs e)
        {
            int rowID = Convert.ToInt32(((Button)sender).Name[8]) - '0';
            int colID = Convert.ToInt32(((Button)sender).Name[9]) - '0';

            internalBoardRep.recordTurn(currentPlayer, rowID, colID);

            string thisToken = (currentPlayer.getIcon).ToString();
            ((Button)sender).Text = thisToken;

            ((Button)sender).Enabled = false;

            if (internalBoardRep.hasPlayerWon(currentPlayer.getIcon))
            {
                MessageBox.Show("Congratulations " + currentPlayer.getName + ". You won!!!");
                currentPlayer.won();
                pnlBoard.Enabled = false;
                btnNewGame.Visible = true;
                btnExit.Visible = true;
            } 
            else
            {
                turnCount++;
                if (turnCount >= 9)
                {
                    MessageBox.Show("Game over.  We have a draw.");
                    btnNewGame.Visible = true;
                    btnExit.Visible = true;
                    return;
                } 
            }

            if (currentPlayer == playersList[0])
            {
                currentPlayer = playersList[1];
                
            }


            else if (currentPlayer == playersList[1])
            {
                currentPlayer = playersList[0];
            }
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}




