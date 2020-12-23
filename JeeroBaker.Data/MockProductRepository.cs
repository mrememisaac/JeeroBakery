using JeeroBakery.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace JeeroBaker.Data
{
    public class MockProductRepository : IRepository<Product>
    {
        private List<Product> _products => new List<Product>()
        {
            new Product(){ Id=1, Name = "Handy Loaf", Description="For a nice quick snack", Price=100, CategoryId=1 },
            new Product(){ Id=2, Name = "Family Loaf", Description="For a happy family breakfast", Price=500, CategoryId=1 }
        };

        public Product Add(Product entity)
        {
            _products.Add(entity);
            return entity;
        }

        public int Count()
        {
            return _products.Count();
        }

        public Product Delete(int id)
        {
            var entity = GetById(id);
            _products.Remove(entity);
            return entity;
        }

        public IEnumerable<Product> GetAll()
        {
            return _products;
        }

        public Product GetById(int id)
        {
            return _products.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Product> Page(int startPage, int count = 50)
        {
            return _products.Skip(startPage * count).Take(count);
        }

        public Product Update(Product entity)
        {
            Delete(entity.Id);
            return Add(entity);
        }
    }
}
