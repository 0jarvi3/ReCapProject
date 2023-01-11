using Core.Utilities;
using Entities.Concrete;

namespace Business.Abstract;

public interface IBrandService
{
    IResult Add(Brand brand);
    IResult Delete(Brand brand);
    IResult Update(Brand brand);
    IDataResult<List<Brand>?> GetAll();
    IDataResult<Brand?> Get(int brandId);
}