using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace game
{
    public partial class Form1 : Form
    {
        int bomb;
        int ans;
        int score1 = 0;
        int score2 = 0;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            button11.Enabled = false;
            button12.Enabled = false;
            button13.Enabled = false;
            button14.Enabled = false;
            button15.Enabled = false;
            button16.Enabled = false;
            button17.Enabled = false;
            button18.Enabled = false;
            button19.Enabled = false;
            button20.Enabled = false;
            button21.Enabled = false;
            button22.Enabled = false;
            button23.Enabled = false;
            button24.Enabled = false;
            button25.Enabled = false;

            restart.Visible = false;
        }

        private void start_Click(object sender, EventArgs e)
        {
            bomb = new Random().Next(1, 25);
            label2.Text = "1";
            start.Hide();
            restart.Hide();

            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button10.Enabled = true;
            button11.Enabled = true;
            button12.Enabled = true;
            button13.Enabled = true;
            button14.Enabled = true;
            button15.Enabled = true;
            button16.Enabled = true;
            button17.Enabled = true;
            button18.Enabled = true;
            button19.Enabled = true;
            button20.Enabled = true;
            button21.Enabled = true;
            button22.Enabled = true;
            button23.Enabled = true;
            button24.Enabled = true;
            button25.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ans = 1;
            check(ans);
            button1.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ans = 2;
            check(ans);
            button2.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ans = 3;
            check(ans);
            button3.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ans = 4;
            check(ans);
            button4.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ans = 5;
            check(ans);
            button5.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ans = 6;
            check(ans);
            button6.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ans = 7;
            check(ans);
            button7.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ans = 8;
            check(ans);
            button8.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ans = 9;
            check(ans);
            button9.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ans = 10;
            check(ans);
            button10.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            ans = 11;
            check(ans);
            button11.Hide();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            ans = 12;
            check(ans);
            button12.Hide();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            ans = 13;
            check(ans);
            button13.Hide();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            ans = 14;
            check(ans);
            button14.Hide();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            ans = 15;
            check(ans);
            button15.Hide();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            ans = 16;
            check(ans);
            button16.Hide();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            ans = 17;
            check(ans);
            button17.Hide();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            ans = 18;
            check(ans);
            button18.Hide();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            ans = 19;
            check(ans);
            button19.Hide();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            ans = 20;
            check(ans);
            button20.Hide();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            ans = 21;
            check(ans);
            button21.Hide();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            ans = 22;
            check(ans);
            button22.Hide();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            ans = 23;
            check(ans);
            button23.Hide();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            ans = 24;
            check(ans);
            button24.Hide();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            ans = 25;
            check(ans);
            button25.Hide();
        }

        private void restart_Click(object sender, EventArgs e)
        {
            bomb = new Random().Next(1, 25);
            label2.Text = "1";
            restart.Hide();
            MessageBox.Show("Game Start");

            button1.Show();
            button2.Show();
            button3.Show();
            button4.Show();
            button5.Show();
            button6.Show();
            button7.Show();
            button8.Show();
            button9.Show();
            button10.Show();
            button11.Show();
            button12.Show();
            button13.Show();
            button14.Show();
            button15.Show();
            button16.Show();
            button17.Show();
            button18.Show();
            button19.Show();
            button20.Show();
            button21.Show();
            button22.Show();
            button23.Show();
            button24.Show();
            button25.Show();
        }

        private void result_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Result\n"+"Player 1: "+score1+"\n"+"Player 2: "+score2);
        }

        public void check(int checkans)
        {
            string player = label2.Text;
            if (checkans == bomb)
            {
                MessageBox.Show("BOMB !!!");
                MessageBox.Show("Player: " + player + " Lose");
                restart.Visible = true;
                score(player);
                bomb = 0;
            }
            else if (player == "1")
            {
                label2.Text = "2";
            }
            else if (player == "2")
            {
                label2.Text = "1";
            }
        }

        public void score(string player)
        {
            if (player == "1")
            {
                score2++;
            }
            else if (player == "2")
            {
                score1++;
            }
        }
    }
}