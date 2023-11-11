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
        return View(new CadastroModel ());
    }

    [HttpPost]
    public IActionResult Autenticar(UsuarioViewModel entidade)
    {
        if (entidade.Autenticado())
            return base.RedirectToAction("Index", "Home");
        else
            return base.RedirectToAction("Erro");
    }

    public IActionResult Cadastrar (CadastroModel Cadastro) {
        Cadastro cad = new Cadastro();
        cad.CPF = Cadastro.CPF;
        cad.PrimeiroNome = Cadastro.PrimeiroNome;
        cad.Sobrenome = Cadastro.Sobrenome;
        cad.Senha = Cadastro.Senha;
        cad.Email = Cadastro.Email;
        _service.AdicionarCadastro(cad);
        return View("../Home/Index");
    }

    [HttpGet]
    public IActionResult Erro()
    {
        return View();
    }
}