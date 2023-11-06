using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScoreCard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void player1name_TextChanged(object sender, EventArgs e)
        {
            string playername = player1name.Text;

            if (string.IsNullOrEmpty(playername))
            {
                MessageBox.Show("Input error: Player 1 name is empty", "Error", MessageBoxButtons.OK);
                return;
            }
            if (!Regex.Match(playername, "^[A-Z][a-zA-Z]{0,15}$").Success)
            {
                MessageBox.Show("Input error: The name must start with a capital and contain up to 15 letters.", "Error", MessageBoxButtons.OK);
                const char empty = '0';
                player1name.Text = empty.ToString();
                return;
            }
        }

        private void player2name_TextChanged(object sender, EventArgs e)
        {
            string playername = player2name.Text;

            if (string.IsNullOrEmpty(playername))
            {
                MessageBox.Show("Input error: Player 2 name is empty", "Error", MessageBoxButtons.OK);
                return;
            }
            if (!Regex.Match(playername, "^[A-Z][a-zA-Z]{0,15}$").Success)
            {
                MessageBox.Show("Input error: The name must start with a capital and contain up to 15 letters.", "Error", MessageBoxButtons.OK);
                const char empty = '0';
                player2name.Text = empty.ToString();
                return;
            }
        }

        private void player3name_TextChanged(object sender, EventArgs e)
        {
            string playername = player3name.Text;

            if (string.IsNullOrEmpty(playername))
            {
                MessageBox.Show("Input error: Player 3 name is empty", "Error", MessageBoxButtons.OK);
                return;
            }
            if (!Regex.Match(playername, "^[A-Z][a-zA-Z]{0,15}$").Success)
            {
                MessageBox.Show("Input error: The name must start with a capital and contain up to 15 letters.", "Error", MessageBoxButtons.OK);
                const char empty = '0';
                player3name.Text = empty.ToString();
                return;
            }
        }

        private void player4name_TextChanged(object sender, EventArgs e)
        {
            string playername = player4name.Text;

            if (string.IsNullOrEmpty(playername))
            {
                MessageBox.Show("Input error: Player 4 name is empty", "Error", MessageBoxButtons.OK);
                return;
            }
            if (!Regex.Match(playername, "^[A-Z][a-zA-Z]{0,15}$").Success)
            {
                MessageBox.Show("Input error: The name must start with a capital and contain up to 15 letters.", "Error", MessageBoxButtons.OK);
                const char empty = '0';
                player4name.Text = empty.ToString();
                return;
            }
        }

        private void player5name_TextChanged(object sender, EventArgs e)
        {
            string playername = player5name.Text;

            if (string.IsNullOrEmpty(playername))
            {
                MessageBox.Show("Input error: Player 5 name is empty", "Error", MessageBoxButtons.OK);
                return;
            }
            if (!Regex.Match(playername, "^[A-Z][a-zA-Z]{0,15}$").Success)
            {
                MessageBox.Show("Input error: The name must start with a capital and contain up to 15 letters.", "Error", MessageBoxButtons.OK);
                const char empty = '0';
                player5name.Text = empty.ToString();
                return;
            }
        }

        private void player6name_TextChanged(object sender, EventArgs e)
        {
            string playername = player6name.Text;

            if (string.IsNullOrEmpty(playername))
            {
                MessageBox.Show("Input error: Player 6 name is empty", "Error", MessageBoxButtons.OK);
                return;
            }
            if (!Regex.Match(playername, "^[A-Z][a-zA-Z]{0,15}$").Success)
            {
                MessageBox.Show("Input error: The name must start with a capital and contain up to 15 letters.", "Error", MessageBoxButtons.OK);
                const char empty = '0';
                player6name.Text = empty.ToString();
                return;
            }
        }

        private void player1round12_TextChanged(object sender, EventArgs e)
        {
            string playerscore = player1round12.Text;

            if (string.IsNullOrEmpty(playerscore))
            {
                MessageBox.Show("Input error: Player 1 score is empty for the 12's round.", "Error", MessageBoxButtons.OK);
                return;
            }
            if (!Regex.Match(playerscore, "^[0-9]{0,3}$").Success)
            {
                MessageBox.Show("Input error: The score can only contain whole numbers 0 - 999.", "Error", MessageBoxButtons.OK);
                const char empty = '0';
                player1round12.Text = empty.ToString();
                return;
            }
        }

        private void player2round12_TextChanged(object sender, EventArgs e)
        {
            string playerscore = player2round12.Text;

            if (string.IsNullOrEmpty(playerscore))
            {
                MessageBox.Show("Input error: Player 2 score is empty for the 12's round.", "Error", MessageBoxButtons.OK);
                return;
            }
            if (!Regex.Match(playerscore, "^[0-9]{0,3}$").Success)
            {
                MessageBox.Show("Input error: The score can only contain whole numbers 0 - 999.", "Error", MessageBoxButtons.OK);
                const char empty = '0';
                player2round12.Text = empty.ToString();
                return;
            }
        }

        private void player3round12_TextChanged(object sender, EventArgs e)
        {
            string playerscore = player3round12.Text;

            if (string.IsNullOrEmpty(playerscore))
            {
                MessageBox.Show("Input error: Player 3 score is empty for the 12's round.", "Error", MessageBoxButtons.OK);
                return;
            }
            if (!Regex.Match(playerscore, "^[0-9]{0,3}$").Success)
            {
                MessageBox.Show("Input error: The score can only contain whole numbers 0 - 999.", "Error", MessageBoxButtons.OK);
                const char empty = '0';
                player3round12.Text = empty.ToString();
                return;
            }
        }

        private void player4round12_TextChanged(object sender, EventArgs e)
        {
            string playerscore = player4round12.Text;

            if (string.IsNullOrEmpty(playerscore))
            {
                MessageBox.Show("Input error: Player 4 score is empty for the 12's round.", "Error", MessageBoxButtons.OK);
                return;
            }
            if (!Regex.Match(playerscore, "^[0-9]{0,3}$").Success)
            {
                MessageBox.Show("Input error: The score can only contain whole numbers 0 - 999.", "Error", MessageBoxButtons.OK);
                const char empty = '0';
                player4round12.Text = empty.ToString();
                return;
            }
        }

        private void player5round12_TextChanged(object sender, EventArgs e)
        {
            string playerscore = player5round12.Text;

            if (string.IsNullOrEmpty(playerscore))
            {
                MessageBox.Show("Input error: Player 5 score is empty for the 12's round.", "Error", MessageBoxButtons.OK);
                return;
            }
            if (!Regex.Match(playerscore, "^[0-9]{0,3}$").Success)
            {
                MessageBox.Show("Input error: The score can only contain whole numbers 0 - 999.", "Error", MessageBoxButtons.OK);
                const char empty = '0';
                player5round12.Text = empty.ToString();
                return;
            }
        }

        private void player6round12_TextChanged(object sender, EventArgs e)
        {
            string playerscore = player6round12.Text;

            if (string.IsNullOrEmpty(playerscore))
            {
                MessageBox.Show("Input error: Player 6 score is empty for the 12's round.", "Error", MessageBoxButtons.OK);
                return;
            }
            if (!Regex.Match(playerscore, "^[0-9]{0,3}$").Success)
            {
                MessageBox.Show("Input error: The score can only contain whole numbers 0 - 999.", "Error", MessageBoxButtons.OK);
                const char empty = '0';
                player6round12.Text = empty.ToString();
                return;
            }
        }

        private void player1round11_TextChanged(object sender, EventArgs e)
        {
            string playerscore = player1round11.Text;

            if (string.IsNullOrEmpty(playerscore))
            {
                MessageBox.Show("Input error: Player 1 score is empty for the 11's round.", "Error", MessageBoxButtons.OK);
                return;
            }
            if (!Regex.Match(playerscore, "^[0-9]{0,3}$").Success)
            {
                MessageBox.Show("Input error: The score can only contain whole numbers 0 - 999.", "Error", MessageBoxButtons.OK);
                const char empty = '0';
                player1round11.Text = empty.ToString();
                return;
            }
        }

        private void player2round11_TextChanged(object sender, EventArgs e)
        {
            string playerscore = player2round11.Text;

            if (string.IsNullOrEmpty(playerscore))
            {
                MessageBox.Show("Input error: Player 2 score is empty for the 11's round.", "Error", MessageBoxButtons.OK);
                return;
            }
            if (!Regex.Match(playerscore, "^[0-9]{0,3}$").Success)
            {
                MessageBox.Show("Input error: The score can only contain whole numbers 0 - 999.", "Error", MessageBoxButtons.OK);
                const char empty = '0';
                player2round11.Text = empty.ToString();
                return;
            }
        }

        private void player3round11_TextChanged(object sender, EventArgs e)
        {
            string playerscore = player3round11.Text;

            if (string.IsNullOrEmpty(playerscore))
            {
                MessageBox.Show("Input error: Player 3 score is empty for the 11's round.", "Error", MessageBoxButtons.OK);
                return;
            }
            if (!Regex.Match(playerscore, "^[0-9]{0,3}$").Success)
            {
                MessageBox.Show("Input error: The score can only contain whole numbers 0 - 999.", "Error", MessageBoxButtons.OK);
                const char empty = '0';
                player3round11.Text = empty.ToString();
                return;
            }
        }

        private void player4round11_TextChanged(object sender, EventArgs e)
        {
            string playerscore = player4round11.Text;

            if (string.IsNullOrEmpty(playerscore))
            {
                MessageBox.Show("Input error: Player 4 score is empty for the 11's round.", "Error", MessageBoxButtons.OK);
                return;
            }
            if (!Regex.Match(playerscore, "^[0-9]{0,3}$").Success)
            {
                MessageBox.Show("Input error: The score can only contain whole numbers 0 - 999.", "Error", MessageBoxButtons.OK);
                const char empty = '0';
                player4round11.Text = empty.ToString();
                return;
            }
        }

        private void player5round11_TextChanged(object sender, EventArgs e)
        {
            string playerscore = player5round11.Text;

            if (string.IsNullOrEmpty(playerscore))
            {
                MessageBox.Show("Input error: Player 5 score is empty for the 11's round.", "Error", MessageBoxButtons.OK);
                return;
            }
            if (!Regex.Match(playerscore, "^[0-9]{0,3}$").Success)
            {
                MessageBox.Show("Input error: The score can only contain whole numbers 0 - 999.", "Error", MessageBoxButtons.OK);
                const char empty = '0';
                player5round11.Text = empty.ToString();
                return;
            }
        }

        private void player6round11_TextChanged(object sender, EventArgs e)
        {
            string playerscore = player6round11.Text;

            if (string.IsNullOrEmpty(playerscore))
            {
                MessageBox.Show("Input error: Player 6 score is empty for the 11's round.", "Error", MessageBoxButtons.OK);
                return;
            }
            if (!Regex.Match(playerscore, "^[0-9]{0,3}$").Success)
            {
                MessageBox.Show("Input error: The score can only contain whole numbers 0 - 999.", "Error", MessageBoxButtons.OK);
                const char empty = '0';
                player6round11.Text = empty.ToString();
                return;
            }
        }

        private void player1round10_TextChanged(object sender, EventArgs e)
        {
            string playerscore = player1round10.Text;

            if (string.IsNullOrEmpty(playerscore))
            {
                MessageBox.Show("Input error: Player 1 score is empty for the 10's round.", "Error", MessageBoxButtons.OK);
                return;
            }
            if (!Regex.Match(playerscore, "^[0-9]{0,3}$").Success)
            {
                MessageBox.Show("Input error: The score can only contain whole numbers 0 - 999.", "Error", MessageBoxButtons.OK);
                const char empty = '0';
                player1round10.Text = empty.ToString();
                return;
            }
        }

        private void player2round10_TextChanged(object sender, EventArgs e)
        {
            string playerscore = player2round10.Text;

            if (string.IsNullOrEmpty(playerscore))
            {
                MessageBox.Show("Input error: Player 2 score is empty for the 10's round.", "Error", MessageBoxButtons.OK);
                return;
            }
            if (!Regex.Match(playerscore, "^[0-9]{0,3}$").Success)
            {
                MessageBox.Show("Input error: The score can only contain whole numbers 0 - 999.", "Error", MessageBoxButtons.OK);
                const char empty = '0';
                player2round10.Text = empty.ToString();
                return;
            }
        }

        private void player3round10_TextChanged(object sender, EventArgs e)
        {
            string playerscore = player3round10.Text;

            if (string.IsNullOrEmpty(playerscore))
            {
                MessageBox.Show("Input error: Player 3 score is empty for the 10's round.", "Error", MessageBoxButtons.OK);
                return;
            }
            if (!Regex.Match(playerscore, "^[0-9]{0,3}$").Success)
            {
                MessageBox.Show("Input error: The score can only contain whole numbers 0 - 999.", "Error", MessageBoxButtons.OK);
                const char empty = '0';
                player3round10.Text = empty.ToString();
                return;
            }
        }

        private void player4round10_TextChanged(object sender, EventArgs e)
        {
            string playerscore = player4round10.Text;

            if (string.IsNullOrEmpty(playerscore))
            {
                MessageBox.Show("Input error: Player 4 score is empty for the 10's round.", "Error", MessageBoxButtons.OK);
                return;
            }
            if (!Regex.Match(playerscore, "^[0-9]{0,3}$").Success)
            {
                MessageBox.Show("Input error: The score can only contain whole numbers 0 - 999.", "Error", MessageBoxButtons.OK);
                const char empty = '0';
                player4round10.Text = empty.ToString();
                return;
            }
        }

        private void player5round10_TextChanged(object sender, EventArgs e)
        {
            string playerscore = player5round10.Text;

            if (string.IsNullOrEmpty(playerscore))
            {
                MessageBox.Show("Input error: Player 5 score is empty for the 10's round.", "Error", MessageBoxButtons.OK);
                return;
            }
            if (!Regex.Match(playerscore, "^[0-9]{0,3}$").Success)
            {
                MessageBox.Show("Input error: The score can only contain whole numbers 0 - 999.", "Error", MessageBoxButtons.OK);
                const char empty = '0';
                player5round10.Text = empty.ToString();
                return;
            }
        }

        private void player6round10_TextChanged(object sender, EventArgs e)
        {
            string playerscore = player6round10.Text;

            if (string.IsNullOrEmpty(playerscore))
            {
                MessageBox.Show("Input error: Player 6 score is empty for the 10's round.", "Error", MessageBoxButtons.OK);
                return;
            }
            if (!Regex.Match(playerscore, "^[0-9]{0,3}$").Success)
            {
                MessageBox.Show("Input error: The score can only contain whole numbers 0 - 999.", "Error", MessageBoxButtons.OK);
                const char empty = '0';
                player6round10.Text = empty.ToString();
                return;
            }
        }

        private void player1round9_TextChanged(object sender, EventArgs e)
        {
            string playerscore = player1round9.Text;

            if (string.IsNullOrEmpty(playerscore))
            {
                MessageBox.Show("Input error: Player 1 score is empty for the 9's round.", "Error", MessageBoxButtons.OK);
                return;
            }
            if (!Regex.Match(playerscore, "^[0-9]{0,3}$").Success)
            {
                MessageBox.Show("Input error: The score can only contain whole numbers 0 - 999.", "Error", MessageBoxButtons.OK);
                const char empty = '0';
                player1round9.Text = empty.ToString();
                return;
            }
        }

        private void player2round9_TextChanged(object sender, EventArgs e)
        {
            string playerscore = player2round9.Text;

            if (string.IsNullOrEmpty(playerscore))
            {
                MessageBox.Show("Input error: Player 2 score is empty for the 9's round.", "Error", MessageBoxButtons.OK);
                return;
            }
            if (!Regex.Match(playerscore, "^[0-9]{0,3}$").Success)
            {
                MessageBox.Show("Input error: The score can only contain whole numbers 0 - 999.", "Error", MessageBoxButtons.OK);
                const char empty = '0';
                player2round9.Text = empty.ToString();
                return;
            }
        }

        private void player3round9_TextChanged(object sender, EventArgs e)
        {
            string playerscore = player3round9.Text;

            if (string.IsNullOrEmpty(playerscore))
            {
                MessageBox.Show("Input error: Player 3 score is empty for the 9's round.", "Error", MessageBoxButtons.OK);
                return;
            }
            if (!Regex.Match(playerscore, "^[0-9]{0,3}$").Success)
            {
                MessageBox.Show("Input error: The score can only contain whole numbers 0 - 999.", "Error", MessageBoxButtons.OK);
                const char empty = '0';
                player3round9.Text = empty.ToString();
                return;
            }
        }

        private void player4round9_TextChanged(object sender, EventArgs e)
        {
            string playerscore = player4round9.Text;

            if (string.IsNullOrEmpty(playerscore))
            {
                MessageBox.Show("Input error: Player 4 score is empty for the 9's round.", "Error", MessageBoxButtons.OK);
                return;
            }
            if (!Regex.Match(playerscore, "^[0-9]{0,3}$").Success)
            {
                MessageBox.Show("Input error: The score can only contain whole numbers 0 - 999.", "Error", MessageBoxButtons.OK);
                const char empty = '0';
                player4round9.Text = empty.ToString();
                return;
            }
        }

        private void player5round9_TextChanged(object sender, EventArgs e)
        {
            string playerscore = player5round9.Text;

            if (string.IsNullOrEmpty(playerscore))
            {
                MessageBox.Show("Input error: Player 4 score is empty for the 9's round.", "Error", MessageBoxButtons.OK);
                return;
            }
            if (!Regex.Match(playerscore, "^[0-9]{0,3}$").Success)
            {
                MessageBox.Show("Input error: The score can only contain whole numbers 0 - 999.", "Error", MessageBoxButtons.OK);
                const char empty = '0';
                player5round9.Text = empty.ToString();
                return;
            }
        }

        private void player6round9_TextChanged(object sender, EventArgs e)
        {
            string playerscore = player6round9.Text;

            if (string.IsNullOrEmpty(playerscore))
            {
                MessageBox.Show("Input error: Player 6 score is empty for the 9's round.", "Error", MessageBoxButtons.OK);
                return;
            }
            if (!Regex.Match(playerscore, "^[0-9]{0,3}$").Success)
            {
                MessageBox.Show("Input error: The score can only contain whole numbers 0 - 999.", "Error", MessageBoxButtons.OK);
                const char empty = '0';
                player6round9.Text = empty.ToString();
                return;
            }
        }

        private void player1round8_TextChanged(object sender, EventArgs e)
        {
            string playerscore = player1round8.Text;

            if (string.IsNullOrEmpty(playerscore))
            {
                MessageBox.Show("Input error: Player 1 score is empty for the 8's round.", "Error", MessageBoxButtons.OK);
                return;
            }
            if (!Regex.Match(playerscore, "^[0-9]{0,3}$").Success)
            {
                MessageBox.Show("Input error: The score can only contain whole numbers 0 - 999.", "Error", MessageBoxButtons.OK);
                const char empty = '0';
                player1round8.Text = empty.ToString();
                return;
            }
        }

        private void player2round8_TextChanged(object sender, EventArgs e)
        {
            string playerscore = player2round8.Text;

            if (string.IsNullOrEmpty(playerscore))
            {
                MessageBox.Show("Input error: Player 2 score is empty for the 8's round.", "Error", MessageBoxButtons.OK);
                return;
            }
            if (!Regex.Match(playerscore, "^[0-9]{0,3}$").Success)
            {
                MessageBox.Show("Input error: The score can only contain whole numbers 0 - 999.", "Error", MessageBoxButtons.OK);
                const char empty = '0';
                player2round8.Text = empty.ToString();
                return;
            }
        }

        private void player3round8_TextChanged(object sender, EventArgs e)
        {
            string playerscore = player3round8.Text;

            if (string.IsNullOrEmpty(playerscore))
            {
                MessageBox.Show("Input error: Player 3 score is empty for the 8's round.", "Error", MessageBoxButtons.OK);
                return;
            }
            if (!Regex.Match(playerscore, "^[0-9]{0,3}$").Success)
            {
                MessageBox.Show("Input error: The score can only contain whole numbers 0 - 999.", "Error", MessageBoxButtons.OK);
                const char empty = '0';
                player3round8.Text = empty.ToString();
                return;
            }
        }

        private void player4round8_TextChanged(object sender, EventArgs e)
        {
            string playerscore = player4round8.Text;

            if (string.IsNullOrEmpty(playerscore))
            {
                MessageBox.Show("Input error: Player 4 score is empty for the 8's round.", "Error", MessageBoxButtons.OK);
                return;
            }
            if (!Regex.Match(playerscore, "^[0-9]{0,3}$").Success)
            {
                MessageBox.Show("Input error: The score can only contain whole numbers 0 - 999.", "Error", MessageBoxButtons.OK);
                const char empty = '0';
                player4round8.Text = empty.ToString();
                return;
            }
        }

        private void player5round8_TextChanged(object sender, EventArgs e)
        {
            string playerscore = player5round8.Text;

            if (string.IsNullOrEmpty(playerscore))
            {
                MessageBox.Show("Input error: Player 5 score is empty for the 8's round.", "Error", MessageBoxButtons.OK);
                return;
            }
            if (!Regex.Match(playerscore, "^[0-9]{0,3}$").Success)
            {
                MessageBox.Show("Input error: The score can only contain whole numbers 0 - 999.", "Error", MessageBoxButtons.OK);
                const char empty = '0';
                player5round8.Text = empty.ToString();
                return;
            }
        }

        private void player6round8_TextChanged(object sender, EventArgs e)
        {
            string playerscore = player6round8.Text;

            if (string.IsNullOrEmpty(playerscore))
            {
                MessageBox.Show("Input error: Player 6 score is empty for the 8's round.", "Error", MessageBoxButtons.OK);
                return;
            }
            if (!Regex.Match(playerscore, "^[0-9]{0,3}$").Success)
            {
                MessageBox.Show("Input error: The score can only contain whole numbers 0 - 999.", "Error", MessageBoxButtons.OK);
                const char empty = '0';
                player6round8.Text = empty.ToString();
                return;
            }
        }

        private void player1round7_TextChanged(object sender, EventArgs e)
        {
            string playerscore = player1round7.Text;

            if (string.IsNullOrEmpty(playerscore))
            {
                MessageBox.Show("Input error: Player 1 score is empty for the 7's round.", "Error", MessageBoxButtons.OK);
                return;
            }
            if (!Regex.Match(playerscore, "^[0-9]{0,3}$").Success)
            {
                MessageBox.Show("Input error: The score can only contain whole numbers 0 - 999.", "Error", MessageBoxButtons.OK);
                const char empty = '0';
                player1round7.Text = empty.ToString();
                return;
            }
        }

        private void player2round7_TextChanged(object sender, EventArgs e)
        {
            string playerscore = player2round7.Text;

            if (string.IsNullOrEmpty(playerscore))
            {
                MessageBox.Show("Input error: Player 2 score is empty for the 7's round.", "Error", MessageBoxButtons.OK);
                return;
            }
            if (!Regex.Match(playerscore, "^[0-9]{0,3}$").Success)
            {
                MessageBox.Show("Input error: The score can only contain whole numbers 0 - 999.", "Error", MessageBoxButtons.OK);
                const char empty = '0';
                player2round7.Text = empty.ToString();
                return;
            }
        }

        private void player3round7_TextChanged(object sender, EventArgs e)
        {
            string playerscore = player3round7.Text;

            if (string.IsNullOrEmpty(playerscore))
            {
                MessageBox.Show("Input error: Player 3 score is empty for the 7's round.", "Error", MessageBoxButtons.OK);
                return;
            }
            if (!Regex.Match(playerscore, "^[0-9]{0,3}$").Success)
            {
                MessageBox.Show("Input error: The score can only contain whole numbers 0 - 999.", "Error", MessageBoxButtons.OK);
                const char empty = '0';
                player3round7.Text = empty.ToString();
                return;
            }
        }

        private void player4round7_TextChanged(object sender, EventArgs e)
        {
            string playerscore = player4round7.Text;

            if (string.IsNullOrEmpty(playerscore))
            {
                MessageBox.Show("Input error: Player 4 score is empty for the 7's round.", "Error", MessageBoxButtons.OK);
                return;
            }
            if (!Regex.Match(playerscore, "^[0-9]{0,3}$").Success)
            {
                MessageBox.Show("Input error: The score can only contain whole numbers 0 - 999.", "Error", MessageBoxButtons.OK);
                const char empty = '0';
                player4round7.Text = empty.ToString();
                return;
            }
        }

        private void player5round7_TextChanged(object sender, EventArgs e)
        {
            string playerscore = player5round7.Text;

            if (string.IsNullOrEmpty(playerscore))
            {
                MessageBox.Show("Input error: Player 5 score is empty for the 7's round.", "Error", MessageBoxButtons.OK);
                return;
            }
            if (!Regex.Match(playerscore, "^[0-9]{0,3}$").Success)
            {
                MessageBox.Show("Input error: The score can only contain whole numbers 0 - 999.", "Error", MessageBoxButtons.OK);
                const char empty = '0';
                player5round7.Text = empty.ToString();
                return;
            }
        }

        private void player6round7_TextChanged(object sender, EventArgs e)
        {
            string playerscore = player6round7.Text;

            if (string.IsNullOrEmpty(playerscore))
            {
                MessageBox.Show("Input error: Player 6 score is empty for the 7's round.", "Error", MessageBoxButtons.OK);
                return;
            }
            if (!Regex.Match(playerscore, "^[0-9]{0,3}$").Success)
            {
                MessageBox.Show("Input error: The score can only contain whole numbers 0 - 999.", "Error", MessageBoxButtons.OK);
                const char empty = '0';
                player6round7.Text = empty.ToString();
                return;
            }
        }

        private void player1round6_TextChanged(object sender, EventArgs e)
        {
            string playerscore = player1round6.Text;

            if (string.IsNullOrEmpty(playerscore))
            {
                MessageBox.Show("Input error: Player 1 score is empty for the 6's round.", "Error", MessageBoxButtons.OK);
                return;
            }
            if (!Regex.Match(playerscore, "^[0-9]{0,3}$").Success)
            {
                MessageBox.Show("Input error: The score can only contain whole numbers 0 - 999.", "Error", MessageBoxButtons.OK);
                const char empty = '0';
                player1round6.Text = empty.ToString();
                return;
            }
        }

        private void player2round6_TextChanged(object sender, EventArgs e)
        {
            string playerscore = player2round6.Text;

            if (string.IsNullOrEmpty(playerscore))
            {
                MessageBox.Show("Input error: Player 1 score is empty for the 6's round.", "Error", MessageBoxButtons.OK);
                return;
            }
            if (!Regex.Match(playerscore, "^[0-9]{0,3}$").Success)
            {
                MessageBox.Show("Input error: The score can only contain whole numbers 0 - 999.", "Error", MessageBoxButtons.OK);
                const char empty = '0';
                player2round6.Text = empty.ToString();
                return;
            }
        }

        private void player3round6_TextChanged(object sender, EventArgs e)
        {
            string playerscore = player3round6.Text;

            if (string.IsNullOrEmpty(playerscore))
            {
                MessageBox.Show("Input error: Player 3 score is empty for the 6's round.", "Error", MessageBoxButtons.OK);
                return;
            }
            if (!Regex.Match(playerscore, "^[0-9]{0,3}$").Success)
            {
                MessageBox.Show("Input error: The score can only contain whole numbers 0 - 999.", "Error", MessageBoxButtons.OK);
                const char empty = '0';
                player3round6.Text = empty.ToString();
                return;
            }
        }

        private void player4round6_TextChanged(object sender, EventArgs e)
        {
            string playerscore = player4round6.Text;

            if (string.IsNullOrEmpty(playerscore))
            {
                MessageBox.Show("Input error: Player 4 score is empty for the 6's round.", "Error", MessageBoxButtons.OK);
                return;
            }
            if (!Regex.Match(playerscore, "^[0-9]{0,3}$").Success)
            {
                MessageBox.Show("Input error: The score can only contain whole numbers 0 - 999.", "Error", MessageBoxButtons.OK);
                const char empty = '0';
                player4round6.Text = empty.ToString();
                return;
            }
        }

        private void player5round6_TextChanged(object sender, EventArgs e)
        {
            string playerscore = player5round6.Text;

            if (string.IsNullOrEmpty(playerscore))
            {
                MessageBox.Show("Input error: Player 5 score is empty for the 6's round.", "Error", MessageBoxButtons.OK);
                return;
            }
            if (!Regex.Match(playerscore, "^[0-9]{0,3}$").Success)
            {
                MessageBox.Show("Input error: The score can only contain whole numbers 0 - 999.", "Error", MessageBoxButtons.OK);
                const char empty = '0';
                player5round6.Text = empty.ToString();
                return;
            }
        }

        private void player6round6_TextChanged(object sender, EventArgs e)
        {
            string playerscore = player6round6.Text;

            if (string.IsNullOrEmpty(playerscore))
            {
                MessageBox.Show("Input error: Player 6 score is empty for the 6's round.", "Error", MessageBoxButtons.OK);
                return;
            }
            if (!Regex.Match(playerscore, "^[0-9]{0,3}$").Success)
            {
                MessageBox.Show("Input error: The score can only contain whole numbers 0 - 999.", "Error", MessageBoxButtons.OK);
                const char empty = '0';
                player6round6.Text = empty.ToString();
                return;
            }
        }

        private void player1round5_TextChanged(object sender, EventArgs e)
        {
            string playerscore = player1round5.Text;

            if (string.IsNullOrEmpty(playerscore))
            {
                MessageBox.Show("Input error: Player 1 score is empty for the 5's round.", "Error", MessageBoxButtons.OK);
                return;
            }
            if (!Regex.Match(playerscore, "^[0-9]{0,3}$").Success)
            {
                MessageBox.Show("Input error: The score can only contain whole numbers 0 - 999.", "Error", MessageBoxButtons.OK);
                const char empty = '0';
                player1round5.Text = empty.ToString();
                return;
            }
        }

        private void player2round5_TextChanged(object sender, EventArgs e)
        {
            string playerscore = player2round5.Text;

            if (string.IsNullOrEmpty(playerscore))
            {
                MessageBox.Show("Input error: Player 2 score is empty for the 5's round.", "Error", MessageBoxButtons.OK);
                return;
            }
            if (!Regex.Match(playerscore, "^[0-9]{0,3}$").Success)
            {
                MessageBox.Show("Input error: The score can only contain whole numbers 0 - 999.", "Error", MessageBoxButtons.OK);
                const char empty = '0';
                player2round5.Text = empty.ToString();
                return;
            }
        }

        private void player3round5_TextChanged(object sender, EventArgs e)
        {
            string playerscore = player3round5.Text;

            if (string.IsNullOrEmpty(playerscore))
            {
                MessageBox.Show("Input error: Player 3 score is empty for the 5's round.", "Error", MessageBoxButtons.OK);
                return;
            }
            if (!Regex.Match(playerscore, "^[0-9]{0,3}$").Success)
            {
                MessageBox.Show("Input error: The score can only contain whole numbers 0 - 999.", "Error", MessageBoxButtons.OK);
                const char empty = '0';
                player3round5.Text = empty.ToString();
                return;
            }
        }

        private void player4round5_TextChanged(object sender, EventArgs e)
        {
            string playerscore = player4round5.Text;

            if (string.IsNullOrEmpty(playerscore))
            {
                MessageBox.Show("Input error: Player 4 score is empty for the 5's round.", "Error", MessageBoxButtons.OK);
                return;
            }
            if (!Regex.Match(playerscore, "^[0-9]{0,3}$").Success)
            {
                MessageBox.Show("Input error: The score can only contain whole numbers 0 - 999.", "Error", MessageBoxButtons.OK);
                const char empty = '0';
                player4round5.Text = empty.ToString();
                return;
            }
        }

        private void player5round5_TextChanged(object sender, EventArgs e)
        {
            string playerscore = player5round5.Text;

            if (string.IsNullOrEmpty(playerscore))
            {
                MessageBox.Show("Input error: Player 5 score is empty for the 5's round.", "Error", MessageBoxButtons.OK);
                return;
            }
            if (!Regex.Match(playerscore, "^[0-9]{0,3}$").Success)
            {
                MessageBox.Show("Input error: The score can only contain whole numbers 0 - 999.", "Error", MessageBoxButtons.OK);
                const char empty = '0';
                player5round5.Text = empty.ToString();
                return;
            }
        }

        private void player6round5_TextChanged(object sender, EventArgs e)
        {
            string playerscore = player6round5.Text;

            if (string.IsNullOrEmpty(playerscore))
            {
                MessageBox.Show("Input error: Player 6 score is empty for the 5's round.", "Error", MessageBoxButtons.OK);
                return;
            }
            if (!Regex.Match(playerscore, "^[0-9]{0,3}$").Success)
            {
                MessageBox.Show("Input error: The score can only contain whole numbers 0 - 999.", "Error", MessageBoxButtons.OK);
                const char empty = '0';
                player6round5.Text = empty.ToString();
                return;
            }
        }

        private void player1round4_TextChanged(object sender, EventArgs e)
        {
            string playerscore = player1round4.Text;

            if (string.IsNullOrEmpty(playerscore))
            {
                MessageBox.Show("Input error: Player 1 score is empty for the 4's round.", "Error", MessageBoxButtons.OK);
                return;
            }
            if (!Regex.Match(playerscore, "^[0-9]{0,3}$").Success)
            {
                MessageBox.Show("Input error: The score can only contain whole numbers 0 - 999.", "Error", MessageBoxButtons.OK);
                const char empty = '0';
                player1round4.Text = empty.ToString();
                return;
            }
        }

        private void player2round4_TextChanged(object sender, EventArgs e)
        {
            string playerscore = player2round4.Text;

            if (string.IsNullOrEmpty(playerscore))
            {
                MessageBox.Show("Input error: Player 2 score is empty for the 4's round.", "Error", MessageBoxButtons.OK);
                return;
            }
            if (!Regex.Match(playerscore, "^[0-9]{0,3}$").Success)
            {
                MessageBox.Show("Input error: The score can only contain whole numbers 0 - 999.", "Error", MessageBoxButtons.OK);
                const char empty = '0';
                player2round4.Text = empty.ToString();
                return;
            }
        }

        private void player3round4_TextChanged(object sender, EventArgs e)
        {
            string playerscore = player3round4.Text;

            if (string.IsNullOrEmpty(playerscore))
            {
                MessageBox.Show("Input error: Player 3 score is empty for the 4's round.", "Error", MessageBoxButtons.OK);
                return;
            }
            if (!Regex.Match(playerscore, "^[0-9]{0,3}$").Success)
            {
                MessageBox.Show("Input error: The score can only contain whole numbers 0 - 999.", "Error", MessageBoxButtons.OK);
                const char empty = '0';
                player3round4.Text = empty.ToString();
                return;
            }
        }

        private void player4round4_TextChanged(object sender, EventArgs e)
        {
            string playerscore = player4round4.Text;

            if (string.IsNullOrEmpty(playerscore))
            {
                MessageBox.Show("Input error: Player 4 score is empty for the 4's round.", "Error", MessageBoxButtons.OK);
                return;
            }
            if (!Regex.Match(playerscore, "^[0-9]{0,3}$").Success)
            {
                MessageBox.Show("Input error: The score can only contain whole numbers 0 - 999.", "Error", MessageBoxButtons.OK);
                const char empty = '0';
                player4round4.Text = empty.ToString();
                return;
            }
        }

        private void player5round4_TextChanged(object sender, EventArgs e)
        {
            string playerscore = player5round4.Text;

            if (string.IsNullOrEmpty(playerscore))
            {
                MessageBox.Show("Input error: Player 5 score is empty for the 4's round.", "Error", MessageBoxButtons.OK);
                return;
            }
            if (!Regex.Match(playerscore, "^[0-9]{0,3}$").Success)
            {
                MessageBox.Show("Input error: The score can only contain whole numbers 0 - 999.", "Error", MessageBoxButtons.OK);
                const char empty = '0';
                player5round4.Text = empty.ToString();
                return;
            }
        }

        private void player6round4_TextChanged(object sender, EventArgs e)
        {
            string playerscore = player6round4.Text;

            if (string.IsNullOrEmpty(playerscore))
            {
                MessageBox.Show("Input error: Player 6 score is empty for the 4's round.", "Error", MessageBoxButtons.OK);
                return;
            }
            if (!Regex.Match(playerscore, "^[0-9]{0,3}$").Success)
            {
                MessageBox.Show("Input error: The score can only contain whole numbers 0 - 999.", "Error", MessageBoxButtons.OK);
                const char empty = '0';
                player6round4.Text = empty.ToString();
                return;
            }
        }

        private void player1round3_TextChanged(object sender, EventArgs e)
        {
            string playerscore = player1round3.Text;

            if (string.IsNullOrEmpty(playerscore))
            {
                MessageBox.Show("Input error: Player 1 score is empty for the 3's round.", "Error", MessageBoxButtons.OK);
                return;
            }
            if (!Regex.Match(playerscore, "^[0-9]{0,3}$").Success)
            {
                MessageBox.Show("Input error: The score can only contain whole numbers 0 - 999.", "Error", MessageBoxButtons.OK);
                const char empty = '0';
                player1round3.Text = empty.ToString();
                return;
            }
        }

        private void player2round3_TextChanged(object sender, EventArgs e)
        {
            string playerscore = player2round3.Text;

            if (string.IsNullOrEmpty(playerscore))
            {
                MessageBox.Show("Input error: Player 2 score is empty for the 3's round.", "Error", MessageBoxButtons.OK);
                return;
            }
            if (!Regex.Match(playerscore, "^[0-9]{0,3}$").Success)
            {
                MessageBox.Show("Input error: The score can only contain whole numbers 0 - 999.", "Error", MessageBoxButtons.OK);
                const char empty = '0';
                player2round3.Text = empty.ToString();
                return;
            }
        }

        private void player3round3_TextChanged(object sender, EventArgs e)
        {
            string playerscore = player3round3.Text;

            if (string.IsNullOrEmpty(playerscore))
            {
                MessageBox.Show("Input error: Player 3 score is empty for the 3's round.", "Error", MessageBoxButtons.OK);
                return;
            }
            if (!Regex.Match(playerscore, "^[0-9]{0,3}$").Success)
            {
                MessageBox.Show("Input error: The score can only contain whole numbers 0 - 999.", "Error", MessageBoxButtons.OK);
                const char empty = '0';
                player3round3.Text = empty.ToString();
                return;
            }
        }

        private void player4round3_TextChanged(object sender, EventArgs e)
        {
            string playerscore = player4round3.Text;

            if (string.IsNullOrEmpty(playerscore))
            {
                MessageBox.Show("Input error: Player 4 score is empty for the 3's round.", "Error", MessageBoxButtons.OK);
                return;
            }
            if (!Regex.Match(playerscore, "^[0-9]{0,3}$").Success)
            {
                MessageBox.Show("Input error: The score can only contain whole numbers 0 - 999.", "Error", MessageBoxButtons.OK);
                const char empty = '0';
                player4round3.Text = empty.ToString();
                return;
            }
        }

        private void player5round3_TextChanged(object sender, EventArgs e)
        {
            string playerscore = player5round3.Text;

            if (string.IsNullOrEmpty(playerscore))
            {
                MessageBox.Show("Input error: Player 5 score is empty for the 3's round.", "Error", MessageBoxButtons.OK);
                return;
            }
            if (!Regex.Match(playerscore, "^[0-9]{0,3}$").Success)
            {
                MessageBox.Show("Input error: The score can only contain whole numbers 0 - 999.", "Error", MessageBoxButtons.OK);
                const char empty = '0';
                player5round3.Text = empty.ToString();
                return;
            }
        }

        private void player6round3_TextChanged(object sender, EventArgs e)
        {
            string playerscore = player6round3.Text;

            if (string.IsNullOrEmpty(playerscore))
            {
                MessageBox.Show("Input error: Player 6 score is empty for the 3's round.", "Error", MessageBoxButtons.OK);
                return;
            }
            if (!Regex.Match(playerscore, "^[0-9]{0,3}$").Success)
            {
                MessageBox.Show("Input error: The score can only contain whole numbers 0 - 999.", "Error", MessageBoxButtons.OK);
                const char empty = '0';
                player6round3.Text = empty.ToString();
                return;
            }
        }

        private void player1round2_TextChanged(object sender, EventArgs e)
        {
            string playerscore = player1round2.Text;

            if (string.IsNullOrEmpty(playerscore))
            {
                MessageBox.Show("Input error: Player 1 score is empty for the 2's round.", "Error", MessageBoxButtons.OK);
                return;
            }
            if (!Regex.Match(playerscore, "^[0-9]{0,3}$").Success)
            {
                MessageBox.Show("Input error: The score can only contain whole numbers 0 - 999.", "Error", MessageBoxButtons.OK);
                const char empty = '0';
                player1round2.Text = empty.ToString();
                return;
            }
        }

        private void player2round2_TextChanged(object sender, EventArgs e)
        {
            string playerscore = player2round2.Text;

            if (string.IsNullOrEmpty(playerscore))
            {
                MessageBox.Show("Input error: Player 2 score is empty for the 2's round.", "Error", MessageBoxButtons.OK);
                return;
            }
            if (!Regex.Match(playerscore, "^[0-9]{0,3}$").Success)
            {
                MessageBox.Show("Input error: The score can only contain whole numbers 0 - 999.", "Error", MessageBoxButtons.OK);
                const char empty = '0';
                player2round2.Text = empty.ToString();
                return;
            }
        }

        private void player3round2_TextChanged(object sender, EventArgs e)
        {
            string playerscore = player3round2.Text;

            if (string.IsNullOrEmpty(playerscore))
            {
                MessageBox.Show("Input error: Player 3 score is empty for the 2's round.", "Error", MessageBoxButtons.OK);
                return;
            }
            if (!Regex.Match(playerscore, "^[0-9]{0,3}$").Success)
            {
                MessageBox.Show("Input error: The score can only contain whole numbers 0 - 999.", "Error", MessageBoxButtons.OK);
                const char empty = '0';
                player3round2.Text = empty.ToString();
                return;
            }
        }

        private void player4round2_TextChanged(object sender, EventArgs e)
        {
            string playerscore = player4round2.Text;

            if (string.IsNullOrEmpty(playerscore))
            {
                MessageBox.Show("Input error: Player 4 score is empty for the 2's round.", "Error", MessageBoxButtons.OK);
                return;
            }
            if (!Regex.Match(playerscore, "^[0-9]{0,3}$").Success)
            {
                MessageBox.Show("Input error: The score can only contain whole numbers 0 - 999.", "Error", MessageBoxButtons.OK);
                const char empty = '0';
                player4round2.Text = empty.ToString();
                return;
            }
        }

        private void player5round2_TextChanged(object sender, EventArgs e)
        {
            string playerscore = player5round2.Text;

            if (string.IsNullOrEmpty(playerscore))
            {
                MessageBox.Show("Input error: Player 6 score is empty for the 2's round.", "Error", MessageBoxButtons.OK);
                return;
            }
            if (!Regex.Match(playerscore, "^[0-9]{0,3}$").Success)
            {
                MessageBox.Show("Input error: The score can only contain whole numbers 0 - 999.", "Error", MessageBoxButtons.OK);
                const char empty = '0';
                player5round2.Text = empty.ToString();
                return;
            }
        }

        private void player6round2_TextChanged(object sender, EventArgs e)
        {
            string playerscore = player6round2.Text;

            if (string.IsNullOrEmpty(playerscore))
            {
                MessageBox.Show("Input error: Player 6 score is empty for the 2's round.", "Error", MessageBoxButtons.OK);
                return;
            }
            if (!Regex.Match(playerscore, "^[0-9]{0,3}$").Success)
            {
                MessageBox.Show("Input error: The score can only contain whole numbers 0 - 999.", "Error", MessageBoxButtons.OK);
                const char empty = '0';
                player6round2.Text = empty.ToString();
                return;
            }
        }

        private void player1round1_TextChanged(object sender, EventArgs e)
        {
            string playerscore = player1round1.Text;

            if (string.IsNullOrEmpty(playerscore))
            {
                MessageBox.Show("Input error: Player 1 score is empty for the 1's round.", "Error", MessageBoxButtons.OK);
                return;
            }
            if (!Regex.Match(playerscore, "^[0-9]{0,3}$").Success)
            {
                MessageBox.Show("Input error: The score can only contain whole numbers 0 - 999.", "Error", MessageBoxButtons.OK);
                const char empty = '0';
                player1round1.Text = empty.ToString();
                return;
            }
        }

        private void player2round1_TextChanged(object sender, EventArgs e)
        {
            string playerscore = player2round1.Text;

            if (string.IsNullOrEmpty(playerscore))
            {
                MessageBox.Show("Input error: Player 2 score is empty for the 1's round.", "Error", MessageBoxButtons.OK);
                return;
            }
            if (!Regex.Match(playerscore, "^[0-9]{0,3}$").Success)
            {
                MessageBox.Show("Input error: The score can only contain whole numbers 0 - 999.", "Error", MessageBoxButtons.OK);
                const char empty = '0';
                player2round1.Text = empty.ToString();
                return;
            }
        }

        private void player3round1_TextChanged(object sender, EventArgs e)
        {
            string playerscore = player3round1.Text;

            if (string.IsNullOrEmpty(playerscore))
            {
                MessageBox.Show("Input error: Player 3 score is empty for the 1's round.", "Error", MessageBoxButtons.OK);
                return;
            }
            if (!Regex.Match(playerscore, "^[0-9]{0,3}$").Success)
            {
                MessageBox.Show("Input error: The score can only contain whole numbers 0 - 999.", "Error", MessageBoxButtons.OK);
                const char empty = '0';
                player3round1.Text = empty.ToString();
                return;
            }
        }

        private void player4round1_TextChanged(object sender, EventArgs e)
        {
            string playerscore = player4round1.Text;

            if (string.IsNullOrEmpty(playerscore))
            {
                MessageBox.Show("Input error: Player 4 score is empty for the 1's round.", "Error", MessageBoxButtons.OK);
                return;
            }
            if (!Regex.Match(playerscore, "^[0-9]{0,3}$").Success)
            {
                MessageBox.Show("Input error: The score can only contain whole numbers 0 - 999.", "Error", MessageBoxButtons.OK);
                const char empty = '0';
                player4round1.Text = empty.ToString();
                return;
            }
        }

        private void player5round1_TextChanged(object sender, EventArgs e)
        {
            string playerscore = player5round1.Text;

            if (string.IsNullOrEmpty(playerscore))
            {
                MessageBox.Show("Input error: Player 5 score is empty for the 1's round.", "Error", MessageBoxButtons.OK);
                return;
            }
            if (!Regex.Match(playerscore, "^[0-9]{0,3}$").Success)
            {
                MessageBox.Show("Input error: The score can only contain whole numbers 0 - 999.", "Error", MessageBoxButtons.OK);
                const char empty = '0';
                player5round1.Text = empty.ToString();
                return;
            }
        }

        private void player6round1_TextChanged(object sender, EventArgs e)
        {
            string playerscore = player6round1.Text;

            if (string.IsNullOrEmpty(playerscore))
            {
                MessageBox.Show("Input error: Player 6 score is empty for the 1's round.", "Error", MessageBoxButtons.OK);
                return;
            }
            if (!Regex.Match(playerscore, "^[0-9]{0,3}$").Success)
            {
                MessageBox.Show("Input error: The score can only contain whole numbers 0 - 999.", "Error", MessageBoxButtons.OK);
                const char empty = '0';
                player6round1.Text = empty.ToString();
                return;
            }
        }

        private void player1round0_TextChanged(object sender, EventArgs e)
        {
            string playerscore = player1round0.Text;

            if (string.IsNullOrEmpty(playerscore))
            {
                MessageBox.Show("Input error: Player 1 score is empty for the blanks round.", "Error", MessageBoxButtons.OK);
                return;
            }
            if (!Regex.Match(playerscore, "^[0-9]{0,3}$").Success)
            {
                MessageBox.Show("Input error: The score can only contain whole numbers 0 - 999.", "Error", MessageBoxButtons.OK);
                const char empty = '0';
                player1round0.Text = empty.ToString();
                return;
            }
        }

        private void player2round0_TextChanged(object sender, EventArgs e)
        {
            string playerscore = player2round0.Text;

            if (string.IsNullOrEmpty(playerscore))
            {
                MessageBox.Show("Input error: Player 2 score is empty for the blanks round.", "Error", MessageBoxButtons.OK);
                return;
            }
            if (!Regex.Match(playerscore, "^[0-9]{0,3}$").Success)
            {
                MessageBox.Show("Input error: The score can only contain whole numbers 0 - 999.", "Error", MessageBoxButtons.OK);
                const char empty = '0';
                player2round0.Text = empty.ToString();
                return;
            }
        }

        private void player3round0_TextChanged(object sender, EventArgs e)
        {
            string playerscore = player3round0.Text;

            if (string.IsNullOrEmpty(playerscore))
            {
                MessageBox.Show("Input error: Player 3 score is empty for the blanks round.", "Error", MessageBoxButtons.OK);
                return;
            }
            if (!Regex.Match(playerscore, "^[0-9]{0,3}$").Success)
            {
                MessageBox.Show("Input error: The score can only contain whole numbers 0 - 999.", "Error", MessageBoxButtons.OK);
                const char empty = '0';
                player3round0.Text = empty.ToString();
                return;
            }
        }

        private void player4round0_TextChanged(object sender, EventArgs e)
        {
            string playerscore = player4round0.Text;

            if (string.IsNullOrEmpty(playerscore))
            {
                MessageBox.Show("Input error: Player 4 score is empty for the blanks round.", "Error", MessageBoxButtons.OK);
                return;
            }
            if (!Regex.Match(playerscore, "^[0-9]{0,3}$").Success)
            {
                MessageBox.Show("Input error: The score can only contain whole numbers 0 - 999.", "Error", MessageBoxButtons.OK);
                const char empty = '0';
                player4round0.Text = empty.ToString();
                return;
            }
        }

        private void player5round0_TextChanged(object sender, EventArgs e)
        {
            string playerscore = player5round0.Text;

            if (string.IsNullOrEmpty(playerscore))
            {
                MessageBox.Show("Input error: Player 5 score is empty for the blanks round.", "Error", MessageBoxButtons.OK);
                return;
            }
            if (!Regex.Match(playerscore, "^[0-9]{0,3}$").Success)
            {
                MessageBox.Show("Input error: The score can only contain whole numbers 0 - 999.", "Error", MessageBoxButtons.OK);
                const char empty = '0';
                player5round0.Text = empty.ToString();
                return;
            }
        }

        private void player6round0_TextChanged(object sender, EventArgs e)
        {
            string playerscore = player6round0.Text;

            if (string.IsNullOrEmpty(playerscore))
            {
                MessageBox.Show("Input error: Player 6 score is empty for the blanks round.", "Error", MessageBoxButtons.OK);
                return;
            }
            if (!Regex.Match(playerscore, "^[0-9]{0,3}$").Success)
            {
                MessageBox.Show("Input error: The score can only contain whole numbers 0 - 999.", "Error", MessageBoxButtons.OK);
                const char empty = '0';
                player6round0.Text = empty.ToString();
                return;
            }
        }

        private void totalsButton_Click(object sender, EventArgs e)
        {
            int p1r12;
            if (!string.IsNullOrWhiteSpace(player1round12.Text))
            {
                p1r12 = Int32.Parse(player1round12.Text);
            } else
            {
                p1r12 = 0;
            }
            
            int p1r11;
            if (!string.IsNullOrWhiteSpace(player1round11.Text))
            {
                p1r11 = Int32.Parse(player1round11.Text);
            }
            else
            {
                p1r11 = 0;
            }
            
            int p1r10;
            if (!string.IsNullOrWhiteSpace(player1round10.Text))
            {
                p1r10 = Int32.Parse(player1round10.Text);
            }
            else
            {
                p1r10 = 0;
            }

            int p1r9;
            if (!string.IsNullOrWhiteSpace(player1round9.Text))
            {
                p1r9 = Int32.Parse(player1round9.Text);
            }
            else
            {
                p1r9 = 0;
            }

            int p1r8;
            if (!string.IsNullOrWhiteSpace(player1round8.Text))
            {
                p1r8 = Int32.Parse(player1round8.Text);
            }
            else
            {
                p1r8 = 0;
            }

            int p1r7;
            if (!string.IsNullOrWhiteSpace(player1round7.Text))
            {
                p1r7 = Int32.Parse(player1round7.Text);
            }
            else
            {
                p1r7 = 0;
            }

            int p1r6;
            if (!string.IsNullOrWhiteSpace(player1round6.Text))
            {
                p1r6 = Int32.Parse(player1round6.Text);
            }
            else
            {
                p1r6 = 0;
            }

            int p1r5;
            if (!string.IsNullOrWhiteSpace(player1round5.Text))
            {
                p1r5 = Int32.Parse(player1round5.Text);
            }
            else
            {
                p1r5 = 0;
            }

            int p1r4;
            if (!string.IsNullOrWhiteSpace(player1round4.Text))
            {
                p1r4 = Int32.Parse(player1round4.Text);
            }
            else
            {
                p1r4 = 0;
            }

            int p1r3;
            if (!string.IsNullOrWhiteSpace(player1round3.Text))
            {
                p1r3 = Int32.Parse(player1round3.Text);
            }
            else
            {
                p1r3 = 0;
            }

            int p1r2;
            if (!string.IsNullOrWhiteSpace(player1round2.Text))
            {
                p1r2 = Int32.Parse(player1round2.Text);
            }
            else
            {
                p1r2 = 0;
            }

            int p1r1;
            if (!string.IsNullOrWhiteSpace(player1round1.Text))
            {
                p1r1 = Int32.Parse(player1round1.Text);
            }
            else
            {
                p1r1 = 0;
            }

            int p1r0;
            if (!string.IsNullOrWhiteSpace(player1round0.Text))
            {
                p1r0 = Int32.Parse(player1round0.Text);
            }
            else
            {
                p1r0 = 0;
            }

            int p1total = p1r12 + p1r11 + p1r10 + p1r9 + p1r8 + p1r7 + p1r6 + p1r5 + p1r4 + p1r3 + p1r2 + p1r1 + p1r0;
            player1total.Text = p1total.ToString();

            int p2r12;
            if (!string.IsNullOrWhiteSpace(player2round12.Text))
            {
                p2r12 = Int32.Parse(player2round12.Text);
            }
            else
            {
                p2r12 = 0;
            }

            int p2r11;
            if (!string.IsNullOrWhiteSpace(player2round11.Text))
            {
                p2r11 = Int32.Parse(player2round11.Text);
            }
            else
            {
                p2r11 = 0;
            }

            int p2r10;
            if (!string.IsNullOrWhiteSpace(player2round10.Text))
            {
                p2r10 = Int32.Parse(player2round10.Text);
            }
            else
            {
                p2r10 = 0;
            }

            int p2r9;
            if (!string.IsNullOrWhiteSpace(player2round9.Text))
            {
                p2r9 = Int32.Parse(player2round9.Text);
            }
            else
            {
                p2r9 = 0;
            }

            int p2r8;
            if (!string.IsNullOrWhiteSpace(player2round8.Text))
            {
                p2r8 = Int32.Parse(player2round8.Text);
            }
            else
            {
                p2r8 = 0;
            }

            int p2r7;
            if (!string.IsNullOrWhiteSpace(player2round7.Text))
            {
                p2r7 = Int32.Parse(player2round7.Text);
            }
            else
            {
                p2r7 = 0;
            }

            int p2r6;
            if (!string.IsNullOrWhiteSpace(player2round6.Text))
            {
                p2r6 = Int32.Parse(player2round6.Text);
            }
            else
            {
                p2r6 = 0;
            }

            int p2r5;
            if (!string.IsNullOrWhiteSpace(player2round5.Text))
            {
                p2r5 = Int32.Parse(player2round5.Text);
            }
            else
            {
                p2r5 = 0;
            }

            int p2r4;
            if (!string.IsNullOrWhiteSpace(player2round4.Text))
            {
                p2r4 = Int32.Parse(player2round4.Text);
            }
            else
            {
                p2r4 = 0;
            }

            int p2r3;
            if (!string.IsNullOrWhiteSpace(player2round3.Text))
            {
                p2r3 = Int32.Parse(player2round3.Text);
            }
            else
            {
                p2r3 = 0;
            }

            int p2r2;
            if (!string.IsNullOrWhiteSpace(player2round2.Text))
            {
                p2r2 = Int32.Parse(player2round2.Text);
            }
            else
            {
                p2r2 = 0;
            }

            int p2r1;
            if (!string.IsNullOrWhiteSpace(player2round1.Text))
            {
                p2r1 = Int32.Parse(player2round1.Text);
            }
            else
            {
                p2r1 = 0;
            }

            int p2r0;
            if (!string.IsNullOrWhiteSpace(player2round0.Text))
            {
                p2r0 = Int32.Parse(player2round0.Text);
            }
            else
            {
                p2r0 = 0;
            }

            int p2total = p2r12 + p2r11 + p2r10 + p2r9 + p2r8 + p2r7 + p2r6 + p2r5 + p2r4 + p2r3 + p2r2 + p2r1 + p2r0;
            player2total.Text = p2total.ToString();

            int p3r12;
            if (!string.IsNullOrWhiteSpace(player3round12.Text))
            {
                p3r12 = Int32.Parse(player3round12.Text);
            }
            else
            {
                p3r12 = 0;
            }

            int p3r11;
            if (!string.IsNullOrWhiteSpace(player3round11.Text))
            {
                p3r11 = Int32.Parse(player3round11.Text);
            }
            else
            {
                p3r11 = 0;
            }

            int p3r10;
            if (!string.IsNullOrWhiteSpace(player3round10.Text))
            {
                p3r10 = Int32.Parse(player3round10.Text);
            }
            else
            {
                p3r10 = 0;
            }

            int p3r9;
            if (!string.IsNullOrWhiteSpace(player3round9.Text))
            {
                p3r9 = Int32.Parse(player3round9.Text);
            }
            else
            {
                p3r9 = 0;
            }

            int p3r8;
            if (!string.IsNullOrWhiteSpace(player3round8.Text))
            {
                p3r8 = Int32.Parse(player3round8.Text);
            }
            else
            {
                p3r8 = 0;
            }

            int p3r7;
            if (!string.IsNullOrWhiteSpace(player3round7.Text))
            {
                p3r7 = Int32.Parse(player3round7.Text);
            }
            else
            {
                p3r7 = 0;
            }

            int p3r6;
            if (!string.IsNullOrWhiteSpace(player3round6.Text))
            {
                p3r6 = Int32.Parse(player3round6.Text);
            }
            else
            {
                p3r6 = 0;
            }

            int p3r5;
            if (!string.IsNullOrWhiteSpace(player3round5.Text))
            {
                p3r5 = Int32.Parse(player3round5.Text);
            }
            else
            {
                p3r5 = 0;
            }

            int p3r4;
            if (!string.IsNullOrWhiteSpace(player3round4.Text))
            {
                p3r4 = Int32.Parse(player3round4.Text);
            }
            else
            {
                p3r4 = 0;
            }

            int p3r3;
            if (!string.IsNullOrWhiteSpace(player3round3.Text))
            {
                p3r3 = Int32.Parse(player3round3.Text);
            }
            else
            {
                p3r3 = 0;
            }

            int p3r2;
            if (!string.IsNullOrWhiteSpace(player3round2.Text))
            {
                p3r2 = Int32.Parse(player3round2.Text);
            }
            else
            {
                p3r2 = 0;
            }

            int p3r1;
            if (!string.IsNullOrWhiteSpace(player3round1.Text))
            {
                p3r1 = Int32.Parse(player3round1.Text);
            }
            else
            {
                p3r1 = 0;
            }

            int p3r0;
            if (!string.IsNullOrWhiteSpace(player3round0.Text))
            {
                p3r0 = Int32.Parse(player3round0.Text);
            }
            else
            {
                p3r0 = 0;
            }

            int p3total = p3r12 + p3r11 + p3r10 + p3r9 + p3r8 + p3r7 + p3r6 + p3r5 + p3r4 + p3r3 + p3r2 + p3r1 + p3r0;
            player3total.Text = p3total.ToString();

            int p4r12;
            if (!string.IsNullOrWhiteSpace(player4round12.Text))
            {
                p4r12 = Int32.Parse(player4round12.Text);
            }
            else
            {
                p4r12 = 0;
            }

            int p4r11;
            if (!string.IsNullOrWhiteSpace(player4round11.Text))
            {
                p4r11 = Int32.Parse(player4round11.Text);
            }
            else
            {
                p4r11 = 0;
            }

            int p4r10;
            if (!string.IsNullOrWhiteSpace(player4round10.Text))
            {
                p4r10 = Int32.Parse(player4round10.Text);
            }
            else
            {
                p4r10 = 0;
            }

            int p4r9;
            if (!string.IsNullOrWhiteSpace(player4round9.Text))
            {
                p4r9 = Int32.Parse(player4round9.Text);
            }
            else
            {
                p4r9 = 0;
            }

            int p4r8;
            if (!string.IsNullOrWhiteSpace(player4round8.Text))
            {
                p4r8 = Int32.Parse(player4round8.Text);
            }
            else
            {
                p4r8 = 0;
            }

            int p4r7;
            if (!string.IsNullOrWhiteSpace(player4round7.Text))
            {
                p4r7 = Int32.Parse(player4round7.Text);
            }
            else
            {
                p4r7 = 0;
            }

            int p4r6;
            if (!string.IsNullOrWhiteSpace(player4round6.Text))
            {
                p4r6 = Int32.Parse(player4round6.Text);
            }
            else
            {
                p4r6 = 0;
            }

            int p4r5;
            if (!string.IsNullOrWhiteSpace(player4round5.Text))
            {
                p4r5 = Int32.Parse(player4round5.Text);
            }
            else
            {
                p4r5 = 0;
            }

            int p4r4;
            if (!string.IsNullOrWhiteSpace(player4round4.Text))
            {
                p4r4 = Int32.Parse(player4round4.Text);
            }
            else
            {
                p4r4 = 0;
            }

            int p4r3;
            if (!string.IsNullOrWhiteSpace(player4round3.Text))
            {
                p4r3 = Int32.Parse(player4round3.Text);
            }
            else
            {
                p4r3 = 0;
            }

            int p4r2;
            if (!string.IsNullOrWhiteSpace(player4round2.Text))
            {
                p4r2 = Int32.Parse(player4round2.Text);
            }
            else
            {
                p4r2 = 0;
            }

            int p4r1;
            if (!string.IsNullOrWhiteSpace(player4round1.Text))
            {
                p4r1 = Int32.Parse(player4round1.Text);
            }
            else
            {
                p4r1 = 0;
            }

            int p4r0;
            if (!string.IsNullOrWhiteSpace(player4round0.Text))
            {
                p4r0 = Int32.Parse(player4round0.Text);
            }
            else
            {
                p4r0 = 0;
            }

            int p4total = p4r12 + p4r11 + p4r10 + p4r9 + p4r8 + p4r7 + p4r6 + p4r5 + p4r4 + p4r3 + p4r2 + p4r1 + p4r0;
            player4total.Text = p4total.ToString();

            int p5r12;
            if (!string.IsNullOrWhiteSpace(player5round12.Text))
            {
                p5r12 = Int32.Parse(player5round12.Text);
            }
            else
            {
                p5r12 = 0;
            }

            int p5r11;
            if (!string.IsNullOrWhiteSpace(player5round11.Text))
            {
                p5r11 = Int32.Parse(player5round11.Text);
            }
            else
            {
                p5r11 = 0;
            }

            int p5r10;
            if (!string.IsNullOrWhiteSpace(player5round10.Text))
            {
                p5r10 = Int32.Parse(player4round9.Text);
            }
            else
            {
                p5r10 = 0;
            }

            int p5r9;
            if (!string.IsNullOrWhiteSpace(player5round9.Text))
            {
                p5r9 = Int32.Parse(player5round9.Text);
            }
            else
            {
                p5r9 = 0;
            }

            int p5r8;
            if (!string.IsNullOrWhiteSpace(player5round8.Text))
            {
                p5r8 = Int32.Parse(player5round8.Text);
            }
            else
            {
                p5r8 = 0;
            }

            int p5r7;
            if (!string.IsNullOrWhiteSpace(player5round7.Text))
            {
                p5r7 = Int32.Parse(player5round7.Text);
            }
            else
            {
                p5r7 = 0;
            }

            int p5r6;
            if (!string.IsNullOrWhiteSpace(player5round6.Text))
            {
                p5r6 = Int32.Parse(player5round6.Text);
            }
            else
            {
                p5r6 = 0;
            }

            int p5r5;
            if (!string.IsNullOrWhiteSpace(player5round5.Text))
            {
                p5r5 = Int32.Parse(player5round5.Text);
            }
            else
            {
                p5r5 = 0;
            }

            int p5r4;
            if (!string.IsNullOrWhiteSpace(player5round4.Text))
            {
                p5r4 = Int32.Parse(player5round4.Text);
            }
            else
            {
                p5r4 = 0;
            }

            int p5r3;
            if (!string.IsNullOrWhiteSpace(player5round3.Text))
            {
                p5r3 = Int32.Parse(player5round3.Text);
            }
            else
            {
                p5r3 = 0;
            }

            int p5r2;
            if (!string.IsNullOrWhiteSpace(player5round2.Text))
            {
                p5r2 = Int32.Parse(player2round5.Text);
            }
            else
            {
                p5r2 = 0;
            }

            int p5r1;
            if (!string.IsNullOrWhiteSpace(player5round1.Text))
            {
                p5r1 = Int32.Parse(player5round1.Text);
            }
            else
            {
                p5r1 = 0;
            }

            int p5r0;
            if (!string.IsNullOrWhiteSpace(player5round0.Text))
            {
                p5r0 = Int32.Parse(player5round0.Text);
            }
            else
            {
                p5r0 = 0;
            }

            int p5total = p5r12 + p5r11 + p5r10 + p5r9 + p5r8 + p5r7 + p5r6 + p5r5 + p5r4 + p5r3 + p5r2 + p5r1 + p5r0;
            player5total.Text = p5total.ToString();

            int p6r12;
            if (!string.IsNullOrWhiteSpace(player6round12.Text))
            {
                p6r12 = Int32.Parse(player6round12.Text);
            }
            else
            {
                p6r12 = 0;
            }


            int p6r11;
            if (!string.IsNullOrWhiteSpace(player6round11.Text))
            {
                p6r11 = Int32.Parse(player6round11.Text);
            }
            else
            {
                p6r11 = 0;
            }

            int p6r10;
            if (!string.IsNullOrWhiteSpace(player6round10.Text))
            {
                p6r10 = Int32.Parse(player6round10.Text);
            }
            else
            {
                p6r10 = 0;
            }

            int p6r9;
            if (!string.IsNullOrWhiteSpace(player6round9.Text))
            {
                p6r9 = Int32.Parse(player6round9.Text);
            }
            else
            {
                p6r9 = 0;
            }

            int p6r8;
            if (!string.IsNullOrWhiteSpace(player6round8.Text))
            {
                p6r8 = Int32.Parse(player6round8.Text);
            }
            else
            {
                p6r8 = 0;
            }

            int p6r7;
            if (!string.IsNullOrWhiteSpace(player6round7.Text))
            {
                p6r7 = Int32.Parse(player6round7.Text);
            }
            else
            {
                p6r7 = 0;
            }

            int p6r6;
            if (!string.IsNullOrWhiteSpace(player6round6.Text))
            {
                p6r6 = Int32.Parse(player6round6.Text);
            }
            else
            {
                p6r6 = 0;
            }

            int p6r5;
            if (!string.IsNullOrWhiteSpace(player6round5.Text))
            {
                p6r5 = Int32.Parse(player6round5.Text);
            }
            else
            {
                p6r5 = 0;
            }

            int p6r4;
            if (!string.IsNullOrWhiteSpace(player6round4.Text))
            {
                p6r4 = Int32.Parse(player6round4.Text);
            }
            else
            {
                p6r4 = 0;
            }
            
            int p6r3;
            if (!string.IsNullOrWhiteSpace(player6round3.Text))
            {
                p6r3 = Int32.Parse(player6round3.Text);
            }
            else
            {
                p6r3 = 0;
            }
            
            int p6r2;
            if (!string.IsNullOrWhiteSpace(player6round2.Text))
            {
                p6r2 = Int32.Parse(player6round2.Text);
            }
            else
            {
                p6r2 = 0;
            }

            int p6r1;
            if (!string.IsNullOrWhiteSpace(player6round1.Text))
            {
                p6r1 = Int32.Parse(player6round1.Text);
            }
            else
            {
                p6r1 = 0;
            }

            int p6r0;
            if (!string.IsNullOrWhiteSpace(player6round0.Text))
            {
                p6r0 = Int32.Parse(player6round0.Text);
            }
            else
            {
                p6r0 = 0;
            }

            int p6total = p6r12 + p6r11 + p6r10 + p6r9 + p6r8 + p6r7 + p6r6 + p6r5 + p6r4 + p6r3 + p6r2 + p6r1 + p6r0;
            player6total.Text = p6total.ToString();
        }
    }
}
