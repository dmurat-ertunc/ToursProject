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
    public class EfContactsDal : GenericRepository<Contact>, IContactsDal
    {
        public EfContactsDal(Context context) : base(context)
        {

        }
    }
}
