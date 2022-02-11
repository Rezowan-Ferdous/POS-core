﻿using BLL.IManagers;
using DAL.IRepositories;
using MODELS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Managers
{
    public class SupplierTypeManager : Manager<SupplierType>, ISupplierTypeManager
    {
        public SupplierTypeManager(ISupplierTypeRepository supplierTypeRepository):base(supplierTypeRepository)
        {

        }
    }
}
