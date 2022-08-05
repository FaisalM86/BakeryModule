using System;
using BakeryModue.Domain;
using System.Collections.Generic;

namespace BakeryModule.Service
{
	public interface IRecipeService
	{
		public void InsertRecipe(string name, Enumerations.ProductType productType);
		public List<Recipe> GetRecipesByProductClassification(Enumerations.ProductType productType);
		public List<Recipe> GetRecipesByDates(DateTime startDate, DateTime endDate);
		public bool CheckReceipeInventory(Enumerations.ProductType productType, int requiredQuantity);

	}
}
