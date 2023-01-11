using Business.Abstract;
using Business.Constants;
using Core.Utilities;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete;

public class ColorManager : IColorService
{
    private IColorDal _colorDal;

    public ColorManager(IColorDal colorDal)
    {
        _colorDal = colorDal;
    }

    public IResult Add(Color color)
    {
        _colorDal.Add(color);
        return new SuccessResult(Messages.ColorAdded);
    }

    public IResult Delete(Color color)
    {
        _colorDal.Delete(color);
        return new SuccessResult(Messages.ColorDeleted);
    }

    public IResult Update(Color color)
    {
        _colorDal.Update(color);
        return new SuccessResult(Messages.ColorUpdated);
    }

    public IDataResult<List<Color>?> GetAll()
    {
        var result = _colorDal.GetAll();
        return new SuccessDataResult<List<Color>?>(result);
    }

    public IDataResult<Color?> Get(int brandId)
    {
        var result = _colorDal.Get(p => p.Id == brandId);
        return new SuccessDataResult<Color?>(result);
    }
}