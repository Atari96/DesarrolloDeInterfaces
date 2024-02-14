using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazingPizza
{
    public class ThemeService
    {
        public string CurrentTheme { get; private set; } = "site"; // Tema por defecto

        public async Task CambiarModoOscuro()
        {
            Console.WriteLine("Modo oscuro en clase themeservice");
            await Task.Run(() =>
            {
                CurrentTheme = CurrentTheme == "site" ? "site2" : "site";
            });
        }
    }
}
