using FinanSmart.Dados;
using FinanSmart.Dominio.Entities;
using Microsoft.AspNetCore.Mvc;

namespace FinanSmart.WebApp.Controllers
{
    public class CategoriaController : Controller
    {
        private Contexto db = new Contexto();

        public CategoriaController() 
        
        {
            var emp = new Categoria()
            {
                CategoriaID = 100,  
                CategoriaNome = "náthan",
				CategoriaDescricao = "pagamento de boleto"

			};

            db.Categoria.Add(emp);  
            db.SaveChanges();
        }
       
        
        
        
        
        public IActionResult Index()
        {
            var resultado = db.Categoria.ToList();
                
            return View();
        }
    }
}
