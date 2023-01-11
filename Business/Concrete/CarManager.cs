using Business.Abstract;
using Business.Constants;
using Core.Utilities;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Concrete;

public class CarManager : ICarService
{
    private ICarDal _carDal;

    public CarManager(ICarDal carDal)
    {
        _carDal = carDal;
    }

    public IResult Add(Car car)
    {
        _carDal.Add(car);
        return new SuccessResult(Messages.CarAdded);
    }

    public IResult Delete(Car car)
    {
        _carDal.Delete(car);
        return new SuccessResult(Messages.CarDeleted);
    }

    public IResult Update(Car car)
    {
        _carDal.Update(car);
        return new SuccessResult(Messages.CarUpdated);
    }

    public IDataResult<List<Car>?> GetAll()
    {
        var result = _carDal.GetAll();
        return new SuccessDataResult<List<Car>?>(result);
    }

    public IDataResult<Car?> Get(int carId)
    {
        var result = _carDal.Get(p => p.Id == carId);
        return new SuccessDataResult<Car?>(result);
    }

    public IDataResult<List<Car>?> GetByColorId(int colorId)
    {
        var result = _carDal.GetAll(p => p.ColorId == colorId);
        return new SuccessDataResult<List<Car>?>(result);
    }

    public IDataResult<List<Car>?> GetByBrandId(int brandId)
    {
        var result = _carDal.GetAll(p => p.BrandId == brandId);
        return new SuccessDataResult<List<Car>?>(result);
    }

    public IDataResult<List<CarDetailsDto>?> GetCarDetails()
    {
        var result = _carDal.GetCarDetails();
        return new SuccessDataResult<List<CarDetailsDto>?>(result);
    }
}