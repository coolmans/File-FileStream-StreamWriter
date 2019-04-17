using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace File__FileStream__StreamWriter
{
    public partial class Form1 : Form
    {
        static string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        string patch = desktopPath + (@"\2.txt");

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
                //sw.WriteLine("Хрень какая");
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
                    textBox1.Text += ( sr.ReadLine()+"\r\n");

                }


            }


        }
    }
}
