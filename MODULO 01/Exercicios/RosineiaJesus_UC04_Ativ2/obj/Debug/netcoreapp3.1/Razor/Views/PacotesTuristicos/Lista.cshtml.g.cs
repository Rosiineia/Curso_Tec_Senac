#pragma checksum "D:\CURSO TECNICO - SENAC\Modulo1_Senac\MODULO 01\Exercicios\RosineiaJesus_UC04_Ativ2\Views\PacotesTuristicos\Lista.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4bc4f598f0dbf5871f20171afafa15b9959c8f4d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PacotesTuristicos_Lista), @"mvc.1.0.view", @"/Views/PacotesTuristicos/Lista.cshtml")]
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
#line 1 "D:\CURSO TECNICO - SENAC\Modulo1_Senac\MODULO 01\Exercicios\RosineiaJesus_UC04_Ativ2\Views\_ViewImports.cshtml"
using RosineiaJesus_UC04_Ativ2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\CURSO TECNICO - SENAC\Modulo1_Senac\MODULO 01\Exercicios\RosineiaJesus_UC04_Ativ2\Views\_ViewImports.cshtml"
using RosineiaJesus_UC04_Ativ2.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\CURSO TECNICO - SENAC\Modulo1_Senac\MODULO 01\Exercicios\RosineiaJesus_UC04_Ativ2\Views\PacotesTuristicos\Lista.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4bc4f598f0dbf5871f20171afafa15b9959c8f4d", @"/Views/PacotesTuristicos/Lista.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f639b79923db6fd49931fdb0d5cef46509aa6b7", @"/Views/_ViewImports.cshtml")]
    public class Views_PacotesTuristicos_Lista : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<PacotesTuristicos>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 5 "D:\CURSO TECNICO - SENAC\Modulo1_Senac\MODULO 01\Exercicios\RosineiaJesus_UC04_Ativ2\Views\PacotesTuristicos\Lista.cshtml"
  
    ViewData["Title"] = "Lista de Pacotes Turisticos";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<table class=\"table\">\r\n  <tr>\r\n    <th>Id</th>\r\n    <th>Nome</th> <br>\r\n    <th>Origem</th><br>\r\n    <th>Destino</th><br>\r\n    <th>Atrativos</th><br>\r\n    <th>Saida</th><br>\r\n    <th>Retorno</th><br>\r\n  </tr>\r\n");
#nullable restore
#line 19 "D:\CURSO TECNICO - SENAC\Modulo1_Senac\MODULO 01\Exercicios\RosineiaJesus_UC04_Ativ2\Views\PacotesTuristicos\Lista.cshtml"
  foreach (PacotesTuristicos us in Model)
  {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\r\n\r\n      <td>");
#nullable restore
#line 23 "D:\CURSO TECNICO - SENAC\Modulo1_Senac\MODULO 01\Exercicios\RosineiaJesus_UC04_Ativ2\Views\PacotesTuristicos\Lista.cshtml"
     Write(us.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n      <td>");
#nullable restore
#line 24 "D:\CURSO TECNICO - SENAC\Modulo1_Senac\MODULO 01\Exercicios\RosineiaJesus_UC04_Ativ2\Views\PacotesTuristicos\Lista.cshtml"
     Write(us.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n      <td>");
#nullable restore
#line 25 "D:\CURSO TECNICO - SENAC\Modulo1_Senac\MODULO 01\Exercicios\RosineiaJesus_UC04_Ativ2\Views\PacotesTuristicos\Lista.cshtml"
     Write(us.Origem);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n      <td>");
#nullable restore
#line 26 "D:\CURSO TECNICO - SENAC\Modulo1_Senac\MODULO 01\Exercicios\RosineiaJesus_UC04_Ativ2\Views\PacotesTuristicos\Lista.cshtml"
     Write(us.Destino);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n      <td>");
#nullable restore
#line 27 "D:\CURSO TECNICO - SENAC\Modulo1_Senac\MODULO 01\Exercicios\RosineiaJesus_UC04_Ativ2\Views\PacotesTuristicos\Lista.cshtml"
     Write(us.Atrativos);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n      <td>");
#nullable restore
#line 28 "D:\CURSO TECNICO - SENAC\Modulo1_Senac\MODULO 01\Exercicios\RosineiaJesus_UC04_Ativ2\Views\PacotesTuristicos\Lista.cshtml"
     Write(us.Saida);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n      <td>");
#nullable restore
#line 29 "D:\CURSO TECNICO - SENAC\Modulo1_Senac\MODULO 01\Exercicios\RosineiaJesus_UC04_Ativ2\Views\PacotesTuristicos\Lista.cshtml"
     Write(us.Retorno);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n      <td>\r\n\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 618, "\"", 661, 2);
            WriteAttributeValue("", 625, "/PacotesTuristicos/alterar?Id=", 625, 30, true);
#nullable restore
#line 32 "D:\CURSO TECNICO - SENAC\Modulo1_Senac\MODULO 01\Exercicios\RosineiaJesus_UC04_Ativ2\Views\PacotesTuristicos\Lista.cshtml"
WriteAttributeValue("", 655, us.Id, 655, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Alterar</a>\r\n\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 688, "\"", 731, 2);
            WriteAttributeValue("", 695, "/PacotesTuristicos/excluir?Id=", 695, 30, true);
#nullable restore
#line 34 "D:\CURSO TECNICO - SENAC\Modulo1_Senac\MODULO 01\Exercicios\RosineiaJesus_UC04_Ativ2\Views\PacotesTuristicos\Lista.cshtml"
WriteAttributeValue("", 725, us.Id, 725, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Excluir</a>\r\n      </td>\r\n\r\n    </tr>\r\n");
#nullable restore
#line 38 "D:\CURSO TECNICO - SENAC\Modulo1_Senac\MODULO 01\Exercicios\RosineiaJesus_UC04_Ativ2\Views\PacotesTuristicos\Lista.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<PacotesTuristicos>> Html { get; private set; }
    }
}
#pragma warning restore 1591
