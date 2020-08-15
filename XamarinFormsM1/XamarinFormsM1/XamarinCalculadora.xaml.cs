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
    public partial class XamarinCalculadora : ContentPage
    {
        public XamarinCalculadora()
        {
            InitializeComponent();
        }

        void OnSelectNumber(object sender, EventArgs e)
        {

        }
    }
}