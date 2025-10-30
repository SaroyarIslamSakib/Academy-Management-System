﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMS.Domain.Entities
{
    public interface IAggregateRoot<Tkey>
    {
        Tkey Id { get; set; }
    }
}
