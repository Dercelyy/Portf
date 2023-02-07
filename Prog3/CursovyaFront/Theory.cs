using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursovyaFront
{
    public partial class Theory : Form
    {
        public Theory()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form fr1 = Application.OpenForms[0];
            this.Hide();
            fr1.Show();
        }

        private void Theory_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
        }
    }
}
