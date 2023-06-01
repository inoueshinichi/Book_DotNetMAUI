namespace UiStack;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}
	
	// 同期
	private async void OnSendAddressButtonClicked(object sender, EventArgs e)
	{
		string name = textName.Text;
		int age = int.Parse(textAge.Text);
		string addr = textAddress.Text;
		await DisplayAlert(".NET MAUI", $"{name} ({age}) in {addr}", "OK");
	}
}


