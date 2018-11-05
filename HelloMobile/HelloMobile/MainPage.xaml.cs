using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using HelloLibrary;

namespace HelloMobile
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            var hello = new Greeting("Hello, World!");

            InitializeComponent();

            Content = new Label
            {
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                Text = hello.Value
            };
        }
    }
}
