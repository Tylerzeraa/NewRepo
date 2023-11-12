﻿using FinanSmart.Dominio.Interface.Repository;
using FinanSmart.Dominio.ValueObjects;
using Microsoft.AspNetCore.Mvc;

namespace FinanSmart.WebApp.Controllers
{
    public class CadastrosController : Controller
    {
        private readonly ICadastroRepository _cadastroRepository;
        public CadastrosController(ICadastroRepository cadastroRepository)
        {
            _cadastroRepository = cadastroRepository;
        }

        public IActionResult Excluir(string id)
        {
            _cadastroRepository.Excluir(id);

            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Index()
        {
            List<Cadastro> cadastros = await _cadastroRepository.GetCadastros();

            return View(cadastros);
        }
    }
}
