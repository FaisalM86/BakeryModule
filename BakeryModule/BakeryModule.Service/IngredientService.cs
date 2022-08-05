using BakeryModue.Domain;
using System;
using System.Linq;

namespace BakeryModule.Service
{
	public class IngredientService
	{
		public void InsertIngredient(string name, double grams)
		{
			var newIngrandient = new Ingredient()
			{
				ID = new Guid(),
				Name = name,
				Grams = grams
			};
			// insertion will into database.
			var dbContext = new DbContextExample();
			dbContext.DbIngredients.Add(newIngrandient);
		}
		public void UpdateIngredient(double grams, Guid ID)
		{
			// Get the entity from database by using the above ID.
			var dbContext = new DbContextExample();
			var existingEnityt = dbContext.DbIngredients.FirstOrDefault(x => x.ID == ID);

			if (existingEnityt != null)
			{
				existingEnityt.Grams = grams;
			}
			// Update will be into database.
		}
	}
}
