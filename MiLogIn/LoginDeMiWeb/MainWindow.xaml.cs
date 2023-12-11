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
using System.IO;
using Newtonsoft.Json;

namespace LoginDeMiWeb
{
    public class Usuario
    {
        public string usuario { get; set; } = string.Empty;
        public string password { get; set; } = string.Empty;
    }
    public partial class MainWindow : Window
    {
        private object registroWindow = new object();
        private List<Usuario> listaUsuarios = new List<Usuario>();

        public MainWindow()
        {
            InitializeComponent();
            CargarUsuarios();
        }

        private void CargarUsuarios()
        {
            string rutaArchivo = @"DatosLogin\listadoPersonas.json"; 
            string contenidoJson = File.ReadAllText(rutaArchivo);
            listaUsuarios = JsonConvert.DeserializeObject<List<Usuario>>(contenidoJson);
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

            if (ValidarCredenciales(usuario, password))
            {
                MessageBox.Show("¡Olé, Bienvenido a la web!");
            }
            else
            {
                MessageBox.Show("Error, usuario o contraseña incorrectos");
            }
        }

        private bool ValidarCredenciales(string usuario, string password)
        {
            // Verificar coincidencia usuarios y contraseñas
            return listaUsuarios.Any(u => u.usuario == usuario && u.password == password);
        }

        private void registro(object sender, MouseButtonEventArgs e)
        {
            Registro registroWindow = new Registro();
            registroWindow.ShowDialog();
        }

        private void recuperar(object sender, MouseButtonEventArgs e)
        {
            Window1 window1 = new Window1();
            window1.ShowDialog();
        }
    }
}
