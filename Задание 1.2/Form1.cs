using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Задание_1._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region First_list
        int a11, a12, a13, 
            b21, b22, b23, 
            c31, c32, c33;

        private void button3_Click(object sender, EventArgs e) //заполненить 3 на 3
        {
            Random rand = new Random();

            a11 = rand.Next(10);
            a12 = rand.Next(10);
            a13 = rand.Next(0);

            b21 = rand.Next(10);
            b22 = rand.Next(10);
            b23 = rand.Next(10);

            c31 = rand.Next(0);
            c32 = rand.Next(10);
            c33 = rand.Next(10);

            textBox1.Text = Convert.ToString(a11);
            textBox2.Text = Convert.ToString(a12);
            textBox3.Text = Convert.ToString(a13);

            textBox4.Text = Convert.ToString(b21);
            textBox5.Text = Convert.ToString(b22);
            textBox6.Text = Convert.ToString(b23);

            textBox7.Text = Convert.ToString(c31);
            textBox8.Text = Convert.ToString(c32);
            textBox9.Text = Convert.ToString(c33);
        }

        private void button1_Click(object sender, EventArgs e) //вычислить матрицу 3 на 3
        {
            int result = (a11 * b22 * c33) + (a12 * c31 * b23) + (b21 * a13 * c32) - (a13 * b22 * c31) -
                (a12 * b23 * c31) - (b21 * a12 * c32);
            textBox10.Text = "Результат: " + result;
        }

        private void button2_Click(object sender, EventArgs e) //очистить 3 на 3
        {
            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text =
                textBox6.Text = textBox7.Text = textBox8.Text = textBox9.Text = textBox10.Text = "";
        }

        #endregion


        #region Second_list

        int a1, a2, a3, a4,
            a5, a6, a7, a8,
            a9, a10, a_11, a_12,
            a_13, a_14, a_15, a_16,
            result2, matr1, matr2, matr3, matr4;

        private void Button8_Click(object sender, EventArgs e) //2х
        {
            Random rand1 = new Random();
            a1 = rand1.Next(10);
            a2 = rand1.Next(10);
            a3 = rand1.Next(0);

            a5 = rand1.Next(10);
            a6 = rand1.Next(10);
            a7 = rand1.Next(10);
            a8 = rand1.Next(0);

            a9 = rand1.Next(0);
            a10 = rand1.Next(10);
            a_11 = rand1.Next(10);
            a_12 = rand1.Next(10);

            a_14 = rand1.Next(0);
            a_15 = rand1.Next(10);
            a_16 = rand1.Next(10);

            textBox12.Text = Convert.ToString(a1);
            textBox13.Text = Convert.ToString(a2);
            textBox14.Text = Convert.ToString(a3);

            textBox17.Text = Convert.ToString(a5);
            textBox19.Text = Convert.ToString(a6);
            textBox20.Text = Convert.ToString(a7);
            textBox18.Text = Convert.ToString(a8);

            textBox16.Text = Convert.ToString(a9);
            textBox21.Text = Convert.ToString(a10);
            textBox22.Text = Convert.ToString(a_11);
            textBox23.Text = Convert.ToString(a_12);

            textBox26.Text = Convert.ToString(a_14);
            textBox25.Text = Convert.ToString(a_15);
            textBox24.Text = Convert.ToString(a_16);
        }

        private void Button7_Click(object sender, EventArgs e) //3х
        {
            Random rand1 = new Random();
            a1 = rand1.Next(10);
            a2 = rand1.Next(10);
            a3 = rand1.Next(10);

            a5 = rand1.Next(10);
            a6 = rand1.Next(10);
            a7 = rand1.Next(10);
            a8 = rand1.Next(10);

            a9 = rand1.Next(10);
            a10 = rand1.Next(10);
            a_11 = rand1.Next(10);
            a_12 = rand1.Next(10);

            a_14 = rand1.Next(10);
            a_15 = rand1.Next(10);
            a_16 = rand1.Next(10);

            textBox12.Text = Convert.ToString(a1);
            textBox13.Text = Convert.ToString(a2);
            textBox14.Text = Convert.ToString(a3);

            textBox17.Text = Convert.ToString(a5);
            textBox19.Text = Convert.ToString(a6);
            textBox20.Text = Convert.ToString(a7);
            textBox18.Text = Convert.ToString(a8);

            textBox16.Text = Convert.ToString(a9);
            textBox21.Text = Convert.ToString(a10);
            textBox22.Text = Convert.ToString(a_11);
            textBox23.Text = Convert.ToString(a_12);

            textBox26.Text = Convert.ToString(a_14);
            textBox25.Text = Convert.ToString(a_15);
            textBox24.Text = Convert.ToString(a_16);
        }

        private void Button6_Click(object sender, EventArgs e) // Вычислить матрицу 4 на 4
        {
            a1 = Convert.ToInt32(textBox12.Text);
            a2 = Convert.ToInt32(textBox13.Text);
            a3 = Convert.ToInt32(textBox14.Text);
            a4 = Convert.ToInt32(textBox15.Text);

            a5 = Convert.ToInt32(textBox17.Text);
            a6 = Convert.ToInt32(textBox19.Text);
            a7 = Convert.ToInt32(textBox20.Text);
            a8 = Convert.ToInt32(textBox18.Text);

            a9 = Convert.ToInt32(textBox16.Text);
            a10 = Convert.ToInt32(textBox21.Text);
            a_11 = Convert.ToInt32(textBox22.Text);
            a_12 = Convert.ToInt32(textBox23.Text);

            a_13 = Convert.ToInt32(textBox27.Text);
            a_14 = Convert.ToInt32(textBox26.Text);
            a_15 = Convert.ToInt32(textBox25.Text);
            a_16 = Convert.ToInt32(textBox24.Text);

            matr1 = (a6 * a_11 * a_16) + (a7 * a_12 * a_14) + (a10 * a_15 * a8) - (a8 * a_11 * a_14) - (a10 * a7 * a_16) - (a6 * a_15 * a_12);
            matr2 = (a5 * a_11 * a_16) + (a7 * a_12 * a_13) + (a9 * a_15 * a8) - (a8 * a_11 * a_13) - (a7 * a9 * a_16) - (a_15 * a_12 * a5);
            matr3 = (a5 * a10 * a_13) + (a6 * a_12 * a_13) + (a9 * a_14 * a8) - (a8 * a10 * a_13) - (a9 * a6 * a_13) - (a5 * a_14 * a_12);
            matr4 = (a5 * a10 * a_15) + (a9 * a_14 * a7) + (a6 * a_11 * a_13) - (a7 * a10 * a_13) - (a9 * a6 * a_15) - (a5 * a_11 * a_14);

            result2 = (a1 * (matr1)) - (a2 * (matr2)) + (a3 * (matr3)) - (a4 * (matr4));
            textBox11.Text = "Результат: " + result2;
        }

        private void Button5_Click(object sender, EventArgs e) //очистить матрицу 4 на 4
        {
            textBox12.Text = textBox13.Text = textBox17.Text =
            textBox19.Text = textBox20.Text = textBox21.Text =
            textBox22.Text = textBox23.Text = textBox25.Text =
            textBox24.Text = "";
        }

        private void button4_Click(object sender, EventArgs e) // заполнить 4 на 4
        {
            Random rand1 = new Random();
            a1 = rand1.Next(10);
            a2 = rand1.Next(10);

            a5 = rand1.Next(10);
            a6 = rand1.Next(10);
            a7 = rand1.Next(10);

            a10 = rand1.Next(10);
            a_11 = rand1.Next(10);
            a_12 = rand1.Next(10);

            a_15 = rand1.Next(10);
            a_16 = rand1.Next(10);

            textBox12.Text = Convert.ToString(a1);
            textBox13.Text = Convert.ToString(a2);

            textBox17.Text = Convert.ToString(a5);
            textBox19.Text = Convert.ToString(a6);
            textBox20.Text = Convert.ToString(a7);

            textBox21.Text = Convert.ToString(a10);
            textBox22.Text = Convert.ToString(a_11);
            textBox23.Text = Convert.ToString(a_12);

            textBox25.Text = Convert.ToString(a_15);
            textBox24.Text = Convert.ToString(a_16);
        }

        #endregion


        #region Third_list

        int e1, e2, e3,
           e4, e5, e6,
           e7, e8, e9;

        int r1, r2, r3,
            r4, r5, r6,
            r7, r8, r9;

        int t1, t2, t3,
            t4, t5, t6,
            t7, t8, t9;

        private void Button9_Click(object sender, EventArgs e)//перемножение матриц
        {
            try
            {
                e1 = Convert.ToInt32(textBox28.Text);
                e2 = Convert.ToInt32(textBox29.Text);
                e3 = Convert.ToInt32(textBox30.Text);

                e4 = Convert.ToInt32(textBox31.Text);
                e5 = Convert.ToInt32(textBox32.Text);
                e6 = Convert.ToInt32(textBox33.Text);

                e7 = Convert.ToInt32(textBox34.Text);
                e8 = Convert.ToInt32(textBox35.Text);
                e9 = Convert.ToInt32(textBox36.Text);

                r1 = Convert.ToInt32(textBox37.Text);
                r2 = Convert.ToInt32(textBox38.Text);
                r3 = Convert.ToInt32(textBox39.Text);

                r4 = Convert.ToInt32(textBox40.Text);
                r5 = Convert.ToInt32(textBox41.Text);
                r6 = Convert.ToInt32(textBox42.Text);

                r7 = Convert.ToInt32(textBox43.Text);
                r8 = Convert.ToInt32(textBox44.Text);
                r9 = Convert.ToInt32(textBox45.Text);

                t1 = (e1 * r1) + (e2 * r4) + (e3 * r7);
                t2 = (e1 * r2) + (e2 * r5) + (e3 * r8);
                t3 = (e1 * r3) + (e2 * r6) + (e3 * r9);

                t4 = (e4 * r1) + (e5 * r2) + (e6 * r7);
                t5 = (e4 * r2) + (e5 * r5) + (e6 * r8);
                t6 = (e4 * r3) + (e5 * r6) + (e6 * r9);

                t7 = (e7 * r1) + (e8 * r2) + (e9 * r7);
                t8 = (e7 * r2) + (e8 * r5) + (e9 * r8);
                t9 = (e7 * r3) + (e8 * r6) + (e9 * r9);

                textBox46.Text = t1.ToString();
                textBox47.Text = t2.ToString();
                textBox48.Text = t3.ToString();

                textBox49.Text = t4.ToString();
                textBox50.Text = t5.ToString();
                textBox51.Text = t6.ToString();

                textBox52.Text = t7.ToString();
                textBox53.Text = t8.ToString();
                textBox54.Text = t9.ToString();
            }
            catch
            {
                MessageBox.Show("Error", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Button11_Click(object sender, EventArgs e) //очистить умножение
        {
            textBox28.Text = "";
        }

        private void Button10_Click(object sender, EventArgs e) // Заполнить умножение
        {
            textBox55.Text = "";
            int[] mas = new int[10];
            Random rand1 = new Random();
            for (int i = 1; i < 10; i++)
            {
                mas[i] = rand1.Next(10);
                textBox55.Text += mas[i] + " - ";
            }
                        //E блок
            e1 = mas[1]; e2 = mas[2]; e3 = mas[3];
            e4 = mas[4]; e5 = mas[5]; e6 = mas[6];
            e7 = mas[7]; e8 = mas[8]; e9 = mas[9];

            textBox28.Text = Convert.ToString(e1);
            textBox29.Text = Convert.ToString(e2);
            textBox30.Text = Convert.ToString(e3);

            textBox31.Text = Convert.ToString(e4);
            textBox32.Text = Convert.ToString(e5);
            textBox33.Text = Convert.ToString(e6);

            textBox34.Text = Convert.ToString(e7);
            textBox35.Text = Convert.ToString(e8);
            textBox36.Text = Convert.ToString(e9);

                        //R блок
            int[] masR = new int[10];
            for (int i = 1; i < 10; i++)
            {
                masR[i] = rand1.Next(10);
                textBox55.Text += mas[i] + " - ";
            }
            
            r1 = masR[1]; r2 = masR[2]; r3 = masR[3];
            r4 = masR[4]; r5 = masR[5]; r6 = masR[6];
            r7 = masR[7]; r8 = masR[8]; r9 = masR[9];

            textBox37.Text = Convert.ToString(r1);
            textBox38.Text = Convert.ToString(r2);
            textBox39.Text = Convert.ToString(r3);

            textBox40.Text = Convert.ToString(r4);
            textBox41.Text = Convert.ToString(r5);
            textBox42.Text = Convert.ToString(r6);

            textBox43.Text = Convert.ToString(r7);
            textBox44.Text = Convert.ToString(r8);
            textBox45.Text = Convert.ToString(r9);
        }


        #endregion
    }
}
