using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using UC_5Rosineia_Ativ3.Models;

namespace UC_5Rosineia_Ativ3.Controllers
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

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Cadastro()
        {
            return View();
        }

        [HttpPost]

        public IActionResult Cadastro(Agendamento a)
        {
            Dados.AgendamentoAtual.AdicionarAgendamento(a);
            return RedirectToAction("Listagem");
        }
        public IActionResult Listagem()
        {
            List<Agendamento> lista = Dados.AgendamentoAtual.ListarAgendamento();
            return View(lista);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
