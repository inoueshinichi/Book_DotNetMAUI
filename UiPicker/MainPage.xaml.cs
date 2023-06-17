namespace UiPicker
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
            this.Loaded += MainPage_Loaded;
        }

        private void MainPage_Loaded(object sender, EventArgs e)
        {
            var list = new List<string>();
            list.Add("選択してください");
            list.Add("C#");
            list.Add("Visual Basic");
            list.Add("F#");
            list.Add("Kotlin");
            list.Add("Swift");
            list.Add("Java");
            list.Add("Objective-C");

            pick.ItemsSource = list;
            pick.SelectedIndex = 0;
        }

        private void PickSelectedIndexChanged(object sender, EventArgs e)
        {
            if (pick.SelectedIndex != -1)
            {
                labelResult.Text = pick.SelectedItem as string;
            }
        }
    }
}