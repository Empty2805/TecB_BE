using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WanoSoft_TecB.Models;

namespace WanoSoft_TecB.Repository
{
    public interface IProductRepository
    {
        public void DeleteProduct(int ProductId);
        public Product GetProductByID(int productId);
        public IEnumerable<Product> GetProducts();
        public void InsertProduct(Product product);
        public void Save();
        public void UpdateProduct(Product product);
    }
}
