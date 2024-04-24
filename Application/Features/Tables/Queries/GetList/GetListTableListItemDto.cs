using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Tables.Queries.GetList;

public class GetListTableListItemDto
{
    public Guid Id { get; set; }
    public int Number { get; set; }
    public Guid RoomId { get; set; }
}
