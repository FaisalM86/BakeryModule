using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BakeryModule.Service;

namespace BakeryModule.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class IngredientController : ControllerBase
	{

		private readonly ILogger<RecipeController> _logger;
		private readonly IngredientService _ingredientService;

		public IngredientController(ILogger<RecipeController> logger, IngredientService ingredientService)
		{
			_logger = logger;
			_ingredientService = ingredientService;
		}
		[HttpGet]
		public IEnumerable<string> Get()
		{
			return new string[] { "value1", "value2" };
		}

	}
}
