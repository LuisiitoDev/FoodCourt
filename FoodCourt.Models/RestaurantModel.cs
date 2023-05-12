using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodCourt.Models;

public class RestaurantModel
{
	public long RestaurantId { get; set; }
	public string? Name { get; set; }
	public string? Description { get; set; }
	public string? Telephone { get; set; }
	public DateTime CreatedDate { get; set; }
}

