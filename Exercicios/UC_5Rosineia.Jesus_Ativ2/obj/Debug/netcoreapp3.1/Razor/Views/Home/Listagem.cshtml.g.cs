#pragma checksum "D:\CURSO TECNICO - SENAC\Modulo1_Senac\Exercicios\UC_5Rosineia.Jesus_Ativ2\Views\Home\Listagem.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e79e5efa364518913ce7de3322ee8b35877db191"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Listagem), @"mvc.1.0.view", @"/Views/Home/Listagem.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\CURSO TECNICO - SENAC\Modulo1_Senac\Exercicios\UC_5Rosineia.Jesus_Ativ2\Views\_ViewImports.cshtml"
using UC_5Rosineia.Jesus_Ativ2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\CURSO TECNICO - SENAC\Modulo1_Senac\Exercicios\UC_5Rosineia.Jesus_Ativ2\Views\_ViewImports.cshtml"
using UC_5Rosineia.Jesus_Ativ2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e79e5efa364518913ce7de3322ee8b35877db191", @"/Views/Home/Listagem.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a47f51a182573bab672dc3d225d31cb47d8a4d41", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Listagem : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ItensPedido>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"

<h2>Lista de Pedidos</h2>
    <table>
         <style>
table, th, td {
  border: 2px solid black;
}
</style>
         <tr>
              <th>Descricão</th>   
            <th>Valor</th> <br>
            <th>Quantidade</th><br>
        </tr>
   
");
#nullable restore
#line 17 "D:\CURSO TECNICO - SENAC\Modulo1_Senac\Exercicios\UC_5Rosineia.Jesus_Ativ2\Views\Home\Listagem.cshtml"
 foreach (ItensPedido pp in Model)
{   

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\r\n\r\n    <td>");
#nullable restore
#line 21 "D:\CURSO TECNICO - SENAC\Modulo1_Senac\Exercicios\UC_5Rosineia.Jesus_Ativ2\Views\Home\Listagem.cshtml"
   Write(pp.descricao);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 22 "D:\CURSO TECNICO - SENAC\Modulo1_Senac\Exercicios\UC_5Rosineia.Jesus_Ativ2\Views\Home\Listagem.cshtml"
   Write(pp.valor_unitario);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 23 "D:\CURSO TECNICO - SENAC\Modulo1_Senac\Exercicios\UC_5Rosineia.Jesus_Ativ2\Views\Home\Listagem.cshtml"
   Write(pp.quantidade);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n  </tr>\r\n");
            WriteLiteral("  <p>  \r\n");
#nullable restore
#line 27 "D:\CURSO TECNICO - SENAC\Modulo1_Senac\Exercicios\UC_5Rosineia.Jesus_Ativ2\Views\Home\Listagem.cshtml"
        
          double total= 0;
          total = pp.quantidade*pp.valor_unitario;
      

#line default
#line hidden
#nullable disable
            WriteLiteral("      \r\n       </p>\r\n");
#nullable restore
#line 33 "D:\CURSO TECNICO - SENAC\Modulo1_Senac\Exercicios\UC_5Rosineia.Jesus_Ativ2\Views\Home\Listagem.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n<br>\r\n\r\nTotal de pedidos cadastrados: ");
#nullable restore
#line 37 "D:\CURSO TECNICO - SENAC\Modulo1_Senac\Exercicios\UC_5Rosineia.Jesus_Ativ2\Views\Home\Listagem.cshtml"
                         Write(Dados.PedidoAtual.TotalizarItensPedido());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ItensPedido>> Html { get; private set; }
    }
}
#pragma warning restore 1591
