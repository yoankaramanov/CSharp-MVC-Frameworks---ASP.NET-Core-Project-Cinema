#pragma checksum "C:\Users\yoank\Desktop\versions done - Copy\Cinema.Web\Cinema.Web\Areas\Admin\Pages\Items\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "47031fe36d8c6984b61354633f00c58d678de9e4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Cinema.Web.Areas.Identity.Pages.Items.Areas_Admin_Pages_Items_Details), @"mvc.1.0.razor-page", @"/Areas/Admin/Pages/Items/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Areas/Admin/Pages/Items/Details.cshtml", typeof(Cinema.Web.Areas.Identity.Pages.Items.Areas_Admin_Pages_Items_Details), @"{id}")]
namespace Cinema.Web.Areas.Identity.Pages.Items
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\yoank\Desktop\versions done - Copy\Cinema.Web\Cinema.Web\Areas\Admin\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "C:\Users\yoank\Desktop\versions done - Copy\Cinema.Web\Cinema.Web\Areas\Admin\Pages\_ViewImports.cshtml"
using Cinema.Web.Areas.Identity;

#line default
#line hidden
#line 3 "C:\Users\yoank\Desktop\versions done - Copy\Cinema.Web\Cinema.Web\Areas\Admin\Pages\_ViewImports.cshtml"
using Cinema.Models;

#line default
#line hidden
#line 6 "C:\Users\yoank\Desktop\versions done - Copy\Cinema.Web\Cinema.Web\Areas\Admin\Pages\_ViewImports.cshtml"
using Cinema.Web.Areas.Admin.Models.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "{id}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"47031fe36d8c6984b61354633f00c58d678de9e4", @"/Areas/Admin/Pages/Items/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"37fc1be3dbcfe0e8a8bf99ccf4851f5e60ddbc2b", @"/Areas/Admin/Pages/_ViewImports.cshtml")]
    public class Areas_Admin_Pages_Items_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "DeleteItem", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", new global::Microsoft.AspNetCore.Html.HtmlString("Delete"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\yoank\Desktop\versions done - Copy\Cinema.Web\Cinema.Web\Areas\Admin\Pages\Items\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(113, 98, true);
            WriteLiteral("\r\n<div class=\"container\">\r\n    <div class=\"row\">\r\n        <div class=\"col-md-5\">\r\n            <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 211, "\"", 232, 1);
#line 10 "C:\Users\yoank\Desktop\versions done - Copy\Cinema.Web\Cinema.Web\Areas\Admin\Pages\Items\Details.cshtml"
WriteAttributeValue("", 217, Model.ImageUrl, 217, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(233, 25, true);
            WriteLiteral(" width=\"400\" height=\"300\"");
            EndContext();
            BeginWriteAttribute("alt", " alt=\"", 258, "\"", 291, 4);
            WriteAttributeValue("", 264, "Cover", 264, 5, true);
            WriteAttributeValue(" ", 269, "image", 270, 6, true);
            WriteAttributeValue(" ", 275, "for", 276, 4, true);
#line 10 "C:\Users\yoank\Desktop\versions done - Copy\Cinema.Web\Cinema.Web\Areas\Admin\Pages\Items\Details.cshtml"
WriteAttributeValue(" ", 279, Model.Name, 280, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(292, 69, true);
            WriteLiteral(" />\r\n        </div>\r\n        <div class=\"col-md-7\">\r\n            <h2>");
            EndContext();
            BeginContext(362, 10, false);
#line 13 "C:\Users\yoank\Desktop\versions done - Copy\Cinema.Web\Cinema.Web\Areas\Admin\Pages\Items\Details.cshtml"
           Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(372, 30, true);
            WriteLiteral("</h2>\r\n            <h5>Price: ");
            EndContext();
            BeginContext(403, 11, false);
#line 14 "C:\Users\yoank\Desktop\versions done - Copy\Cinema.Web\Cinema.Web\Areas\Admin\Pages\Items\Details.cshtml"
                  Write(Model.Price);

#line default
#line hidden
            EndContext();
            BeginContext(414, 35, true);
            WriteLiteral("</h5>\r\n            <p>Description: ");
            EndContext();
            BeginContext(450, 17, false);
#line 15 "C:\Users\yoank\Desktop\versions done - Copy\Cinema.Web\Cinema.Web\Areas\Admin\Pages\Items\Details.cshtml"
                       Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(467, 50, true);
            WriteLiteral("</p>\r\n            <br />\r\n        </div>\r\n        ");
            EndContext();
            BeginContext(517, 166, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ce05c1c97d27479396cae07fbd0954b5", async() => {
                BeginContext(537, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(551, 115, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "81686c91af764c319876fc89e763e25b", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.PageHandler = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 19 "C:\Users\yoank\Desktop\versions done - Copy\Cinema.Web\Cinema.Web\Areas\Admin\Pages\Items\Details.cshtml"
                                                   WriteLiteral(Model.Id);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(666, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(683, 20, true);
            WriteLiteral("\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Cinema.Web.Areas.Admin.Pages.Items.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Cinema.Web.Areas.Admin.Pages.Items.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Cinema.Web.Areas.Admin.Pages.Items.DetailsModel>)PageContext?.ViewData;
        public Cinema.Web.Areas.Admin.Pages.Items.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
