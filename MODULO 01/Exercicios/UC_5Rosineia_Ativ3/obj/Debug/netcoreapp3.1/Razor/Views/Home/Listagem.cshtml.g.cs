#pragma checksum "D:\CURSO TECNICO - SENAC\Modulo1_Senac\Exercicios\UC_5Rosineia_Ativ3\Views\Home\Listagem.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "458c7673f52a09365d36448c2e6d74f227108019"
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
#line 1 "D:\CURSO TECNICO - SENAC\Modulo1_Senac\Exercicios\UC_5Rosineia_Ativ3\Views\_ViewImports.cshtml"
using UC_5Rosineia_Ativ3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\CURSO TECNICO - SENAC\Modulo1_Senac\Exercicios\UC_5Rosineia_Ativ3\Views\_ViewImports.cshtml"
using UC_5Rosineia_Ativ3.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"458c7673f52a09365d36448c2e6d74f227108019", @"/Views/Home/Listagem.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1573c5b7d5636a6d8b610d8ff10a6704abae8c1b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Listagem : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Agendamento>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h2>Confirmação de Agendamentos</h2>\r\n\r\n<table>\r\n  <style>\r\n    table,\r\n    th,\r\n    td {\r\n      border: 2px solid black;\r\n    }\r\n  </style>\r\n  <h3>Agendamento realizado, Parabéns!!</h3>\r\n\r\n");
#nullable restore
#line 15 "D:\CURSO TECNICO - SENAC\Modulo1_Senac\Exercicios\UC_5Rosineia_Ativ3\Views\Home\Listagem.cshtml"
    foreach (Agendamento a in Model)
  {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <table>\r\n  <tr>\r\n    <th>Nome</th>\r\n    <th>Telefone</th> <br>\r\n    <th>Data</th><br>\r\n    <th>Animal</th><br>\r\n    <th>Necessidade</th><br>\r\n  </tr>\r\n \r\n    <tr>\r\n\r\n      <td>");
#nullable restore
#line 28 "D:\CURSO TECNICO - SENAC\Modulo1_Senac\Exercicios\UC_5Rosineia_Ativ3\Views\Home\Listagem.cshtml"
     Write(a.nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n      <td>");
#nullable restore
#line 29 "D:\CURSO TECNICO - SENAC\Modulo1_Senac\Exercicios\UC_5Rosineia_Ativ3\Views\Home\Listagem.cshtml"
     Write(a.telefone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n      <td>");
#nullable restore
#line 30 "D:\CURSO TECNICO - SENAC\Modulo1_Senac\Exercicios\UC_5Rosineia_Ativ3\Views\Home\Listagem.cshtml"
     Write(a.data.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n      <td>");
#nullable restore
#line 31 "D:\CURSO TECNICO - SENAC\Modulo1_Senac\Exercicios\UC_5Rosineia_Ativ3\Views\Home\Listagem.cshtml"
     Write(a.animal);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n      <td>");
#nullable restore
#line 32 "D:\CURSO TECNICO - SENAC\Modulo1_Senac\Exercicios\UC_5Rosineia_Ativ3\Views\Home\Listagem.cshtml"
     Write(a.necessidade);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    </table>\r\n");
#nullable restore
#line 35 "D:\CURSO TECNICO - SENAC\Modulo1_Senac\Exercicios\UC_5Rosineia_Ativ3\Views\Home\Listagem.cshtml"
  }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\nRetornar para página pricipal ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "458c7673f52a09365d36448c2e6d74f2271080196260", async() => {
                WriteLiteral("Inicio");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Agendamento>> Html { get; private set; }
    }
}
#pragma warning restore 1591
