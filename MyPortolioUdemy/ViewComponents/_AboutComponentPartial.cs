
using Microsoft.AspNetCore.Mvc;
using MyPortfolioUdemy.DAL.Context;
using System.Linq;

namespace MyPortfolioUdemy.ViewComponents
{
    public class _AboutComponentPartial : ViewComponent
    {
        MyPortfolioContext portfolioContext = new MyPortfolioContext();

        public IViewComponentResult Invoke()
        {
            ViewBag.aboutTitle = portfolioContext.Abouts
                .Select(x => x.Title)
                .FirstOrDefault();

            ViewBag.aboutSubDescription = portfolioContext.Abouts
                .Select(x => x.SubDescripton)
                .FirstOrDefault();

            ViewBag.aboutDetail = portfolioContext.Abouts
                .Select(x => x.Detail)
                .FirstOrDefault();


            return View();
        }
    }
}
