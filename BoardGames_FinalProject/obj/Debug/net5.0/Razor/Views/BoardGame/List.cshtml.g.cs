#pragma checksum "C:\Users\lfcla\source\repos\AspNet_FINAL_CART\Asp.net-Final\BoardGames_FinalProject\Views\BoardGame\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7908d32e8ebe5f84fa24b9702d2834a5a0c1cc6f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(BoardGames_FinalProject.Pages.BoardGame.Views_BoardGame_List), @"mvc.1.0.view", @"/Views/BoardGame/List.cshtml")]
namespace BoardGames_FinalProject.Pages.BoardGame
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
#line 1 "C:\Users\lfcla\source\repos\AspNet_FINAL_CART\Asp.net-Final\BoardGames_FinalProject\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\lfcla\source\repos\AspNet_FINAL_CART\Asp.net-Final\BoardGames_FinalProject\Views\_ViewImports.cshtml"
using BoardGames_FinalProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\lfcla\source\repos\AspNet_FINAL_CART\Asp.net-Final\BoardGames_FinalProject\Views\BoardGame\List.cshtml"
using BoardGames_FinalProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\lfcla\source\repos\AspNet_FINAL_CART\Asp.net-Final\BoardGames_FinalProject\Views\BoardGame\List.cshtml"
using BoardGames_FinalProject.Models.Grid;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\lfcla\source\repos\AspNet_FINAL_CART\Asp.net-Final\BoardGames_FinalProject\Views\BoardGame\List.cshtml"
using BoardGames_FinalProject.Models.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7908d32e8ebe5f84fa24b9702d2834a5a0c1cc6f", @"/Views/BoardGame/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f1288ff5dddf03788c2fd0d2ed4e08521fe1a6a", @"/Views/_ViewImports.cshtml")]
    public class Views_BoardGame_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BoardGameListViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "List", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-white"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Add", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\lfcla\source\repos\AspNet_FINAL_CART\Asp.net-Final\BoardGames_FinalProject\Views\BoardGame\List.cshtml"
  
    ViewData["Title"] = " | BoardGame Catalog";

    // aliases to make paging, sorting, and filtering code shorter
    RouteDictionary current = Model.CurrentRoute;
    RouteDictionary routes = Model.CurrentRoute.Clone();


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Board Game Catalog</h1>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7908d32e8ebe5f84fa24b9702d2834a5a0c1cc6f6599", async() => {
                WriteLiteral("\r\n    <table class=\"table table-bordered table-striped table-sm\">\r\n");
                WriteLiteral("        <thead class=\"thead-dark\">\r\n            <tr>\r\n                <th>\r\n");
#nullable restore
#line 24 "C:\Users\lfcla\source\repos\AspNet_FINAL_CART\Asp.net-Final\BoardGames_FinalProject\Views\BoardGame\List.cshtml"
                       routes.SetSortAndDirection(nameof(BoardGame.name), current); 

