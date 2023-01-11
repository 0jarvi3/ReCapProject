﻿using Core.Utilities;
using Entities.Concrete;

namespace Business.Abstract;

public interface IColorService
{
    IResult Add(Color color);
    IResult Delete(Color color);
    IResult Update(Color color);
    IDataResult<List<Color>?> GetAll();
    IDataResult<Color?> Get(int brandId);
}