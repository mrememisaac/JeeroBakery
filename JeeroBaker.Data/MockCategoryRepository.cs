using JeeroBakery.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JeeroBaker.Data
{
    public class MockCategoryRepository : IRepository<Category>
    {
        private List<Category> _categories => new List<Category>()
        {
            new Category() { Id=1, Name = "Bread"},
            new Category() { Id=2, Name = "Flour Cake"},
            new Category() { Id=3, Name = "Rolls"},
            new Category() { Id=4, Name = "Pies"},
            new Category() { Id=5, Name = "Pancakes"},
            new Category() { Id=6, Name = "Bean Cake"},
        };

        public Category Add(Category entity)
        {
            _categories.Add(entity);
            return entity;
        }

        public int Count()
        {
            return _categories.Count;
        }

        public Category Delete(int id)
        {
            var entity = _categories.FirstOrDefault(x => x.Id == id);
            _categories.Remove(entity);
            return entity;
        }

        public IEnumerable<Category> GetAll()
        {
            return _categories;
        }

        public Category GetById(int id)
        {
            return _categories.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Category> Page(int startPage, int count = 50)
        {
            return _categories.Skip(startPage * count).Take(count);
        }

        public Category Update(Category entity)
        {
            Delete(entity.Id);
            return Add(entity);
        }
    }
}
