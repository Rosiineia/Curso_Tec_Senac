using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Exerc_AgendaMVC.Models;

namespace Exerc_AgendaMVC.Controllers
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
        
        public IActionResult Produto()
        {//irá chamar a pag em html de produto
        //cmo estamos em um modelo MVC fica na camada "views"
            return View();
        }

        public IActionResult Contato(){
            //Finalidade é chamar o formulario de contato
            return View();
        }
        [HttpPost]

        public IActionResult Cadastro(Contato c){
            //RECEBER DADOS INFORMADO PELO USUSARIO NO FORMULARIO
            Dados.AgendaAtual.AdicionarContato(c);
            return View();
        }

        public IActionResult Listagem(){
           List<Contato> lista = Dados.AgendaAtual.ListarContato();
            return View(lista);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
