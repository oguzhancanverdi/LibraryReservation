using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Reservations.Commands.Create;

public class CreatedReservationResponse
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public Guid SeatId { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public DateTime CreatedDate { get; set; }
}
