using Application.Features.Tables.Constants;
using Application.Services.Repositories;
using Core.Application.Rules;
using Core.CrossCuttingConcerns.Exceptions.Types;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Tables.Rules;

public class TableBusinessRules : BaseBusinessRules
{
    private readonly ITableRepository _TableRepository;

    public TableBusinessRules(ITableRepository TableRepository)
    {
        _TableRepository = TableRepository;
    }

    public async Task TableNumberCannotBeDuplicatedWhenInserted(int number)
    {
        Table? result = await _TableRepository.GetAsync(predicate: b => b.Number == number);

        if (result != null)
        {
            throw new BusinessException(TablesMessages.TableNumberExists);
        }
    }
}

