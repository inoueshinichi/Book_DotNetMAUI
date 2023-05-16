namespace UiEntry
{
    public partial class MainPage : ContentPage
    {
        

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnClickCommit(object sender, EventArgs e)
        {
            string name = textName.Text;
            string addr = textAddress.Text;
            labelMessage.Text = $"{name} in {addr}";
        }
    }
}