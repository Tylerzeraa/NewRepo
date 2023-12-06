using FinanSmart.Dominio.Entities;
using FinanSmart.Dominio.Interface.Repository;
using Microsoft.AspNetCore.Mvc;

namespace FinanSmart.WebApp.Controllers
{
    public class GastosController : Controller
    {
        IGastoRepository _gastoRepository;
        public GastosController(IGastoRepository gastoRepository)
        {
            _gastoRepository = gastoRepository;
        }
        public IActionResult Index()
        {
            string idUsuario = HttpContext.Session.GetString("UsuarioId");
            return View(_gastoRepository.ListarGastos(idUsuario));
        }

        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Gasto gasto)
        {
            string idUsuario = HttpContext.Session.GetString("UsuarioId");
            gasto.UsuarioId = idUsuario;
            _gastoRepository.CadastrarGasto(gasto);
            return RedirectToAction("Index");
        }

        public IActionResult Editar(int id)
        {

            return View(_gastoRepository.BuscarGasto(id));
        }

        [HttpPost]
        public IActionResult Editar(Gasto gasto)
        {
            _gastoRepository.EditarGasto(gasto);
            return RedirectToAction("Index");
        }

        public IActionResult Excluir(int id)
        {
            _gastoRepository.ExcluirGasto(_gastoRepository.BuscarGasto(id));
            return RedirectToAction("Index");
        }
    }
}
