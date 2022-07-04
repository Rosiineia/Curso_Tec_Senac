// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function Cadastrar()
{
    let parametros={
        Nome:$("nome").val(),
        Email:$("email").val(),
        Mensagem:$("mensagem").val()
    }
    $.post("/Home/Cadastrar", parametros)

    .done(
        function(retorno){
            if(retorno.status=="ok"){

                $("#areaContato").after("<h3>Cadstro Realizado com sucesso </h3>");
                $("#areaContato").hide();

            }else{
                $("#areaContato").after("<h3>" + retorno.mensagem + "</h3>");
            }

        }
        
    )
    .fail(
        function(){

            alert("Falha ao realzar o cadastro!")
        }
    )
}

$(document).ready(function(){

    $("#formCadastro").submit(
        function(e){

            e.preventDefault();
            Cadastrar()


        }
    )

}

);//Ler os dados do formulario