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
    public Guid SeatId { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }

    public Reservation()
    {
    }

    public Reservation(Guid id, Guid roomId, Guid seatId, DateTime startTime, DateTime endTime) : this()
    {
        Id = id;
        SeatId = seatId;
        StartTime = startTime;
        EndTime = endTime;
    }
}