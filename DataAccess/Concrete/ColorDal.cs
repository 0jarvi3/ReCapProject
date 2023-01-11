using Core.DataAccess;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete;

public class ColorDal : EntityRepositoryBase<Color,ReCapContext> , IColorDal
{
    
}