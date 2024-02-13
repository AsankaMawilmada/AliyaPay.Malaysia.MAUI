using CommunityToolkit.Mvvm.ComponentModel;
namespace AliyaPay.Malaysia.UI.ViewModel
{
    public partial class BaseViewModel : ObservableObject
    {
        [ObservableProperty]
        bool isRunning = false;
    }
}
