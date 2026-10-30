using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace MyPortfolioUdemy.ViewComponents
{
    public class _StatisticComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }

    }
}
