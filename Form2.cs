﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Original1
{
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();
            button1.Text = Form1.testString;

        }


        private void Form2_Load(object sender, EventArgs e)
        {

        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            
            this.Owner.Show();
            this.Hide();
        }
    }
    
}
