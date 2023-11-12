using FinanSmart.Dominio.Interface.Repository;
using Microsoft.AspNetCore.Mvc;

public class AutenticadoController : Controller
{
    private readonly ILoginService _loginService;
    public AutenticadoController(ILoginService loginService)
    {
        _loginService = loginService;
    }

    [HttpGet]
    public IActionResult Index()
    {
        return View(new UsuarioViewModel());
    }

    [HttpPost]
    public IActionResult Autenticar(UsuarioViewModel entidade)
    {
        bool valido = _loginService.IsValid(entidade.Usuario, entidade.Senha);
        Console.WriteLine(valido);
        if (!valido)
        {
            return base.RedirectToAction("Index");
        }

        HttpContext.Session.SetString("Usuario", entidade.Usuario);
        return base.RedirectToAction("Index", "Cadastros");
    }

    [HttpGet]
    public IActionResult Erro()
    {
        return View();
    }
}