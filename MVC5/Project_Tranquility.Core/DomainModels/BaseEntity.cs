﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Tranquility.Core.DomainModels
{
    public abstract class BaseEntity
    {
        public virtual int Id { get; set; }
    }
}
