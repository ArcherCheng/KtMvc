﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KtMvc.Domain.Models
{
    public abstract class EntityAggregateRootBase<T> : EntityBase<T>, IAggregateRoot
    {
    }
}