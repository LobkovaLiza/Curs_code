using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace curs
{
    public partial class Decodingresult : Form
    {
        public static String rresult = "";
        public Decodingresult()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = rresult;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainMenu frm1 = new MainMenu();
            frm1.Show();

            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
