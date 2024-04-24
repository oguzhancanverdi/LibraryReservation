using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Tables.Commands.Update;

public class UpdatedTableResponse
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public Guid TableId { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }
}
