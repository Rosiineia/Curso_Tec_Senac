#pragma checksum "D:\CURSO TECNICO - SENAC\Modulo1_Senac\MODULO 01\Exercicios\UC04_Atividade2\Views\Usuario\Lista.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9cc225437a2d71d8af02ed593a35b068f3c472b6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuario_Lista), @"mvc.1.0.view", @"/Views/Usuario/Lista.cshtml")]
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
#line 1 "D:\CURSO TECNICO - SENAC\Modulo1_Senac\MODULO 01\Exercicios\UC04_Atividade2\Views\_ViewImports.cshtml"
using Rosineia_UC04_Atividade2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\CURSO TECNICO - SENAC\Modulo1_Senac\MODULO 01\Exercicios\UC04_Atividade2\Views\_ViewImports.cshtml"
using Rosineia_UC04_Atividade2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9cc225437a2d71d8af02ed593a35b068f3c472b6", @"/Views/Usuario/Lista.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c5c582c49da3a57183cf3c75f5b9eccc8a2121f", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuario_Lista : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Usuario>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\CURSO TECNICO - SENAC\Modulo1_Senac\MODULO 01\Exercicios\UC04_Atividade2\Views\Usuario\Lista.cshtml"
      
        ViewData["Title"] = "Lista";
    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n <table class=\"table\">\r\n  <tr>\r\n    <th>Id</th>\r\n    <th>Nome</th> <br>\r\n    <th>Login</th><br>\r\n    <th>Senha</th><br>\r\n    <th>Data de Nascimento</th><br>\r\n  </tr>\r\n");
#nullable restore
#line 15 "D:\CURSO TECNICO - SENAC\Modulo1_Senac\MODULO 01\Exercicios\UC04_Atividade2\Views\Usuario\Lista.cshtml"
  foreach (Usuario us in Model)
  {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\r\n\r\n      <td>");
#nullable restore
#line 19 "D:\CURSO TECNICO - SENAC\Modulo1_Senac\MODULO 01\Exercicios\UC04_Atividade2\Views\Usuario\Lista.cshtml"
     Write(us.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n      <td>");
#nullable restore
#line 20 "D:\CURSO TECNICO - SENAC\Modulo1_Senac\MODULO 01\Exercicios\UC04_Atividade2\Views\Usuario\Lista.cshtml"
     Write(us.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n      <td>");
#nullable restore
#line 21 "D:\CURSO TECNICO - SENAC\Modulo1_Senac\MODULO 01\Exercicios\UC04_Atividade2\Views\Usuario\Lista.cshtml"
     Write(us.Login);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n      <td>");
#nullable restore
#line 22 "D:\CURSO TECNICO - SENAC\Modulo1_Senac\MODULO 01\Exercicios\UC04_Atividade2\Views\Usuario\Lista.cshtml"
     Write(us.Senha);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n      <td>");
#nullable restore
#line 23 "D:\CURSO TECNICO - SENAC\Modulo1_Senac\MODULO 01\Exercicios\UC04_Atividade2\Views\Usuario\Lista.cshtml"
     Write(us.DataNascimento);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n      <td>\r\n\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 455, "\"", 488, 2);
            WriteAttributeValue("", 462, "/Usuario/alterar?Id=", 462, 20, true);
#nullable restore
#line 26 "D:\CURSO TECNICO - SENAC\Modulo1_Senac\MODULO 01\Exercicios\UC04_Atividade2\Views\Usuario\Lista.cshtml"
WriteAttributeValue("", 482, us.Id, 482, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Alterar</a>\r\n\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 515, "\"", 548, 2);
            WriteAttributeValue("", 522, "/Usuario/excluir?Id=", 522, 20, true);
#nullable restore
#line 28 "D:\CURSO TECNICO - SENAC\Modulo1_Senac\MODULO 01\Exercicios\UC04_Atividade2\Views\Usuario\Lista.cshtml"
WriteAttributeValue("", 542, us.Id, 542, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Excluir</a>\r\n      </td>\r\n\r\n    </tr>\r\n");
#nullable restore
#line 32 "D:\CURSO TECNICO - SENAC\Modulo1_Senac\MODULO 01\Exercicios\UC04_Atividade2\Views\Usuario\Lista.cshtml"
  }

#line default
#line hidden
#nullable disable
            WriteLiteral("  <tbody>\r\n  </tbody>\r\n</table>\r\n  \r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Usuario>> Html { get; private set; }
    }
}
#pragma warning restore 1591
