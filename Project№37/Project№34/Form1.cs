using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_34
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Modulars MOD = new Modulars();
        private void button1_Click(object sender, EventArgs e)
        {
            MOD.BuildRoud(int.Parse(textBox1.Text), dataGridView1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MOD.Analiz(dataGridView1, dataGridView2,dataGridView3);
        }

        
    }
}
