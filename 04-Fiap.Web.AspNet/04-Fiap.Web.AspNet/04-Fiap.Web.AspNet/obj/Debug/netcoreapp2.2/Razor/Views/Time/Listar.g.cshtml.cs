#pragma checksum "F:\FIAP-TDS\2ANO\thiago\2SEM\Projetos\04-Fiap.Web.AspNet\04-Fiap.Web.AspNet\04-Fiap.Web.AspNet\Views\Time\Listar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "81d34347bde7b673cc5df59d558d43889c614c2d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Time_Listar), @"mvc.1.0.view", @"/Views/Time/Listar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Time/Listar.cshtml", typeof(AspNetCore.Views_Time_Listar))]
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
#line 1 "F:\FIAP-TDS\2ANO\thiago\2SEM\Projetos\04-Fiap.Web.AspNet\04-Fiap.Web.AspNet\04-Fiap.Web.AspNet\Views\_ViewImports.cshtml"
using _04_Fiap.Web.AspNet;

#line default
#line hidden
#line 2 "F:\FIAP-TDS\2ANO\thiago\2SEM\Projetos\04-Fiap.Web.AspNet\04-Fiap.Web.AspNet\04-Fiap.Web.AspNet\Views\_ViewImports.cshtml"
using _04_Fiap.Web.AspNet.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"81d34347bde7b673cc5df59d558d43889c614c2d", @"/Views/Time/Listar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"19cab6835be4e66a23eaaf4573b7b637b298eb82", @"/Views/_ViewImports.cshtml")]
    public class Views_Time_Listar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IList<Time>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Cadastrar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Time", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "F:\FIAP-TDS\2ANO\thiago\2SEM\Projetos\04-Fiap.Web.AspNet\04-Fiap.Web.AspNet\04-Fiap.Web.AspNet\Views\Time\Listar.cshtml"
  
    ViewData["Title"] = "Listar";

#line default
#line hidden
            BeginContext(44, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(66, 24, true);
            WriteLiteral("\r\n<h1>Lista Times</h1>\r\n");
            EndContext();
            BeginContext(90, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "81d34347bde7b673cc5df59d558d43889c614c2d4354", async() => {
                BeginContext(138, 9, true);
                WriteLiteral("Cadastrar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(151, 10, true);
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n");
            EndContext();
#line 14 "F:\FIAP-TDS\2ANO\thiago\2SEM\Projetos\04-Fiap.Web.AspNet\04-Fiap.Web.AspNet\04-Fiap.Web.AspNet\Views\Time\Listar.cshtml"
 if (TempData["msg"] != null)
{

#line default
#line hidden
            BeginContext(195, 33, true);
            WriteLiteral("<div class=\"alert alert-success\">");
            EndContext();
            BeginContext(229, 15, false);
#line 16 "F:\FIAP-TDS\2ANO\thiago\2SEM\Projetos\04-Fiap.Web.AspNet\04-Fiap.Web.AspNet\04-Fiap.Web.AspNet\Views\Time\Listar.cshtml"
                            Write(TempData["msg"]);

#line default
#line hidden
            EndContext();
            BeginContext(244, 8, true);
            WriteLiteral("</div>\r\n");
            EndContext();
#line 17 "F:\FIAP-TDS\2ANO\thiago\2SEM\Projetos\04-Fiap.Web.AspNet\04-Fiap.Web.AspNet\04-Fiap.Web.AspNet\Views\Time\Listar.cshtml"
}

#line default
#line hidden
            BeginContext(255, 196, true);
            WriteLiteral("<table class=\"table\">\r\n\r\n    <tr>\r\n        <th>Nome</th>\r\n        <th>Data Fundação</th>\r\n        <th>Folha de Pagamento</th>\r\n        <th>Vitórias</th>\r\n        <th>Classificado</th>\r\n    </tr>\r\n");
            EndContext();
#line 27 "F:\FIAP-TDS\2ANO\thiago\2SEM\Projetos\04-Fiap.Web.AspNet\04-Fiap.Web.AspNet\04-Fiap.Web.AspNet\Views\Time\Listar.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
            BeginContext(492, 30, true);
            WriteLiteral("        <tr>\r\n            <td>");
            EndContext();
            BeginContext(523, 9, false);
#line 30 "F:\FIAP-TDS\2ANO\thiago\2SEM\Projetos\04-Fiap.Web.AspNet\04-Fiap.Web.AspNet\04-Fiap.Web.AspNet\Views\Time\Listar.cshtml"
           Write(item.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(532, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(556, 17, false);
#line 31 "F:\FIAP-TDS\2ANO\thiago\2SEM\Projetos\04-Fiap.Web.AspNet\04-Fiap.Web.AspNet\04-Fiap.Web.AspNet\Views\Time\Listar.cshtml"
           Write(item.DataFundacao);

#line default
#line hidden
            EndContext();
            BeginContext(573, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(597, 19, false);
#line 32 "F:\FIAP-TDS\2ANO\thiago\2SEM\Projetos\04-Fiap.Web.AspNet\04-Fiap.Web.AspNet\04-Fiap.Web.AspNet\Views\Time\Listar.cshtml"
           Write(item.FolhaPagamento);

#line default
#line hidden
            EndContext();
            BeginContext(616, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(640, 13, false);
#line 33 "F:\FIAP-TDS\2ANO\thiago\2SEM\Projetos\04-Fiap.Web.AspNet\04-Fiap.Web.AspNet\04-Fiap.Web.AspNet\Views\Time\Listar.cshtml"
           Write(item.Vitorias);

#line default
#line hidden
            EndContext();
            BeginContext(653, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(678, 29, false);
#line 34 "F:\FIAP-TDS\2ANO\thiago\2SEM\Projetos\04-Fiap.Web.AspNet\04-Fiap.Web.AspNet\04-Fiap.Web.AspNet\Views\Time\Listar.cshtml"
            Write(item.Classificado?"Sim":"Não");

#line default
#line hidden
            EndContext();
            BeginContext(708, 24, true);
            WriteLiteral("</td>\r\n\r\n        </tr>\r\n");
            EndContext();
#line 37 "F:\FIAP-TDS\2ANO\thiago\2SEM\Projetos\04-Fiap.Web.AspNet\04-Fiap.Web.AspNet\04-Fiap.Web.AspNet\Views\Time\Listar.cshtml"
    }

#line default
#line hidden
            BeginContext(739, 10, true);
            WriteLiteral("\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IList<Time>> Html { get; private set; }
    }
}
#pragma warning restore 1591
