#pragma checksum "C:\Users\yoank\Desktop\versions done - Copy\Cinema.Web\Cinema.Web\Areas\Admin\Views\UpcomingMovies\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2fc327d8e86ce89c6fb0da9ddbaa0bbcb1676e09"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Cinema.Web.Areas.Admin.UpcomingMovies.Areas_Admin_Views_UpcomingMovies_Details), @"mvc.1.0.view", @"/Areas/Admin/Views/UpcomingMovies/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/UpcomingMovies/Details.cshtml", typeof(Cinema.Web.Areas.Admin.UpcomingMovies.Areas_Admin_Views_UpcomingMovies_Details))]
namespace Cinema.Web.Areas.Admin.UpcomingMovies
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\yoank\Desktop\versions done - Copy\Cinema.Web\Cinema.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "C:\Users\yoank\Desktop\versions done - Copy\Cinema.Web\Cinema.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Cinema.Web.Areas.Identity;

#line default
#line hidden
#line 3 "C:\Users\yoank\Desktop\versions done - Copy\Cinema.Web\Cinema.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Cinema.Models;

#line default
#line hidden
#line 6 "C:\Users\yoank\Desktop\versions done - Copy\Cinema.Web\Cinema.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Cinema.Web.Areas.Admin.Models.ViewModels;

#line default
#line hidden
#line 7 "C:\Users\yoank\Desktop\versions done - Copy\Cinema.Web\Cinema.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Cinema.Web.Areas.Admin.Models.BindingModels;

#line default
#line hidden
#line 8 "C:\Users\yoank\Desktop\versions done - Copy\Cinema.Web\Cinema.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Cinema.Web.Areas.Admin.Pages.Items;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2fc327d8e86ce89c6fb0da9ddbaa0bbcb1676e09", @"/Areas/Admin/Views/UpcomingMovies/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"11d8e7f3040d82f19266ab5ece5a29d139de1b8e", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_UpcomingMovies_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MovieDetailsViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Directors", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "UpcomingMovies", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Publish", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(30, 100, true);
            WriteLiteral("\r\n\r\n<div class=\"container\">\r\n    <div class=\"row\">\r\n        <div class=\"col-md-5\">\r\n            <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 130, "\"", 151, 1);
#line 7 "C:\Users\yoank\Desktop\versions done - Copy\Cinema.Web\Cinema.Web\Areas\Admin\Views\UpcomingMovies\Details.cshtml"
WriteAttributeValue("", 136, Model.ImageUrl, 136, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(152, 25, true);
            WriteLiteral(" width=\"400\" height=\"600\"");
            EndContext();
            BeginWriteAttribute("alt", " alt=\"", 177, "\"", 211, 4);
            WriteAttributeValue("", 183, "Cover", 183, 5, true);
            WriteAttributeValue(" ", 188, "image", 189, 6, true);
            WriteAttributeValue(" ", 194, "for", 195, 4, true);
#line 7 "C:\Users\yoank\Desktop\versions done - Copy\Cinema.Web\Cinema.Web\Areas\Admin\Views\UpcomingMovies\Details.cshtml"
WriteAttributeValue(" ", 198, Model.Title, 199, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(212, 69, true);
            WriteLiteral(" />\r\n        </div>\r\n        <div class=\"col-md-7\">\r\n            <h1>");
            EndContext();
            BeginContext(282, 11, false);
#line 10 "C:\Users\yoank\Desktop\versions done - Copy\Cinema.Web\Cinema.Web\Areas\Admin\Views\UpcomingMovies\Details.cshtml"
           Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(293, 51, true);
            WriteLiteral("</h1>\r\n            <h3>\r\n                Director: ");
            EndContext();
            BeginContext(344, 170, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "60de3c5e69eb4f6fb35fc578561bbf4d", async() => {
                BeginContext(446, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
                BeginContext(469, 23, false);
#line 13 "C:\Users\yoank\Desktop\versions done - Copy\Cinema.Web\Cinema.Web\Areas\Admin\Views\UpcomingMovies\Details.cshtml"
               Write(Model.Director.FullName);

#line default
#line hidden
                EndContext();
                BeginContext(492, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 12 "C:\Users\yoank\Desktop\versions done - Copy\Cinema.Web\Cinema.Web\Areas\Admin\Views\UpcomingMovies\Details.cshtml"
                                                                                                WriteLiteral(Model.Director.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(514, 45, true);
            WriteLiteral("\r\n            </h3>\r\n            <h3>Lenght: ");
            EndContext();
            BeginContext(560, 12, false);
#line 16 "C:\Users\yoank\Desktop\versions done - Copy\Cinema.Web\Cinema.Web\Areas\Admin\Views\UpcomingMovies\Details.cshtml"
                   Write(Model.Lenght);

#line default
#line hidden
            EndContext();
            BeginContext(572, 39, true);
            WriteLiteral(" minutes</h3>\r\n            <h3>Actors: ");
            EndContext();
            BeginContext(612, 12, false);
#line 17 "C:\Users\yoank\Desktop\versions done - Copy\Cinema.Web\Cinema.Web\Areas\Admin\Views\UpcomingMovies\Details.cshtml"
                   Write(Model.Actors);

#line default
#line hidden
            EndContext();
            BeginContext(624, 37, true);
            WriteLiteral(" </h3>\r\n            <h3>ReleaseDate: ");
            EndContext();
            BeginContext(662, 17, false);
#line 18 "C:\Users\yoank\Desktop\versions done - Copy\Cinema.Web\Cinema.Web\Areas\Admin\Views\UpcomingMovies\Details.cshtml"
                        Write(Model.ReleaseDate);

#line default
#line hidden
            EndContext();
            BeginContext(679, 36, true);
            WriteLiteral("</h3>\r\n            <h3>Description: ");
            EndContext();
            BeginContext(716, 17, false);
#line 19 "C:\Users\yoank\Desktop\versions done - Copy\Cinema.Web\Cinema.Web\Areas\Admin\Views\UpcomingMovies\Details.cshtml"
                        Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(733, 67, true);
            WriteLiteral("</h3>\r\n            <td>\r\n                <h2>\r\n                    ");
            EndContext();
            BeginContext(800, 203, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ee0fd1cf92ec4a2487c557f86df39d78", async() => {
                BeginContext(945, 54, true);
                WriteLiteral("\r\n                        Delete\r\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 22 "C:\Users\yoank\Desktop\versions done - Copy\Cinema.Web\Cinema.Web\Areas\Admin\Views\UpcomingMovies\Details.cshtml"
                                                                                              WriteLiteral(Model.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1003, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(1025, 209, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "66dcde28758242b691f542e67b30f758", async() => {
                BeginContext(1171, 59, true);
                WriteLiteral("\r\n                        Make public\r\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 26 "C:\Users\yoank\Desktop\versions done - Copy\Cinema.Web\Cinema.Web\Areas\Admin\Views\UpcomingMovies\Details.cshtml"
                                                                                               WriteLiteral(Model.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1234, 89, true);
            WriteLiteral("\r\n                </h2>               \r\n            </td>                  \r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MovieDetailsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
