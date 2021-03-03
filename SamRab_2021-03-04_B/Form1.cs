﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SamRab_2021_03_04_B
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        float[,] a = new float[100, 100];
        int i, j, n, m;
        Random rand = new Random();

        private void button1_Click(object sender, EventArgs e)
        {
            n = Convert.ToInt32(textBox1.Text);
            m = Convert.ToInt32(textBox2.Text);
            dataGridView1.RowCount = n;
            dataGridView1.ColumnCount = m;
            for
                (
                i = 0;
                i < n; i++
                )
            {
                for (
                    j = 0;
                    j < m;
                    j++
                    )
                {
                    a[i, j] = rand.Next(0, 21) - 10;
                    dataGridView1[j, i].Value = Convert.ToString(a[i, j]);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView2.RowCount = n;
            dataGridView2.ColumnCount = m;
            for (i = 0; i < n; i++)
            {
                for
                (
                j = 0;
                j < m;
                j++
                )

                {
                    a[i, j] = Convert.ToInt32(dataGridView1[j, i].Value);
                }
            }

            for
            (
            i = 0;
            i < n;
            i++
            )

            {
                for
                (
                j = 0;
                j < m;
                j++
                )

                {
                    dataGridView2[j, i].Value = Convert.ToString(a[i, j]);
                }
            }
        }
    }
}
