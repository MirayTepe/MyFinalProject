using Bussiness.Abstract;
using Core.Utilities.Results.Concrete;
using Core.Utilities.Results.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
           _categoryDal = categoryDal;
        }

        public IDataResult<List<Category>> GetAll()
        {
           return new SuccessDataResult<List<Category>>(_categoryDal.GetAll());
        }
        //Select*from Categories where CategoryId=3
        public IDataResult<Category> GetById(int categoryId)
        {
           return new SuccessDataResult<Category> (_categoryDal.Get (c=>c.CategoryID== categoryId));  
        }
    }
}
