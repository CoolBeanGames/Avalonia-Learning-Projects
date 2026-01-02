namespace MVVM_Sample.ViewModels
{
    public partial class MainWindowViewModel : ViewModelBase
    {
        public string Greeting { get; } = "Welcome to Avalonia!";
        public SimpleViewModel SimpleVM { get; } = new SimpleViewModel();
    }
}
