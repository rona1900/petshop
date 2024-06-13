﻿using ScottPlot;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Petshop
{
    public partial class Home : Form
    {
        private Form currentchildForm;
        public Home()
        {
            InitializeComponent();
        }
        public void OpenChildForm(Form childForm, int xpos, int ypos)
        {
            if (currentchildForm != null)
            {
                currentchildForm.Hide();
            }
            currentchildForm = childForm;
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.None;
            this.Controls.Add(childForm);
            this.Tag = childForm;
            //childForm.BringToFront();
            childForm.Show();
            childForm.Size = new Size(/*Convert.ToInt32(childForm.Width * 1.155), Convert.ToInt32(childForm.Height * 1.096 - 5)*/1400, 782);
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Location = new Point(xpos, ypos);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Employee(), 133, 80);
        }

        private void product_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Product(), 133, 80);
        }

        private void customer_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Customer(), 133, 80);
        }

        private void analytics_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Analytics(), 133, 80);
        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Home(), 133, 80);
        }

        private void Home_Load(object sender, EventArgs e)
        {
            OpenChildForm(new Analytics(), 133, 80);
        }
    }
}
