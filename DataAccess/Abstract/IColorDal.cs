﻿using System;
using System.Collections.Generic;
using Entities.Concrete;
using System.Text;
using Core.DataAccess;

namespace DataAccess.Abstract
{
    public interface IColorDal:IEntityRepository<Color>
    {
    }
}
