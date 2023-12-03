using FinanSmart.Dominio.Interface.Serviços;
using FinanSmart.WebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FinanSmart.WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        ICategoriaServico serv {get; set;}

        public HomeController(ILogger<HomeController> logger, ICategoriaServico categoriaServico)
        {
            _logger = logger;
            serv = categoriaServico;
        }

        public IActionResult Index()
        {
           /* Categoria cat = new Categoria() {
                CategoriaDescricao = "CategoriaTeste",
                CategoriaID = Random.Shared.Next(1, 1000),
                CategoriaNome = "TremBala"


            };
            serv.AdicionarCategoria(cat);*/
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