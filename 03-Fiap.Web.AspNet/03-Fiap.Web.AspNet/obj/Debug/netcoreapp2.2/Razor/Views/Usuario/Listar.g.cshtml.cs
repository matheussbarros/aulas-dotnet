#pragma checksum "E:\FIAP-TDS\2ANO\thiago\2SEM\Projetos\03-Fiap.Web.AspNet\03-Fiap.Web.AspNet\Views\Usuario\Listar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e7b32a3e5cf6bb7bc27d89686b314d1b7cdb7ab7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuario_Listar), @"mvc.1.0.view", @"/Views/Usuario/Listar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Usuario/Listar.cshtml", typeof(AspNetCore.Views_Usuario_Listar))]
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
#line 1 "E:\FIAP-TDS\2ANO\thiago\2SEM\Projetos\03-Fiap.Web.AspNet\03-Fiap.Web.AspNet\Views\_ViewImports.cshtml"
using _03_Fiap.Web.AspNet;

#line default
#line hidden
#line 2 "E:\FIAP-TDS\2ANO\thiago\2SEM\Projetos\03-Fiap.Web.AspNet\03-Fiap.Web.AspNet\Views\_ViewImports.cshtml"
using _03_Fiap.Web.AspNet.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e7b32a3e5cf6bb7bc27d89686b314d1b7cdb7ab7", @"/Views/Usuario/Listar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70c6b2faf4af2b11edff1dd927194cae734b1dc1", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuario_Listar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "E:\FIAP-TDS\2ANO\thiago\2SEM\Projetos\03-Fiap.Web.AspNet\03-Fiap.Web.AspNet\Views\Usuario\Listar.cshtml"
  
    ViewData["Title"] = "Listar";

#line default
#line hidden
            BeginContext(44, 147, true);
            WriteLiteral("\r\n<h1>Lista de Usuários</h1>\r\n\r\n<table class=\"table\">\r\n    <tr>\r\n        <th>Nome</th>\r\n        <th>Data</th>\r\n        <th>E-mail</th>\r\n    </tr>\r\n");
            EndContext();
#line 14 "E:\FIAP-TDS\2ANO\thiago\2SEM\Projetos\03-Fiap.Web.AspNet\03-Fiap.Web.AspNet\Views\Usuario\Listar.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
            BeginContext(232, 30, true);
            WriteLiteral("        <tr>\r\n            <td>");
            EndContext();
            BeginContext(263, 9, false);
#line 17 "E:\FIAP-TDS\2ANO\thiago\2SEM\Projetos\03-Fiap.Web.AspNet\03-Fiap.Web.AspNet\Views\Usuario\Listar.cshtml"
           Write(item.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(272, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(296, 19, false);
#line 18 "E:\FIAP-TDS\2ANO\thiago\2SEM\Projetos\03-Fiap.Web.AspNet\03-Fiap.Web.AspNet\Views\Usuario\Listar.cshtml"
           Write(item.DataNascimento);

#line default
#line hidden
            EndContext();
            BeginContext(315, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(339, 10, false);
#line 19 "E:\FIAP-TDS\2ANO\thiago\2SEM\Projetos\03-Fiap.Web.AspNet\03-Fiap.Web.AspNet\Views\Usuario\Listar.cshtml"
           Write(item.Email);

#line default
#line hidden
            EndContext();
            BeginContext(349, 22, true);
            WriteLiteral("</td>\r\n        </tr>\r\n");
            EndContext();
#line 21 "E:\FIAP-TDS\2ANO\thiago\2SEM\Projetos\03-Fiap.Web.AspNet\03-Fiap.Web.AspNet\Views\Usuario\Listar.cshtml"
    }

#line default
#line hidden
            BeginContext(378, 14, true);
            WriteLiteral("\r\n</table>\r\n\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
