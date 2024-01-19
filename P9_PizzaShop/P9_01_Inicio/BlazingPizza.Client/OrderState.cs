namespace BlazingPizza.Client
{
    public class OrderState
    {
        public bool ShowingConfigureDialog { get; private set; }

        public Pizza? ConfiguringPizza { get; private set; }

        public Order Order { get; private set; } = new Order();

        public void ShowConfigurePizzaDialog(PizzaSpecial special) // Este metodo es movido desde el index.razor
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

        public void CancelConfigurePizzaDialog() // Este metodo es movido desde el index.razor
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
