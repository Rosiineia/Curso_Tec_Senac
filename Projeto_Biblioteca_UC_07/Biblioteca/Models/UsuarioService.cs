using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Biblioteca.Models
{
    public class UsuarioService
    {
        //Listar
       public List<Usuario> Listar(){

        using(BibliotecaContext bc = new BibliotecaContext()){
           return bc.Usuarios.ToList();
        }
        }

        public Usuario Listar( int id){
            using(BibliotecaContext bc = new BibliotecaContext()){
            return bc.Usuarios.Find(id);

        }
        }      
        //incluir usuario        
    
        public void incluirUsuario(Usuario novoUser)
        {
            using(BibliotecaContext bc = new BibliotecaContext())
            {
                bc.Usuarios.Add(novoUser);
                bc.SaveChanges();
            }
        }
        //editar usuario
        public void editarUsuario(Usuario edUser)
        {
            using(BibliotecaContext bc = new BibliotecaContext())
            {
                Usuario u = Listar(edUser.Id);
                
                u.Nome = edUser.Nome;
                u.Login = edUser.Login;
                u.Senha = edUser.Senha;
                u.Tipo = edUser.Tipo;

                bc.SaveChanges();
            }
        }       

        //excluir ususario
        public void excluirUsuario(int id){
            using(BibliotecaContext bc = new BibliotecaContext())
            {
                bc.Usuarios.Remove(bc.Usuarios.Find(id));
                bc.SaveChanges();
            }

        }
    }
}
