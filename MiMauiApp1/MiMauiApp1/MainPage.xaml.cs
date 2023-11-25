using MiMauiApp1.ViewModel;

namespace MiMauiApp1
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