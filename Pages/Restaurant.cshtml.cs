using Microsoft.EntityFrameworkCore;
using RestaurantASP.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace mgonzales_3312Final_1.Pages
{
    public class RestaurantModel : PageModel
    {
        private readonly RestaurantDbContext _context; // Replaces the "db" variable from before

        private readonly ILogger<RestaurantModel> _logger;

        public List<Restaurant> Restaurants {get; set;} = default!;

        public RestaurantModel(RestaurantDbContext context, ILogger<RestaurantModel> logger)
        {
            _context = context;
            _logger = logger;
        }
        public void OnGet()
        {
            Restaurants = _context.Restaurants.ToList();

        }
    }
}
