﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HA.PMS.SnManager
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.ControlBox = false;
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "huangxiaoke1" && textBox2.Text == "123789456")
            {
                this.Close();
            }
        }
    }
}
