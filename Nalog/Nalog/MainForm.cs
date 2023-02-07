using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nalog
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            IstDohFizForm isfrm = new IstDohFizForm();
            isfrm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            VidFizForm vffrm = new VidFizForm();
            vffrm.Show();
        }

        private void CityButton_Click(object sender, EventArgs e)
        {
            CityForm cfrm = new CityForm();
            cfrm.Show();
        }

        private void FizButton_Click(object sender, EventArgs e)
        {
            FizForm frm = new FizForm();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NalogFizForm nfrm = new NalogFizForm();
            nfrm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DohodFizForm dfrm = new DohodFizForm();
            dfrm.Show();
        }

        private void UrButton_Click(object sender, EventArgs e)
        {
            URLForm ufrm = new URLForm();
            ufrm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DeyatForm defrm = new DeyatForm();
            defrm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            VidUrForm vufrm = new VidUrForm();
            vufrm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            NalogUrForm nufrm = new NalogUrForm();
            nufrm.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DohodUrForm dufrm = new DohodUrForm();
            dufrm.Show();
        }
    }
}
