using Core.Utilities;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract;

public interface ICarService
{
    IResult Add(Car car);
    IResult Delete(Car car);
    IResult Update(Car car);
    IDataResult<List<Car>?> GetAll();
    IDataResult<Car?> Get(int carId);
    IDataResult<List<Car>?> GetByColorId(int colorId);
    IDataResult<List<Car>?> GetByBrandId(int brandId);
    IDataResult<List<CarDetailsDto>?> GetCarDetails();

}