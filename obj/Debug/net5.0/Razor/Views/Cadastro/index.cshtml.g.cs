#pragma checksum "C:\Users\user\Desktop\InstaDev-Projeto_1DM\Projeto-InstaDev\Views\Cadastro\index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ff2d16b2d0a5d65e6e1e13f976f096dcf0e23cde"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cadastro_index), @"mvc.1.0.view", @"/Views/Cadastro/index.cshtml")]
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
#line 1 "C:\Users\user\Desktop\InstaDev-Projeto_1DM\Projeto-InstaDev\Views\_ViewImports.cshtml"
using InstaDev_Projeto_1DM;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\user\Desktop\InstaDev-Projeto_1DM\Projeto-InstaDev\Views\_ViewImports.cshtml"
using InstaDev_Projeto_1DM.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff2d16b2d0a5d65e6e1e13f976f096dcf0e23cde", @"/Views/Cadastro/index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d08ce984e7ec58e67bf2c1fbecdafb602c2d537", @"/Views/_ViewImports.cshtml")]
    public class Views_Cadastro_index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Cadastro>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("cadastro"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\user\Desktop\InstaDev-Projeto_1DM\Projeto-InstaDev\Views\Cadastro\index.cshtml"
  
    ViewData["Title"] = "Cadastre-se";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container\">\r\n    <div class=\"formulario\">\r\n        <img src=\"../images/Instadev.svg\"");
            BeginWriteAttribute("alt", " alt=\"", 162, "\"", 168, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n        <h5>Cadastre-se para ver videos e <br> fotos do seus amigos</h5>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ff2d16b2d0a5d65e6e1e13f976f096dcf0e23cde4460", async() => {
                WriteLiteral("\r\n                <input type=\"email\" name=\"Email\"");
                BeginWriteAttribute("id", " id=\"", 380, "\"", 385, 0);
                EndWriteAttribute();
                WriteLiteral(" placeholder=\"E-mail\" required>\r\n                <input type=\"text\" name=\"NomeCompleto\"");
                BeginWriteAttribute("id", " id=\"", 473, "\"", 478, 0);
                EndWriteAttribute();
                WriteLiteral(" placeholder=\"Nome Completo\" required>\r\n                <input type=\"text\" name=\"Username\"");
                BeginWriteAttribute("id", " id=\"", 569, "\"", 574, 0);
                EndWriteAttribute();
                WriteLiteral(" placeholder=\"Nome de usuário\" required>\r\n                <input type=\"date\" name=\"DataDeNascimento\"");
                BeginWriteAttribute("id", " id=\"", 675, "\"", 680, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                <input type=\"file\" name=\"foto\">\r\n                <input type=\"password\" name=\"Senha\"");
                BeginWriteAttribute("id", " id=\"", 784, "\"", 789, 0);
                EndWriteAttribute();
                WriteLiteral(" placeholder=\"Senha\" required>\r\n                <button type=\"submit\">Cadastre-se</button>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
#nullable restore
#line 10 "C:\Users\user\Desktop\InstaDev-Projeto_1DM\Projeto-InstaDev\Views\Cadastro\index.cshtml"
AddHtmlAttributeValue("", 289, Url.Action("Cadastrar"), 289, 24, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        <h6>Ao se cadastrar em nosso site você concorda com nossos <br> <a");
            BeginWriteAttribute("href", " href=\"", 977, "\"", 984, 0);
            EndWriteAttribute();
            WriteLiteral(@">Termos, Política de dados e Políticas de Cookies</a></h6>    
    </div><!--Formulario DIV-->
    <div class=""jatemconta"">
        <p>Tem uma conta?<a href=""../Login""> Conecte-se</a></p>
    </div><!--Já tem conta?-->
    <div class=""app"">
        <p>Obtenha o aplicativo</p>
        <a href=""#""><img src=""../images/app_store 1.svg""");
            BeginWriteAttribute("alt", " alt=\"", 1325, "\"", 1331, 0);
            EndWriteAttribute();
            WriteLiteral("></a>\r\n        <a href=\"#\"><img src=\"../images/google_play 1.svg\"");
            BeginWriteAttribute("alt", " alt=\"", 1397, "\"", 1403, 0);
            EndWriteAttribute();
            WriteLiteral("></a>\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Cadastro> Html { get; private set; }
    }
}
#pragma warning restore 1591
