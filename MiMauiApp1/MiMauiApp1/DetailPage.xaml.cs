using MiMauiApp1.ViewModel;

namespace MiMauiApp1;


public partial class DetailPage : ContentPage
{
    public DetailPage(DetailViewModel vm) 
    {
        InitializeComponent();
        BindingContext = vm;
    }

    
}
