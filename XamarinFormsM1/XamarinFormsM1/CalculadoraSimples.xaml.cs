using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsM1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CalculadoraSimples : ContentPage
    {
        public CalculadoraSimples()
        {
            InitializeComponent();
        }

        private void Calcular(object sender, EventArgs e)
        {
            double a = 0, b = 0, t = 0;
            
            a = Convert.ToDouble(etValorA.Text);
            b = Convert.ToDouble(etValorB.Text);

            Button bt = (Button)sender;
            
            if (bt.Text == "+")
            {
                t = a + b;
            } else if (bt.Text == "-")
            {
                t = a - b;
            }
            else if (bt.Text == "*")
            {
                t = a * b;
            }
            else if (bt.Text == "/")
            {
                t = a / b;
            }

            lbResp.Text = t.ToString();
        }
    }
}