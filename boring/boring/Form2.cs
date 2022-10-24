using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace boring
{
    public partial class Form2 : Form
    {
        Bitmap img = new Bitmap(@"C:\Users\Bysky\Desktop\git-hub\c#\5dd210151931ac0aa59b74a070197896.png");
        int i;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = img;

            Method.calculate(img);

            List<double> data1 = Data.parameter["data"];

            setchart();
            for (i = 0; i < img.Width; i++)
            {
                chart1.Series[0].Points.AddXY(i, data1[i]);
            }
        }

        public void setchart()
        {
            chart1.Series[0].Points.Clear();
            chart1.ChartAreas[0].AxisX.Minimum = 0;
            chart1.ChartAreas[0].AxisY.Minimum = 0;

            chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gamebtn_Click(object sender, EventArgs e)
        {
            game.Form1 gamef1 = new game.Form1();
            gamef1.Show();
        }

        private void lotterybtn_Click(object sender, EventArgs e)
        {
            lottery.Form1 lotteryf1 = new lottery.Form1();
            lotteryf1.Show();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.ShowDialog();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
