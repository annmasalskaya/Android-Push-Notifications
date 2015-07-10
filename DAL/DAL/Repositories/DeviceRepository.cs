﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using DAL.Entites;

namespace DAL.Repositories
{
    public class DeviceRepository: GenericRepository<Device>
    {
        public DeviceRepository(DbContext context)
            : base(context)
        {

        }
    }
}
