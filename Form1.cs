using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// Lab 1: Temperature Conversion Calculator
/// Authors: Jashanpreet Singh and Sean 
/// Date: January 12 2022
/// Source: Formulas for temperature conversion at : https://www.thoughtco.com/temperature-conversion-formulas-609324
/// </summary>
namespace Tech_Pro_Lab_1
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Clear selections from all the Radio buttons in Form 1.
        /// </summary>
        public void resetRadioButtons()
        {
            fromCelsius.Checked = false;
            fromFahrenheit.Checked = false;
            fromKalvin.Checked = false;
            toCelsius.Checked=false;
            toFahrenheit.Checked = false;
            toKalvin.Checked = false;
        }

        /// <summary>
        /// Check if the input is Valid before processing.
        /// </summary>
        /// <param name="textField"> A string </param>
        /// <returns> A boolean value specifying if the input is valid or not </returns>
        public bool checkInputValidation(string textField)
        {
            if(textField.Length == 0)
            {
                errorLabel.Visible = true;
                return false;
            }
            return true;

        }

        /// <summary>
        /// Convert Fahrenheit temperature value to Celsius
        /// </summary>
        /// <param name="fahrenheit"> A float value for the temperature in Fahrenheit </param>
        /// <returns> A float value in Celsius </returns>
        public float FromFtoC(float fahrenheit)
        {
            return (fahrenheit - 32) * 5/9;
        }

        /// <summary>
        /// Convert Kalvin temperature value to Celsius
        /// </summary>
        /// <param name="kalvin"> A float value for the temperature in Kalvin </param>
        /// <returns> A float value in Celsius </returns>
        public float FromKtoC(float kalvin)
        {
            return (float)(kalvin - 273.15);
        }

        /// <summary>
        /// Convert Celsius temperature value to Fahrenheit
        /// </summary>
        /// <param name="celsius"> A float value for the temperature in Celsius </param>
        /// <returns> A float value in Fahrenheit </returns>
        public float FromCtoF(float celsius)
        {
            return (celsius * 9/5) + 32;
        }

        /// <summary>
        /// Convert Celsius temperature value to Kalvin
        /// </summary>
        /// <param name="celsius"> A float value for the temperature in Celsius </param>
        /// <returns> A float value in Kalvin </returns>
        public float FromCtoK(float celsius)
        {
            return (float)(celsius + 273.15);
        }

        /// <summary>
        /// Set text of text field to the correct input or show error.
        /// </summary>
        /// <param name="sender">An object</param>
        /// <param name="e"> An Event Argument</param>
        private void toCelsius_CheckedChanged(object sender, EventArgs e)
        {
            if (checkInputValidation(convertFromTextfield.Text) == false)
            {
                convertToTextfield.Clear();
            }
            else
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
        }

        /// <summary>
        /// Set text of text field to the correct input or show error.
        /// </summary>
        /// <param name="sender">An object</param>
        /// <param name="e"> An Event Argument</param>
        private void toFahrenheit_CheckedChanged(object sender, EventArgs e)
        {
            if (checkInputValidation(convertFromTextfield.Text) == false)
            {
                convertToTextfield.Clear();
            }
            else
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

        }

        /// <summary>
        /// Set text of text field to the correct input or show error.
        /// </summary>
        /// <param name="sender">An object</param>
        /// <param name="e"> An Event Argument</param>
        private void toKalvin_CheckedChanged(object sender, EventArgs e)
        {
            if (checkInputValidation(convertFromTextfield.Text) == false)
            {
                convertToTextfield.Clear();
            }
            else
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
        }

        /// <summary>
        /// Clear from side's Radio button to start a new Calculation process
        /// </summary>
        /// <param name="sender">An object</param>
        /// <param name="e"> An Event Argument</param>
        private void fromCelsius_CheckedChanged(object sender, EventArgs e)
        {
            clearRadioBtnsFrom();
            errorLabel.Visible = false;
        }

        /// <summary>
        /// Clear from side's Radio button to start a new Calculation process
        /// </summary>
        /// <param name="sender">An object</param>
        /// <param name="e"> An Event Argument</param>
        private void fromFahrenheit_CheckedChanged(object sender, EventArgs e)
        {
            clearRadioBtnsFrom();
            errorLabel.Visible = false;
        }

        /// <summary>
        /// Clear from side's Radio button to start a new Calculation process
        /// </summary>
        /// <param name="sender">An object</param>
        /// <param name="e"> An Event Argument</param>
        private void fromKalvin_CheckedChanged(object sender, EventArgs e)
        {
            clearRadioBtnsFrom();
            errorLabel.Visible = false;
        }

        /// <summary>
        /// Clear from side's Radio Buttons all in once
        /// </summary>
        private void clearRadioBtnsFrom()
        {
            toKalvin.Checked = false;
            toCelsius.Checked = false;
            toFahrenheit.Checked = false;
            convertToTextfield.Clear();
        }

        /// <summary>
        /// Reset All the input and output fields.
        /// </summary>
        /// <param name="sender">An object</param>
        /// <param name="e"> An Event Argument</param>
        private void button1_Click(object sender, EventArgs e)
        {
            resetRadioButtons();
            convertToTextfield.Clear();
            convertFromTextfield.Clear();
            errorLabel.Visible = false;
        }

    }
}
