#pragma checksum "C:\Users\FIC\Desktop\InstaDev-Projeto_1DM\Views\Perfil\index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d234e14a78782293608cc21df915d5e153bf327d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Perfil_index), @"mvc.1.0.view", @"/Views/Perfil/index.cshtml")]
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
#line 1 "C:\Users\FIC\Desktop\InstaDev-Projeto_1DM\Views\_ViewImports.cshtml"
using InstaDev_Projeto_1DM;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\FIC\Desktop\InstaDev-Projeto_1DM\Views\_ViewImports.cshtml"
using InstaDev_Projeto_1DM.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d234e14a78782293608cc21df915d5e153bf327d", @"/Views/Perfil/index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d08ce984e7ec58e67bf2c1fbecdafb602c2d537", @"/Views/_ViewImports.cshtml")]
    public class Views_Perfil_index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Cadastro>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Logout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\FIC\Desktop\InstaDev-Projeto_1DM\Views\Perfil\index.cshtml"
  
    ViewData["Title"] = "Perfil";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<header>\r\n        <div class=\"logo\"><img src=\"../images/Instadev.svg\"");
            BeginWriteAttribute("alt", " alt=\"", 131, "\"", 137, 0);
            EndWriteAttribute();
            WriteLiteral(@"></div>
        <div class=""search-box"">
         <svg xmlns=""http://www.w3.org/2000/svg"" width=""16"" height=""16"" fill=""currentColor"" class=""bi bi-search"" viewBox=""0 0 16 16""><path d=""M11.742 10.344a6.5 6.5 0 1 0-1.397 1.398h-.001c.03.04.062.078.098.115l3.85 3.85a1 1 0 0 0 1.415-1.414l-3.85-3.85a1.007 1.007 0 0 0-.115-.1zM12 6.5a5.5 5.5 0 1 1-11 0 5.5 5.5 0 0 1 11 0z""/></svg>
            <input type=""search"" name=""pesquisar"" id=""pesquisa"" placeholder=""Pesquisar""><i class=""bi bi-search""></i>
        </div><!--barra de pesquisa-->
        <div class=""info-perfil"">
            <ul class=""icons"">
                <li><a href=""../Publicacao""><img src=""../images/house.svg""");
            BeginWriteAttribute("alt", " alt=\"", 818, "\"", 824, 0);
            EndWriteAttribute();
            WriteLiteral("></a></li>\r\n                <li><a href=\"#\"><img src=\"../images/plane 1.svg\"");
            BeginWriteAttribute("alt", " alt=\"", 901, "\"", 907, 0);
            EndWriteAttribute();
            WriteLiteral("></a></li>\r\n                <li><a href=\"#\"><img src=\"../images/compass 1.svg\"");
            BeginWriteAttribute("alt", " alt=\"", 986, "\"", 992, 0);
            EndWriteAttribute();
            WriteLiteral("></a></li>\r\n                <li><a href=\"#\"><img src=\"../images/heart.svg\"");
            BeginWriteAttribute("alt", " alt=\"", 1067, "\"", 1073, 0);
            EndWriteAttribute();
            WriteLiteral(@"></a></li>
                <li onclick=""botaoMenu()"" class=""perfil2""><a  class=""perfil"" href=""../Perfil""></a></li>
                <ul class=""menu-perfil"" id=""menu-perfil"">
                    <li><a href=""../Perfil"">Perfil</a></li>
                    <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d234e14a78782293608cc21df915d5e153bf327d5842", async() => {
                WriteLiteral("Sair");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n                </ul>\r\n            </ul>          \r\n        </div>\r\n\r\n</header>\r\n\r\n<div class=\"container\">\r\n    <div class=\"infos-perfil\">\r\n        <div class=\"foto-perfil\">\r\n\r\n        </div>\r\n        <div class=\"info\">\r\n                <p>");
#nullable restore
#line 34 "C:\Users\FIC\Desktop\InstaDev-Projeto_1DM\Views\Perfil\index.cshtml"
              Write(ViewBag.User);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>     

                <div class=""seguidores"">
                    <p> 0 Publicações</p>
                    <p> 0 Seguindo</p>
                    <p> 0 Seguidores</p>
                </div>
                <div class=""usuario"">
                    <h5>");
#nullable restore
#line 42 "C:\Users\FIC\Desktop\InstaDev-Projeto_1DM\Views\Perfil\index.cshtml"
                   Write(ViewBag.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("<!--Nome do perfil--></h5>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d234e14a78782293608cc21df915d5e153bf327d8241", async() => {
                WriteLiteral("Sair");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    <a href=""#"">Editar perfil</a>
                </div>
        </div>
    </div>
    <div class=""publicacoes"">
       <h4>PUBLICAÇÕES</h4>
            <div class=""publicacao"">
                <div class=""imagem"">
                   
                </div>
                <div class=""info-publicacao"">
                        <div class=""imagemperfilpublicacao"">

                        </div>
                        <div class=""nomeelocalizacao"">
                            <p>wall<!--NomeCompleto--></p>
                            <a href=""#""><p>São Paulo, Brasil<!--Localização--></p></a>
                        </div>
                        <div class=""icons-publicacao"">         
                                <img src=""../images/heart.svg"" alt=""Curtir"">
                                <img src=""../images/Comentarios.svg"" alt=""Comentarios"">
                        </div>
                        <div class=""curtidas"">
                            <p>200 Curtidas</p>");
            WriteLiteral(@"
                        </div>
                        <div class=""comentarios"">
                            <div class=""comentarios-pessoas"">
                                <a href=""#"">fausto_silva<!--nome de usuarios--></a>
                                <p>Oloco bixo!<!--comentario de algum usuario--></p>
                                <img src=""../images/heart.svg"" alt=""Curtir"">
                            </div>
                        </div>
                </div>
            </div>
    </div>
</div><!--Container-->");
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
