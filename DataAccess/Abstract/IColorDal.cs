﻿using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Abstract
{
   public interface IColorDal:IEntityRepository<Color>
   {
       List<ColorDetailsDto> GetColorDetails();
   }
}