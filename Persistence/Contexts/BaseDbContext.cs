using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Contexts;

public class BaseDbContext : DbContext
{
	protected IConfiguration Configuration { get; set; }
	public DbSet<Reservation> Reservations { get; set; }
	public DbSet<Room> Rooms { get; set; }
	public DbSet<Table> Tables { get; set; }
	public DbSet<User> Users { get; set; }
	public DbSet<Seat> Seats { get; set; }

	public BaseDbContext(DbContextOptions dbContextOptions, IConfiguration configuration) : base(dbContextOptions)
	{
		Configuration = configuration;
		Database.EnsureCreated();
	}

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

		#region Dummy Data

		#region Rooms
		modelBuilder.Entity<Room>().HasData(
			new Room() { Id = new Guid("ce5d4dd5-73c4-4612-8616-0895c845c584"), Capacity = 8, Name = "Salon 1", CreatedDate = DateTime.UtcNow },
			new Room() { Id = new Guid("1d6d393e-cdec-4b50-b8e7-d1f7d70b12f6"), Capacity = 5, Name = "Salon 2" }
		);
		#endregion

		#region Tables
		modelBuilder.Entity<Table>().HasData(
				new Table() { Id = new Guid("ccc5c724-de7e-447b-bb56-e48af49b76fd"), Number = 1, RoomId = new Guid("ce5d4dd5-73c4-4612-8616-0895c845c584"), CreatedDate = DateTime.UtcNow },
				new Table() { Id = new Guid("8546b44f-a2e9-4230-bf03-5e10a35634a0"), Number = 2, RoomId = new Guid("ce5d4dd5-73c4-4612-8616-0895c845c584"), CreatedDate = DateTime.UtcNow },
				new Table() { Id = new Guid("6e370b8a-f7d8-43d0-a9aa-a56156268237"), Number = 3, RoomId = new Guid("ce5d4dd5-73c4-4612-8616-0895c845c584"), CreatedDate = DateTime.UtcNow },
				new Table() { Id = new Guid("352b7cc2-e0b8-4eee-a710-8bb9a1c457c6"), Number = 4, RoomId = new Guid("ce5d4dd5-73c4-4612-8616-0895c845c584"), CreatedDate = DateTime.UtcNow },
				new Table() { Id = new Guid("0e0b6a62-42ae-4c40-9739-7e95c23e6b4e"), Number = 5, RoomId = new Guid("ce5d4dd5-73c4-4612-8616-0895c845c584"), CreatedDate = DateTime.UtcNow },
				new Table() { Id = new Guid("2d43b3b4-6b1b-470e-82f7-2e84b424d34c"), Number = 6, RoomId = new Guid("ce5d4dd5-73c4-4612-8616-0895c845c584"), CreatedDate = DateTime.UtcNow },
				new Table() { Id = new Guid("0d59c258-7038-4da1-9b95-ff693b5d050c"), Number = 7, RoomId = new Guid("ce5d4dd5-73c4-4612-8616-0895c845c584"), CreatedDate = DateTime.UtcNow },
				new Table() { Id = new Guid("fe2134b3-c415-4e6d-917c-e9b652d3657a"), Number = 8, RoomId = new Guid("ce5d4dd5-73c4-4612-8616-0895c845c584"), CreatedDate = DateTime.UtcNow },

				new Table() { Id = new Guid("823ffbf8-4488-4bbd-a7ad-455414ac9015"), Number = 1, RoomId = new Guid("1d6d393e-cdec-4b50-b8e7-d1f7d70b12f6"), CreatedDate = DateTime.UtcNow },
				new Table() { Id = new Guid("407a043c-44e5-4315-85e1-697b44d5bbc2"), Number = 2, RoomId = new Guid("1d6d393e-cdec-4b50-b8e7-d1f7d70b12f6"), CreatedDate = DateTime.UtcNow },
				new Table() { Id = new Guid("c6fd7999-3e5e-425c-9efd-3a290c4c7a97"), Number = 3, RoomId = new Guid("1d6d393e-cdec-4b50-b8e7-d1f7d70b12f6"), CreatedDate = DateTime.UtcNow },
				new Table() { Id = new Guid("4953a8fa-782e-474d-a556-47a225111a20"), Number = 4, RoomId = new Guid("1d6d393e-cdec-4b50-b8e7-d1f7d70b12f6"), CreatedDate = DateTime.UtcNow },
				new Table() { Id = new Guid("90a81b07-3120-4510-a139-3d9ae9f3a6f9"), Number = 5, RoomId = new Guid("1d6d393e-cdec-4b50-b8e7-d1f7d70b12f6"), CreatedDate = DateTime.UtcNow }
			);
		#endregion

