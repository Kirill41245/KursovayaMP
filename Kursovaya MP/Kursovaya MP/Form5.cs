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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double procent = Convert.ToDouble(textBox1.Text);
            for (int i = 0; i < ((Form1)this.Owner).dataGridView1.RowCount; i++)
            {
                double cost = Convert.ToDouble(((Form1)this.Owner).dataGridView1[3, i].Value);
                int prod = Convert.ToInt32(((Form1)this.Owner).dataGridView1[4, i].Value);
                int ostat = Convert.ToInt32(((Form1)this.Owner).dataGridView1[5, i].Value);
                if (ostat > 2 * prod)
                {
                    cost = cost - (cost * procent / 100);
                    ((Form1)this.Owner).dataGridView1[3, i].Value = cost;
                }
            }
            Close();
        }
    }
}
