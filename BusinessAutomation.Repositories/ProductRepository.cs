using BuisnessAutomation.Database;
using BusinessAutomations.Models.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAutomation.Repositories
{
    public class ProductRepository
    {
        BusinessAutomationDbContext db;
        public ProductRepository() 
        { 
            db = new BusinessAutomationDbContext();
        }
        public bool Add(Product product)
        {
            db.Products.Add(product);
            return db.SaveChanges() > 0;
        }
        public bool AddList(List<Product> products)
        {
            db.Products.AddRange(products);
            return db.SaveChanges()>0;
        }

        public Product GetById(int id)
        {
            var existingProduct = db.Products.FirstOrDefault(x => x.Id == id);
            return existingProduct;
        }

        public bool Update(Product product)
        {
            db.Products.Update(product);
            return db.SaveChanges()>0;
        }
        
    }
}
