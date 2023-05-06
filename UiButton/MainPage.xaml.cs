using System.Diagnostics;

namespace UiButton
{
    public partial class MainPage : ContentPage
    {
        private int _count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            _count++;
            btnCounter.Text = $"Count {_count}";
        }

        private void OnDateTimeClicked(object sender, EventArgs e)
        {
            textNow.Text = DateTime.Now.ToString();
            Debug.WriteLine(textNow.Text);
        }
    }
}