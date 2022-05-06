using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImperialUnitConversion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!(textBox1.Text == ""))
            {
                try
                {
                    double value = Convert.ToDouble(textBox1.Text);
                    label9.Text = $"{value} m = {value / 0.0254:f4} in";
                    label10.Text = $"{value} m = {value / 0.3048:f4} ft";
                    label11.Text = $"{value} m = {value / 0.9144:f4} yd";
                    label12.Text = $"{value} m = {value / 1609.3:f4} mi";
                    label13.Text = $"{value} m = {Convert.ToDouble(value) / 5556:f4} lg";
                    textBox1.Text = "";
                }
                catch
                {
                    label9.Text = "";
                    label10.Text = $"";
                    label11.Text = $"";
                    label12.Text = $"";
                    label13.Text = $"";
                    textBox1.Text = "";
                    MessageBox.Show("Not a number.", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                label9.Text = "";
                label10.Text = $"";
                label11.Text = $"";
                label12.Text = $"";
                label13.Text = $"";
                textBox1.Text = "";
                MessageBox.Show("Not a number.", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
