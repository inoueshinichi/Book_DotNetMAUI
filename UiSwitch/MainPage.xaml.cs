namespace UiSwitch
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void SwitchToggled(object sender, ToggledEventArgs e)
        {
            if (sw.IsToggled == true) 
            {
                image.IsVisible = true;
            }
            else
            {
                image.IsVisible = false;
            }
        }
    }
}