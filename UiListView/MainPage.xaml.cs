
namespace UiListView
{
    public class Card
    {
        public string ImageUrl { get; set; } = "";
        public string Name { get; set; } = "";
        public string Location { get; set; } = "";
    }

    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            this.Loaded += MainPage_Loaded;
        }

        private void MainPage_Loaded(object sender, EventArgs e)
        {
            var list = new List<Card>();
            list.Add(new Card() { Name = "C#" });
            list.Add(new Card() { Name = "Visual Basic" });
            list.Add(new Card() { Name = "F#" });
            list.Add(new Card() { Name = "Java" });
            list.Add(new Card() { Name = "Kotlin" });
            list.Add(new Card() { Name = "Objective-C" });
            list.Add(new Card() { Name = "Swift" });
            list.Add(new Card() { Name = "C++" });
            list.Add(new Card() { Name = "Rust" });

            this.listView.ItemsSource = list;
        } 
    }
}