#line default
#line hidden
#nullable disable
                WriteLiteral("                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7908d32e8ebe5f84fa24b9702d2834a5a0c1cc6f7379", async() => {
                    WriteLiteral("Title");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 25 "C:\Users\lfcla\source\repos\AspNet_FINAL_CART\Asp.net-Final\BoardGames_FinalProject\Views\BoardGame\List.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues = routes;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-all-route-data", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                </th>\r\n                <th>Picture</th>\r\n                <th>\r\n");
#nullable restore
#line 30 "C:\Users\lfcla\source\repos\AspNet_FINAL_CART\Asp.net-Final\BoardGames_FinalProject\Views\BoardGame\List.cshtml"
                       routes.SetSortAndDirection(nameof(BoardGame.price_ca), current); 

#line default
#line hidden
#nullable disable
                WriteLiteral("                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7908d32e8ebe5f84fa24b9702d2834a5a0c1cc6f9618", async() => {
                    WriteLiteral("Price");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 31 "C:\Users\lfcla\source\repos\AspNet_FINAL_CART\Asp.net-Final\BoardGames_FinalProject\Views\BoardGame\List.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues = routes;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-all-route-data", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                </th>\r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 38 "C:\Users\lfcla\source\repos\AspNet_FINAL_CART\Asp.net-Final\BoardGames_FinalProject\Views\BoardGame\List.cshtml"
             foreach (BoardGame boardGame in Model.BoardGames)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7908d32e8ebe5f84fa24b9702d2834a5a0c1cc6f11919", async() => {
                    WriteLiteral("\r\n                        ");
#nullable restore
#line 44 "C:\Users\lfcla\source\repos\AspNet_FINAL_CART\Asp.net-Final\BoardGames_FinalProject\Views\BoardGame\List.cshtml"
                   Write(boardGame.name);

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n                    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 42 "C:\Users\lfcla\source\repos\AspNet_FINAL_CART\Asp.net-Final\BoardGames_FinalProject\Views\BoardGame\List.cshtml"
                                              WriteLiteral(boardGame.ID);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 43 "C:\Users\lfcla\source\repos\AspNet_FINAL_CART\Asp.net-Final\BoardGames_FinalProject\Views\BoardGame\List.cshtml"
                           WriteLiteral(boardGame.name);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["slug"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-slug", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["slug"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                </td>\r\n                <td><img");
                BeginWriteAttribute("src", " src=\"", 1839, "\"", 1865, 1);
#nullable restore
#line 47 "C:\Users\lfcla\source\repos\AspNet_FINAL_CART\Asp.net-Final\BoardGames_FinalProject\Views\BoardGame\List.cshtml"
WriteAttributeValue("", 1845, boardGame.image_url, 1845, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 1866, "\"", 1887, 1);
#nullable restore
#line 47 "C:\Users\lfcla\source\repos\AspNet_FINAL_CART\Asp.net-Final\BoardGames_FinalProject\Views\BoardGame\List.cshtml"
WriteAttributeValue("", 1872, boardGame.name, 1872, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" width=\"100\" class=\"img-thumbnail\" /></td>\r\n                <td>");
#nullable restore
#line 48 "C:\Users\lfcla\source\repos\AspNet_FINAL_CART\Asp.net-Final\BoardGames_FinalProject\Views\BoardGame\List.cshtml"
               Write(boardGame.price_ca);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>\r\n                    <button type=\"submit\" name=\"id\"");
                BeginWriteAttribute("value", " value=\"", 2051, "\"", 2072, 1);
#nullable restore
#line 50 "C:\Users\lfcla\source\repos\AspNet_FINAL_CART\Asp.net-Final\BoardGames_FinalProject\Views\BoardGame\List.cshtml"
WriteAttributeValue("", 2059, boardGame.ID, 2059, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("\r\n                            class=\"btn btn-primary\">\r\n                        Add To Cart\r\n                    </button>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 56 "C:\Users\lfcla\source\repos\AspNet_FINAL_CART\Asp.net-Final\BoardGames_FinalProject\Views\BoardGame\List.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </tbody>\r\n    </table>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 65 "C:\Users\lfcla\source\repos\AspNet_FINAL_CART\Asp.net-Final\BoardGames_FinalProject\Views\BoardGame\List.cshtml"
                                                        
    routes = Model.CurrentRoute.Clone();

    

#line default
#line hidden
#nullable disable
#nullable restore
#line 69 "C:\Users\lfcla\source\repos\AspNet_FINAL_CART\Asp.net-Final\BoardGames_FinalProject\Views\BoardGame\List.cshtml"
                                                                            
    for (int i = 1; i <= Model.TotalPages; i++)
    {
        routes.PageNumber = i;

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7908d32e8ebe5f84fa24b9702d2834a5a0c1cc6f19689", async() => {
#nullable restore
#line 74 "C:\Users\lfcla\source\repos\AspNet_FINAL_CART\Asp.net-Final\BoardGames_FinalProject\Views\BoardGame\List.cshtml"
                                                                         Write(i);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 73 "C:\Users\lfcla\source\repos\AspNet_FINAL_CART\Asp.net-Final\BoardGames_FinalProject\Views\BoardGame\List.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues = routes;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-all-route-data", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2901, "btn", 2901, 3, true);
            AddHtmlAttributeValue(" ", 2904, "btn-outline-primary", 2905, 20, true);
#nullable restore
#line 74 "C:\Users\lfcla\source\repos\AspNet_FINAL_CART\Asp.net-Final\BoardGames_FinalProject\Views\BoardGame\List.cshtml"
AddHtmlAttributeValue(" ", 2924, Nav.Active(i, current.PageNumber), 2925, 34, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 75 "C:\Users\lfcla\source\repos\AspNet_FINAL_CART\Asp.net-Final\BoardGames_FinalProject\Views\BoardGame\List.cshtml"
    }

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BoardGameListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
