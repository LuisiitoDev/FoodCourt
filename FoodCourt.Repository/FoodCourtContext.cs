using System;
using FoodCourt.Models;
using Microsoft.EntityFrameworkCore;

namespace FoodCourt.Repository
{
	public class FoodCourtContext : DbContext
	{
		public DbSet<RestaurantModel> Restaurants { get; set; }
	}
}

