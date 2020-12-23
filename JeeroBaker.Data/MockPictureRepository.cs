using JeeroBakery.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JeeroBaker.Data
{
    public class MockPictureRepository : IRepository<Picture>
    {
        private List<Picture> _pictures = new List<Picture>()
        {
            new Picture(){ ProductId=1, Path="", Type = ImageType.Standard, View = ImageView.Mixed },
            new Picture(){ ProductId=2, Path="", Type = ImageType.Standard, View = ImageView.Mixed },
        };

        public Picture Add(Picture entity)
        {
            _pictures.Add(entity);
            return entity;
        }

        public int Count() => _pictures.Count;

        public Picture Delete(int id)
        {
            var entity = GetById(id);
            _pictures.Remove(entity);
            return entity;
        }

        public IEnumerable<Picture> GetAll()
        {
            return _pictures;
        }

        public Picture GetById(int id)
        {
            return _pictures.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Picture> Page(int startPage, int count = 50)
        {
            return _pictures.Skip(startPage * count).Take(count);
        }

        public Picture Update(Picture entity)
        {
            Delete(entity.Id);
            return Add(entity);
        }
    }
}
