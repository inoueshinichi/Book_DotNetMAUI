namespace UiBrush
{
    public partial class MainPage : ContentPage
    {
        
        public MainPage()
        {
            InitializeComponent();

            
        }

        private void OnRedClicked(object sender, EventArgs e)
        {
            imageNet.Background = new SolidColorBrush(Colors.Red);
        }

        private void OnBlueClicked(object sender, EventArgs e) 
        {
            imageNet.Background = new LinearGradientBrush(
                new GradientStopCollection()
                {
                    new GradientStop(Colors.Red, 0),
                    new GradientStop(Colors.White, 1),
                },
                new Point(0,0),
                new Point(1,0)
            );
        }

        private void OnYellowClicked(object sender, EventArgs e)
        {
            imageNet.Background = new RadialGradientBrush(
                new GradientStopCollection()
                {
                    new GradientStop(Colors.Yellow, 0),
                    new GradientStop(Colors.White, 1),
                },
                new Point(0.5,0.5),
                0.5
            );
        }

        private void OnFlexibleUserColorClicked(object sender, EventArgs e)
        {
            // labelColorObjの背景色(属性)を設定
            imageNet.Background = new SolidColorBrush(Colors.Green);
        }
    }
}