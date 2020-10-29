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
    public class IndexModel : PageModel
    {
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

        public void OnGet()
        {

        }



    }
}
