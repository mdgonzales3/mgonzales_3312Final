using Microsoft.EntityFrameworkCore;
namespace RestaurantASP.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RestaurantDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<RestaurantDbContext>>()))
            {
                // Look for any proffesors.
                if (context.Restaurants.Any())
                {
                    return; // DB has been seeded
                }
                
                context.Restaurants.AddRange(
                    new Restaurant
                    {
                        RestaurantName = "Beef O Brady's",
                        Location = "Lubbock",
                    },
                   new Restaurant
                    {
                        RestaurantName = "50th Street Caboose",
                        Location = "Lubbock",
                    },
                    new Restaurant
                    {
                        RestaurantName = "",
                        Location = "",
                    },
                    new Restaurant
                    {
                        RestaurantName = "Wing King",
                        Location = "Brownfield",
                    },
                    new Restaurant
                    {
                        RestaurantName = "Brooklyn Pizzeria",
                        Location = "Lubbock",
                    },
                    new Restaurant
                    {
                        RestaurantName = "Papa V Pizza",
                        Location = "Lubbock",
                    },
                    new Restaurant
                    {
                        RestaurantName = "Drylands",
                        Location = "Hobbs",
                    },
                    new Restaurant
                    {
                        RestaurantName = "Silver Bullet Saloon",
                        Location = "Lubbock",
                    },
                    new Restaurant
                    {
                        RestaurantName = "Pepe's Pizza and Ice Cream",
                        Location = "Lubbock",
                    },
                    new Restaurant
                    {
                        RestaurantName = "Lubbock Breakfast House",
                        Location = "Lubbock",
                    },
                    new Restaurant
                    {
                        RestaurantName = "Teddy Jacks",
                        Location = "Lubbock",
                    },
                    new Restaurant
                    {
                        RestaurantName = "Urban Bricks",
                        Location = "Lubbock",
                    },
                    new Restaurant
                    {
                        RestaurantName = "The Spoon",
                        Location = "Lubbock",
                    },
                    new Restaurant
                    {
                        RestaurantName = "King Louie's",
                        Location = "Lubbock",
                    },
                    new Restaurant
                    {
                        RestaurantName = "Shotzy's",
                        Location = "Lubbock",
                    },
                    new Restaurant
                    {
                        RestaurantName = "Buffalo Bros",
                        Location = "Fort Worth",
                    },
                    new Restaurant
                    {
                        RestaurantName = "Kelly's Craft Tavern",
                        Location = "Allen",
                    },
                    new Restaurant
                    {
                        RestaurantName = "Wingstop",
                        Location = "Lubbock",
                    },
                    new Restaurant
                    {
                        RestaurantName = "Longhorn Steakhouse",
                        Location = "Lubbock",
                    },
                    new Restaurant
                    {
                        RestaurantName = "Wayne's Wings",
                        Location = "San Antonio",
                    },
                    new Restaurant
                    {
                        RestaurantName = "Track One",
                        Location = "El Paso",
                    },
                    new Restaurant
                    {
                        RestaurantName = "Duff's Famous Wings",
                        Location = "Southlake",
                    },
                    new Restaurant
                    {
                        RestaurantName = "Mike's Chicken",
                        Location = "Dallas",
                    },
                    new Restaurant
                    {
                        RestaurantName = "Wings 'n More",
                        Location = "College Station",
                    },
                    new Restaurant
                    {
                        RestaurantName = "WingIT",
                        Location = "San Antonio",
                    }
                );
                
                context.SaveChanges();
            }
        }
    }
}
