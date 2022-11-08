namespace curs
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Encryption frm2 = new Encryption();
            frm2.Show();

            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Decoding frm3 = new Decoding();
            frm3.Show();

            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}