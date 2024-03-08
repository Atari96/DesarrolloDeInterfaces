using Duende.IdentityServer.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace BlazingPizza.Server;

/// <summary>
/// Clase en la cual se controlan los datos que se van a importar de la base de datos
/// hacemos una nueva llamada para coger los datos de la tabla promociones de la base de datos
/// </summary>

public class PizzaStoreContext : ApiAuthorizationDbContext<PizzaStoreUser>
{
    public PizzaStoreContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
    {
    }

    public DbSet<Order> Orders { get; set; }

    public DbSet<Pizza> Pizzas { get; set; }

    public DbSet<PizzaSpecial> Specials { get; set; }

    // Nueva llamada para coger los datos de la tabla de la base de datos
    public DbSet<Promocion> Promociones { get; set; }

    public DbSet<Topping> Toppings { get; set; }

    public DbSet<NotificationSubscription> NotificationSubscriptions { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Configuring a many-to-many special -> topping relationship that is friendly for serialization
        modelBuilder.Entity<PizzaTopping>().HasKey(pst => new { pst.PizzaId, pst.ToppingId });
        modelBuilder.Entity<PizzaTopping>().HasOne<Pizza>().WithMany(ps => ps.Toppings);
        modelBuilder.Entity<PizzaTopping>().HasOne(pst => pst.Topping).WithMany();

        // Inline the Lat-Long pairs in Order rather than having a FK to another table
        modelBuilder.Entity<Order>().OwnsOne(o => o.DeliveryLocation);
    }
}