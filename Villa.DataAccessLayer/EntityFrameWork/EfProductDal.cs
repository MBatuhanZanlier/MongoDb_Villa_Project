﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Villa.DataAccessLayer.Context;
using Villa.EntityLayer.Entities;
using Villa.DataAccessLayer.Repositories;
using Villa.DataAccessLayer.Abstract;

namespace Villa.DataAccessLayer.EntityFrameWork
{
    public class EfProductDal : GenericRepository<Product>,IProductDal
    {
        public EfProductDal(VillaContext context) : base(context)
        {
        }
    }
}