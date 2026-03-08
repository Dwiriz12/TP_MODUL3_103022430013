using System.Reflection.Emit;
//Menambahkan implementasi kalkulator

namespace TP_MODUL3_103022430013
{
    public partial class Form1 : Form
    {
        int angkaPertama = 0;
        bool tombolTambah = false;

        public Form1()
        {
            InitializeComponent();
            lblOutput.Text = "0";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (lblOutput.Text == "0")
                lblOutput.Text = "1";
            else
                lblOutput.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (lblOutput.Text == "0")
                lblOutput.Text = "2";
            else
                lblOutput.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (lblOutput.Text == "0")
                lblOutput.Text = "3";
            else
                lblOutput.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (lblOutput.Text == "0")
                lblOutput.Text = "4";
            else
                lblOutput.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (lblOutput.Text == "0")
                lblOutput.Text = "5";
            else
                lblOutput.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (lblOutput.Text == "0")
                lblOutput.Text = "6";
            else
                lblOutput.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (lblOutput.Text == "0")
                lblOutput.Text = "7";
            else
                lblOutput.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (lblOutput.Text == "0")
                lblOutput.Text = "8";
            else
                lblOutput.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (lblOutput.Text == "0")
                lblOutput.Text = "9";
            else
                lblOutput.Text += "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (lblOutput.Text == "0")
                lblOutput.Text = "0";
            else
                lblOutput.Text += "0";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (lblOutput.Text != "")
            {
                angkaPertama = int.Parse(lblOutput.Text);
                tombolTambah = true;
                lblOutput.Text = "0";
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (tombolTambah && lblOutput.Text != "")
            {
                int hasil = angkaPertama + int.Parse(lblOutput.Text);
                lblOutput.Text = hasil.ToString();
                tombolTambah = false;
            }
        }
    }
}