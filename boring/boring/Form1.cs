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
    public partial class Form1 : Form
    {
        Form2 f2 = new Form2();

        string boring = "我也很無聊";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(boring);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("可是你旁邊的人很無聊");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form2 f2 = new Form2();

            f2.Close();
            
        }
    }
}
