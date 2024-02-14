using System.Net.Http.Json;

namespace BlazingPizza.Client;

public class OrdersClient
{
    // Declaramos el httpclient para enviar peticiones y respuestas solo de lectura para que no pueda ser modificado
    private readonly HttpClient httpClient;

    public OrdersClient(HttpClient httpClient)
    {
        this.httpClient = httpClient;
    }

    // Metodos que nos serviran para interactuar con la API mediante lasa solicitudes httpClient

    // El metodo getOrders obtiene la lista de pedidos junto con su estado, con el getFromJsonAsync deserializamos los datos
    // tenemos que pasar la ruta, y nos devuelve la lista de pedidos. Con ?? gestionamos el nulo

    public async Task<IEnumerable<OrderWithStatus>> GetOrders() =>
            await httpClient.GetFromJsonAsync("orders", OrderContext.Default.ListOrderWithStatus) ?? new();

    // Obtenemos el pedido segun el id que hayamos pasado como parametro
    public async Task<OrderWithStatus> GetOrder(int orderId) =>
            await httpClient.GetFromJsonAsync($"orders/{orderId}", OrderContext.Default.OrderWithStatus) ?? new();

    // Metodo para realizar una peticion Post al servidor (post), enviando el pedido, hay que pasar por parametro el pedido
    public async Task<int> PlaceOrder(Order order)
    {
        var response = await httpClient.PostAsJsonAsync("orders", order, OrderContext.Default.Order);
        response.EnsureSuccessStatusCode();
        var orderId = await response.Content.ReadFromJsonAsync<int>();
        return orderId;
    }

    // Metodo que permite subscribirnos a las notificaciones, se le pasa una notificación
    // El metodo no tiene que esperar (await) mientras se hace una petición http del tipo put a la direccion notification/susbscribe
    // La peticion se serializa a Json
    public async Task SubscribeToNotifications(NotificationSubscription subscription)
    {
        var response = await httpClient.PutAsJsonAsync("notifications/subscribe", subscription);
        // En funcion de la respuesta podria arrojar un codigo de error y lanzará excepcion 
        response.EnsureSuccessStatusCode();
    }

}
