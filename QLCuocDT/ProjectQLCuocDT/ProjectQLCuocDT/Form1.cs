﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectQLCuocDT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmHoaDonDK frm = new frmHoaDonDK();
            frm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmHoaDonThanhToan frm = new frmHoaDonThanhToan();
            frm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmSim frm = new frmSim();
            frm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmLoaiCuoc frm = new frmLoaiCuoc();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Frmkhachhang frm = new Frmkhachhang();
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmCuocGoi frm = new frmCuocGoi();
            frm.Show();
        }
    }
}
