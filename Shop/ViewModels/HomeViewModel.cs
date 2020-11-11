using Shop.Data.Models;
using System.Collections.Generic;

namespace Shop.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Product> PreferredProducts { get; set; }
    }
}
