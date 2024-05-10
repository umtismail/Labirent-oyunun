using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sure = 0;
        Point p;
        DialogResult sonuc;
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            p = label19.Location;
            Cursor.Position = PointToScreen(p);
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sure++;
            label21.Text = sure.ToString();
            if (sure == 40)
            {
                timer1.Stop();
                sonuc = MessageBox.Show("Süre doldu. Tekrar oynamak ister misiniz?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (sonuc == DialogResult.Yes)
                {
                    Cursor.Position = PointToScreen(p);
                    sure = 0;
                    timer1.Start();
                }
                else
                {
                    this.Close();
                }
            }
        }

        private void label20_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            sonuc = MessageBox.Show("Tebrikler, oyunu tamamladınız. Tekrar oynamak ister misiniz?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sonuc == DialogResult.Yes)
            {
                Cursor.Position = PointToScreen(p);
                sure = 0;
                timer1.Start();
            }
            else
            {
                this.Close();
            }
        }

        private void Form1_MouseEnter(object sender, EventArgs e)
        {     
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {

        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {

        }

        private void label19_MouseEnter(object sender, EventArgs e)
        {
            Cursor.Position = PointToScreen(p);
        }
    }
}
