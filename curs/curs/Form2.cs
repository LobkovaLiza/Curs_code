using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace curs
{
    public partial class Encryption : Form
    {
        public Encryption()
        {
            InitializeComponent();
        }
        //вводимый текст зашифровки
        public void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
        //размерность по оси X массива
        public void textBox2_TextChanged(object sender, EventArgs e)
        {
        }
        //размерность по оси Y массива
        public void textBox3_TextChanged(object sender, EventArgs e)
        {
        }
        //если размерность массива соответствует слову, то переходит в Form 4, если нет, то переходит в Form 5
        public void button1_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            int x = Convert.ToInt32(textBox2.Text);
            int y = Convert.ToInt32(textBox3.Text);

            int z = x * y;
            int text_length = text.Length;
            if(z == text_length)
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
                String result = "";
                for (int i = 0; i < y; i++)
                {
                    for (int j = 0; j < x; j++)
                    {
                        result += array[j, i];
                    }
                }

                Encryptionresult frm4 = new Encryptionresult();
                Encryptionresult.result = result;
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
