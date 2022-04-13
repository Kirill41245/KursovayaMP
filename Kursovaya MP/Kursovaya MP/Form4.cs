using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursovaya_MP
{
    
    public partial class Form4 : Form
    {
        public static int nomer;
        public Form4()
        {
            InitializeComponent();
            textBox2.ReadOnly = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nomer = Convert.ToInt32(textBox1.Text);
            int res = 0;
            for (int i = 0; i < ((Form1)this.Owner).dataGridView1.RowCount; i++)
            {
                int a = Convert.ToInt32(((Form1)this.Owner).dataGridView1[2, i].Value); // [столбец, строка]
                if (nomer == a)
                {
                    res += Convert.ToInt32(((Form1)this.Owner).dataGridView1[4, i].Value);
                }
            }
            textBox2.Text = Convert.ToString(res);
        }
    }
}
