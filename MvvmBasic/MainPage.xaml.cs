namespace MvvmBasic;

using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

public partial class MainPage : ContentPage
{
     public MainPage()
     {
        InitializeComponent();
        this.Loaded += (_, _) =>
        {
            // ViewとViewModelの結びつけを設定する.
            this.BindingContext = _vm;
        };
     }

     MyViewModel _vm = new MyViewModel();
}

// ViewModel
public class MyViewModel : INotifyPropertyChanged
{
    // ViewModelからviewにプロパティの値が変更したことを通知する定番の方法
    public event PropertyChangedEventHandler PropertyChanged;
    private string _hello = "Hello, world!";
    public string Hello
    {
        get => _hello;
        set
        {
            if (_hello != null)
            {
                _hello = value;
                OnPropertyChanged(); // HelloプロパティにOnPropertyChangedメソッドを設定
            }
        }
    }

    public void OnPropertyChanged(
        [CallerMemberName] string name = "") =>
            PropertyChanged?.Invoke(
                this, new PropertyChangedEventArgs(name));

    public ICommand OnHelloClicked { get; private set; }
    public MyViewModel()
    {
        OnHelloClicked = new Command(() =>
        {
            this.Hello = "ようこそ .NET MAUIの世界へ";
        });
    }

}
