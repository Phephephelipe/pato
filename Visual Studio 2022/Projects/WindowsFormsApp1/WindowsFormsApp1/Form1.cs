using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string i1 = inp_d1.Text;
            string i2 = inp_d2.Text;

            if (i1.Length != 0 && i2.Length != 0)
            {
                float i_1 = float.Parse(i1);
                float i_2 = float.Parse(i2);
                float result;
                result = i_1 + i_2;
                txt_data.Text = i1 + " + " + i2 + " = " + result;
            }
            else
            {
                MessageBox.Show("Por favor complete as caixas!");

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string i1 = inp_d1.Text;
            string i2 = inp_d2.Text;

            if (i1.Length != 0 && i2.Length != 0)
            {
                float i_1 = float.Parse(i1);
                float i_2 = float.Parse(i2);
                float result;
                result = i_1 - i_2;
                txt_data.Text = i1 + " - " + i2 + " = " + result;
            }
            else
            {
                MessageBox.Show("Por favor complete as caixas!");

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string i1 = inp_d1.Text;
            string i2 = inp_d2.Text;

            if (i1.Length != 0 && i2.Length != 0)
            {
                float i_1 = float.Parse(i1);
                float i_2 = float.Parse(i2);
                float result;
                result = i_1 / i_2;
                txt_data.Text = i1 + " / " + i2 + " = " + result;
            }
            else
            {
                MessageBox.Show("Por favor complete as caixas!");

            }
        }

        private void mult_btn_Click(object sender, EventArgs e)
        {
            string i1 = inp_d1.Text;
            string i2 = inp_d2.Text;

            if (i1.Length != 0 && i2.Length != 0)
            {
                float i_1 = float.Parse(i1);
                float i_2 = float.Parse(i2);
                float result;
                result = i_1 * i_2;
                txt_data.Text = i1 + " * " + i2 + " = " + result;
            }
            else
            {
                MessageBox.Show("Por favor complete as caixas!");

            }
        }

        private void inp_d1_TextChanged(object sender, EventArgs e)
        {

        }

        private void inp_d2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
