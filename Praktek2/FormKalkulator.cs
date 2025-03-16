using System.Drawing.Design;

namespace Praktek2
{
    public partial class Kalkulator : Form
    {
        string strDisplay;
        string operasi;
        Double temp;
        bool isButtonDisable;
        public Kalkulator()
        {
            InitializeComponent();
            strDisplay = "";
            operasi = "";
            temp = 0.0;
            isButtonDisable = false;
        }

        private void Kalkulator_Load(object sender, EventArgs e)
        {

        }

        private void button0_Click(object sender, EventArgs e)
        {
            strDisplay += "0";
            textboxhasil.Text = strDisplay;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            strDisplay += "1";
            textboxhasil.Text = strDisplay;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            strDisplay += "2";
            textboxhasil.Text = strDisplay;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            strDisplay += "3";
            textboxhasil.Text = strDisplay;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            strDisplay += "4";
            textboxhasil.Text = strDisplay;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            strDisplay += "5";
            textboxhasil.Text = strDisplay;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            strDisplay += "6";
            textboxhasil.Text = strDisplay;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            strDisplay += "7";
            textboxhasil.Text = strDisplay;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            strDisplay += "8";
            textboxhasil.Text = strDisplay;
        }
        private void button9_Click(object sender, EventArgs e)
        {
            strDisplay += "9";
            textboxhasil.Text = strDisplay;
        }

        private void buttontitik_Click(object sender, EventArgs e)
        {
            if (strDisplay == null)
            {
                strDisplay = "";
            }
            if (strDisplay == "")
            {
                strDisplay = "0,";
            }
            else if (!strDisplay.Contains(","))
            {
                strDisplay += ",";
            }
            textboxhasil.Text = strDisplay;
        }

        private void buttonplus_Click(object sender, EventArgs e)
        {
            temp = Convert.ToDouble(textboxhasil.Text);
            operasi = "+";
            strDisplay = "";
        }

        private void buttonminus_Click(object sender, EventArgs e)
        {
            temp = Convert.ToDouble(textboxhasil.Text);
            operasi = "-";
            strDisplay = "";
        }

        private void buttonkali_Click(object sender, EventArgs e)
        {
            temp = Convert.ToDouble(textboxhasil.Text);
            operasi = "×";
            strDisplay = "";
        }

        private void buttonbagi_Click(object sender, EventArgs e)
        {
            temp = Convert.ToDouble(textboxhasil.Text);
            operasi = "÷";
            strDisplay = "";
        }

        private void buttonhasil_Click(object sender, EventArgs e)
        {
            double hasil = 0.0;
            if (operasi == "+")
            {
                hasil = temp + Convert.ToDouble(textboxhasil.Text);
                strDisplay = hasil.ToString();
                textboxhasil.Text = strDisplay;
            }
            else if (operasi == "-")
            {
                hasil = temp - Convert.ToDouble(textboxhasil.Text);
                strDisplay = hasil.ToString();
                textboxhasil.Text = strDisplay;
            }
            else if (operasi == "÷")
            {
                hasil = temp / Convert.ToDouble(textboxhasil.Text);
                strDisplay = hasil.ToString();
                textboxhasil.Text = strDisplay;
            }
            else if (operasi == "×")
            {
                hasil = temp * Convert.ToDouble(textboxhasil.Text);
                strDisplay = hasil.ToString();
                textboxhasil.Text = strDisplay;
            }
        }

        private void buttondelete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(strDisplay))
            {
                strDisplay = strDisplay.Remove(strDisplay.Length - 1);
                textboxhasil.Text = strDisplay;
            }

        }

        private void buttondeleteall_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(strDisplay))
            {
                strDisplay = "";
                textboxhasil.Text = strDisplay;
            }
        }

        private void buttononoff_Click(object sender, EventArgs e)
        {
            isButtonDisable = !isButtonDisable;

            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Button btn && btn != buttononoff)
                {
                    btn.Enabled = !isButtonDisable;
                }
            }
            textboxhasil.Text = "";
            strDisplay = "";
        }

        private void buttonplusminus_Click(object sender, EventArgs e)
        {
            double currentValue = Convert.ToDouble(strDisplay);
            currentValue = -currentValue;
            strDisplay = currentValue.ToString();
            textboxhasil.Text = strDisplay;
        }
    }
}
