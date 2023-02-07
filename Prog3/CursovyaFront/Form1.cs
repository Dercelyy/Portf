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

namespace CursovyaFront
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Theory tr = new Theory();

            string curDir = Directory.GetCurrentDirectory();
            tr.webBrowser1.Url = new Uri(String.Format("file:///{0}/orgraf.html", curDir));
            tr.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Practice pacticeForm = new Practice();
            pacticeForm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Protocol protocolForm = new Protocol();
            protocolForm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
