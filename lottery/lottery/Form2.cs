﻿using System;
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
    public partial class Form2 : Form
    {
        Form1 f1;

        public System.Windows.Forms.Keys KeyData { get; }

        public string returntext { get; set; }

        public Form2(Form1 form1)
        {
            InitializeComponent();
            f1 = form1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.returntext = this.textBox1.Text;
            textBox1.Clear();
            
            Close();
        }
    }
}
