using Microsoft.EntityFrameworkCore;
using OnlineBookStore.Models;

namespace OnlineBookStore.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            StoreDbContext context = app.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<StoreDbContext>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if (!context.Books.Any())
            {
                context.Books.AddRange(
                    new Book
                    {
                        Title = "Chainsaw Man",
                        Description = "Episode 10",
                        Supplier = "NXB Tre",
                        Category = "Action",
                        Price = 40500
                    },
                    new Book
                    {
                        Title = "BlueLock",
                        Description = "Episode 4",
                        Supplier = "NXB Kim Dong",
                        Category = "Sports",
                        Price = 30800
                    },
                     new Book
                     {
                         Title = "Weathering with you",
                         Description = "Weathering with you light novel",
                         Supplier = "NXB Ha Noi",
                         Category = "Romantic",
                         Price = 68000
                     },
                     new Book
                     {
                         Title = "5 cm/s",
                         Description = "5 centimeters on second light novel",
                         Supplier = "NXB Hong Duc",
                         Category = "Romantic",
                         Price = 48000
                     },
                     new Book
                     {
                         Title = "Your Name",
                         Description = "Light novel",
                         Supplier = "NXB Hong Duc",
                         Category = "Romantic",
                         Price = 79500
                     },
                     new Book
                     {
                         Title = "Pokemon Special 64",
                         Description = "Variety of Pokemon",
                         Supplier = "NXB Kim Dong",
                         Category = "Adventure,",
                         Price = 40500
                     },
                     new Book
                     {
                         Title = "Naruto",
                         Description = "Episode 1: Uzumaki Naruto",
                         Supplier = "NXB Kim Dong",
                         Category = "Fantasy",
                         Price = 27000
                     },
                     new Book
                     {
                         Title = "Jujutsu Kaisen",
                         Description = "Episode 2",
                         Supplier = "NXB Kim Dong",
                         Category = "Action",
                         Price = 27000
                     },
                     new Book
                     {
                         Title = "HORIMIYA",
                         Description = "Episode 16",
                         Supplier = "NXB Hong Duc",
                         Category = "Romantic",
                         Price = 42500
                     }
                    );
                context.SaveChanges();
            }
        }
    }
}
