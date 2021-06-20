using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calcul_Scientific
{
    public partial class Form1 : Form
    {
        double results = 0;
        string operation = "";
        bool enter_value = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
        
        }

        private void standardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 260;
           textBox1.Width = 240;
        }

        private void scientificToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 510;
            textBox1.Width = 485;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 260;
            textBox1.Width = 240;
        }

        private void tempuratureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 810;
            textBox1.Width = 485;
            textBox2.Focus();
        }

        private void convertiseurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 810;
            textBox1.Width = 485;
        }

        private void button_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0") || (enter_value))
                textBox1.Text = "";
            enter_value = false;
            Button num =(Button)sender;
            if (num.Text == ".")
            {
                if (!textBox1.Text.Contains("."))
                    textBox1.Text = textBox1.Text + num.Text;

            }
            else
                textBox1.Text = textBox1.Text + num.Text;


             
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            label2.Text = "";

        }

        private void btnC_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            label2.Text = "";
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Length>0)
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
            }
            if (textBox1.Text=="")
            {
                textBox1.Text = "0";
            }
        }

        private void Arithmitic_Operator(object sender, EventArgs e)
        {
            Button num = (Button)sender;
            operation = num.Text;
            results = double.Parse(textBox1.Text);
            textBox1.Text = "";
            label2.Text = System.Convert.ToString(results)+" " +operation;
        }

        private void btnEgal_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            switch(operation)
            {
                case "+":
                    textBox1.Text = (results + double.Parse(textBox1.Text)).ToString();
                    break;
                case "-":
                    textBox1.Text = (results - double.Parse(textBox1.Text)).ToString();
                    break;
                case "*":
                    textBox1.Text = (results * double.Parse(textBox1.Text)).ToString();
                    break;
                case "/":
                    textBox1.Text = (results / double.Parse(textBox1.Text)).ToString();
                    break;
                case "Exp":
                    double i = double.Parse(textBox1.Text);
                    double q;
                    q = (results);
                    textBox1.Text = Math.Exp(i * Math.Log(q * 4)).ToString();
                    break;
                case "Mod":
                    textBox1.Text = (results % double.Parse(textBox1.Text)).ToString();
                    break;

            }
        }

        private void btnP_Click(object sender, EventArgs e)
        {
            textBox1.Text = "3014592653589976323";
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            double ilog = double.Parse(textBox1.Text);
            label2.Text = System.Convert.ToString("Log" + "(" + (textBox1.Text) + ")");
            ilog = Math.Log10(ilog);
            textBox1.Text = System.Convert.ToString(ilog);
            
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            double sq = double.Parse(textBox1.Text);
            label2.Text = System.Convert.ToString("sqrt" + "(" + (textBox1.Text) + ")");
            sq = Math.Sqrt(sq);
            textBox1.Text = System.Convert.ToString(sq);

        }

        private void btnSinh_Click(object sender, EventArgs e)
        {
            double qSinh = double.Parse(textBox1.Text);
            label2.Text = System.Convert.ToString("sinh" + "(" + (textBox1.Text) + ")");
            qSinh = Math.Sinh(qSinh);
            textBox1.Text = System.Convert.ToString(qSinh);

        }

        private void btnSin_Click(object sender, EventArgs e)
        {
            double qSin = double.Parse(textBox1.Text);
            label2.Text = System.Convert.ToString("sin" + "(" + (textBox1.Text) + ")");
            qSin = Math.Sin(qSin);
            textBox1.Text = System.Convert.ToString(qSin);

        }

        private void btnCosh_Click(object sender, EventArgs e)
        {
            double qcosh = double.Parse(textBox1.Text);
            label2.Text = System.Convert.ToString("cosh" + "(" + (textBox1.Text) + ")");
            qcosh = Math.Cosh(qcosh);
            textBox1.Text = System.Convert.ToString(qcosh);

        }

        private void btnCos_Click(object sender, EventArgs e)
        {
            double qcos= double.Parse(textBox1.Text);
            label2.Text = System.Convert.ToString("cos" + "(" + (textBox1.Text) + ")");
            qcos = Math.Cos(qcos);
            textBox1.Text = System.Convert.ToString(qcos);
        }

        private void btnTanh_Click(object sender, EventArgs e)
        {
            double qtanh = double.Parse(textBox1.Text);
            label2.Text = System.Convert.ToString("tanh " + "(" + (textBox1.Text) + ")");
            qtanh = Math.Tanh(qtanh);
            textBox1.Text = System.Convert.ToString(qtanh);
        }

        private void btnTan_Click(object sender, EventArgs e)
        {
            double qtan = double.Parse(textBox1.Text);
            label2.Text = System.Convert.ToString("tan " + "(" + (textBox1.Text) + ")");
            qtan = Math.Tan(qtan);
            textBox1.Text = System.Convert.ToString(qtan);
        }

        private void btnBin_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            textBox1.Text = System.Convert.ToString(a, 2);
        }

        private void btnHex_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            textBox1.Text = System.Convert.ToString(a, 16);
        }

        private void btnOct_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            textBox1.Text = System.Convert.ToString(a, 8);
        }

        private void btnDec_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            textBox1.Text = System.Convert.ToString(a);
        }

        private void btnXfois2_Click(object sender, EventArgs e)
        {
            double a;
            a = Convert.ToDouble(textBox1.Text) *Convert.ToDouble(textBox1.Text);
            textBox1.Text = System.Convert.ToString(a);
        }

        private void btnXfois3_Click(object sender, EventArgs e)
        {
            double a;
            a = Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox1.Text);
            textBox1.Text = System.Convert.ToString(a);
        }

        private void btn1surX_Click(object sender, EventArgs e)
        {
            double a;
            a = Convert.ToDouble(1.0/ Convert.ToDouble(textBox1.Text));
            textBox1.Text = System.Convert.ToString(a);
        }

        private void btnLnX_Click(object sender, EventArgs e)
        {
            double ilog = double.Parse(textBox1.Text);
            label2.Text = System.Convert.ToString("Log" + "(" + (textBox1.Text) + ")");
            ilog = Math.Log(ilog);
            textBox1.Text = System.Convert.ToString(ilog);
        }

        private void btnPoursontage_Click(object sender, EventArgs e)
        {
            double a;
            a = Convert.ToDouble(textBox1.Text) / Convert.ToDouble(100);
            textBox1.Text = System.Convert.ToString(a);
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void multiplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 810;
            textBox1.Width = 485;
            txtMultip.Focus();
           

        }
    }

}
