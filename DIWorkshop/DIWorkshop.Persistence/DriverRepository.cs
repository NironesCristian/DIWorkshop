﻿using DIWorkshop.Entities;
using System.Linq;

namespace DIWorkshop.Persistence
{
	public class DriverRepository
	{
		private readonly DbContext _dbContext;

		public DriverRepository(DbContext dbContext)
		{
			_dbContext = dbContext;
		}

		public Driver GetDriver(int id)
		{
			return _dbContext.Drivers.FirstOrDefault(x => x.Id == id);
		}
	}
}
