﻿using DataAccesLayer.Abstract;
using DataAccesLayer.Concrete;
using DataAccesLayer.Repository;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.EfDal
{
    public class EfCitiesDal : GenericRepository<Cities>, ICitiesDal
    {
        public EfCitiesDal(Context context) : base(context) 
        {
            
        }
    }
}
