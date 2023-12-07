namespace MiLogIn
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void loginBtn(object sender, EventArgs e) {
            String usuario = usuarioEntry.Text;
            String password = passwordEntry.Text;
        }

        
    }

}
