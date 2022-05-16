function valida_formulario(form){
    var invalid = /^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,4})+$/;

    var nome=document.getElementById('name');
    var endereco=document.getElementById('endereco');
    var telefone=document.getElementById('telefone');
    var tamanhoSabor=document.getElementById('tamanhoSabor');
    var pagamento=document.getElementById('pagamento');


   
    var caixa_nome= document.querySelector('.js_nome');
    caixa_nome.style.display='none'/* NÃO mostar FRASE:'Favor colocar nome completo'*/


    if(nome.value==""){/*para FOCAR a propriedade o .value fica aqui*/
        caixa_nome.innerHTML="CAMPO OBRIGATÓRIO";
        caixa_nome.style.display='block'/*mostar FRASE:'Favor colocar nome completo' */
        nome.focus();
        return false;
    }

    var cx_endereco= document.querySelector('.js_end');
    cx_endereco.style.display='none'/* NÃO mostar FRASE:'Favor colocar nome completo'*/


    if(endereco.value==""){/*para FOCAR a propriedade o .value fica aqui*/
        cx_endereco.innerHTML="CAMPO OBRIGATÓRIO";
        cx_endereco.style.display='block'/*mostar FRASE:'Favor colocar nome completo' */
        nome.focus();
        return false;
    }
    var cx_telefone= document.querySelector('.js_tel');
    cx_telefone.style.display='none'/* NÃO mostar FRASE:'Favor colocar nome completo'*/


    if(telefone.value==""){/*para FOCAR a propriedade o .value fica aqui*/
        cx_telefone.innerHTML="CAMPO OBRIGATÓRIO";
        cx_telefone.style.display='block'/*mostar FRASE:'Favor colocar nome completo' */
        nome.focus();
        return false;
    }

    var cx_tamanhoSabor= document.querySelector('.js_tam');
    cx_tamanhoSabor.style.display='none'/* NÃO mostar FRASE:'Favor colocar nome completo'*/


    if(tamanhoSabor.value==""){/*para FOCAR a propriedade o .value fica aqui*/
        cx_tamanhoSabor.innerHTML="CAMPO OBRIGATÓRIO";
        cx_tamanhoSabor.style.display='block'/*mostar FRASE:'Favor colocar nome completo' */
        nome.focus();
        return false;
    }

    var cx_pagamento= document.querySelector('.js_pag');
    cx_pagamento.style.display='none'/* NÃO mostar FRASE:'Favor colocar nome completo'*/


    if(pagamento.value==""){/*para FOCAR a propriedade o .value fica aqui*/
        cx_pagamento.innerHTML="CAMPO OBRIGATÓRIO";
        cx_pagamento.style.display='block'/*mostar FRASE:'Favor colocar nome completo' */
        nome.focus();
        return false;
    }
    
}
