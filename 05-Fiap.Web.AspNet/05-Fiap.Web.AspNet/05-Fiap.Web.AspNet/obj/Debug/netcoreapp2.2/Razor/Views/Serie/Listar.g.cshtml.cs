#pragma checksum "E:\FIAP-TDS\2ANO\thiago\2SEM\Projetos\05-Fiap.Web.AspNet\05-Fiap.Web.AspNet\05-Fiap.Web.AspNet\Views\Serie\Listar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "93e6f63e084f45c4c6f97b997d402d27d92b846e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Serie_Listar), @"mvc.1.0.view", @"/Views/Serie/Listar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Serie/Listar.cshtml", typeof(AspNetCore.Views_Serie_Listar))]
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
#line 1 "E:\FIAP-TDS\2ANO\thiago\2SEM\Projetos\05-Fiap.Web.AspNet\05-Fiap.Web.AspNet\05-Fiap.Web.AspNet\Views\_ViewImports.cshtml"
using _05_Fiap.Web.AspNet;

#line default
#line hidden
#line 2 "E:\FIAP-TDS\2ANO\thiago\2SEM\Projetos\05-Fiap.Web.AspNet\05-Fiap.Web.AspNet\05-Fiap.Web.AspNet\Views\_ViewImports.cshtml"
using _05_Fiap.Web.AspNet.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"93e6f63e084f45c4c6f97b997d402d27d92b846e", @"/Views/Serie/Listar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f28426a4bd23c3d46b8f25efded82f7cacc609d", @"/Views/_ViewImports.cshtml")]
    public class Views_Serie_Listar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IList<Serie>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(23, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "E:\FIAP-TDS\2ANO\thiago\2SEM\Projetos\05-Fiap.Web.AspNet\05-Fiap.Web.AspNet\05-Fiap.Web.AspNet\Views\Serie\Listar.cshtml"
  
    ViewData["Title"] = "Listar";

#line default
#line hidden
            BeginContext(67, 27, true);
            WriteLiteral("\r\n\r\n\r\n\r\n<h1>Listar</h1>\r\n\r\n");
            EndContext();
#line 13 "E:\FIAP-TDS\2ANO\thiago\2SEM\Projetos\05-Fiap.Web.AspNet\05-Fiap.Web.AspNet\05-Fiap.Web.AspNet\Views\Serie\Listar.cshtml"
 if (TempData["msg"] != null)
{
    
}

#line default
#line hidden
            BeginContext(137, 11, true);
            WriteLiteral("\r\n<mensagem");
            EndContext();
            BeginWriteAttribute("texto", " texto=\"", 148, "\"", 172, 1);
#line 18 "E:\FIAP-TDS\2ANO\thiago\2SEM\Projetos\05-Fiap.Web.AspNet\05-Fiap.Web.AspNet\05-Fiap.Web.AspNet\Views\Serie\Listar.cshtml"
WriteAttributeValue("", 156, TempData["msg"], 156, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(173, 168, true);
            WriteLiteral("></mensagem>\r\n\r\n<table class=\"table\">\r\n    <tr>\r\n        <th>Nome</th>\r\n        <th>Temporada</th>\r\n        <th>Tipo</th>\r\n        <th>Data Lançamento</th>\r\n    </tr>\r\n");
            EndContext();
#line 27 "E:\FIAP-TDS\2ANO\thiago\2SEM\Projetos\05-Fiap.Web.AspNet\05-Fiap.Web.AspNet\05-Fiap.Web.AspNet\Views\Serie\Listar.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
            BeginContext(382, 30, true);
            WriteLiteral("        <tr>\r\n            <td>");
            EndContext();
            BeginContext(413, 9, false);
#line 30 "E:\FIAP-TDS\2ANO\thiago\2SEM\Projetos\05-Fiap.Web.AspNet\05-Fiap.Web.AspNet\05-Fiap.Web.AspNet\Views\Serie\Listar.cshtml"
           Write(item.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(422, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(446, 15, false);
#line 31 "E:\FIAP-TDS\2ANO\thiago\2SEM\Projetos\05-Fiap.Web.AspNet\05-Fiap.Web.AspNet\05-Fiap.Web.AspNet\Views\Serie\Listar.cshtml"
           Write(item.Temporadas);

#line default
#line hidden
            EndContext();
            BeginContext(461, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(485, 9, false);
#line 32 "E:\FIAP-TDS\2ANO\thiago\2SEM\Projetos\05-Fiap.Web.AspNet\05-Fiap.Web.AspNet\05-Fiap.Web.AspNet\Views\Serie\Listar.cshtml"
           Write(item.Tipo);

#line default
#line hidden
            EndContext();
            BeginContext(494, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(518, 39, false);
#line 33 "E:\FIAP-TDS\2ANO\thiago\2SEM\Projetos\05-Fiap.Web.AspNet\05-Fiap.Web.AspNet\05-Fiap.Web.AspNet\Views\Serie\Listar.cshtml"
           Write(item.DataLancamento.ToShortDateString());

#line default
#line hidden
            EndContext();
            BeginContext(557, 22, true);
            WriteLiteral("</td>\r\n        </tr>\r\n");
            EndContext();
#line 35 "E:\FIAP-TDS\2ANO\thiago\2SEM\Projetos\05-Fiap.Web.AspNet\05-Fiap.Web.AspNet\05-Fiap.Web.AspNet\Views\Serie\Listar.cshtml"
    }

#line default
#line hidden
            BeginContext(586, 18, true);
            WriteLiteral("\r\n</table>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IList<Serie>> Html { get; private set; }
    }
}
#pragma warning restore 1591
