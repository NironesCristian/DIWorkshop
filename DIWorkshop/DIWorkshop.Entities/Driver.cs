﻿namespace DIWorkshop.Entities
{
	public class Driver
	{
		public int Id { get; set; }

		public string Firstname { get; set; }

		public string Lastname { get; set; }

		public Car Car { get; set; }
	}
}
