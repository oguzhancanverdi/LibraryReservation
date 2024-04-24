﻿using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.EntityConfigurations;

public class SeatConfiguration : IEntityTypeConfiguration<Seat>
{
	public void Configure(EntityTypeBuilder<Seat> builder)
	{
		builder.ToTable("Seats").HasKey(b => b.Id);

		builder.Property(b => b.Id).HasColumnName("Id").IsRequired();
		builder.Property(b => b.Name).HasColumnName("Name").IsRequired();
		builder.Property(b => b.TableId).HasColumnName("TableId").IsRequired();
		builder.Property(b => b.IsReserved).HasColumnName("IsReserved").IsRequired();
		builder.Property(b => b.CreatedDate).HasColumnName("CreatedDate").IsRequired();
		builder.Property(b => b.UpdatedDate).HasColumnName("UpdatedDate");
		builder.Property(b => b.DeletedDate).HasColumnName("DeletedDate");

		builder.HasQueryFilter(b => !b.DeletedDate.HasValue);
	}
}
