using Microsoft.AspNetCore.Mvc;
using System.Security.Policy;

namespace MyPortfolioUdemy.ViewComponents.LayoutViewComponents
{
	public class _LayoutScriptComponentPartial : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
