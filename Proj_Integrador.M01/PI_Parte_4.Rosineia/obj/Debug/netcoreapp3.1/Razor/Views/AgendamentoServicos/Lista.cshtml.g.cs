#pragma checksum "D:\CURSO TECNICO - SENAC\Proj_Integrador.M01\PI_Parte_4.Rosineia\Views\AgendamentoServicos\Lista.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "166298558a73fcff2bbe66fa7019b5b982533aa0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AgendamentoServicos_Lista), @"mvc.1.0.view", @"/Views/AgendamentoServicos/Lista.cshtml")]
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
#line 1 "D:\CURSO TECNICO - SENAC\Proj_Integrador.M01\PI_Parte_4.Rosineia\Views\_ViewImports.cshtml"
using PI_Parte_4.Rosineia;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\CURSO TECNICO - SENAC\Proj_Integrador.M01\PI_Parte_4.Rosineia\Views\_ViewImports.cshtml"
using PI_Parte_4.Rosineia.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\CURSO TECNICO - SENAC\Proj_Integrador.M01\PI_Parte_4.Rosineia\Views\AgendamentoServicos\Lista.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"166298558a73fcff2bbe66fa7019b5b982533aa0", @"/Views/AgendamentoServicos/Lista.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3132be09eacefa0a1ff307314748efea4f5a54c4", @"/Views/_ViewImports.cshtml")]
    public class Views_AgendamentoServicos_Lista : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<AgendamentoServicos>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 5 "D:\CURSO TECNICO - SENAC\Proj_Integrador.M01\PI_Parte_4.Rosineia\Views\AgendamentoServicos\Lista.cshtml"
  
    ViewData["Title"] = "Lista de Agendamentos";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<table class=\"table\">\r\n  <tr>\r\n    <th>Id</th>\r\n    <th>Nome</th> <br>\r\n    <th>Data de Solicitacao</th><br>\r\n    <th>Serviços</th><br>\r\n   <br>\r\n  </tr>\r\n");
#nullable restore
#line 17 "D:\CURSO TECNICO - SENAC\Proj_Integrador.M01\PI_Parte_4.Rosineia\Views\AgendamentoServicos\Lista.cshtml"
  foreach (AgendamentoServicos us in Model)
  {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\r\n\r\n      <td>");
#nullable restore
#line 21 "D:\CURSO TECNICO - SENAC\Proj_Integrador.M01\PI_Parte_4.Rosineia\Views\AgendamentoServicos\Lista.cshtml"
     Write(us.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n      <td>");
#nullable restore
#line 22 "D:\CURSO TECNICO - SENAC\Proj_Integrador.M01\PI_Parte_4.Rosineia\Views\AgendamentoServicos\Lista.cshtml"
     Write(us.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n      <td>");
#nullable restore
#line 23 "D:\CURSO TECNICO - SENAC\Proj_Integrador.M01\PI_Parte_4.Rosineia\Views\AgendamentoServicos\Lista.cshtml"
     Write(us.DataSolicitacao);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n      <td>");
#nullable restore
#line 24 "D:\CURSO TECNICO - SENAC\Proj_Integrador.M01\PI_Parte_4.Rosineia\Views\AgendamentoServicos\Lista.cshtml"
     Write(us.Servico);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n     \r\n      <td>\r\n\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 493, "\"", 538, 2);
            WriteAttributeValue("", 500, "/AgendamentoServicos/alterar?Id=", 500, 32, true);
#nullable restore
#line 28 "D:\CURSO TECNICO - SENAC\Proj_Integrador.M01\PI_Parte_4.Rosineia\Views\AgendamentoServicos\Lista.cshtml"
WriteAttributeValue("", 532, us.Id, 532, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Alterar</a>\r\n\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 565, "\"", 610, 2);
            WriteAttributeValue("", 572, "/AgendamentoServicos/excluir?Id=", 572, 32, true);
#nullable restore
#line 30 "D:\CURSO TECNICO - SENAC\Proj_Integrador.M01\PI_Parte_4.Rosineia\Views\AgendamentoServicos\Lista.cshtml"
WriteAttributeValue("", 604, us.Id, 604, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Excluir</a>\r\n      </td>\r\n\r\n    </tr>\r\n");
#nullable restore
#line 34 "D:\CURSO TECNICO - SENAC\Proj_Integrador.M01\PI_Parte_4.Rosineia\Views\AgendamentoServicos\Lista.cshtml"
  }

#line default
#line hidden
#nullable disable
            WriteLiteral("  <tbody>\r\n  </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<AgendamentoServicos>> Html { get; private set; }
    }
}
#pragma warning restore 1591
