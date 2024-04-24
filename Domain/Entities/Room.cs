using Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;

public class Room : Entity<Guid>
{
    public string Name { get; set; }
    public int Capacity { get; set; }

	public virtual ICollection<Table> Tables { get; set; }

	public Room()
    {
		Tables = new HashSet<Table>();
	}

    public Room(Guid id, string name, int capacity) : this()
    {
        Id = id;
        Name = name;
        Capacity = capacity;
    }
}