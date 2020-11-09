using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Data.Interfaces
{
    public interface IProductRepository
    {
        IEnumerable<Product> Products { get;}
        IEnumerable<Product> PreferredProducts { get;}
        Product GetProductById(int ProductId);


    }
}
