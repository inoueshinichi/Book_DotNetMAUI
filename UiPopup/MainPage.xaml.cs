namespace UiPopup
{
    public partial class MainPage : ContentPage
    {
        
        public MainPage()
        {
            InitializeComponent();
        }

        // ポップアップ形式で表示
        private async void OnPopupClicked(object sender, EventArgs e)
        {
            await DisplayAlert(".NET MAUI サンプル",
                                "メッセージを表示します",
                                "CLOSE");
        }

        // YES/NOの選択
        private async void OnYesNoClicked(object sender, EventArgs e)
        {
            bool answer = await DisplayAlert(".NET MAUI サンプル",
                "あなたはC#が得意ですか?", "はい", "いいえ");

            labelResult.Text = $"結果: {answer}";
        }

        // プロンプトで表示
        private async void OnPromptClicked(object sender, EventArgs e)
        {
            string result = await DisplayPromptAsync(
                ".NET MAUI サンプル", "好きなプログラミング言語は?");

            labelResult.Text = $"結果: {result}";
        }
    }
}