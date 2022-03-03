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
using System.Collections;

namespace Battlefield
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            int[] firstPointsUser = MaskedDigits1.Text.Split(' ').Select(int.Parse).ToArray();
            int[] secondPointsUser = MaskedDigits2.Text.Split(' ').Select(int.Parse).ToArray();
            int[] thirdPointsUser = MaskedDigits3.Text.Split(' ').Select(int.Parse).ToArray();

            if (firstPointsUser.Length == 10)
            {
                dataGridView1.Rows.Clear();

                for (int i = 0; i < 10; i++)
                {
                    dataGridView1.Rows.Add(new object[] { i + 1, firstPointsUser[i] });
                }
                dataGridView1.ClearSelection();
            }
            else MessageBox.Show("Возможно, не все поля для 1-разрядных правильно заполнены.\nДобавьте или удалите данные и повторите попыткую.");
            
            if (secondPointsUser.Length == 10)
            {
                dataGridView2.Rows.Clear();
                for (int i = 0; i < 10; i++)
                {
                    dataGridView2.Rows.Add(new object[] { secondPointsUser[i] });
                }
                dataGridView2.ClearSelection();

            }
            else MessageBox.Show("Возможно, не все поля для 2-разрядных правильно заполнены.\nДобавьте или удалите данные и повторите попыткую.");

            if (thirdPointsUser.Length == 10)
            {
                dataGridView3.Rows.Clear();
                for (int i = 0; i < 10; i++)
                {
                    dataGridView3.Rows.Add(new object[] { thirdPointsUser[i] });
                }
                dataGridView3.ClearSelection();

            }
            else MessageBox.Show("Возможно, не все поля для 3-разрядных правильно заполнены.\nДобавьте или удалите данные и повторите попыткую.");


            dataGridView11.Rows.Clear();
            for (int i = 0; i < 1; i++)
            {
                dataGridView11.Rows.Add(new object[] { " ", Criterium(firstPointsUser, 0, 10), Criterium(secondPointsUser, 10, 100), Criterium(thirdPointsUser, 100, 1000) });
            }
            dataGridView11.ClearSelection();
        }

        public void button2_Click(object sender, EventArgs e)
        {
            int[] firstPointsAlgorithm = new int[100];
            Random rand1 = new Random();
            for (int i = 0; i < 100; i++)
                firstPointsAlgorithm[i] = rand1.Next(0, 9);

            int[] secondPointsAlgorithm = new int[100];
            Random rand2 = new Random();
            for (int i = 0; i < 100; i++)
                secondPointsAlgorithm[i] = rand2.Next(10, 99);

            int[] thirdPointsAlgorithm = new int[100];
            Random rand3 = new Random();
            for (int i = 0; i < 100; i++)
                thirdPointsAlgorithm[i] = rand3.Next(100, 999);

            dataGridView4.Rows.Clear();
            for (int i = 0; i < 10; i++)
            {
                dataGridView4.Rows.Add(new object[] { firstPointsAlgorithm[i] });
            }
            dataGridView4.ClearSelection();

            dataGridView5.Rows.Clear();
            for (int i = 0; i < 10; i++)
            {
                dataGridView5.Rows.Add(new object[] { secondPointsAlgorithm[i] });
            }
            dataGridView5.ClearSelection();

            dataGridView6.Rows.Clear();
            for (int i = 0; i < 10; i++)
            {
                dataGridView6.Rows.Add(new object[] { thirdPointsAlgorithm[i] });
            }
            dataGridView6.ClearSelection();


            dataGridView12.Rows.Clear();
            for (int i = 0; i < 1; i++)
            {
                dataGridView12.Rows.Add(new object[] { Criterium(firstPointsAlgorithm, 0, 10), Criterium(secondPointsAlgorithm, 10, 100), Criterium(thirdPointsAlgorithm, 100, 1000) });
            }
            dataGridView12.ClearSelection();
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
                dataGridView11.ClearSelection();
                dataGridView12.ClearSelection();
                dataGridView13.ClearSelection();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            int[] firstPointsTable = System.IO.File.ReadAllText("C://Users//Admin//BMSTU//Modelling//modelling-1.1//TableValue1.txt").Split(' ').Select(n => int.Parse(n)).ToArray();
            int[] secondPointsTable = System.IO.File.ReadAllText("C://Users//Admin//BMSTU//Modelling//modelling-1.1//TableValue2.txt").Split(' ').Select(n => int.Parse(n)).ToArray();
            int[] thirdPointsTable = System.IO.File.ReadAllText("C://Users//Admin//BMSTU//Modelling//modelling-1.1//TableValue3.txt").Split(' ').Select(n => int.Parse(n)).ToArray();

            dataGridView7.Rows.Clear();
            for (int i = 0; i < 10; i++)
            {
                dataGridView7.Rows.Add(new object[] { firstPointsTable[i] });
            }
            dataGridView7.ClearSelection();

            dataGridView8.Rows.Clear();
            for (int i = 0; i < 10; i++)
            {
                dataGridView8.Rows.Add(new object[] { secondPointsTable[i] });
            }
            dataGridView8.ClearSelection();

            dataGridView9.Rows.Clear();
            for (int i = 0; i < 10; i++)
            {
                dataGridView9.Rows.Add(new object[] { thirdPointsTable[i] });
            }
            dataGridView9.ClearSelection();

            dataGridView13.Rows.Clear();
            for (int i = 0; i < 1; i++)
            {
                dataGridView13.Rows.Add(new object[] { "0", "0", "0" });
            }
            dataGridView13.ClearSelection();

        }

        private float Criterium(int[] InpArray,
            int EntrancePoint,
            int LastPoint)
        {
            float sump = 0;
            float count = 0;
            int temp = EntrancePoint;
            int size = InpArray.Length;
            float[] proc = new float[1000];
            while (temp < LastPoint)
            {
                for (int i = 0; i < InpArray.Length; i++)
                {
                    if (InpArray[i].Equals(temp))
                    {
                        count++;
                    }
                }
                proc[temp] = count * count / 1000;
                temp++;
                count = 0;
            }
            for (int i = 0; i < InpArray.Length; i++)
            {
                sump += proc[i];
            }
            sump = (float)sump / size;
            return sump;
        }

    }
    }
