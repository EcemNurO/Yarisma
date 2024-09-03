using Microsoft.AspNetCore.Mvc;

namespace Yarışma.Areas.Management.Controllers
{
	public class ThematicAreaController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
