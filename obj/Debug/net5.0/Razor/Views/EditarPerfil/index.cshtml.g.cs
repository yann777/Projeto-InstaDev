#pragma checksum "C:\Users\FIC\Desktop\Projeto_InstaDev_1DM\Projeto-InstaDev\Views\EditarPerfil\index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a1517302e7db5b5469c55baee8f995dbfe195ff6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_EditarPerfil_index), @"mvc.1.0.view", @"/Views/EditarPerfil/index.cshtml")]
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
#line 1 "C:\Users\FIC\Desktop\Projeto_InstaDev_1DM\Projeto-InstaDev\Views\_ViewImports.cshtml"
using InstaDev_Projeto_1DM;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\FIC\Desktop\Projeto_InstaDev_1DM\Projeto-InstaDev\Views\_ViewImports.cshtml"
using InstaDev_Projeto_1DM.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1517302e7db5b5469c55baee8f995dbfe195ff6", @"/Views/EditarPerfil/index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d08ce984e7ec58e67bf2c1fbecdafb602c2d537", @"/Views/_ViewImports.cshtml")]
    public class Views_EditarPerfil_index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Usuario>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("pesquisar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("navbar-brand"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Link para deletar a conta", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Editar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\FIC\Desktop\Projeto_InstaDev_1DM\Projeto-InstaDev\Views\EditarPerfil\index.cshtml"
  
    ViewData["Title"] = "Edição";

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"pt-br\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a1517302e7db5b5469c55baee8f995dbfe195ff66229", async() => {
                WriteLiteral("\r\n    <meta charset=\"UTF-8\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\r\n    <title>Document</title>\r\n    <link rel=\"stylesheet\" href=\"css/style.css\">\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a1517302e7db5b5469c55baee8f995dbfe195ff67396", async() => {
                WriteLiteral("\r\n    \r\n    <header class=\"header-top\">\r\n        <div class=\"content-header\">\r\n            <div class=\"logo\">\r\n                <a href=\"#\"><img src=\"imgEdição/Instadev.svg\" alt=\"Logo InstaDev\"></a>\r\n            </div>\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a1517302e7db5b5469c55baee8f995dbfe195ff67907", async() => {
                    WriteLiteral("\r\n                <input type=\"text\" name=\"pesquisa\" placeholder=\"Pesquisar\" class=\"pesquisa\">\r\n                <button type=\"submit\"></button>\r\n            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
            <nav class=""navegacao"">
                <ul>
                    <li><a href=""#""><img src=""imgEdição/Vector-1.png"" alt=""Imagem de uma casa""></a></li>
                    <li><a href=""#""><img src=""imgEdição/plane 1.png"" alt=""Imagem de um avião de papel""></a></li>
                    <li><a href=""#""><img src=""imgEdição/compass 1.png"" alt=""Imagem de uma bússola""></a></li>
                    <li><a href=""#""><img src=""imgEdição/Vector.png"" alt=""Imagem de um coração""></a></li>
                    <li><a href=""#""><img src=""imgEdição/thank-you 2.png"" alt=""Imagem de perfil do usuário"" class=""imagem-perfil""></a></li>
                </ul>
            </nav>
        </div>
    </header>

    <main>
        <section class=""editar-perfil"">
            <div class=""content"">

                <div class=""texto-editar"" >
                    <div class=""texto-editar-perfil"">
                        <h1>Editar Perfil</h1>
                    </div>
                </div>

                <as");
                WriteLiteral("ide class=\"editar\">\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a1517302e7db5b5469c55baee8f995dbfe195ff610601", async() => {
                    WriteLiteral("\r\n                    <div class=\"perfil\">\r\n                        <div class=\"conteudo alinhar-esquerda\">\r\n                            <img src=\"imgEdição/thank-you 2.png\"");
                    BeginWriteAttribute("alt", " alt=\"", 2042, "\"", 2048, 0);
                    EndWriteAttribute();
                    WriteLiteral(">\r\n\r\n                            <div class=\"texto\">\r\n                                <h2>");
#nullable restore
#line 53 "C:\Users\FIC\Desktop\Projeto_InstaDev_1DM\Projeto-InstaDev\Views\EditarPerfil\index.cshtml"
                               Write(ViewBag.UserName);

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
                                    
                                        <input name=""Username"" type=""text"" class=""input-nome-usuario""");
                    BeginWriteAttribute("placeholder", " placeholder=", 3927, "", 3940, 0);
                    EndWriteAttribute();
                    WriteLiteral(" ");
#nullable restore
#line 91 "C:\Users\FIC\Desktop\Projeto_InstaDev_1DM\Projeto-InstaDev\Views\EditarPerfil\index.cshtml"
                                                                                                              Write(ViewBag.UserName);

#line default
#line hidden
#nullable disable
                    WriteLiteral(@">
                                        <div>
                                            <p>Na maioria dos casos, você poderá alterar seu nome de usuário novamente para nascimento_tr por mais 14 dias.</p>
                                            <p>Informações pessoais </p>
                                            <p>Forneça suas informações pessoais, mesmo se a conta for usada para uma empresa, um animal de estimação ou outra coisa. Elas não farão parte do seu perfil público.</p>
                                        </div>
                                    
                                </div>

                            </div>
                        </div>

                        <div class=""email"">
                            <div class=""conteudo"">
                                <div class=""endereco-email"">
                                    <h2>E-mail</h2>
                                    
                                        <input name=""Email"" type=""email"" cla");
                    WriteLiteral("ss=\"input-email\"");
                    BeginWriteAttribute("placeholder", " placeholder=", 4998, "", 5011, 0);
                    EndWriteAttribute();
                    WriteLiteral(" ");
#nullable restore
#line 108 "C:\Users\FIC\Desktop\Projeto_InstaDev_1DM\Projeto-InstaDev\Views\EditarPerfil\index.cshtml"
                                                                                                     Write(ViewBag.UserName);

#line default
#line hidden
#nullable disable
                    WriteLiteral(@">
                                    
                                </div>
                                <aside class=""desativar-conta"">
                                    <div class=""botao-enviar"">
                                        <button type=""submit"" class=""botao-alterar"">Enviar</button> 

                                    </div>
                                    <div class=""botao-desativar"">
                                       ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a1517302e7db5b5469c55baee8f995dbfe195ff616030", async() => {
                        WriteLiteral("Desativar minha conta definitivamente");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_2.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
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
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
#nullable restore
#line 47 "C:\Users\FIC\Desktop\Projeto_InstaDev_1DM\Projeto-InstaDev\Views\EditarPerfil\index.cshtml"
AddHtmlAttributeValue("", 1815, Url.Action("Alterar"), 1815, 22, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n                </aside>\r\n\r\n            </div>\r\n        </section>\r\n\r\n    </main>\r\n\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Usuario> Html { get; private set; }
    }
}
#pragma warning restore 1591
