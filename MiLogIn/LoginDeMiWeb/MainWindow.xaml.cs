using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LoginDeMiWeb
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private object registroWindow;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            // Limpiar el contenido del cuadro de texto
            textUsuario.Text = string.Empty;

            // Limpiar el contenido del password
            textPassword.Password = string.Empty;

            // Desmarcar CheckBox
            CheckBox1.IsChecked = false; 

        }

        private void btnEnviar_Click(object sender, RoutedEventArgs e)
        {
            String usuario = textUsuario.Text;
            String password = textPassword.Password;
        }

        private void registro(object sender, MouseButtonEventArgs e)
        {
            Registro registroWindow = new Registro();
            registroWindow.Show();
        }

        private void recuperar(object sender, MouseButtonEventArgs e)
        {
            Window1 window1 = new Window1();
            window1.Show();
        }
    }
}
