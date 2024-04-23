using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Rooms.Queries.GetList;

public class GetListRoomListItemDto
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public int Capacity { get; set; }
}
