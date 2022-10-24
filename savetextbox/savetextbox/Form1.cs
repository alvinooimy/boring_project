using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace savetextbox
{
    public partial class Form1 : Form
    {
        List<string> savefile = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists("savedata.txt"))
            {
                List<string> readfile = File.ReadAllLines("savedata.txt").ToList();

                textBox1.Text = readfile[0];
                textBox2.Text = readfile[1];
                textBox3.Text = readfile[2];
            }         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string save_result;

            savefile.Add(textBox1.Text);
            savefile.Add(textBox2.Text);
            savefile.Add(textBox3.Text);

            try{
                File.WriteAllLines("savedata.txt", savefile);
                savefile.Clear();
                save_result = "DONE";
            }
            catch(Exception err){
                Console.WriteLine(err.ToString());
                save_result = err.ToString();
            }
            MessageBox.Show(save_result);
        }
    }
}
