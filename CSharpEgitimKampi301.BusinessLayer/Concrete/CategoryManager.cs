using CSharpEgitimKampi301.BusinessLayer.Abstract;
using CSharpEgitimKampi301.DataAccessLayer.Abstract;
using CSharpEgitimKampi301.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryDal _categroyDal;

        public CategoryManager(ICategoryDal categroyDal)
        {
            _categroyDal = categroyDal;
        }

        public List<Category> GetAll()
        {
            return _categroyDal.GetAll();
        }

        public void TDelete(Category entity)
        {
           _categroyDal.Delete(entity);
        }

        public Category TGetById(int id)
        {
            return _categroyDal.GetById(id);
        }

        public void TInsert(Category entity)
        {
            _categroyDal.Insert(entity);
        }

        public void TUpdate(Category entity)
        {
            _categroyDal.Update(entity);
        }
    }
}
