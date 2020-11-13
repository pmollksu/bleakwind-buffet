using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Drinks;

namespace Website.Pages
{
    [BindProperties(SupportsGet = true)]
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
        /// Minimum filter for price
        /// </summary>
        public double? PriceMin { get; set; }

        /// <summary>
        /// Maximum filter for price
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
        public IEnumerable<IOrderItem> Entrees { get => Menu.Entrees(); }

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
            MenuItems = Menu.All;
            // Search menuItem names or description for the SearchTerms
            if (SearchTerms != null)
            {
                string[] terms = SearchTerms.Split(" ");
                IEnumerable<IOrderItem> results = new List<IOrderItem>();
                List<IOrderItem> resultsList = new List<IOrderItem>();
                foreach (string term in terms)
                {
                    results = MenuItems.Where(menuitem => (menuitem.ToString().Contains(term, StringComparison.InvariantCultureIgnoreCase) || (menuitem.Description.Contains(term, StringComparison.InvariantCultureIgnoreCase))));
                    resultsList.AddRange(results.ToList());                                  
                }
                MenuItems = resultsList; 
            }

            // Filter by item type
            if (ItemTypes != null && ItemTypes.Length != 0)
            {
                MenuItems = MenuItems.Where(menuItem =>
                    (menuItem is Entree &&
                    ItemTypes.Contains("Entree")) || (menuItem is Side &&
                    ItemTypes.Contains("Side")) || (menuItem is Drink &&
                    ItemTypes.Contains("Drink"))
                    );
            }
            // Filter by Calories
            if (CaloriesMax != null && CaloriesMin != null)
            {
                if (CaloriesMax == null)
                {
                    MenuItems = MenuItems.Where(menuItem =>
                    (menuItem.Calories >= CaloriesMin)
                    );
                }

                if (CaloriesMin == null)
                {
                    MenuItems = MenuItems.Where(menuItem =>
                    (menuItem.Calories <= CaloriesMax)
                    );
                }
                else
                {
                    MenuItems = MenuItems.Where(menuItem =>
                    ((menuItem.Calories <= CaloriesMax) && (menuItem.Calories >= CaloriesMin))
                    );
                }

            }
            // Filter by Price
            if (PriceMax != null && PriceMin != null)
            {
                if (PriceMax == null)
                {
                    MenuItems = MenuItems.Where(menuItem =>
                    (menuItem.Price >= PriceMin)
                    );
                }

                if (PriceMin == null)
                {
                    MenuItems = MenuItems.Where(menuItem =>
                    (menuItem.Price <= PriceMax)
                    );
                }
                else
                {
                    MenuItems = MenuItems.Where(menuItem =>
                    ((menuItem.Price <= PriceMax) && (menuItem.Price >= PriceMin))
                    );
                }
            }




        }
    }
}

