﻿using Microsoft.AspNetCore.Mvc;

namespace Yarışma.Areas.Management.Controllers
{
	public class DashboardContestantController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
