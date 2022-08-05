using BakeryModue.Domain;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BakeryModule.Service
{
	public class RecipeService
	{
		public void InsertRecipe(string name, Enumerations.ProductType productType)
		{
			try
			{


				var newRecipes = new Recipe()
				{
					ID = new Guid(),
					Name = name,
					RegistrationDate = DateTime.Now,
					ProductType = productType
				};
				// insertion will into database.
				var dbContext = new DbContextExample();
				dbContext.DbRecipes.Add(newRecipes);

			}
			catch (Exception e)
			{
				throw;
			}
			
		}

		public List<Recipe> GetRecipesByProductClassification(Enumerations.ProductType productType)
		{
			try
			{
				var dbContext = new DbContextExample();
				return dbContext.DbRecipes.Where(x => x.ProductType == productType).OrderBy(x => x.Name).ToList();
			}
			catch (Exception e)
			{
				throw e;
			}
			
		}
		public List<Recipe> GetRecipesByDates(DateTime startDate, DateTime endDate)
		{
			try
			{
				var dbContext = new DbContextExample();
				return dbContext.DbRecipes.Where(x => x.RegistrationDate >= startDate && x.RegistrationDate <= endDate).ToList();
			}
			catch (Exception e)
			{
				throw e;
			} 
			
		}
		public bool CheckReceipeInventory(Enumerations.ProductType productType, int requiredQuantity)
		{
			try
			{
				var dbContext = new DbContextExample();
				if (dbContext.DbRecipes.Count(x => x.ProductType == productType) > requiredQuantity)
					return true;
				return false;
			}
			catch (Exception e)
			{
				throw e;
			}
			
		}
		public bool RemoveInventory(Enumerations.ProductType productType, int requiredQuantity)
		{
			try
			{
				var dbContext = new DbContextExample();

				var recipe = dbContext.DbRecipes.FirstOrDefault(x => x.ProductType == productType);
				if (recipe != null)
				{
					var result = dbContext.DbIngredients.FirstOrDefault(x => x.ID == recipe.IngredientId);
					if (result != null)
					{
						if (result.Grams > requiredQuantity)
						{
							result.Grams = result.Grams - requiredQuantity;
						}
					}
				}
				return true;
			}
			catch (Exception e)
			{
				throw e;
			}

			
		}
	}
}
