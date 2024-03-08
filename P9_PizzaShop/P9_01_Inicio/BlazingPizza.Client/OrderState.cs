namespace BlazingPizza.Client
{

    /// <summary>
    /// Controla la informacion que se mostrara relacionada con el estado de los pedidos
    /// Se encarga de mostrar la pantalla en donde diseñaremos la pizza
    /// Se encarga de cerrar el cuadro de la configuracion
    /// Metodo que se realiza para recuperar un pedido que habiamos hecho antes de loguearnos, y que persista despues
    /// </summary>
    public class OrderState
    {
        public bool ShowingConfigureDialog { get; private set; }

        public Pizza? ConfiguringPizza { get; private set; }

        public Order Order { get; private set; } = new Order();

        // Este metodo es movido desde el index.razor
        // Se encarga de mostrar la pantalla en donde diseñaremos la pizza
        public void ShowConfigurePizzaDialog(PizzaSpecial special) 
        {
            ConfiguringPizza = new Pizza()
            {
                Special = special,
                SpecialId = special.Id,
                Size = Pizza.DefaultSize,
                Toppings = new List<PizzaTopping>(),
            };

            ShowingConfigureDialog = true;
        }

        // Este metodo es movido desde el index.razor
        // Se encarga de cerrar el cuadro de la configuracion
        public void CancelConfigurePizzaDialog() 
        {
            ConfiguringPizza = null;

            ShowingConfigureDialog = false;
        }

        public void ConfirmConfigurePizzaDialog() // Este metodo es movido desde el index.razor
        {
            if (ConfiguringPizza is not null)
            {
                Order.Pizzas.Add(ConfiguringPizza);
                ConfiguringPizza = null;
            }

            ShowingConfigureDialog = false;
        }

        public void ResetOrder() // Este metodo es movido desde el index.razor
        {
            Order = new Order();
        }

        public void RemoveConfiguredPizza(Pizza pizza) // Este metodo es movido desde el index.razor
        {
            Order.Pizzas.Remove(pizza);
        }

        // Metodo que se realiza para recuperar un pedido que habiamos hecho antes de loguearnos, y que persista despues
        public void ReplaceOrder(Order order)
        {
            Order = order;
        }
    }
}
