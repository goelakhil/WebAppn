using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebAppn.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ProductsController : Controller
    {
		[HttpGet]
		public ActionResult<IEnumerable<string>> Get()
		{
			return new string[] { "p1", "p2", "p3" };
		}
	}
}