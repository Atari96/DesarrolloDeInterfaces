// Clase utilizada para poder interactuar con codigo JavaScript en el lado cliente
using Microsoft.JSInterop;

namespace BlazingPizza.Client
{
    public static class JSRuntimeExtensions
    {
        public static ValueTask<bool> Confirm(this IJSRuntime jsRuntime, string message)
        {
            return jsRuntime.InvokeAsync<bool>("confirm", message);
        }
    }
}