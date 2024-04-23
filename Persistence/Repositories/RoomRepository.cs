using Application.Services.Repositories;
using Core.Persistence.Repositories;
using Domain.Entities;
using Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories;

public class RoomRepository : EfRepositoryBase<Room, Guid, BaseDbContext>, IRoomRepository
{
    public RoomRepository(BaseDbContext context) : base(context)
    {

    }
}
