using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ScoreZone.Web.Data.NoticiasEntities;
using ScoreZone.Web.Helpers;
using ScoreZone.Web.Models;

namespace ScoreZone.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IApiServices _apiServices;

        public HomeController(IApiServices apiServices)
        {
            _apiServices = apiServices;
        }
        public async Task<IActionResult> Index()
        {
           var mbl =  _apiServices.getFirtsNews("http://site.api.espn.com/apis/site/v2/sports/baseball/mlb/news");
            var Football =  _apiServices.getFirtsNews("http://site.api.espn.com/apis/site/v2/sports/football/college-football/news");
            var NFL =  _apiServices.getFirtsNews("http://site.api.espn.com/apis/site/v2/sports/football/nfl/news");
            //var Hockey = await _apiServices.getFirtsNews("http://site.api.espn.com/apis/site/v2/sports/hockey/nhl/news");
            var NBA =  _apiServices.getFirtsNews("http://site.api.espn.com/apis/site/v2/sports/basketball/nba/news");
            //var Soccer = await _apiServices.getFirtsNews("http://site.api.espn.com/apis/site/v2/sports/soccer/:league/news");
            var resultados = new List<Root>();

            await Task.WhenAll(mbl, Football, NFL, NBA);
            
            resultados.Add(await mbl);
            resultados.Add(await Football);
            resultados.Add(await NFL);
            resultados.Add(await NBA);

            return View(resultados);
        }

        public async Task<IActionResult> ResultNews(string resul)
        {
           var result2 =await _apiServices.getSecondNews(resul);
            return View(result2);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
