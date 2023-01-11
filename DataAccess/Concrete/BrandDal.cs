using Core.DataAccess;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete;

public class BrandDal : EntityRepositoryBase<Brand,ReCapContext> , IBrandDal
{
    
}