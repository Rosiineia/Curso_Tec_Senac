using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Rosineia_UC04_Atividade2.Models;

namespace Rosineia_UC04_Atividade2.Controllers
{
    public class PacotesTuristicosController : Controller
    {
        //CRUD DE PACOTES TURISTICOS

        public IActionResult Lista(){
            //Validando se o ususario está logado, caso não eseja é redirecionado para o login
            if(HttpContext.Session.GetInt32("IdPacotesTuristicos")==null){
                return RedirectToAction("Login", "PacotesTuristicos");
            }
            PacotesTuristicosRepository us = new PacotesTuristicosRepository();

            List<PacotesTuristicos> lista = us.Listar();
            return View(lista);
        }
        public IActionResult incluir(){
            return View();
        }
            [HttpPost]

            public IActionResult incluir(PacotesTuristicos p){

                PacotesTuristicosRepository us = new PacotesTuristicosRepository();
                p.Usuario = (int)(HttpContext.Session.GetInt32("idUsuario"));
                us.incluir(p);
                ViewData["mensagem"]= "Pacote Incluido com  Sucesso";
                return View();
            }
            public  IActionResult alterar(int IdPacotesTuristicos){
                PacotesTuristicosRepository us = new PacotesTuristicosRepository();
               PacotesTuristicos pacoteEncontrado = us.BuscarPorID(IdPacotesTuristicos);

               return View(pacoteEncontrado);
            }
            [HttpPost]

            public IActionResult alterar(Usuario pacotesturisticos){
                PacotesTuristicosRepository us = new PacotesTuristicosRepository();
                us.alterar(pacotesturisticos);

                return RedirectToAction("Lista");
            }

            public IActionResult excluir(int Id){

            PacotesTuristicosRepository us = new PacotesTuristicosRepository();           
            PacotesTuristicos pacoteEncontrado = us.BuscarPorID(Id);
            if(pacoteEncontrado.Id>0){
                 us.excluir(pacoteEncontrado);
            }else{
                ViewData["mensagem"] = "Pacote não Localizado";
            }
            return RedirectToAction("Lista");
        }
    }
}