using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;

public class Reservation : Entity<Guid>
{
    public string Name { get; set; }

    public Reservation()
    {
    }

    public Reservation(Guid id, string name) : this()
    {
        Id = id;
        Name = name;
    }
}
