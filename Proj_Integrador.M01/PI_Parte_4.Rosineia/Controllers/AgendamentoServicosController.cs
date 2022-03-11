using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using PI_Parte_4.Rosineia.Models;


namespace PI_Parte_4.Rosineia.Controllers
{
    public class AgendamentoServicosController : Controller
    {
      public IActionResult Lista(){
            //Validando se o ususario está logado, caso não eseja é redirecionado para o login
            if(HttpContext.Session.GetInt32("IdUsuario")==null){
                return RedirectToAction("Login", "AgendamentoServicos");
            }
            AgendamentoServicosRepository us = new AgendamentoServicosRepository();

            List<AgendamentoServicos> lista = us.Listar();
            return View(lista);
             }
             
            public  IActionResult alterar(int Id){
                AgendamentoServicosRepository us = new AgendamentoServicosRepository();
               AgendamentoServicos servicoAgend = us.BuscarPorID(Id);

               return View(servicoAgend);
            }
            [HttpPost]

            public IActionResult alterar(AgendamentoServicos agenda){
                AgendamentoServicosRepository us = new AgendamentoServicosRepository();
                us.alterar(agenda);

                return RedirectToAction("Lista");
            }
            
            public IActionResult incluir()
            {

            if(HttpContext.Session.GetInt32("IdUsuario")==null)
            {
           
                return RedirectToAction("Login", "Usuario");
            }
                return View();
            }            
            [HttpPost]

            public IActionResult incluir(AgendamentoServicos p)
            {

                AgendamentoServicosRepository ptr = new AgendamentoServicosRepository();
                p.Usuario = (int)(HttpContext.Session.GetInt32("IdUsuario"));
                ptr.incluir(p);
                
                
                ViewData["mensagem"]= "Solicitação Cadastrada com Sucesso!!";
                return View();
                }
            public IActionResult excluir(int Id){

            AgendamentoServicosRepository us = new AgendamentoServicosRepository();           
            AgendamentoServicos servicoAgend = us.BuscarPorID(Id);
            if(servicoAgend.Id>0){
                 us.excluir(servicoAgend);
            }else{
                ViewData["mensagem"] = "Serviço não localizado";
            }
            return RedirectToAction("Lista");
        }
        public IActionResult Vitrine(){

            AgendamentoServicosRepository ptr = new AgendamentoServicosRepository();
                            
                return View(ptr.Listar());
            }
    }
}