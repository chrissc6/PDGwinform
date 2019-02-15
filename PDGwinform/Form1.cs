using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDGwinform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rng = new Random();
        int NbGm = 0;
        int HiSr = 0;
        int total = 0;
        int CuSc = 0;
        int rolls = 0;
        int lasts = 0;

        private void button1_Click(object sender, EventArgs e)
        {

            Roll();
        }

        private void Roll()
        {
            total = rng.Next(1, 7);
            if (total != 1)
            {
                CuSc += total;
                label5Croll.Text = total.ToString();
                label6CrSr.Text = CuSc.ToString();
                rolls++;
                label7Rolls.Text = rolls.ToString();
                return;
            }
            else
            {
                label5Croll.Text = total.ToString();
                WinCheck();
                return;
            }
        }

        private void WinCheck()
        {
            total = 0;
            rolls = 0;
            lasts = CuSc;
            label8LastS.Text = lasts.ToString();

            if (CuSc > HiSr)
            {
                HiSr = CuSc;
                NbGm++;
                CuSc = 0;
                label3HS.Text = HiSr.ToString();
                label4NbrGa.Text = NbGm.ToString();
                label6CrSr.Text = "";
                //label5Croll.Text = "";
                return;
            }
            else
            {
                NbGm++;
                CuSc = 0;
                label4NbrGa.Text = NbGm.ToString();
                label6CrSr.Text = "";
                //label5Croll.Text = "";
                return;
            }
        }
    }
}
