#pragma checksum "C:\Users\andre\OneDrive\Área de Trabalho\InstaDev\Projeto-InstaDev\Views\EdicaoDePerfil\index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f7789014ed3648ab550a15eab8006d3f878bb74a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_EdicaoDePerfil_index), @"mvc.1.0.view", @"/Views/EdicaoDePerfil/index.cshtml")]
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
#line 1 "C:\Users\andre\OneDrive\Área de Trabalho\InstaDev\Projeto-InstaDev\Views\_ViewImports.cshtml"
using InstaDev_Projeto_1DM;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\andre\OneDrive\Área de Trabalho\InstaDev\Projeto-InstaDev\Views\_ViewImports.cshtml"
using InstaDev_Projeto_1DM.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f7789014ed3648ab550a15eab8006d3f878bb74a", @"/Views/EdicaoDePerfil/index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d08ce984e7ec58e67bf2c1fbecdafb602c2d537", @"/Views/_ViewImports.cshtml")]
    public class Views_EdicaoDePerfil_index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Cadastro>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Logout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("navbar-brand"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Link para deletar a conta", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cadastro", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Excluir", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\andre\OneDrive\Área de Trabalho\InstaDev\Projeto-InstaDev\Views\EdicaoDePerfil\index.cshtml"
  
    ViewData["Title"] = "Edição de perfil";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<header>\r\n        <div class=\"logo\"><img src=\"../images/Instadev.svg\"");
            BeginWriteAttribute("alt", " alt=\"", 140, "\"", 146, 0);
            EndWriteAttribute();
            WriteLiteral(@"></div>
        <div class=""search-box"">
         <svg xmlns=""http://www.w3.org/2000/svg"" width=""16"" height=""16"" fill=""currentColor"" class=""bi bi-search"" viewBox=""0 0 16 16""><path d=""M11.742 10.344a6.5 6.5 0 1 0-1.397 1.398h-.001c.03.04.062.078.098.115l3.85 3.85a1 1 0 0 0 1.415-1.414l-3.85-3.85a1.007 1.007 0 0 0-.115-.1zM12 6.5a5.5 5.5 0 1 1-11 0 5.5 5.5 0 0 1 11 0z""/></svg>
            <input type=""search"" name=""pesquisar"" id=""pesquisa"" placeholder=""Pesquisar""><i class=""bi bi-search""></i>
        </div><!--barra de pesquisa-->
        <div class=""info-perfil"">
            <ul class=""icons"">
                <li><a href=""../Publicacao""><img src=""../images/house.svg""");
            BeginWriteAttribute("alt", " alt=\"", 827, "\"", 833, 0);
            EndWriteAttribute();
            WriteLiteral("></a></li>\r\n                <li><a href=\"#\"><img src=\"../images/plane 1.svg\"");
            BeginWriteAttribute("alt", " alt=\"", 910, "\"", 916, 0);
            EndWriteAttribute();
            WriteLiteral("></a></li>\r\n                <li><a href=\"#\"><img src=\"../images/compass 1.svg\"");
            BeginWriteAttribute("alt", " alt=\"", 995, "\"", 1001, 0);
            EndWriteAttribute();
            WriteLiteral("></a></li>\r\n                <li><a href=\"#\"><img src=\"../images/heart.svg\"");
            BeginWriteAttribute("alt", " alt=\"", 1076, "\"", 1082, 0);
            EndWriteAttribute();
            WriteLiteral(@"></a></li>
                <li onclick=""botaoMenu()"" class=""perfil2""><a  class=""perfil"" href=""../Perfil""></a></li>
                <ul class=""menu-perfil"" id=""menu-perfil"">
                    <li><a href=""../Perfil"">Perfil</a></li>
                    <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f7789014ed3648ab550a15eab8006d3f878bb74a8218", async() => {
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

    <section class=""editar-perfil"">
            <div class=""content"">

                <div class=""texto-editar"" >
                    <div class=""texto-editar-perfil"">
                        <h1>Editar Perfil</h1>
                    </div>
                </div>
                <aside class=""editar"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f7789014ed3648ab550a15eab8006d3f878bb74a10008", async() => {
                WriteLiteral("\r\n                    <div class=\"perfil\">\r\n                        <div class=\"conteudo alinhar-esquerda\">\r\n                            <img src=\"img/thank-you 2.png\"");
                BeginWriteAttribute("alt", " alt=\"", 2071, "\"", 2077, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n\r\n                            <div class=\"texto\">\r\n                                <h2>");
#nullable restore
#line 43 "C:\Users\andre\OneDrive\Área de Trabalho\InstaDev\Projeto-InstaDev\Views\EdicaoDePerfil\index.cshtml"
                               Write(ViewBag.User);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</h2>
                             
                             

                               
                                <div class=""file-input"">
                                    <input type=""file"" name=""Foto"" id=""Foto"" class=""file"">
                                    <label for=""Foto"">Select file</label>
                                </div>
                              

                                
                            </div>

                        </div>
                    </div>

                    
                        <div class=""nome"">
                            <div class=""conteudo alinhar-esquerda"">
                                <h2>Nome</h2>
                                <div class=""preencher-nome"">
                                    <input type=""text"" class=""input-nome"" placeholder=""Joãozinho"" name=""Nome"">
                                    <div>
                                        <p>Ajude as pessoas a descobrir sua conta usando");
                WriteLiteral(@" o nome pelo qual você é conhecido: seu nome completo, apelido ou nome comercial.</p>
                                        <p>Você pode alterar o seu nome apenas duas vezes a cada 14 dias.</p>
                                    </div>
                                </div>

                            </div>
                        </div>


                        <div class=""nome-usuario"">
                            <div class=""conteudo-usuario alinhar-esquerda"">
                                <h2>Nome de Usuário</h2>
                                <div class=""preencher-usuario"">
                                    
                                        <input name=""Username"" type=""text"" class=""input-nome-usuario"" placeholder=""Unknow_User"">
                                        <div>
                                            <p>Na maioria dos casos, você poderá alterar seu nome de usuário novamente para nascimento_tr por mais 14 dias.</p>
                                        ");
                WriteLiteral(@"    <p>Informações pessoais </p>
                                            <p>Forneça suas informações pessoais, mesmo se a conta for usada para uma empresa, um animal de estimação ou outra coisa. Elas não farão parte do seu perfil público.</p>
                                        </div>
                                    
                                </div>

                            </div>
                        </div>

                        <div class=""email"">
                            <div class=""conteudo"">
                                <div class=""endereco-email"">
                                    <h2>E-mail</h2>
                                    
                                        <input name=""Email"" type=""email"" class=""input-email"" placeholder=""yes_baby@gmail.com"">
                                    
                                </div>
                                <aside class=""desativar-conta"">
                                    <div class=""botao-en");
                WriteLiteral(@"viar"">
                                        <button type=""submit"" class=""botao-alterar"">Enviar</button> 

                                    </div>
                                    <div class=""botao-desativar"">
                                       ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f7789014ed3648ab550a15eab8006d3f878bb74a14467", async() => {
                    WriteLiteral("Desativar minha conta definitivamente");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n                                    </div>\r\n                                </aside>\r\n                            </div>\r\n                        </div>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
#nullable restore
#line 37 "C:\Users\andre\OneDrive\Área de Trabalho\InstaDev\Projeto-InstaDev\Views\EdicaoDePerfil\index.cshtml"
AddHtmlAttributeValue("", 1850, Url.Action("Alterar"), 1850, 22, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                </aside>");
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
