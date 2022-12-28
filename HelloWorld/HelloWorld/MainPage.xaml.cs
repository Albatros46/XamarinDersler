using System;
using Xamarin.Forms;

namespace HelloWorld
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        int count = 0;
        void Handle_Click(object sender,EventArgs eventArgs)
        {
            count++;
            var btn=(Button)sender;
            btn.Text = $"butone {count} kere tiklandi!";
        }
    }
}
