using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Rosineia_UC04_Atividade2.Models;

namespace Rosineia_UC04_Atividade2.Controllers
{
    public class UsuarioController : Controller
    {
        public IActionResult Lista(){

            UsuarioRepository us = new UsuarioRepository();
            List<Usuario> lista = us.Listar();
            return View(lista);

        }

        public IActionResult excluir(int Id){

            UsuarioRepository us = new UsuarioRepository();
           
            Usuario userEncontrado = us.BuscarPorId(Id);

            if(userEncontrado.Id>0){
                 us.excluir(userEncontrado);
            }else{
                ViewData["mensagem"] = "Usuario não Localizado";
            }
            return RedirectToAction("Lista");
        }

        public IActionResult incluir(){
            return View();
        }
            [HttpPost]

            public IActionResult incluir(Usuario novoUser){

                UsuarioRepository us = new UsuarioRepository();
                us.incluir(novoUser);

                ViewData["mensagem"]= "Cadastro Realizado com Sucesso";
                return View();
            }
            public  IActionResult Alterar(int Id){
                UsuarioRepository us = new UsuarioRepository();
               Usuario userEncontrado = us.BuscarPorId(Id);

               return View(userEncontrado);
            }
            [HttpPost]

            public IActionResult alterar(Usuario usuario){
                UsuarioRepository us = new UsuarioRepository();
                us.alterar(usuario);

                return RedirectToAction("Lista");
                }
            
        }
    }
