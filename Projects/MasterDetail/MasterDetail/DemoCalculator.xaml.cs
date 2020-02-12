using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MasterDetail
{
    public partial class DemoCalculator : ContentPage
    {
            int currentState = 1;
            string myoperator, temText;
            double firstNumber, secondNumber;
            string str0;
            int d = 0;


            public DemoCalculator()
            {
                InitializeComponent();
                Onclear(this, null);
            }

            void OnSelectNumber(object sender, EventArgs e)
            {

                Button button = (Button)sender;
                string pressed = button.Text;

                if (this.resultText.Text == "0" || currentState < 0)
                {
                    this.resultText.Text = "";
                    if (currentState < 0)
                        currentState *= -1;
                }
                str0 = this.resultText.Text;
                if (pressed == ".")
                {
                    if (str0.Length == 0)
                        pressed = "";
                    else
                        d++;
                }

                if (d > 0)
                {
                    temText = this.resultText.Text;
                    this.resultText.Text = "";
                    this.resultText.Text = temText + pressed;
                    //OnSelectDot(this.resultText.Text);
                }
                else if (str0.Length < 12)
                {
                    this.resultText.Text += pressed;
                    //OnSelectDot(this.resultText.Text);
                    OnSelectComma(this.resultText.Text);
                }
                double number;
                if (double.TryParse(this.resultText.Text, out number))
                {
                    //this.resultText.Text = number.ToString("NO");
                    if (currentState == 1)
                    {
                        firstNumber = number;
                    }
                    else
                    {
                        secondNumber = number;
                    }
                }
            }

            void OnSelectOperator(Object sender, EventArgs e)
            {

                Button button = (Button)sender;
                string pressed = button.Text;
                myoperator = pressed;

                if (pressed == "X")
                {
                    this.Multiplication.BackgroundColor = Color.Orange;
                    this.Division.BackgroundColor = Color.Gray;
                    this.Addition.BackgroundColor = Color.Gray;
                    this.Subtraction.BackgroundColor = Color.Gray;
                }
                if (pressed == "/")
                {
                    this.Multiplication.BackgroundColor = Color.Gray;
                    this.Division.BackgroundColor = Color.Orange;
                    this.Addition.BackgroundColor = Color.Gray;
                    this.Subtraction.BackgroundColor = Color.Gray;
                }
                if (pressed == "-")
                {
                    this.Multiplication.BackgroundColor = Color.Gray;
                    this.Division.BackgroundColor = Color.Gray;
                    this.Addition.BackgroundColor = Color.Gray;
                    this.Subtraction.BackgroundColor = Color.Orange;
                }
                if (pressed == "+")
                {
                    this.Multiplication.BackgroundColor = Color.Gray;
                    this.Division.BackgroundColor = Color.Gray;
                    this.Addition.BackgroundColor = Color.Orange;
                    this.Subtraction.BackgroundColor = Color.Gray;
                }


                if (currentState == 2)
                {
                    var result = OperaterHelper.Calculate(firstNumber, secondNumber, myoperator);

                    this.resultText.Text = result.ToString();
                    //OnSelectComma(this.resultText.Text);
                    firstNumber = result;

                }
                currentState = -2;

                if (str0.Length == 0)
                {
                    if (myoperator == "-")
                    {
                        if (this.resultText.Text == "0" || currentState < 0)
                        {
                            this.resultText.Text = "";
                            if (currentState < 0)
                                currentState *= -1;
                        }
                        this.resultText.Text += myoperator;
                        currentState = 1;
                    }
                    else
                    {
                        currentState = -2;
                    }

                }
                d = 0;
            }

            void OnChange(Object sender, EventArgs e)
            {
                this.Multiplication.BackgroundColor = Color.Gray;
                this.Division.BackgroundColor = Color.Gray;
                this.Addition.BackgroundColor = Color.Gray;
                this.Subtraction.BackgroundColor = Color.Gray;
                double number1;
                double.TryParse(this.resultText.Text, out number1);
                number1 *= -1;
                this.resultText.Text = number1.ToString();
                OnSelectComma(this.resultText.Text);
                double number;
                if (double.TryParse(this.resultText.Text, out number))
                {
                    //this.resultText.Text = number.ToString("NO");
                    if (currentState == 1)
                    {
                        firstNumber = number;
                    }
                    else
                    {
                        secondNumber = number;
                    }
                }
            }

            void Onclear(Object sender, EventArgs e)
            {
                firstNumber = 0;
                secondNumber = 0;
                currentState = 1;
                d = 0;
                this.resultText.Text = "0";
            }

            void OnPercentage(Object sender, EventArgs e)
            {
                this.Multiplication.BackgroundColor = Color.Gray;
                this.Division.BackgroundColor = Color.Gray;
                this.Addition.BackgroundColor = Color.Gray;
                this.Subtraction.BackgroundColor = Color.Gray;
                if ((currentState == -1) || (currentState == 1))
                {
                    var result = firstNumber / 100;
                    this.resultText.Text = result.ToString();
                    OnSelectComma(this.resultText.Text);
                    firstNumber = result;
                    currentState = -1;
                }
            }

            private void OnCalculate(Object sender, EventArgs e)
            {
                this.Multiplication.BackgroundColor = Color.Gray;
                this.Division.BackgroundColor = Color.Gray;
                this.Addition.BackgroundColor = Color.Gray;
                this.Subtraction.BackgroundColor = Color.Gray;

                if (currentState == 2)
                {
                    var result = OperaterHelper.Calculate(firstNumber, secondNumber, myoperator);
                    this.resultText.Text = result.ToString();
                    OnSelectDot(this.resultText.Text);
                    firstNumber = result;
                    currentState = -1;
                }
            }

            void OnSelectComma(string str)
            {
                double number1;
                double.TryParse(str, out number1);
                this.resultText.Text = String.Format("{0:0,0}", number1);
            }
            void OnSelectDot(string str)
            {
                double number1;
                double.TryParse(str, out number1);
                this.resultText.Text = String.Format("{0:0,0.00}", number1);
            }


            
        
    }

}

