using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App3
{
    public partial class MainPage : ContentPage
    {
        string currentInput = string.Empty;
        double firstNumber, secondNumber;
        string operation;

        
        public MainPage()
        {
            InitializeComponent();
            
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            Result.Text = "0"; 
        }

        private void Button_Clicked(object sender, EventArgs e) 
        {
            var button = (Button)sender;
            var buttonText = button.Text;

            if (int.TryParse(buttonText, out int number) || buttonText == "0")
            {
                currentInput += buttonText;
                Result.Text = currentInput;
            }
            else
            {
                if (buttonText == "+" || buttonText == "-" || buttonText == "*" || buttonText == "/")
                {
                    firstNumber = double.Parse(currentInput);
                    operation = buttonText;
                    currentInput = string.Empty;
                }
                else if (buttonText == "=")
                {
                    secondNumber = double.Parse(currentInput);
                    double result = PerformOperation(firstNumber, secondNumber, operation);
                    currentInput = result.ToString();
                    Result.Text = currentInput;
                }
                else if (buttonText == "AC")
                {
                    currentInput = null;
                    Result.Text = 0.ToString();
                }
            }
        }

        double PerformOperation(double first, double second, string operation)
        {
            switch (operation)
            {
                case "+":
                    return first + second;
                case "-":
                    return first - second;
                case "*":
                    return first * second;
                case "/":
                    return first / second;
                default:
                    throw new ArgumentException("Invalid operation");
            }
        }
    }
}

