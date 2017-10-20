using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _1642027_BTCN01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Load();
        }
        public void Load()
        {
            DataProvider dp = new DataProvider();
            dataGridView1.DataSource = dp.HienThiHocSinh();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataProvider dp = new DataProvider();
            int kq = dp.ThemHocSinh(textBox2.Text, dateTimePicker1.Value.ToString(),comboBox1.Text);
            if (kq > 0)
            {
                MessageBox.Show("Them Thanh Cong", "Thong Tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Load();
            }
            else
            {
                MessageBox.Show("Them Khong Thanh Cong", "Thong Tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataProvider dp = new DataProvider();
            int kq = dp.XoaHocSinh(textBox1.Text);
            if (kq > 0)
            {
                MessageBox.Show("Xoa Thanh Cong", "Thong Tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Load();
            }
            else
            {
                MessageBox.Show("Xoa Khong Thanh Cong", "Thong Tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            textBox1.Text = dataGridView1.Rows[index].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
            dateTimePicker1.Text = dataGridView1.Rows[index].Cells[2].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[index].Cells[3].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataProvider dp = new DataProvider();
            int kq = dp.UpdateHocSinh(textBox1.Text, textBox2.Text, dateTimePicker1.Value.ToString(), comboBox1.Text);
            if(kq > 0)
            {
                MessageBox.Show("Sua Thanh Cong", "Thong Tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Load();
            }
            else
            {
                MessageBox.Show("Sua Khong Thanh Cong", "Thong Tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataProvider dp = new DataProvider();
            dataGridView1.DataSource = dp.TimKiemTheoTen(textBox2.Text);
        }
    }
}
