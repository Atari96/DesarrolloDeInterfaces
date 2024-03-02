using BlazingPizza;
using BlazingPizza.Client;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });


// Añadimos un servicio que nos permita configurar e inyectar el httpclient y la direccion, con el gestor que nos permita
// agregar los encabezados de autorizacion
builder.Services.AddHttpClient<OrdersClient>(client => client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress))
    .AddHttpMessageHandler<BaseAddressAuthorizationMessageHandler>();
builder.Services.AddScoped<OrderState>();

// Llamada para habilitar los servicios de autenticacion, incluimoss el <PizzaAuthenticationState>
// La parte options implica el codigo necesario para poder hacer el logout
builder.Services.AddApiAuthorization<PizzaAuthenticationState>(options => {
    options.AuthenticationPaths.LogOutSucceededPath = "";
});

await builder.Build().RunAsync();
