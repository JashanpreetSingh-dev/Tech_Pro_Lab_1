using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tech_Pro_Lab_1
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void resetRadioButtons()
        {
            fromCelsius.Checked = false;
            fromFahrenheit.Checked = false;
            fromKalvin.Checked = false;
            toCelsius.Checked=false;
            toFahrenheit.Checked = false;
            toKalvin.Checked = false;
        }

        public float FromFtoC(float fahrenheit)
        {
            return (fahrenheit - 32) * 5/9;
        }
        public float FromKtoC(float kalvin)
        {
            return (float)(kalvin - 273.15);
        }
        public float FromCtoF(float celsius)
        {
            return (celsius * 9/5) + 32;
        }
        public float FromCtoK(float celsius)
        {
            return (float)(celsius + 273.15);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void toCelsius_CheckedChanged(object sender, EventArgs e)
        {
            if (fromCelsius.Checked && toCelsius.Checked)
            {
                string convertedTemp = convertFromTextfield.Text;
                convertToTextfield.Text = convertedTemp;
            }
            else if (fromFahrenheit.Checked && toCelsius.Checked)
            {
                float convertedTemp = float.Parse(convertFromTextfield.Text);
                convertToTextfield.Text = FromFtoC(convertedTemp).ToString();
            }
            else if (fromKalvin.Checked && toCelsius.Checked)
            {
                float convertedTemp = float.Parse(convertFromTextfield.Text);
                convertToTextfield.Text = FromKtoC(convertedTemp).ToString();

            }
            
        }

        private void toFahrenheit_CheckedChanged(object sender, EventArgs e)
        {
            if (fromCelsius.Checked && toFahrenheit.Checked)
            {
                float convertedTemp = float.Parse(convertFromTextfield.Text);
                convertToTextfield.Text = FromCtoF(convertedTemp).ToString();
            }
            else if (fromFahrenheit.Checked && toFahrenheit.Checked)
            {
                string convertedTemp = convertFromTextfield.Text;
                convertToTextfield.Text = convertedTemp;
            }
            else if (fromKalvin.Checked && toFahrenheit.Checked)
            {
                float convertedTemp = float.Parse(convertFromTextfield.Text);
                convertToTextfield.Text = FromCtoF(FromKtoC(convertedTemp)).ToString();

            }
        }

        private void toKalvin_CheckedChanged(object sender, EventArgs e)
        {
            if (fromCelsius.Checked && toKalvin.Checked)
            {
                float convertedTemp = float.Parse(convertFromTextfield.Text);
                convertToTextfield.Text = FromCtoK(convertedTemp).ToString();
            }
            else if (fromFahrenheit.Checked && toKalvin.Checked)
            {
                float convertedTemp = float.Parse(convertFromTextfield.Text);
                convertToTextfield.Text = FromCtoK(FromFtoC(convertedTemp)).ToString();
            }
            else if (fromKalvin.Checked && toKalvin.Checked)
            { 
                string convertedTemp = convertFromTextfield.Text;
                convertToTextfield.Text = convertedTemp;
            }
        }

        private void fromCelsius_CheckedChanged(object sender, EventArgs e)
        {
            toKalvin.Checked = false;
            toCelsius.Checked = false;
            toFahrenheit.Checked = false;
            convertToTextfield.Clear();
        }

        private void fromFahrenheit_CheckedChanged(object sender, EventArgs e)
        {
            toKalvin.Checked = false;
            toCelsius.Checked = false;
            toFahrenheit.Checked = false;
            convertToTextfield.Clear();
        }

        private void fromKalvin_CheckedChanged(object sender, EventArgs e)
        {
            toKalvin.Checked = false;
            toCelsius.Checked = false;
            toFahrenheit.Checked = false;
            convertToTextfield.Clear();
        }

        private void convertFromTextfield_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            resetRadioButtons();
            convertToTextfield.Clear();
            convertFromTextfield.Clear();

        }
    }
}
