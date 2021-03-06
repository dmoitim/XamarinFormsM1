﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsM1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class XamarinCalculadora : ContentPage
    {
        int currentState = 1;
        string mathOperator;
        double firstNumber, secondNumber;

        public XamarinCalculadora()
        {
            InitializeComponent();
            OnClear(new object(), new EventArgs());
        }

        void OnSelectNumber(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string pressed = button.Text;

            if (lbResultado.Text == "0" || currentState < 0)
            {
                lbResultado.Text = "";
                if (currentState < 0)
                {
                    currentState *= -1;
                }
            }

            lbResultado.Text += pressed;

            double number;
            if (double.TryParse(lbResultado.Text, out number))
            {
                lbResultado.Text = number.ToString("N0");
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

        void OnSelectOperator(object sender, EventArgs e)
        {
            currentState = -2;
            Button button = (Button)sender;
            string pressed = button.Text;
            mathOperator = pressed;
        }

        void OnCalculate(object sender, EventArgs e)
        {
            if (currentState == 2)
            {
                double result = 0;

                if (mathOperator == "+")
                {
                    result = firstNumber + secondNumber;
                }

                if (mathOperator == "-")
                {
                    result = firstNumber - secondNumber;
                }

                if (mathOperator == "x")
                {
                    result = firstNumber * secondNumber;
                }

                if (mathOperator == "/")
                {
                    result = firstNumber / secondNumber;
                }

                lbResultado.Text = result.ToString("N0");
                firstNumber = result;
                currentState = -1;
            }
        }

        void OnClear(object sender, EventArgs e)
        {
            firstNumber = 0;
            secondNumber = 0;
            currentState = 1;
            lbResultado.Text = "0";
        }
    }
}