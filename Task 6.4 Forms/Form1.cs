using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_6._4_Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int n = Convert.ToInt32(numericUpDown1.Value);
                int[][] mass = new int[n][];
                for (int i = 0; i < n; i++)
                {
                    mass[i] = new int[n];

                }
                Random r = new Random();

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        mass[i][j] = r.Next(1, 10);
                        textBox1.Text += mass[i][j] + "     " + "\n\r";
                    }
                    textBox1.Text += "\n\r";
                }

                int[] m = new int[n];
                for (int i = 0; i < n; i++)
                {
                    m[i] = -1;
                }

                for (int i = 0; i < n; i++)
                {
                    for (int k = 0; k < n - 1; k++)
                    {
                        for (int j = k + 1; j < n; j++)
                        {
                            if (mass[j][i] == mass[k][i])
                            {
                                m[i] = k;
                                k = n;
                                break;
                            }

                        }
                    }
                }
                for (int i = 0; i < n; i++)
                {
                    textBox2.Text += m[i] + "   ";
                }
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }
    }
}
