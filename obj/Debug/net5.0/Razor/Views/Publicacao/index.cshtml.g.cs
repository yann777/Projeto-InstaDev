#pragma checksum "C:\Users\User\OneDrive\Área de Trabalho\InstaDev-Projeto_1DM\Views\Publicacao\index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "343b4be22ff74378c41743e05611737e66c41af1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Publicacao_index), @"mvc.1.0.view", @"/Views/Publicacao/index.cshtml")]
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
#line 1 "C:\Users\User\OneDrive\Área de Trabalho\InstaDev-Projeto_1DM\Views\_ViewImports.cshtml"
using InstaDev_Projeto_1DM;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\OneDrive\Área de Trabalho\InstaDev-Projeto_1DM\Views\_ViewImports.cshtml"
using InstaDev_Projeto_1DM.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"343b4be22ff74378c41743e05611737e66c41af1", @"/Views/Publicacao/index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d08ce984e7ec58e67bf2c1fbecdafb602c2d537", @"/Views/_ViewImports.cshtml")]
    public class Views_Publicacao_index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Cadastro>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Logout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\User\OneDrive\Área de Trabalho\InstaDev-Projeto_1DM\Views\Publicacao\index.cshtml"
  
    ViewData["Title"] = "Publicacao";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<header>\r\n        <div class=\"logo\"><img src=\"../images/Instadev.svg\"");
            BeginWriteAttribute("alt", " alt=\"", 134, "\"", 140, 0);
            EndWriteAttribute();
            WriteLiteral(@"></div>
        <div class=""search-box"">
         <svg xmlns=""http://www.w3.org/2000/svg"" width=""16"" height=""16"" fill=""currentColor"" class=""bi bi-search"" viewBox=""0 0 16 16""><path d=""M11.742 10.344a6.5 6.5 0 1 0-1.397 1.398h-.001c.03.04.062.078.098.115l3.85 3.85a1 1 0 0 0 1.415-1.414l-3.85-3.85a1.007 1.007 0 0 0-.115-.1zM12 6.5a5.5 5.5 0 1 1-11 0 5.5 5.5 0 0 1 11 0z""/></svg>
            <input type=""search"" name=""pesquisar"" id=""pesquisa"" placeholder=""Pesquisar""><i class=""bi bi-search""></i>
        </div><!--barra de pesquisa-->
        <div class=""info-perfil"">
            <ul class=""icons"">
                <li><a href=""../Publicacao""><img src=""../images/house.svg""");
            BeginWriteAttribute("alt", " alt=\"", 821, "\"", 827, 0);
            EndWriteAttribute();
            WriteLiteral("></a></li>\r\n                <li><a href=\"#\"><img src=\"../images/plane 1.svg\"");
            BeginWriteAttribute("alt", " alt=\"", 904, "\"", 910, 0);
            EndWriteAttribute();
            WriteLiteral("></a></li>\r\n                <li><a href=\"#\"><img src=\"../images/compass 1.svg\"");
            BeginWriteAttribute("alt", " alt=\"", 989, "\"", 995, 0);
            EndWriteAttribute();
            WriteLiteral("></a></li>\r\n                <li><a href=\"#\"><img src=\"../images/heart.svg\"");
            BeginWriteAttribute("alt", " alt=\"", 1070, "\"", 1076, 0);
            EndWriteAttribute();
            WriteLiteral(@"></a></li>
                <li onclick=""botaoMenu()"" class=""perfil2""><a  class=""perfil"" href=""../Perfil""></a></li>
                <ul class=""menu-perfil"" id=""menu-perfil"">
                    <li><a href=""../Perfil"">Perfil</a></li>
                    <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "343b4be22ff74378c41743e05611737e66c41af16884", async() => {
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
            WriteLiteral(@"</li>
                </ul>
            </ul>          
        </div>

</header>

<div class=""container"">
    <div class=""story"">
        <ul class=""stories"">
            <li><img src=""../img/vin-diesel 1.png"" alt=""vin-diesel""></li>
          
            <li><img src=""../img/gabigordo 1.png"" alt=""Gabi-gordo""></li>
            
            <li><img src=""../img/will-baiano 1.png"" alt=""Will Baiano""></li>
          
            <li><img src=""../img/tony_stark 1.png"" alt=""Tony Stark""></li>
            
            <li><img src=""../img/pele 1.png"" alt=""Pelé""></li>
            
            <li><img src=""../img/samuel-rosa-bebê 1.png"" alt=""Samuel Rosa""></li>
            
            <li><img src=""../img/chaves_metal 1.png"" alt=""Chaves Metal""></li>

            <div class=""menu-lateral-perfil"">
                <div class=""img-user-2"">

                </div>
                <h5><a href=""../Perfil"">");
#nullable restore
#line 49 "C:\Users\User\OneDrive\Área de Trabalho\InstaDev-Projeto_1DM\Views\Publicacao\index.cshtml"
                                   Write(ViewBag.User);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h5>\r\n                <p>");
#nullable restore
#line 50 "C:\Users\User\OneDrive\Área de Trabalho\InstaDev-Projeto_1DM\Views\Publicacao\index.cshtml"
              Write(ViewBag.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
            </div>
            
        </ul>
        <div class=""stories-nomes"">
            <p>vin_diesel</p>
            <p>Gabi_gordo</p>
            <p>Will Baiano</p>
            <p>Tony Stark</p>
            <p>Pelé</p>
            <p>Samuel Rosa</p>
            <p>Cheves metal</p>
        </div>
           
    </div>

    <div class=""formPublicacao"">
        <div class=""user"">
            <div class=""img-user"">

            </div>
            <div class=""secao-postar"">
                <p>Postar</p>
            </div>
        </div>
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "343b4be22ff74378c41743e05611737e66c41af110343", async() => {
                WriteLiteral("\r\n            <input type=\"text\" name=\"Legenda\"");
                BeginWriteAttribute("id", " id=\"", 3101, "\"", 3106, 0);
                EndWriteAttribute();
                WriteLiteral(@" placeholder=""Digite aqui sua legenda..."">
            <div class=""form-group"">
                <label for=""fupload"" class=""control-label label-bordered"">Escolha uma imagem</label>
                <input type=""file"" id=""fupload"" name=""fupload"" class=""fupload form-control"" />
            </div>
            <button class=""publi"" type=""submit"">Postar</button>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
#nullable restore
#line 75 "C:\Users\User\OneDrive\Área de Trabalho\InstaDev-Projeto_1DM\Views\Publicacao\index.cshtml"
AddHtmlAttributeValue("", 2997, Url.Action("Cadastrar"), 2997, 24, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n\r\n");
#nullable restore
#line 85 "C:\Users\User\OneDrive\Área de Trabalho\InstaDev-Projeto_1DM\Views\Publicacao\index.cshtml"
     foreach (Publicacao post in ViewBag.Publicacoes)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"posts\">\r\n            <div class=\"info-user-post\">\r\n                <div class=\"img-user\">\r\n\r\n                </div>\r\n                <div class=\"name-user\">\r\n                    <p>");
#nullable restore
#line 93 "C:\Users\User\OneDrive\Área de Trabalho\InstaDev-Projeto_1DM\Views\Publicacao\index.cshtml"
                  Write(ViewBag.User);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p><a href=\"#\">São Paulo, Brasil</a></p>\r\n                </div>         \r\n            </div>\r\n            <div class=\"imgPost\">\r\n               \r\n            <img");
            BeginWriteAttribute("src", " src=\"", 3968, "\"", 4022, 2);
            WriteAttributeValue("", 3974, "../imgPublicacao/Publicacoes/", 3974, 29, true);
#nullable restore
#line 99 "C:\Users\User\OneDrive\Área de Trabalho\InstaDev-Projeto_1DM\Views\Publicacao\index.cshtml"
WriteAttributeValue("", 4003, post.ImgPublicacao, 4003, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n             \r\n            </div>\r\n            <div class=\"legenda\">\r\n                    <a href=\"../Perfil\">");
#nullable restore
#line 103 "C:\Users\User\OneDrive\Área de Trabalho\InstaDev-Projeto_1DM\Views\Publicacao\index.cshtml"
                                   Write(ViewBag.User);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                    <p>");
#nullable restore
#line 104 "C:\Users\User\OneDrive\Área de Trabalho\InstaDev-Projeto_1DM\Views\Publicacao\index.cshtml"
                  Write(post.Legenda);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n            <div class=\"comentarios\">\r\n\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 110 "C:\Users\User\OneDrive\Área de Trabalho\InstaDev-Projeto_1DM\Views\Publicacao\index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>");
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
