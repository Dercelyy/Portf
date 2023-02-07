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
using System.Drawing.Printing;

namespace CursovyaFront
{
    public partial class Protocol : Form
    {
        public Protocol()
        {
            InitializeComponent();
            richTextBox1.Text = Data.text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form fr1 = Application.OpenForms[0];
            this.Hide();
            fr1.Show();
        }

        private void Protocol_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form fr1 = Application.OpenForms[0];
            this.Hide();
            fr1.Show();
        }

        private void Protocol_Load(object sender, EventArgs e)
        {
            richTextBox1.Text= Data.text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            PrintDocument documentToPrint = new PrintDocument();
            printDialog.Document = documentToPrint;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                StringReader reader = new StringReader(richTextBox1.Text);
                documentToPrint.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
                documentToPrint.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            StringReader reader = new StringReader(richTextBox1.Text);
            float LinesPerPage = 0;
            float YPosition = 0;
            int Count = 0;
            float LeftMargin = e.MarginBounds.Left;
            float TopMargin = e.MarginBounds.Top;
            string Line = null;
            Font PrintFont = this.richTextBox1.Font;
            SolidBrush PrintBrush = new SolidBrush(Color.Black);

            LinesPerPage = e.MarginBounds.Height / PrintFont.GetHeight(e.Graphics);

            while (Count < LinesPerPage && ((Line = reader.ReadLine()) != null))
            {
                YPosition = TopMargin + (Count * PrintFont.GetHeight(e.Graphics));
                e.Graphics.DrawString(Line, PrintFont, PrintBrush, LeftMargin, YPosition, new StringFormat());
                Count++;
            }

            if (Line != null)
            {
                e.HasMorePages = true;
            }
            else
            {
                e.HasMorePages = false;
            }
            PrintBrush.Dispose();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text != "")
                if (MessageBox.Show("Сохранить изменения?", "Сохранить?", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    button2_Click(sender, e);
                    richTextBox1.Text = "";
                }
            OpenFileDialog open = new OpenFileDialog();
            open.Title = ("Открыть");
            open.Filter = "Text Document (*.prot) | *.prot| All Files (*.*)|*.*";
            if (open.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                richTextBox1.LoadFile(open.FileName, RichTextBoxStreamType.PlainText);
                this.Text = open.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Title = ("Сохранить как...");
            save.Filter = "Text Document (*.prot) | *.prot| All Files (*.*)|*.*";
            save.OverwritePrompt = true;
            if (save.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                richTextBox1.SaveFile(save.FileName, RichTextBoxStreamType.PlainText);
                this.Text = save.FileName;
            }
        }
    }
}
