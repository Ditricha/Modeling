using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Battlefield
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] firstPoints = MaskedDigits1.Text.Split(' ').Select(int.Parse).ToArray();
            int[] secondPoints = MaskedDigits2.Text.Split(' ').Select(int.Parse).ToArray();
            int[] thirdPoints = MaskedDigits3.Text.Split(' ').Select(int.Parse).ToArray();

            //if (firstPoints.Length == 10)
            //{
            //    result.Clear();
            //    for (int i = 0; i < firstPoints.Length; i++)
            //        result.Text += firstPoints[i].ToString() + "\r\n";
            //}
            //else MessageBox.Show("Возможно, не все поля правильно заполнены.\nДобавьте или удалите данные и повторите попыткую.");

            if (firstPoints.Length == 10)
            {
                //dataGridView1.Columns.Add("Index", "Index");
                //dataGridView1.Columns.Add("Value", "1 Value");
                dataGridView1.Rows.Clear();

                for (int i = 0; i < firstPoints.Length; i++)
                {
                    dataGridView1.Rows.Add(new object[] { i + 1, firstPoints[i] });
                }
                dataGridView1.ClearSelection();
            }
            else MessageBox.Show("Возможно, не все поля для 1-разрядных правильно заполнены.\nДобавьте или удалите данные и повторите попыткую.");

            textBox1.Text = thirdPoints.Length.ToString();


            if (secondPoints.Length == 10)
            {
                dataGridView2.Rows.Clear();
                for (int i = 0; i < secondPoints.Length; i++)
                {
                    dataGridView2.Rows.Add(new object[] { secondPoints[i] });
                }
                dataGridView2.ClearSelection();

            }
            else MessageBox.Show("Возможно, не все поля для 2-разрядных правильно заполнены.\nДобавьте или удалите данные и повторите попыткую.");

            if (thirdPoints.Length == 10)
            {
                dataGridView3.Rows.Clear();
                for (int i = 0; i < thirdPoints.Length; i++)
                {
                    dataGridView3.Rows.Add(new object[] { thirdPoints[i] });
                }
                dataGridView3.ClearSelection();

            }
            else MessageBox.Show("Возможно, не все поля для 3-разрядных правильно заполнены.\nДобавьте или удалите данные и повторите попыткую.");


            //try
            //{
            //    //if ((15 < firstPoints.Length || firstPoints.Length < 15) &&
            //    //   (30 < secondPoints.Length || secondPoints.Length < 30) &&
            //    //   (45 < thirdPoints.Length || thirdPoints.Length < 45));
            //    if (15 < firstPoints.Length || firstPoints.Length < 15)
            //    {
            //        for (int i = 0; i < firstPoints.Length; i++)
            //        {
            //            result.Text += firstPoints[i].ToString();
            //        }
            //    } 
            //}
            //catch (Exception ex)
            //{
            //    throw ;
            //}



        }

        private void clearSelectionButton_Click(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
            dataGridView2.ClearSelection();
            dataGridView3.ClearSelection();
            dataGridView4.ClearSelection();
            dataGridView5.ClearSelection();
            dataGridView6.ClearSelection();
            dataGridView7.ClearSelection();
            dataGridView8.ClearSelection();
            dataGridView9.ClearSelection();
            dataGridView10.ClearSelection();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        //private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        //{
        //    dataGridView1.ClearSelection();
        //}

        //private void Form1_Load(object sender, EventArgs e)
        //{
        //    // You will get selectedCells count 1 here
        //    DataGridViewSelectedCellCollection selectedCells = dataGridView1.SelectedCells;
        //    // Call clearSelection 
        //    dataGridView1.ClearSelection();
        //    // Now You will get selectedCells count 0 here
        //    selectedCells = dataGridViewSchedule.SelectedCells;
        //}
    }
}
