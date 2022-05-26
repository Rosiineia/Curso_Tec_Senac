// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function valida_formulario(form){
    var invalid = /^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,4})+$/; //expressao regular (PESQUISAR)

    var nome=document.getElementById('nome');/*para saber o nome da propriedade o .value fica aqui*/
    var email=document.getElementById('email');    
    

    var caixa_nome= document.querySelector('.msg_js_nome');
    caixa_nome.style.display='none'/* NÃO mostar FRASE:'Favor colocar nome completo'*/


    if(nome.value==""){/*para FOCAR a propriedade o .value fica aqui*/
        caixa_nome.innerHTML="CAMPO OBRIGATÓRIO";
        caixa_nome.style.display='block'/*mostar FRASE:'Favor colocar nome completo' */
        nome.focus();
        return false;
    }
    if(invalid.test(nome.value)==false){/*Segunda  validação com "expressão regular"*/
        alert("Nome incorreto")
        nome.focus();
        return false;
    }

    var caixa_email= document.querySelector('.msg_js_email');
    caixa_email.style.display='none'/* NÃO mostar FRASE:'Favor colocar nome completo'*/


    if(email.value==""){/*para FOCAR a propriedade o .value fica aqui*/
        caixa_email.innerHTML="CAMPO OBRIGATÓRIO";
        caixa_email.style.display='block'/*mostar FRASE:'Favor colocar nome completo' */
        email.focus();
        return false;
    }
    if(invalid.test(email.value)==false){/*Segunda  validação com "expressão regular"*/
        alert("Email incorreto")
        email.focus();
        return false;
    }
}