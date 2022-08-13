using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RaceTrackSimulator
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            fr.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "Oyun köpeklerimizin hangisinin yarışı kazanacağını tahminlerimiz ile bulmaya çalıştığımız bir oyundur." +
                "Bahis oynatabileceğimiz üç insanımız vardır.Herhangi birinin parası 0 olana kadar oyunumuz devam eder.İyi Oyunlar...";
        }
    }
}
