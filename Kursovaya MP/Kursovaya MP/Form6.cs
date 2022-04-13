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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double graniza = Convert.ToDouble(textBox1.Text);
            for (int i = ((Form1)this.Owner).dataGridView1.RowCount-1; i>=0 ; i--)
            {
                double cost = Convert.ToDouble(((Form1)this.Owner).dataGridView1[3, i].Value);
                
                if (graniza > cost)
                {
                    ((Form1)this.Owner).dataGridView1.Rows.Remove(((Form1)this.Owner).dataGridView1.Rows[i]);
                }
            }
            Close();
        }
    }
}
