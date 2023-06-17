namespace DatePicker
{
    public partial class MainPage : ContentPage
    {
       
        public MainPage()
        {
            InitializeComponent();
        }

        private void PickDateSelected(object sender, EventArgs e)
        {
            labelResult.Text = pick.Date.ToString();
        }
           
    }
}