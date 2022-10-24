using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lottery
{
    public partial class Form1 : Form
    {
        int ans;
        static int speed1;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            startbtn1.Visible = false;

            trackBar1.Minimum = 1;
            trackBar1.Maximum = 10;
            trackscroollbl.Text = Convert.ToString(trackBar1.Value); 
        }

        private void startbtn_Click(object sender, EventArgs e)
        {
            string guessnum;
            string result;
            string status;

            rdn();
            guessnum = guesstxtbox.Text;
            if (guessnum == "")
            {
                result = "Please input a number";
                status = "Error";
            }
            else if(Convert.ToInt32(guessnum) == ans)
            {
                result = "You Win";
                status = "Win";
            }
            else
            {
                result = "You Lose";
                status = "Lose";
            }
            statuslbl.Text = status;
            MessageBox.Show(result);
            Console.WriteLine(ans);
        }

        public void rdn()
        {
            var rand = new Random();

            ans = rand.Next(1,101);          
        }

        private void startbtn1_Click(object sender, EventArgs e)
        {
            setbtn.Visible = false;
            startbtn1.Enabled = false;

            int chartnumber = chart1.Series.Count;

            if (startbtn1.Text == "RESTART")
            {
                for (int i = 0; i < chartnumber; i++)
                {
                    data.horsespeed.Remove(Convert.ToString(i));
                    chart1.Series[i].Points.Clear();
                }
            }
            timer1.Start();
        }

        private void setbtn_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(this);

            int number;

            removechart();
            
            number = Convert.ToInt32(trackscroollbl.Text);

            for (int i = 1;i <= number; i++)
            {
                f2.StartPosition = FormStartPosition.CenterScreen;
                f2.TopMost = true;
                f2.ShowDialog();
                String inputname = f2.returntext;
                chart1.Series.Add(inputname);
            }
            setchart();
            startbtn1.Text = "START";
            startbtn1.Visible = true;
        }

        public void setchart()
        {
            int chartnumber = chart1.Series.Count;

            chart1.ChartAreas[0].AxisX.Minimum = 0;
            chart1.ChartAreas[0].AxisY.Minimum = 0;
            chart1.ChartAreas[0].AxisX.Maximum = chartnumber + 1;
            chart1.ChartAreas[0].AxisY.Maximum = 1000;

            for (int i = 0; i < chart1.Series.Count; i++)
            {
                data.horsespeed.Remove(Convert.ToString(i));
                chart1.Series[i].Points.AddXY(i + 1, 1);
            }
        }

        public void removechart()
        {
            int chartnumber = chart1.Series.Count;

            if (chart1.Series.Count != 0)
            {
                for (int i = 0; i < chartnumber; i++)
                {
                    chart1.Series.Remove(chart1.Series[0]);
                }
            }
        }

        public void speed(int numb)
        {
            Random rand = new Random();
            int speed = 0;
           
            speed = rand.Next(11);
            if (speed == speed1)
            {
                speed = rand.Next(11);
            }
            speed1 = speed;

            method.speedcalculation(speed, numb);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int chartnumber = chart1.Series.Count;

            for (int i = 0; i < chartnumber; i++)
            {
                speed(i);
                chart1.Series[i].Points.AddXY(i + 1, data.horsespeed[Convert.ToString(i)]);

                if (data.horsespeed[Convert.ToString(i)] >= 1000)
                {
                    timer1.Stop();

                    chart1.Series[i].Points.AddXY(i + 1, 1000);
                    MessageBox.Show(chart1.Series[i].Name + " Win");

                    setbtn.Visible = true;

                    startbtn1.Text = "RESTART";
                    startbtn1.Enabled = true;

                    return;
                }
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            trackscroollbl.Text = Convert.ToString(trackBar1.Value);
        }
    }
}
