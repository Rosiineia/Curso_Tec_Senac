
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
    public class UsuarioController : Controller
    {

        public IActionResult Login(){
            return View();
        }

        [HttpPost]
            public IActionResult Login(Usuario usuario){

               UsuarioRepository us = new UsuarioRepository();
               Usuario usuarioSessao = us.ValidarLogin(usuario);
               if(usuarioSessao==null){
                   //Não localizado ususario com dados informados no objeto ususario
                   ViewBag.mensagem = "Usuario não localizado com o login e senha informado";
                   return View();
               }else{ //Login localizado
                    ViewBag.mensagem ="Você está logado";
                    //registra  a sessão e dados do usuario
                    HttpContext.Session.SetInt32("IdUsuario", usuarioSessao.Id);
                    HttpContext.Session.SetString("NomeUsuario", usuarioSessao.Nome);


                    //redirecionamento

                    //return RedirectToAction("Login");
                    return View();

               }
                              
            }    

            public IActionResult Logout(){

                // limpar os dados da sessão
                HttpContext.Session.Clear();//limpa todos os metodos da sessão


                //redirecionamento
                return View("Login");
                
            }

        public IActionResult Lista(){
            //Validando se o ususario está logado, caso não eseja é redirecionado para o login
            if(HttpContext.Session.GetInt32("IdUsuario")==null){
                return RedirectToAction("Login", "Usuario");
            }
            UsuarioRepository us = new UsuarioRepository();

            List<Usuario> lista = us.Listar();
            return View(lista);

        }

        public IActionResult excluir(int Id){

            UsuarioRepository us = new UsuarioRepository();           
            Usuario userEncontrado = us.BuscarPorID(Id);
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

                if(HttpContext.Session.GetInt32("IdUsuario")==null){
                return RedirectToAction("Login", "Usuario");
            }

                UsuarioRepository us = new UsuarioRepository();
                us.incluir(novoUser);

                ViewData["mensagem"]= "Cadastro Realizado com Sucesso";
                return View();
            }
            public  IActionResult Alterar(int Id){
                UsuarioRepository us = new UsuarioRepository();
               Usuario userEncontrado = us.BuscarPorID(Id);

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