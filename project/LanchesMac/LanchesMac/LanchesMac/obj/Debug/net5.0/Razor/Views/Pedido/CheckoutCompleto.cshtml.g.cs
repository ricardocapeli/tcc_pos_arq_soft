#pragma checksum "C:\Users\admin\Downloads\LanchesMac\LanchesMac\LanchesMac\Views\Pedido\CheckoutCompleto.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f7560e970a69f38404fa5cb31c8244759333c338"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pedido_CheckoutCompleto), @"mvc.1.0.view", @"/Views/Pedido/CheckoutCompleto.cshtml")]
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
#line 1 "C:\Users\admin\Downloads\LanchesMac\LanchesMac\LanchesMac\Views\_ViewImports.cshtml"
using LanchesMac;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\admin\Downloads\LanchesMac\LanchesMac\LanchesMac\Views\_ViewImports.cshtml"
using LanchesMac.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\admin\Downloads\LanchesMac\LanchesMac\LanchesMac\Views\_ViewImports.cshtml"
using LanchesMac.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f7560e970a69f38404fa5cb31c8244759333c338", @"/Views/Pedido/CheckoutCompleto.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"133db4ed61ab83cbde0a14b5646c41c7227b114b", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Pedido_CheckoutCompleto : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Pedido>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link text-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n<div class=\"container marginTop1\">\r\n\r\n    <div class=\"jumbotron\">\r\n        <h2>");
#nullable restore
#line 6 "C:\Users\admin\Downloads\LanchesMac\LanchesMac\LanchesMac\Views\Pedido\CheckoutCompleto.cshtml"
       Write(ViewBag.CheckoutCompletoMensagem);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n    </div>\r\n    <div class=\"card\">\r\n        <div class=\"card-body\">\r\n            <p>Cliente : <strong>");
#nullable restore
#line 10 "C:\Users\admin\Downloads\LanchesMac\LanchesMac\LanchesMac\Views\Pedido\CheckoutCompleto.cshtml"
                            Write(Model.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n            <p>Data do Pedido :  <strong>");
#nullable restore
#line 11 "C:\Users\admin\Downloads\LanchesMac\LanchesMac\LanchesMac\Views\Pedido\CheckoutCompleto.cshtml"
                                    Write(Model.PedidoEnviado);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n            <p>Número do Pedido   : <strong>");
#nullable restore
#line 12 "C:\Users\admin\Downloads\LanchesMac\LanchesMac\LanchesMac\Views\Pedido\CheckoutCompleto.cshtml"
                                       Write(Model.PedidoId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></p>\r\n            <table class=\"table\">\r\n                <tr>\r\n                    <th></th>\r\n                    <th>Quantidade</th>\r\n                    <th>Lanche</th>\r\n                    <th>Preço</th>\r\n                </tr>\r\n");
#nullable restore
#line 20 "C:\Users\admin\Downloads\LanchesMac\LanchesMac\LanchesMac\Views\Pedido\CheckoutCompleto.cshtml"
                 foreach (var item in Model.PedidoItens)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td><img");
            BeginWriteAttribute("src", " src=\"", 766, "\"", 794, 1);
#nullable restore
#line 23 "C:\Users\admin\Downloads\LanchesMac\LanchesMac\LanchesMac\Views\Pedido\CheckoutCompleto.cshtml"
WriteAttributeValue("", 772, item.Lanche.ImagemUrl, 772, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"40\" height=\"40\" /></td>\r\n                        <td>");
#nullable restore
#line 24 "C:\Users\admin\Downloads\LanchesMac\LanchesMac\LanchesMac\Views\Pedido\CheckoutCompleto.cshtml"
                       Write(item.Quantidade);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 25 "C:\Users\admin\Downloads\LanchesMac\LanchesMac\LanchesMac\Views\Pedido\CheckoutCompleto.cshtml"
                       Write(item.Lanche.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 26 "C:\Users\admin\Downloads\LanchesMac\LanchesMac\LanchesMac\Views\Pedido\CheckoutCompleto.cshtml"
                       Write(item.Lanche.Preco);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n");
#nullable restore
#line 28 "C:\Users\admin\Downloads\LanchesMac\LanchesMac\LanchesMac\Views\Pedido\CheckoutCompleto.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </table>\r\n            <h4>Valor Total do Pedido: <strong>");
#nullable restore
#line 30 "C:\Users\admin\Downloads\LanchesMac\LanchesMac\LanchesMac\Views\Pedido\CheckoutCompleto.cshtml"
                                           Write(((decimal)ViewBag.TotalPedido).ToString("C2"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></h4>\r\n        </div>\r\n    </div>\r\n</div>\r\n<div class=\"form-group\" style=\"text-align :center\">\r\n    <h3>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f7560e970a69f38404fa5cb31c8244759333c3388383", async() => {
                WriteLiteral("Retornar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
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
            WriteLiteral("\r\n    </h3>\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Pedido> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
