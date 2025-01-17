using CSharpEgitimKampi301.DataAccessLayer.Abstract;
using CSharpEgitimKampi301.DataAccessLayer.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CSharpEgitimKampi301.DataAccessLayer.Repositories
{
    public class GenericRepository<t> : IGenericDal<t> where t : class
    {   KampContext context = new KampContext();
        private readonly DbSet<t> _object;
        public GenericRepository()
        {
            _object = context.Set<t>();
        }
        public void Delete(t entity)
        {
          var deletedEntity=context.Entry(entity);
            deletedEntity.State = EntityState.Deleted;
            context.SaveChanges();
        }

        public List<t> GetAll()
        {
            return _object.ToList();
        }

        public t GetById(int id)
        {
            return _object.Find(id);

        }

        public void Insert(t entity)
        {
           var addedEntity=context.Entry(entity);
            addedEntity.State = EntityState.Added;
            context.SaveChanges();
        }

        public void Update(t entity)
        {
            var updateEntity = context.Entry(entity);
            updateEntity.State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}
