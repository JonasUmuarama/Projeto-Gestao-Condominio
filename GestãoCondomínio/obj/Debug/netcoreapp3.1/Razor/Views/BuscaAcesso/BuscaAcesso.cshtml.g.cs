#pragma checksum "C:\Users\jonas\Documents\Projeto\GestãoCondomínio\GestãoCondomínio\Views\BuscaAcesso\BuscaAcesso.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d0473684017fec285249266472f36901bf832c51"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_BuscaAcesso_BuscaAcesso), @"mvc.1.0.view", @"/Views/BuscaAcesso/BuscaAcesso.cshtml")]
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
#line 1 "C:\Users\jonas\Documents\Projeto\GestãoCondomínio\GestãoCondomínio\Views\_ViewImports.cshtml"
using GestãoCondomínio;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jonas\Documents\Projeto\GestãoCondomínio\GestãoCondomínio\Views\_ViewImports.cshtml"
using GestãoCondomínio.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d0473684017fec285249266472f36901bf832c51", @"/Views/BuscaAcesso/BuscaAcesso.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f183732340d12af10fd306b8d2c08f939e104659", @"/Views/_ViewImports.cshtml")]
    public class Views_BuscaAcesso_BuscaAcesso : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<GestãoCondomínio.Models.AcessoModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("navbar-form navbar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "BuscaAcesso", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\jonas\Documents\Projeto\GestãoCondomínio\GestãoCondomínio\Views\BuscaAcesso\BuscaAcesso.cshtml"
  
    ViewData["Title"] = "Buscar Acesso";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>");
#nullable restore
#line 7 "C:\Users\jonas\Documents\Projeto\GestãoCondomínio\GestãoCondomínio\Views\BuscaAcesso\BuscaAcesso.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n<nav class=\"navbar navbar-inverse\">\r\n    <div class=\"container-fluid\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d0473684017fec285249266472f36901bf832c514993", async() => {
                WriteLiteral("\r\n            <div class=\"form-group\">\r\n                <div class=\"form-group\">\r\n                    <label for=\"minDate\">Data Inicial</label>\r\n                    <input type=\"date\" class=\"form-control\" name=\"minDate\"");
                BeginWriteAttribute("value", " value=", 517, "", 544, 1);
#nullable restore
#line 15 "C:\Users\jonas\Documents\Projeto\GestãoCondomínio\GestãoCondomínio\Views\BuscaAcesso\BuscaAcesso.cshtml"
WriteAttributeValue("", 524, ViewData["minDate"], 524, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <label for=\"maxDate\">Data Final</label>\r\n                    <input type=\"date\" class=\"form-control\" name=\"maxDate\"");
                BeginWriteAttribute("value", " value=", 750, "", 777, 1);
#nullable restore
#line 19 "C:\Users\jonas\Documents\Projeto\GestãoCondomínio\GestãoCondomínio\Views\BuscaAcesso\BuscaAcesso.cshtml"
WriteAttributeValue("", 757, ViewData["maxDate"], 757, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                </div>\r\n            </div>\r\n            <button type=\"submit\" class=\"btn btn-primary\">Buscar</button>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</nav>\r\n<div class=\"panel panel-primary\">\r\n\r\n    <div class=\"panel-body\">\r\n        <table class=\"table table-striped table-hover\">\r\n            <thead>\r\n                <tr class=\"success\">\r\n                    <th>\r\n                        ");
#nullable restore
#line 33 "C:\Users\jonas\Documents\Projeto\GestãoCondomínio\GestãoCondomínio\Views\BuscaAcesso\BuscaAcesso.cshtml"
                   Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 36 "C:\Users\jonas\Documents\Projeto\GestãoCondomínio\GestãoCondomínio\Views\BuscaAcesso\BuscaAcesso.cshtml"
                   Write(Html.DisplayNameFor(model => model.Veiculo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 39 "C:\Users\jonas\Documents\Projeto\GestãoCondomínio\GestãoCondomínio\Views\BuscaAcesso\BuscaAcesso.cshtml"
                   Write(Html.DisplayNameFor(model => model.Condutor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 42 "C:\Users\jonas\Documents\Projeto\GestãoCondomínio\GestãoCondomínio\Views\BuscaAcesso\BuscaAcesso.cshtml"
                   Write(Html.DisplayNameFor(model => model.Documento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 45 "C:\Users\jonas\Documents\Projeto\GestãoCondomínio\GestãoCondomínio\Views\BuscaAcesso\BuscaAcesso.cshtml"
                   Write(Html.DisplayNameFor(model => model.Entrada));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 48 "C:\Users\jonas\Documents\Projeto\GestãoCondomínio\GestãoCondomínio\Views\BuscaAcesso\BuscaAcesso.cshtml"
                   Write(Html.DisplayNameFor(model => model.Saida));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 51 "C:\Users\jonas\Documents\Projeto\GestãoCondomínio\GestãoCondomínio\Views\BuscaAcesso\BuscaAcesso.cshtml"
                   Write(Html.DisplayNameFor(model => model.Destino));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
#nullable restore
#line 56 "C:\Users\jonas\Documents\Projeto\GestãoCondomínio\GestãoCondomínio\Views\BuscaAcesso\BuscaAcesso.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
#nullable restore
#line 60 "C:\Users\jonas\Documents\Projeto\GestãoCondomínio\GestãoCondomínio\Views\BuscaAcesso\BuscaAcesso.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 63 "C:\Users\jonas\Documents\Projeto\GestãoCondomínio\GestãoCondomínio\Views\BuscaAcesso\BuscaAcesso.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Veiculo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 66 "C:\Users\jonas\Documents\Projeto\GestãoCondomínio\GestãoCondomínio\Views\BuscaAcesso\BuscaAcesso.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Condutor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 69 "C:\Users\jonas\Documents\Projeto\GestãoCondomínio\GestãoCondomínio\Views\BuscaAcesso\BuscaAcesso.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Documento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 72 "C:\Users\jonas\Documents\Projeto\GestãoCondomínio\GestãoCondomínio\Views\BuscaAcesso\BuscaAcesso.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Entrada));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 75 "C:\Users\jonas\Documents\Projeto\GestãoCondomínio\GestãoCondomínio\Views\BuscaAcesso\BuscaAcesso.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Saida));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 78 "C:\Users\jonas\Documents\Projeto\GestãoCondomínio\GestãoCondomínio\Views\BuscaAcesso\BuscaAcesso.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Destino));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n\r\n                    </tr>\r\n");
#nullable restore
#line 82 "C:\Users\jonas\Documents\Projeto\GestãoCondomínio\GestãoCondomínio\Views\BuscaAcesso\BuscaAcesso.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<GestãoCondomínio.Models.AcessoModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
