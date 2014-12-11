using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace Auto_Find_Best_Driver_For_BF4___BFVN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == ("GTX 970"))
            {
                Process.Start("http://us.download.nvidia.com/Windows/344.65/344.65-desktop-win8-win7-winvista-64bit-international-whql.exe");
            }
            else
            {
                MessageBox.Show("Chưa có driver cho card này trong danh sách hoặc thím chưa gõ tên card");
            }
            if (textBox1.Text == ("GTX 660"))
            {
                Process.Start("http://us.download.nvidia.com/Windows/344.75/344.75-desktop-win8-win7-winvista-64bit-international-whql.exe");
            }
        }
    }
}
