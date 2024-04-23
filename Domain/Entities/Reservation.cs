using Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;

public class Reservation : Entity<Guid>
{
    public Guid UserId { get; set; }
    public Guid TableId { get; set; }
    public DateTime Time { get; set; }

    public Reservation()
    {
    }

    public Reservation(Guid id, Guid roomId, Guid tableId, DateTime time) : this()
    {
        Id = id;
        TableId = tableId;
        Time = time;
    }
}