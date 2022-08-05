using BakeryModue.Domain;
using System;
using System.Linq;

namespace BakeryModule.Service
{
	public interface IIngredientService
	{
		public void InsertIngredient(string name, string grams);

		public void UpdateIngredient(string grams, Guid ID);

	}
}
