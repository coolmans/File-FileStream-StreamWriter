using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace File__FileStream__StreamWriter
{
    public partial class Form1 : Form
    {
        private static string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        private string patch = desktopPath + (@"\1.txt");

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter(patch, true, Encoding.Default))
            {
                sw.WriteLine(textBox1.Text);
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            using (StreamReader sr = new StreamReader(patch, Encoding.Default))
            {
                //textBox1.Text = sr.CurrentEncoding.ToString();

                while (!sr.EndOfStream)
                {
                    textBox1.Text += (sr.ReadToEnd());
                }
            }
        }
    }
}