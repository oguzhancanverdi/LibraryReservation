using Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;

public class Seat : Entity<Guid>
{
	public string Name { get; set; }
	public Guid TableId { get; set; }
	public bool IsReserved { get; set; }

	public virtual Table? Table { get; set; }

	public Seat()
	{
	}

	public Seat(Guid id, string name, Guid tableId, bool isReserved) : this()
	{
		Id = id;
		Name = name;
		TableId = tableId;
		IsReserved = isReserved;
	}
}
