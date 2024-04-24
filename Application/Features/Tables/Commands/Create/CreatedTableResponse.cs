﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Tables.Commands.Create;

public class CreatedTableResponse
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public Guid TableId { get; set; }
    public DateTime CreatedDate { get; set; }
}
