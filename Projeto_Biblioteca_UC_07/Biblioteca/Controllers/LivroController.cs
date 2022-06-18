using Microsoft.AspNetCore.Mvc;

using Biblioteca.Models;

namespace Biblioteca.Controllers
{
    public class LivroController : Controller
    {
        public IActionResult Cadastro()
        {
            Autenticacao.CheckLogin(this);
            return View();
        }

        [HttpPost]
        public IActionResult Cadastro(Livro l)
        {
            if(l.Autor == "" || l.Ano == 0 || l.Titulo=="") {
                

            }else{                   
            LivroService livroService = new LivroService();

            if(l.Id == 0)
            {
                livroService.Inserir(l);
            }
            else
            {
                livroService.Atualizar(l);
            }
            }

            return RedirectToAction("Listagem");
        }

        public IActionResult Listagem(string tipoFiltro, string filtro)
        {
            Autenticacao.CheckLogin(this);
            FiltrosLivros objFiltro = null;
            if(!string.IsNullOrEmpty(filtro))
            {
                objFiltro = new FiltrosLivros();
                objFiltro.Filtro = filtro;
                objFiltro.TipoFiltro = tipoFiltro;
            }
            LivroService livroService = new LivroService();
            return View(livroService.ListarTodos(objFiltro));
        }

        public IActionResult Edicao(int id)
        {
            Autenticacao.CheckLogin(this);
            LivroService ls = new LivroService();
            Livro l = ls.ObterPorId(id);
            return View(l);
        }

        /*public IActionResult excluirlivros(string id) {
            return View(new LivroService().ListarTodos(id));    
        }
        
        [HttpPost]
        public IActionResult excluirlivros(string decisao)
        {
            
            if(decisao=="EXCLUIR")
            {
                ViewData["Mensagem"] = "Exclusão de Livro Cadastrado "+ new LivroService().ListarTodos(id).Autor + "realizada com sucesso";                
                new LivroService().excluirCadLivros(id);
                return View("ListadeLivros",new LivroService().ListarTodos());
            }
            else
            {
                ViewData["Mensagem"] = "Exclusão cancelada";
                return View("ListadeLivros",new LivroService().ListarTodos());
            }
        }*/
    }
}