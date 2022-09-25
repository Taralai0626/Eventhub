using EventHub_App.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EventHub_App.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        /*
       [HttpGet]
       public async Task<IActionResult> Index(string searchByLocation)
       {
           ViewData["searchByLocation"] = searchByLocation;



           var client = new HttpClient();
           var request = new HttpRequestMessage
           {
               Method = HttpMethod.Get,
               RequestUri = new Uri("https://forward-reverse-geocoding.p.rapidapi.com/v1/forward?city=Toronto&accept-language=en&polygon_threshold=0.0"),
               Headers =
   {
       { "X-RapidAPI-Key", "48e44e0db9msh0a550f0e0f01e70p193d8bjsnc47430e4dab3" },
       { "X-RapidAPI-Host", "forward-reverse-geocoding.p.rapidapi.com" },
   },
           };
           using (var response = await client.SendAsync(request))
           {
               response.EnsureSuccessStatusCode();
               var body = await response.Content.ReadAsStringAsync();

               ViewData["cityLat"] = body;
               System.Diagnostics.Debug.WriteLine(body);

           }


           return View();


       }*/


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