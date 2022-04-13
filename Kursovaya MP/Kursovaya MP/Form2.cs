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

    public partial class Form2 : Form
    {
        public static string book;
        public static string avtor;
        public static int magaz;
        public static double cost;
        public static int prodano;
        public static int ostatok;
        public Form2()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                book = textBox1.Text;
                avtor = textBox2.Text;
                magaz = Convert.ToInt32(textBox3.Text);
                cost = Convert.ToDouble(textBox4.Text);
                prodano = Convert.ToInt32(textBox5.Text);
                ostatok = Convert.ToInt32(textBox6.Text);
                ((Form1)this.Owner).dataGridView1.Rows.Add(book, avtor, magaz, cost, prodano, ostatok);
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
            }
            catch
            {
                MessageBox.Show("Некорректно введены данные");
            }
            
            
            



        }

        

    }
}
