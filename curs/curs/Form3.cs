using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace curs
{
    public partial class Decoding : Form
    {
        public Decoding()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            int x = Convert.ToInt32(textBox2.Text);
            int y = Convert.ToInt32(textBox3.Text);

            int z = x * y;
            int text_length = text.Length;

            if (z == text_length)
            {
                int counter = 0;
                char[,] array = new char[x, y];
                for (int i = 0; i < x; i++)
                {
                    for (int j = 0; j < y; j++)
                    {
                        array[i, j] = text[counter];
                        counter++;
                    }
                }
                String rresult = "";
                for (int i = 0; i < y; i++)
                {
                    for (int j = 0; j < x; j++)
                    {
                        rresult += array[j, i];
                    }
                }

                Encryptionresult frm4 = new Encryptionresult();
                Encryptionresult.result = rresult;
                frm4.Show();

                this.Hide();
            }
            else
            {
                Error frm5 = new Error();
                frm5.Show();

                this.Hide();
            }
        }
    }
}
