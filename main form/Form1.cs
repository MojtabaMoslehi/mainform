namespace main_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            var tarifMahsol = new Form5();
            tarifMahsol.Show();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            var listMahsol = new Form4();
            listMahsol.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var tarifMoshtari = new Form2();
            tarifMoshtari.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var listMoshtari = new Form3();
            listMoshtari.Show();
        }
    }
}