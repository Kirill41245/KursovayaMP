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
    public partial class Form3 : Form
    {
        
        public Form3()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int nomer = 0;
            double sum = 0;
            for (int i = 0; i < ((Form1)this.Owner).dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < ((Form1)this.Owner).dataGridView1.RowCount; j++)
                {
                    
                    nomer = Convert.ToInt32(((Form1)this.Owner).dataGridView1[2, i].Value);
                    int nomer2 = Convert.ToInt32(((Form1)this.Owner).dataGridView1[2, j].Value);
                    double cost = Convert.ToInt32(((Form1)this.Owner).dataGridView1[3, i].Value);
                    double cost2 = Convert.ToInt32(((Form1)this.Owner).dataGridView1[3, j].Value);
                    int prodano = Convert.ToInt32(((Form1)this.Owner).dataGridView1[4, i].Value);
                    int prodano2 = Convert.ToInt32(((Form1)this.Owner).dataGridView1[4, j].Value);
                    if (j == 0)
                    {
                        sum = cost * prodano;
                    }
                    if (nomer == nomer2 && i!=j)
                    {
                        sum += cost2 * prodano2;
                    }
                   
                }
                dataGridView2.Rows.Add(nomer, sum);
            }

            int s = Convert.ToInt32(dataGridView2.RowCount);
            for (int i = 0; i < dataGridView2.RowCount; i++)
            {
                for (int j = 0; j < dataGridView2.RowCount; j++)
                {

                    int nom = Convert.ToInt32(dataGridView2[0, i].Value);
                    int nom2 = Convert.ToInt32(dataGridView2[0, j].Value);

                    if (nom == nom2 && i != j)
                    {
                        dataGridView2.Rows.RemoveAt(j);
                    }
                        
                }
            }
        }
    }
}
