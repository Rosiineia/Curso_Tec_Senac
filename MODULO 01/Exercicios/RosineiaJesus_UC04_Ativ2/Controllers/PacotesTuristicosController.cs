using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using RosineiaJesus_UC04_Ativ2.Models;

namespace RosineiaJesus_UC04_Ativ2.Controllers
{
    public class PacotesTuristicosController : Controller
    {
       //CRUD DE PACOTES TURISTICOS

        public IActionResult Lista(){
            //Validando se o ususario está logado, caso não eseja é redirecionado para o login
            if(HttpContext.Session.GetInt32("IdUsuario")==null){
                return RedirectToAction("Login", "PacotesTuristicos");
            }
            PacotesTuristicosRepository us = new PacotesTuristicosRepository();

            List<PacotesTuristicos> lista = us.Listar();
            return View(lista);
             }
            public  IActionResult alterar(int Id){
                PacotesTuristicosRepository us = new PacotesTuristicosRepository();
               PacotesTuristicos pacoteEncontrado = us.BuscarPorID(Id);

               return View(pacoteEncontrado);
            }
            [HttpPost]

            public IActionResult alterar(PacotesTuristicos pacote){
                PacotesTuristicosRepository us = new PacotesTuristicosRepository();
                us.alterar(pacote);

                return RedirectToAction("Lista");
            }

            public IActionResult incluir()
            {
                return View();
            }
            
            [HttpPost]

            public IActionResult incluir(PacotesTuristicos p){

                PacotesTuristicosRepository ptr = new PacotesTuristicosRepository();
                p.Usuario = (int)(HttpContext.Session.GetInt32("IdUsuario"));
                ptr.incluir(p);
                

                ViewData["mensagem"]= "Pacote Incluido com  Sucesso";
                return View();
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