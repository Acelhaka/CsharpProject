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
    public partial class Form1 : Form
    {
        private int buttonsClicked = 0;
        private bool gameOver = false;
        
        public Form1()
        {
            InitializeComponent();

            foreach (Control ctl in this.Controls)
            {
                //add event handlers to tic tac toe buttons
                if (ctl is Button && ctl.Name != "btnReset")
                    ctl.Click += button_Click;
            }

            DoReset();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if (gameOver)
                return;


            ((Button)sender).Text = radXgoes.Checked ? "X" : "O";
            this.btnReset.Focus();
            ((Button)sender).Enabled = false;

            radXgoes.Checked = !radXgoes.Checked;
            radOgoes.Checked = !radXgoes.Checked;

            string winner = CheckForWinner();
            if (winner.Length > 0) 
            {
                this.lblMessage.Text = string.Format("We have a winner: {0}", winner);
                gameOver = true;
            }

            buttonsClicked++;
            if (buttonsClicked >= 9)
            {
                this.lblMessage.Text = "This game is a draw!";
                gameOver = true;
            }
        }

        private string CheckForWinner() 
        {
            string winner = string.Empty;

            if (button11.Text == button12.Text
                   && button12.Text == button13.Text)
            {
                winner = button11.Text;
            }

            else if (button11.Text == button22.Text
                && button22.Text == button33.Text)
            {
                winner = button11.Text;
            }


            else if ((button11.Text == button21.Text)
                && (button21.Text == button31.Text))
            {
                winner = button11.Text;

            }

            else if ((button12.Text == button22.Text)
              && (button22.Text == button32.Text))
            {
                winner = button12.Text;
            }

            else if ((button13.Text == button23.Text)
                && (button23.Text == button33.Text))
            {
                winner = button13.Text;
            }


            else if (button21.Text == button22.Text
                && button22.Text == button23.Text)
            {
                winner = button21.Text;
            }

            else if (button31.Text == button32.Text
                && button32.Text == button33.Text)
            {
                winner = button31.Text;
            }


            else if (button13.Text == button22.Text
                && button22.Text == button31.Text)
            {
                winner = button13.Text;
            }

            return winner;

            //TO DO:
            //
            //Check for a winner!
            //
            //Return either "X", "O", or "".

            
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            DoReset();
        }

        private void DoReset() 
        {
            foreach (Control ctl in this.Controls)
            {
                if (ctl is Button && ctl.Name != "btnReset") 
                {
                    ((Button)ctl).Text = string.Empty;
                    ((Button)ctl).Enabled = true;
                }
            }

            radXgoes.Checked = true;
            buttonsClicked = 0;
            gameOver = false;
            this.lblMessage.Text = string.Empty;
        }
    }
}
