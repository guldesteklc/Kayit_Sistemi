﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Text = textBox1.Text;
            label4.Text = textBox2.Text;
            label11.Text = comboBox1.Text;
            label9.Text = textBox3.Text;
            label13.Text = textBox4.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
