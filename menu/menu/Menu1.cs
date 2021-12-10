using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace menu
{
    public partial class Menu1 : Form
    {
        public Menu1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            zadanie1 z = new zadanie1();
            z.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Zadanie2 z = new Zadanie2();
            z.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Zadanie3 z = new Zadanie3();
            z.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Zadanie4 z = new Zadanie4();
            z.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Zadanie5 z = new Zadanie5();
            z.Show();
        }
    }
}
