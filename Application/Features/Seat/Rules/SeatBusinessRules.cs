using Application.Features.Seats.Constants;
using Application.Services.Repositories;
using Core.Application.Rules;
using Core.CrossCuttingConcerns.Exceptions.Types;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Seats.Rules;

public class SeatBusinessRules : BaseBusinessRules
{
	private readonly ISeatRepository _SeatRepository;

	public SeatBusinessRules(ISeatRepository SeatRepository)
	{
		_SeatRepository = SeatRepository;
	}

	public async Task SeatNameCannotBeDuplicatedWhenInserted(string name)
	{
		Seat? result = await _SeatRepository.GetAsync(predicate: b => b.Name.ToLower() == name.ToLower());

		if (result != null)
		{
			throw new BusinessException(SeatsMessages.SeatNameExists);
		}
	}

	public async Task SeatReserved(Guid id)
	{
		Seat? result = await _SeatRepository.GetAsync(predicate: b => b.Id == id && b.IsReserved);

		if (result != null)
		{
			throw new BusinessException(SeatsMessages.SeatReserved);
		}
	}
}
