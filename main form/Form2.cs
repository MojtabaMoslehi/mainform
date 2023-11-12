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
using System.DirectoryServices.ActiveDirectory;

namespace main_form
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var name = textBox1.Text;
            var family = textBox2.Text;
            var tel = textBox3.Text;
            string filePath = "C:\\Users\\ASUS\\Desktop\\listMoshtari.csv";
            var csv = new StringBuilder();
            var newLine = string.Format("{0},{1},{2}", name, family, tel);
            csv.AppendLine(newLine);
            File.AppendAllText(filePath, csv.ToString());
            Console.WriteLine("Done!");
        }
    }
}
