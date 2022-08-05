using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BakeryModule.Service;

namespace BakeryModule.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class RecipeController : ControllerBase
	{

		private readonly ILogger<RecipeController> _logger;
		private readonly IRecipeService _recipeService;

		public RecipeController(ILogger<RecipeController> logger, IRecipeService recipeService)
		{
			_logger = logger;
			_recipeService = recipeService;
		}
		[HttpGet]
		public IEnumerable<string> Get()
		{
			return new string[] { "value1", "value2" };
		}

	}
}
