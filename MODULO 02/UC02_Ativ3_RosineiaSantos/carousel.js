var slideIndex= 1;
showSlides(slideIndex);
//var slideIndex2= 0;



function plusSlides(n){
    showSlides(slideIndex += n)
}

function currentSlide(n){
    showSlides(slideIndex = n)

}
function showSlides(n){
    var i;
    var conprodutos = document.getElementsByClassName("conjProdutos");
    ///var pontos = document.getElementsByClassName("ponto");
    if(n > conprodutos.length){ slideIndex =1 }
    if(n < 1){slideIndex = conprodutos.length}  
    for(i = 0; i < conprodutos.length; i++){
        conprodutos[i].style.display = "flex";
    }
    /*for(i = 0; i < pontos.length;i++){
        pontos[i].className = pontos[i].className.replace("active", "")     
    }*/
    conprodutos[slideIndex - 1].style.display="block";
        //pontos[slideIndex-1].className += "active";
} 