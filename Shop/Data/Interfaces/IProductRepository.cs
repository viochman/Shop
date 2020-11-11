using Shop.Data.Models;
using System.Collections.Generic;

namespace Shop.Data.Interfaces
{
    public interface IProductRepository
    {
        IEnumerable<Product> Products { get;}
        IEnumerable<Product> PreferredProducts { get;}
        Product GetProductById(int ProductId);


    }
}
