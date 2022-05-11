function valida_formulario(form){
    var invalid = /^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,4})+$/; //expressao regular (PESQUISAR)

    var nome=document.getElementById('nome');/*para saber o nome da propriedade o .value fica aqui*/
    var email=document.getElementById('email');
    var idade=document.getElementById('idade');
    var mensagem=document.getElementById('mensagem');

    /*if(nome.value==""){/*para FOCAR a propriedade o .value fica aqui*/
        /*alert('O nome é obrigatorio')
        nome.focus();
        /*nome.style.backgroundColor='green';/*para destaca a cor do campo no formulario*/
        /*nome.style.color='red';/*cor da fonte */
        /*return false;
    }*/
    var caixa_nome= document.querySelector('.msg_js_nome');
    caixa_nome.style.display='none'/* NÃO mostar FRASE:'Favor colocar nome completo'*/


    if(nome.value==""){/*para FOCAR a propriedade o .value fica aqui*/
        caixa_nome.innerHTML="Favor colocar nome completo";
        caixa_nome.style.display='block'/*mostar FRASE:'Favor colocar nome completo' */
        nome.focus();
        return false;
    }

    if(email.value==""){
        alert('O email é obrigatorio')/*primeira validação*/
            email.focus();
        return false;
    }
    if(invalid.test(email.value)==false){/*Segunda  validação com "expressão regular"*/
        alert("Email incorreto")
        email.focus();
        return false;
    }

    if(idade.value==""){
        alert('A idade é obrigatorio')
        idade.focus();
        return false;
    }if(mensagem.value==""){
        alert('A mensagem é obrigatorio')
        mensagem.focus();
        return false;
    }
    return true;
}

    