		#region Seats

		modelBuilder.Entity<Seat>().HasData(
			new Seat() { Id = new Guid("caef130f-19e4-4c56-ac2e-4e7663c77903"), TableId = new Guid("ccc5c724-de7e-447b-bb56-e48af49b76fd"), Name = "1A", IsReserved = false },
			new Seat() { Id = new Guid("15d5e543-844d-4fe6-a273-db0d2c1a96b6"), TableId = new Guid("ccc5c724-de7e-447b-bb56-e48af49b76fd"), Name = "1B", IsReserved = false },
			new Seat() { Id = new Guid("89a2e1bf-6347-41b8-b3fb-b6bc33e93db8"), TableId = new Guid("8546b44f-a2e9-4230-bf03-5e10a35634a0"), Name = "2A", IsReserved = false },
			new Seat() { Id = new Guid("23b94c8d-5e8c-4fcb-97ab-acaa9528a02d"), TableId = new Guid("8546b44f-a2e9-4230-bf03-5e10a35634a0"), Name = "2B", IsReserved = false },
			new Seat() { Id = new Guid("72ed544d-fe60-4393-aa7e-cb730119c49e"), TableId = new Guid("6e370b8a-f7d8-43d0-a9aa-a56156268237"), Name = "3A", IsReserved = false },
			new Seat() { Id = new Guid("a4169076-6678-4eac-a950-f0f19e4953f5"), TableId = new Guid("6e370b8a-f7d8-43d0-a9aa-a56156268237"), Name = "3B", IsReserved = false },
			new Seat() { Id = new Guid("862ada42-60cc-4109-959e-5dd3a5ebe391"), TableId = new Guid("352b7cc2-e0b8-4eee-a710-8bb9a1c457c6"), Name = "4A", IsReserved = false },
			new Seat() { Id = new Guid("4290b5b5-e8d6-44f6-aa58-675c3fd19916"), TableId = new Guid("352b7cc2-e0b8-4eee-a710-8bb9a1c457c6"), Name = "4B", IsReserved = false },
			new Seat() { Id = new Guid("1a1e29e0-d086-451b-923b-9ce56e9200f4"), TableId = new Guid("0e0b6a62-42ae-4c40-9739-7e95c23e6b4e"), Name = "5A", IsReserved = false },
			new Seat() { Id = new Guid("83811700-07f4-483d-88ad-f95ff7b93120"), TableId = new Guid("0e0b6a62-42ae-4c40-9739-7e95c23e6b4e"), Name = "5B", IsReserved = false },
			new Seat() { Id = new Guid("c8a5d646-db65-45c4-a31c-93dd05bcd9b2"), TableId = new Guid("2d43b3b4-6b1b-470e-82f7-2e84b424d34c"), Name = "6A", IsReserved = false },
			new Seat() { Id = new Guid("763312a3-305c-42e0-b2fc-923066298a97"), TableId = new Guid("2d43b3b4-6b1b-470e-82f7-2e84b424d34c"), Name = "6B", IsReserved = false },
			new Seat() { Id = new Guid("7ac7adea-e04f-4ad3-b349-964d28b3bc27"), TableId = new Guid("0d59c258-7038-4da1-9b95-ff693b5d050c"), Name = "7A", IsReserved = false },
			new Seat() { Id = new Guid("fef0ba82-4e8f-43cb-bbc5-6a51e185c80d"), TableId = new Guid("0d59c258-7038-4da1-9b95-ff693b5d050c"), Name = "7B", IsReserved = false },
			new Seat() { Id = new Guid("9c77540d-c6c1-44d1-9264-abe06003c7be"), TableId = new Guid("fe2134b3-c415-4e6d-917c-e9b652d3657a"), Name = "8A", IsReserved = false },
			new Seat() { Id = new Guid("37571e34-a8f0-4cb4-b778-07374aa9197a"), TableId = new Guid("fe2134b3-c415-4e6d-917c-e9b652d3657a"), Name = "8B", IsReserved = false },

			new Seat() { Id = new Guid("b4247322-7880-4672-af56-1548e39eb445"), TableId = new Guid("823ffbf8-4488-4bbd-a7ad-455414ac9015"), Name = "1A", IsReserved = false },
			new Seat() { Id = new Guid("1d43e535-1622-4528-b29f-6911dc919f41"), TableId = new Guid("823ffbf8-4488-4bbd-a7ad-455414ac9015"), Name = "1B", IsReserved = false },
			new Seat() { Id = new Guid("66513f72-c4ce-4c27-8a68-083ef98f6272"), TableId = new Guid("407a043c-44e5-4315-85e1-697b44d5bbc2"), Name = "2A", IsReserved = false },
			new Seat() { Id = new Guid("a0e4386d-f5d6-4313-92d5-3bcd37698a08"), TableId = new Guid("407a043c-44e5-4315-85e1-697b44d5bbc2"), Name = "2B", IsReserved = false },
			new Seat() { Id = new Guid("06d90e0f-46e2-466e-8e33-d03328dd6caa"), TableId = new Guid("c6fd7999-3e5e-425c-9efd-3a290c4c7a97"), Name = "3A", IsReserved = false },
			new Seat() { Id = new Guid("eabd269d-f1ea-47d2-9581-3335e3b6eff9"), TableId = new Guid("c6fd7999-3e5e-425c-9efd-3a290c4c7a97"), Name = "3B", IsReserved = false },
			new Seat() { Id = new Guid("6981fdce-2b22-4b9b-be1f-412ce1aa216c"), TableId = new Guid("4953a8fa-782e-474d-a556-47a225111a20"), Name = "4A", IsReserved = false },
			new Seat() { Id = new Guid("5f55c452-66d0-4e2d-9a6b-2b8853fb84f8"), TableId = new Guid("4953a8fa-782e-474d-a556-47a225111a20"), Name = "4B", IsReserved = false },
			new Seat() { Id = new Guid("143c5800-7219-4607-8a39-2d5653593787"), TableId = new Guid("90a81b07-3120-4510-a139-3d9ae9f3a6f9"), Name = "5A", IsReserved = false },
			new Seat() { Id = new Guid("9fa5bbe3-0d2d-4155-919c-1aead14fdf86"), TableId = new Guid("90a81b07-3120-4510-a139-3d9ae9f3a6f9"), Name = "5B", IsReserved = false }
			);

		#endregion

		#region Users

		modelBuilder.Entity<User>().HasData(
				new User() { Id = new Guid("81c202d7-de16-487b-8d2f-f76d7c6f5731"), FirstName = "Deneme", LastName = "Deneme", UserName = "Deneme", Password = "Deneme", CreatedDate = DateTime.UtcNow },
				new User() { Id = new Guid("0342d92e-7075-4e46-a873-a2df245635c8"), FirstName = "Deneme1", LastName = "Deneme1", UserName = "Deneme1", Password = "Deneme1", CreatedDate = DateTime.UtcNow }
			);

		#endregion

		#endregion

	}
}
