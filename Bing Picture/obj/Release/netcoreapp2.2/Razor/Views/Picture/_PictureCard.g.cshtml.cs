#pragma checksum "C:\Users\Night_Dawn\source\repos\Bing_Picture\Bing Picture\Views\Picture\_PictureCard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "55a1d10fd87550617cf2d184943ad2ee6f3f3b53"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Picture__PictureCard), @"mvc.1.0.view", @"/Views/Picture/_PictureCard.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Picture/_PictureCard.cshtml", typeof(AspNetCore.Views_Picture__PictureCard))]
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
#line 1 "C:\Users\Night_Dawn\source\repos\Bing_Picture\Bing Picture\Views\_ViewImports.cshtml"
using Bing_Picture;

#line default
#line hidden
#line 2 "C:\Users\Night_Dawn\source\repos\Bing_Picture\Bing Picture\Views\_ViewImports.cshtml"
using Bing_Picture.Models;

#line default
#line hidden
#line 1 "C:\Users\Night_Dawn\source\repos\Bing_Picture\Bing Picture\Views\Picture\_PictureCard.cshtml"
using Bing_Picture.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55a1d10fd87550617cf2d184943ad2ee6f3f3b53", @"/Views/Picture/_PictureCard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd57803ca8c670dbe52ad226c8820e2f379959a8", @"/Views/_ViewImports.cshtml")]
    public class Views_Picture__PictureCard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PictureViewModel>
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
            BeginContext(57, 47, true);
            WriteLiteral("\r\n<div class=\"card\" style=\"width: 100%;\">\r\n    ");
            EndContext();
            BeginContext(104, 143, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "55a1d10fd87550617cf2d184943ad2ee6f3f3b533787", async() => {
                BeginContext(155, 4, true);
                WriteLiteral("<img");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 159, "\"", 197, 2);
                WriteAttributeValue("", 165, "https://cn.bing.com", 165, 19, true);
                WriteAttributeValue("", 184, new Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_attribute_value_writer) => {
                    PushWriter(__razor_attribute_value_writer);
                                                                                                          
                    BeginContext(187, 9, false);
#line 5 "C:\Users\Night_Dawn\source\repos\Bing_Picture\Bing Picture\Views\Picture\_PictureCard.cshtml"
                                                                                 Write(Model.url);

#line default
#line hidden
                    EndContext();
                                                                                                                    
                    PopWriter();
                }
                ), 184, 13, false);
                EndWriteAttribute();
                BeginContext(198, 21, true);
                WriteLiteral(" class=\"card-img-top\"");
                EndContext();
                BeginWriteAttribute("alt", " alt=\"", 219, "\"", 241, 1);
#line 5 "C:\Users\Night_Dawn\source\repos\Bing_Picture\Bing Picture\Views\Picture\_PictureCard.cshtml"
WriteAttributeValue("", 225, Model.copyright, 225, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(242, 1, true);
                WriteLiteral(">");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-url", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 5 "C:\Users\Night_Dawn\source\repos\Bing_Picture\Bing Picture\Views\Picture\_PictureCard.cshtml"
                               WriteLiteral(Model.url);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["url"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-url", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["url"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(247, 19, true);
            WriteLiteral("\r\n    <div></div>\r\n");
            EndContext();
            BeginContext(747, 6, true);
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PictureViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
