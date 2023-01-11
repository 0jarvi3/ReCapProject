using Core.DataAccess;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete;

public class CarDal : EntityRepositoryBase<Car,ReCapContext> , ICarDal
{
    public List<CarDetailsDto> GetCarDetails()
    {
        using (ReCapContext context = new ReCapContext())
        {
            var result = from car in context.Cars
                join color in context.Colors on car.ColorId equals color.Id
                join brand in context.Brands on car.BrandId equals brand.Id
                select new CarDetailsDto
                {
                    CarId = car.Id,
                    CarName = car.Name,
                    CarDescription = car.Description,
                    DailyPrice = car.DailyPrice,
                    ModelYear = car.ModelYear,
                    BrandName = brand.Name,
                    ColorName = color.Name
                };
            return result.ToList();
        }
    }

    public CarDetailsDto GetCarDetail(int carId)
    {
        throw new NotImplementedException();
    }
}