namespace BlazingPizza.Server;

public static class SeedData
{
    public static void Initialize(PizzaStoreContext db)
    {
        var toppings = new Topping[]
        {
            new Topping()
            {
                    Name = "Extra de queso",
                    Price = 2.50m,
            },
            new Topping()
            {
                    Name = "Bacon americano",
                    Price = 2.99m,
            },
            new Topping()
            {
                    Name = "Bacon ingles",
                    Price = 2.99m,
            },
            new Topping()
            {
                    Name = "Bacon canadiense",
                    Price = 2.99m,
            },
            new Topping()
            {
                    Name = "Te y bollos",
                    Price = 5.00m
            },
            new Topping()
            {
                    Name = "Bollos horneados",
                    Price = 4.50m,
            },
            new Topping()
            {
                    Name = "Pimiento",
                    Price = 1.00m,
            },
            new Topping()
            {
                    Name = "Cebolla",
                    Price = 1.00m,
            },
            new Topping()
            {
                    Name = "Champiñones",
                    Price = 1.00m,
            },
            new Topping()
            {
                    Name = "Pepperoni",
                    Price = 1.00m,
            },
            new Topping()
            {
                    Name = "Salsa de pato",
                    Price = 3.20m,
            },
            new Topping()
            {
                    Name = "Bolas de carne de venado",
                    Price = 2.50m,
            },
            new Topping()
            {
                    Name = "Servida en plato de plata",
                    Price = 250.99m,
            },
            new Topping()
            {
                    Name = "Langosta",
                    Price = 64.50m,
            },
            new Topping()
            {
                    Name = "Caviar",
                    Price = 101.75m,
            },
            new Topping()
            {
                    Name = "Corazones de alcachofa",
                    Price = 3.40m,
            },
            new Topping()
            {
                    Name = "Tomatitos frescos",
                    Price = 1.50m,
            },
            new Topping()
            {
                    Name = "Albahaca",
                    Price = 1.50m,
            },
            new Topping()
            {
                    Name = "Carne",
                    Price = 8.50m,
            },
            new Topping()
            {
                    Name = "Pimiento picante",
                    Price = 4.20m,
            },
            new Topping()
            {
                    Name = "Pechuga de bufalo",
                    Price = 5.00m,
            },
            new Topping()
            {
                    Name = "Queso azul",
                    Price = 2.50m,
            },
        };

        var specials = new PizzaSpecial[]
        {
            new PizzaSpecial()
            {
                    Name = "Pizza de superqueso",
                    Description = "Super queso. Una buena elección",
                    BasePrice = 9.99m,
                    ImageUrl = "img/pizzas/cheese.jpg",
            },
            new PizzaSpecial()
            {
                    Id = 2,
                    Name = "Rey del bacon",
                    Description = "Con todos los tipos de bacon",
                    BasePrice = 11.99m,
                    ImageUrl = "img/pizzas/bacon.jpg",
            },
            new PizzaSpecial()
            {
                    Id = 3,
                    Name = "Pizza diablo",
                    Description = "Te gusta el picante? Es la tuya!",
                    BasePrice = 10.50m,
                    ImageUrl = "img/pizzas/pepperoni.jpg",
            },
            new PizzaSpecial()
            {
                    Id = 4,
                    Name = "Buffalo chicken",
                    Description = "Pollo picante, salsa picante y queso azul, te calentará como un bufalo",
                    BasePrice = 12.75m,
                    ImageUrl = "img/pizzas/meaty.jpg",
            },
            new PizzaSpecial()
            {
                    Id = 5,
                    Name = "Amantes del champiñon",
                    Description = "Es la que come David el gnomo",
                    BasePrice = 11.00m,
                    ImageUrl = "img/pizzas/mushroom.jpg",
            },
            new PizzaSpecial()
            {
                    Id = 6,
                    Name = "The Brit",
                    Description = "En Londres...",
                    BasePrice = 10.25m,
                    ImageUrl = "img/pizzas/brit.jpg",
            },
            new PizzaSpecial()
            {
                    Id = 7,
                    Name = "Delicia vegetariana",
                    Description = "Para los no carnivoros",
                    BasePrice = 11.50m,
                    ImageUrl = "img/pizzas/salad.jpg",
            },
            new PizzaSpecial()
            {
                    Id = 8,
                    Name = "Margarita",
                    Description = "Pizza tradicional de tomate y albahaca",
                    BasePrice = 9.99m,
                    ImageUrl = "img/pizzas/margherita.jpg",
            },
        };

        db.Toppings.AddRange(toppings);
        db.Specials.AddRange(specials);
        db.SaveChanges();
    }
}