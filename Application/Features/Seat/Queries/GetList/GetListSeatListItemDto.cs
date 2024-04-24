using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Seats.Queries.GetList;

public class GetListSeatListItemDto
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public Guid TableId { get; set; }
	public bool IsReserved { get; set; }
}
