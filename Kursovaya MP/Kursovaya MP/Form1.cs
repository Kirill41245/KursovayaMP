using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;




namespace Kursovaya_MP
{
    public partial class Form1 : Form
    {
        public static int res = 0;
        public Form1()
        {
            InitializeComponent();
            dataGridView1.ReadOnly = true;
            

            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                int a = Convert.ToInt32(dataGridView1[2, i].Value);
                if(Form4.nomer==a)
                {
                    res += Form2.prodano;
                }
            }

        }

        private void отчет1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 F4 = new Form4();

            F4.Show(this);
        }

        private void суммарнуюСтоимостьКнигПроданныхКаждымМагазиномToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 F3 = new Form3();

            F3.Show(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 AddNewData = new Form2();
            AddNewData.Show(this);
         


        }

        private void button2_Click(object sender, EventArgs e)
        {
            int ind = dataGridView1.SelectedCells[0].RowIndex;
            dataGridView1.Rows.RemoveAt(ind);
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream mystr = null;
            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                if((mystr = openFileDialog1.OpenFile()) != null)
                {
                    StreamReader myread = new StreamReader(mystr);
                    string[] str;
                    int num = 0;
                    try
                    {
                        string[] str1 = myread.ReadToEnd().Split('\n');
                        num = str1.Count();
                        dataGridView1.RowCount = num-1;
                        for (int i = 0; i < num; i++)
                        {
                            str = str1[i].Split('ᅠ');
                            for (int j = 0; j < dataGridView1.ColumnCount; j++)
                            {
                                try
                                {
                                    dataGridView1.Rows[i].Cells[j].Value = str[j];
                                }
                                catch { }
                            }
                        }
                    } catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        myread.Close();
                    }
                }
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream myStream;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog1.OpenFile()) != null)
                {
                    StreamWriter myWritet = new StreamWriter(myStream);
                    try
                    {
                        for (int i = 0; i < dataGridView1.RowCount; i++)
                        {
                            
                            for (int j = 0; j < dataGridView1.ColumnCount; j++)
                            {
                                myWritet.Write(dataGridView1.Rows[i].Cells[j].Value.ToString() + "ᅠ");
                            }
                            myWritet.WriteLine();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        myWritet.Close();
                    }
                    myStream.Close();
                }
            }
        }

        private void включитьРедактированиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            dataGridView1.ReadOnly = false;
        }

        private void выключитьРедактированиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            dataGridView1.ReadOnly = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void отчет2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double a = 0;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                int ostat = Convert.ToInt32(dataGridView1[5, i].Value);
                double cost = Convert.ToInt32(dataGridView1[3, i].Value);
                a += ostat * cost;
            }
            
            MessageBox.Show("Суммарная стоимость всех непроданных книг равна "+ a +"p.");
        }

        private void средняяЦенаОднойКнигиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double sum=0;
            double srCost = 0;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                double cost = Convert.ToInt32(dataGridView1[3, i].Value);
                sum += cost;
                

            }
            int row = Convert.ToInt32(dataGridView1.RowCount);
            srCost = sum / row;
            MessageBox.Show("Средняя цена одной книги равна " + Math.Round(srCost,2) + "р.");
        }

        
        private void dataGridView1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                var paths = (string[])e.Data.GetData(DataFormats.FileDrop);
                if (paths.Length == 1 && paths[0].EndsWith(".txt"))
                {
                    e.Effect = DragDropEffects.Copy;
                }
                else e.Effect = DragDropEffects.None;
            }
            else e.Effect = DragDropEffects.None;
        }

        private void dataGridView1_DragDrop(object sender, DragEventArgs e)
        {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop , false);
                List<string> textLines = File.ReadAllLines(files[0]).ToList();

                string[] str;
                int num = 0;

                num = textLines.Count();
                dataGridView1.RowCount = num;
                for (int i = 0; i < textLines.Count; i++)
                {
                    str = textLines[i].Split('ᅠ');
                    for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    {
                            dataGridView1.Rows[i].Cells[j].Value = str[j];
                    }
                }
            
        }

        private void уменьшитьЦенуНаКнигиУКоторыхОстатокПревышаетКоличествоПроданныхБолееЧемВ2РазаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 F5 = new Form5();

            F5.Show(this);
            
        }

        private void удалитьСведенияОКнигахСЦенойНижеЗаданнойToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 F6 = new Form6();

            F6.Show(this);
        }
    }
}
