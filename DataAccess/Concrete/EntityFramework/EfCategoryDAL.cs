using System;
using System.Collections.Generic;
using System.Text;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework.Contexts
{
    public class EfCategoryDAL:EfEntityRepositoryBase<Category, NorthwindContext>, ICategoryDAL
    {
    }
}
