using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using BleakwindBuffet.Data;

namespace Website.Pages
{
    [BindProperties(SupportsGet =true)]
    public class IndexModel : PageModel
    {
        /// <summary>
        /// The filtered Menu item types
        /// </summary>
        public string[] ItemTypes { get; set; } = new string[0];

        /// <summary>
        /// Filtered menu items
        /// </summary>
        public IEnumerable<IOrderItem> MenuItems { get; set; }

        /// <summary>
        /// Search string provided
        /// </summary>
        public string SearchTerms { get; set; }

        /// <summary>
        /// Minimum filter for IMDB
        /// </summary>
        public double? PriceMin { get; set; }

        /// <summary>
        /// Maximum filter for IMDB
        /// </summary>
        public double? PriceMax { get; set; }

        /// <summary>
        /// Minimum filter for calories
        /// </summary>
        public int? CaloriesMin { get; set; }

        /// <summary>
        /// Maximum filter for calories
        /// </summary>
        public int? CaloriesMax { get; set; }

        /// <summary>
        /// A list of all entrees
        /// </summary>
        public IEnumerable<IOrderItem> Entrees { get => Menu.Entrees();}

        /// <summary>
        /// A list of all sides
        /// </summary>
        public IEnumerable<IOrderItem> Sides { get => Menu.Sides(); }

        /// <summary>
        /// A list of all drinks
        /// </summary>
        public IEnumerable<IOrderItem> Drinks { get => Menu.Drinks(); }

        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Gets the search results for display on the page
        /// </summary>
        public void OnGet()
        {
            MenuItems = Menu.Search(SearchTerms);
            MenuItems = Menu.FilterByCategory(MenuItems, ItemTypes);
            MenuItems = Menu.FilterByPrice(MenuItems, PriceMin, PriceMax);
            MenuItems = Menu.FilterByCalories(MenuItems, CaloriesMin, CaloriesMax);
        }



    }
}
