#pragma checksum "C:\Users\yoank\Desktop\versions done - Copy\Cinema.Web\Cinema.Web\Views\Shared\DisplayTemplates\DirectorConciseViewModel.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4214b53de8dab3b89ac7a5e23fbfc5b9cde6352d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_DisplayTemplates_DirectorConciseViewModel), @"mvc.1.0.view", @"/Views/Shared/DisplayTemplates/DirectorConciseViewModel.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/DisplayTemplates/DirectorConciseViewModel.cshtml", typeof(AspNetCore.Views_Shared_DisplayTemplates_DirectorConciseViewModel))]
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
#line 1 "C:\Users\yoank\Desktop\versions done - Copy\Cinema.Web\Cinema.Web\Views\_ViewImports.cshtml"
using Cinema.Web.Models;

#line default
#line hidden
#line 2 "C:\Users\yoank\Desktop\versions done - Copy\Cinema.Web\Cinema.Web\Views\_ViewImports.cshtml"
using Cinema.Models;

#line default
#line hidden
#line 4 "C:\Users\yoank\Desktop\versions done - Copy\Cinema.Web\Cinema.Web\Views\_ViewImports.cshtml"
using Cinema.Web.Areas.Admin.Models.ViewModels;

#line default
#line hidden
#line 5 "C:\Users\yoank\Desktop\versions done - Copy\Cinema.Web\Cinema.Web\Views\_ViewImports.cshtml"
using Cinema.Web.Areas.Admin.Models.BindingModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4214b53de8dab3b89ac7a5e23fbfc5b9cde6352d", @"/Views/Shared/DisplayTemplates/DirectorConciseViewModel.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b5c29777071d77b740f716244d82b3d0c037b43a", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_DisplayTemplates_DirectorConciseViewModel : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DirectorConciseViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(33, 34, true);
            WriteLiteral("\r\n<div class=\"col-sm-4\">\r\n    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 67, "\"", 88, 1);
#line 4 "C:\Users\yoank\Desktop\versions done - Copy\Cinema.Web\Cinema.Web\Views\Shared\DisplayTemplates\DirectorConciseViewModel.cshtml"
WriteAttributeValue("", 73, Model.ImageUrl, 73, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(89, 25, true);
            WriteLiteral(" width=\"200\" height=\"300\"");
            EndContext();
            BeginWriteAttribute("alt", " alt=\"", 114, "\"", 151, 4);
            WriteAttributeValue("", 120, "Cover", 120, 5, true);
            WriteAttributeValue(" ", 125, "image", 126, 6, true);
            WriteAttributeValue(" ", 131, "for", 132, 4, true);
#line 4 "C:\Users\yoank\Desktop\versions done - Copy\Cinema.Web\Cinema.Web\Views\Shared\DisplayTemplates\DirectorConciseViewModel.cshtml"
WriteAttributeValue(" ", 135, Model.FullName, 136, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(152, 15, true);
            WriteLiteral(" /><br />\r\n    ");
            EndContext();
            BeginContext(167, 85, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a2439e0c6958463ca72f5bdf00d55003", async() => {
                BeginContext(216, 8, true);
                WriteLiteral("<strong>");
                EndContext();
                BeginContext(225, 14, false);
#line 5 "C:\Users\yoank\Desktop\versions done - Copy\Cinema.Web\Cinema.Web\Views\Shared\DisplayTemplates\DirectorConciseViewModel.cshtml"
                                                        Write(Model.FullName);

#line default
#line hidden
                EndContext();
                BeginContext(239, 9, true);
                WriteLiteral("</strong>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 5 "C:\Users\yoank\Desktop\versions done - Copy\Cinema.Web\Cinema.Web\Views\Shared\DisplayTemplates\DirectorConciseViewModel.cshtml"
                              WriteLiteral(Model.Id);

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
            BeginContext(252, 14, true);
            WriteLiteral("\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DirectorConciseViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
