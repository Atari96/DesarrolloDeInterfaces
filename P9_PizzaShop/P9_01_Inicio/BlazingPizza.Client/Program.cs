using BlazingPizza;
using BlazingPizza.Client;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;

/// <summary>
/// Añadimos un servicio que nos permita configurar e inyectar el httpclient y la direccion, con el gestor que nos permita
/// agregar los encabezados de autorizacion
/// Incluimos un servicio que nos permita persistir el OrderState en el casode que no realicemos el pedido por cambiar de pagina dentro de la app
/// Llamada para habilitar los servicios de autenticacion, incluimoss el <PizzaAuthenticationState>
/// La parte options implica el codigo necesario para poder hacer el logout
/// </summary>


var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });


// Añadimos un servicio que nos permita configurar e inyectar el httpclient y la direccion, con el gestor que nos permita
// agregar los encabezados de autorizacion. Persistimos los pedidoss no solicitados por si cambiamos a otra parte de la app
builder.Services.AddHttpClient<OrdersClient>(client => client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress))
    .AddHttpMessageHandler<BaseAddressAuthorizationMessageHandler>();
builder.Services.AddScoped<OrderState>();

// Llamada para habilitar los servicios de autenticacion, incluimoss el <PizzaAuthenticationState>
// La parte options implica el codigo necesario para poder hacer el logout
builder.Services.AddApiAuthorization<PizzaAuthenticationState>(options => {
    options.AuthenticationPaths.LogOutSucceededPath = "";
});

await builder.Build().RunAsync();
