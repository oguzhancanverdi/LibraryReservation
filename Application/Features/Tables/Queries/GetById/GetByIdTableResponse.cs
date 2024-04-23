using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Tables.Queries.GetById;

public class GetByIdTableResponse
{
    public Guid Id { get; set; }
    public int Number { get; set; }
    public bool IsReserved { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime? UpdatedDate { get; set; }
    public DateTime? DeletedDate { get; set; }
}
