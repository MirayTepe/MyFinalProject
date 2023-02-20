using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Abstract
{
    public interface ICategoryService
    {
       IDataResult<List<Category>> GetAll();

       IDataResult<Category> GetById(int categoryId);
      
    }
}
