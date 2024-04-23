﻿using Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;

public class Table : Entity<Guid>
{
    public int Number { get; set; }
    public bool IsReserved { get; set; }
}