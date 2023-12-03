using FinanSmart.Dominio.Interface.Serviços;
using FinanSmart.Dominio.ValueObjects;
using FinanSmart.WebApp.Models;
using Microsoft.AspNetCore.Mvc;

public class AutenticacaoController : Controller
{
    ICadastroService _service;
    public AutenticacaoController(ICadastroService service) { _service = service; }

    [HttpGet]
    public IActionResult Index()
    {
        if (HttpContext.Session.GetString("Usuario") != null)
            return RedirectToAction("Index", "Home");

        return View(new CadastroModel());
    }

    [HttpPost]
    public IActionResult Autenticar(UsuarioViewModel entidade)
    {
        if (true)
            return base.RedirectToAction("Index", "Home");
        else
            return base.RedirectToAction("Erro");
    }

    public IActionResult Cadastrar (CadastroModel Cadastro) {

        Cadastro cad = new()
        {
            CPF = Cadastro.CPF,
            PrimeiroNome = Cadastro.PrimeiroNome,
            Sobrenome = Cadastro.Sobrenome,
            Senha = Cadastro.Senha,
            Email = Cadastro.Email
        };

        _service.AdicionarCadastro(cad);
        return RedirectToAction("Index", "Autenticado");
    }

    [HttpGet]
    public IActionResult Erro()
    {
        return View();
    }
}