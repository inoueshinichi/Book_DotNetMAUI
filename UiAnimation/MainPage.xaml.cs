namespace UiAnimation
{
    public partial class MainPage : ContentPage
    {
        

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnClickedAnimateAffine(object sender, EventArgs e)
        {
            /*回転アニメーション*/
            await imageNet.RotateTo(360, 2000); // (360deg, 2000ms)
            imageNet.Rotation = 0;

            /*スケールアニメーション*/
            await imageNet.ScaleTo(2.0, 1000);
            await imageNet.ScaleTo(1.0, 1000);

            /*並進アニメーション*/
            await imageNet.TranslateTo(50, 100);
            await imageNet.TranslateTo(-50, -100);
            await imageNet.TranslateTo(0, 0);

            /*フェードアニメーション*/
            await imageNet.FadeTo(0.0, 2000);
            await imageNet.FadeTo(1.0, 2000);

          
        }
    }
}