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
			var str = "äbd";
			double a = 4.5; // or use var 
			double b = 2.5;
			double answer = Add(a, b);
			return new string[] { ($"{a} + {b} = {answer}") };
			//return new string[] { "p1", "p2", "p3" };
		}

		static double Add(double a, double b)
		{
			return a * b; // deliberate bug! 
		}
	}
}