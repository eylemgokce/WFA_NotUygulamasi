﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_NotUygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_hesapla_Click(object sender, EventArgs e)
        {
            double vize = Convert.ToDouble(textBox1_vize.Text);
            double final = Convert.ToDouble(textBox2_final.Text);

            double sonuc = (vize * 0.4) + (final * 0.6);
            label5_sonuc.Text = sonuc.ToString();
            

        }
    }
}
