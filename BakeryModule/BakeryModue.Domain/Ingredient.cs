using System;
using System.Collections.Generic;

namespace BakeryModue.Domain
{
	public class Ingredient
	{
		public Guid ID { get; set; }
		public string Name { get; set; }
		public  double Grams { get; set; }
		public  List<Recipe> Recipes { get; set; }
	}
}

