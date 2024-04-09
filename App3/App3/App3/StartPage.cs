using Xamarin.Forms;
namespace App3
{
    class StartPage : ContentPage
    {
        public StartPage()
        {
            Label header = new Label() { Text = "Привет из Xamarin Forms" };
            this.Content = header;
        }
    }
}