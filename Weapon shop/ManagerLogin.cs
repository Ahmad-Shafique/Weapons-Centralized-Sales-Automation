﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Weapon_shop
{
    public partial class ManagerLogin : Form
    {
        public ManagerLogin()
        {
            InitializeComponent();
            this.ControlBox = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            
        }

        private void ManagerLogin_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            textBox1_EnterKeyPressed(this, new EventArgs());
        }

        private void textBox1_EnterKeyPressed(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals(new ManagerInfo().ManagerPassword))
            {
                this.Hide();
                ManagerInfo minfo = new ManagerInfo();
                minfo.Show();
            }
        }
    }
}
