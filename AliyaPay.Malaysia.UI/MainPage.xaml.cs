using AliyaPay.Malaysia.UI.ViewModel;

namespace Exchange.Monitor.MAUI
{
    public partial class MainPage : ContentPage
    {      

        public MainPage(MainViewModel vm)
        {
            InitializeComponent();
            BindingContext = vm;
        }


    }
}
