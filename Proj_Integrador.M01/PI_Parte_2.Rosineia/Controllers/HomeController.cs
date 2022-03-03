using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PI_Parte_2.Rosineia.Models;

namespace PI_Parte_2.Rosineia.Controllers
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
        public IActionResult Cadastro(){
            return View();
        }
        [HttpPost]
        public IActionResult Cadastro(ItensPedido i ){
            Dados.PedidoAtual.AdicionarItensPedido(i);
            return View();
        }
        public IActionResult Listagem(){
             List<ItensPedido> lista = Dados.PedidoAtual.ListarItensPedido();
            return View(lista);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
