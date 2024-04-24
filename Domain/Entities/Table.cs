using Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;

public class Table : Entity<Guid>
{
	public int Number { get; set; }
	public Guid RoomId { get; set; }

	public virtual Room? Room { get; set; }
	public virtual ICollection<Seat> Seats { get; set; }

	public Table()
	{
		Seats = new HashSet<Seat>();
	}

	public Table(Guid id, int number, Guid roomId)
	{
		Id = id;
		Number = number;
		RoomId = roomId;
	}
}