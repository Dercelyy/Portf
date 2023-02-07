using CursovyaFront.Properties;
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

namespace CursovyaFront
{
    public partial class Login : Form
    {
        bool Clicked = false;
        string textProtocol;

        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = textBox1.TextLength;
            int j = textBox2.TextLength;
            if (i < 2 || j < 2)
            {
                MessageBox.Show("Введите данные корректно!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Clicked = true;
                Settings.Default["Date"] = DateTime.Now.ToString();
                Settings.Default["FIO"] = textBox1.Text;
                Settings.Default["Gruppa"] = textBox2.Text;

                Form fr1 = Application.OpenForms[0];
                this.Hide();
                fr1.Show();

                textProtocol += ("Дата и время: " + Settings.Default["Date"]);
                textProtocol += ("\nФИО: " + Settings.Default["FIO"]);
                textProtocol += ("\nГруппа: " + Settings.Default["Gruppa"]);
                textProtocol += ("\n");

                Data.text += textProtocol;
            }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Clicked)
            {

            }
            else
            {
                Application.Exit();
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && l != '\b' && (l != ' '))
            {
                e.Handled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Protocol pr = new Protocol();
            OpenFileDialog open = new OpenFileDialog();

            open.FileName = "*.prot";
            open.DefaultExt = "*.prot";
            open.Filter = "Prot Files|*.prot";

            if (open.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = open.FileName;
            // читаем файл в строку
            string fileText = File.ReadAllText(filename, System.Text.Encoding.Default);
            Data.text = fileText;
            pr.richTextBox1.Text = Data.text;

            pr.ShowDialog();
        }
    }
}
