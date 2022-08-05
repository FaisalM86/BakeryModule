using System;
using System.Collections.Generic;

namespace BakeryModue.Domain
{
	public class Recipe
	{
		public Guid ID { get; set; }
		public string Name { get; set; }
		public  DateTime RegistrationDate { get; set; }
		public  Enumerations.ProductType  ProductType { get; set; }
		public  Ingredient Ingredient { get; set; }
		public Guid IngredientId { get; set; }
	}

	public class DbContextExample
	{
		public  List<Recipe> DbRecipes { get; set; }
		public  List<Ingredient> DbIngredients { get; set; }
	}
}
