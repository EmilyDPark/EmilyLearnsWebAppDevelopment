#pragma checksum "C:\Users\emily\Desktop\CSC390 Developing ASP.NET Web Applications\EmilyLearnsWebAppDevelopment\EmilyLearnsWebAppDevelopment\Views\Poll\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f01f9c5c255c18bc1b896d5b19f75347ebe80aa8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Poll_Index), @"mvc.1.0.view", @"/Views/Poll/Index.cshtml")]
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
#line 1 "C:\Users\emily\Desktop\CSC390 Developing ASP.NET Web Applications\EmilyLearnsWebAppDevelopment\EmilyLearnsWebAppDevelopment\Views\_ViewImports.cshtml"
using EmilyLearnsWebAppDevelopment;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\emily\Desktop\CSC390 Developing ASP.NET Web Applications\EmilyLearnsWebAppDevelopment\EmilyLearnsWebAppDevelopment\Views\_ViewImports.cshtml"
using EmilyLearnsWebAppDevelopment.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f01f9c5c255c18bc1b896d5b19f75347ebe80aa8", @"/Views/Poll/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"929ded8e4d6c945eabd7518fccb6da2739456aad", @"/Views/_ViewImports.cshtml")]
    public class Views_Poll_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("submit-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\emily\Desktop\CSC390 Developing ASP.NET Web Applications\EmilyLearnsWebAppDevelopment\EmilyLearnsWebAppDevelopment\Views\Poll\Index.cshtml"
  
    ViewData["Title"] = "Favorite Color Poll";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f01f9c5c255c18bc1b896d5b19f75347ebe80aa84436", async() => {
                WriteLiteral("\r\n    <meta charset=\"utf-8\" />\r\n    <title></title>\r\n    <link type=\"text/css\" rel=\"stylesheet\" href=\"css/pollstyle.css\" />\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f01f9c5c255c18bc1b896d5b19f75347ebe80aa85539", async() => {
                WriteLiteral("\r\n    <p>\r\n        <h1>Favorite Color Poll</h1>\r\n        Please selecte your favorite color and then press Submit Poll.\r\n    </p>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f01f9c5c255c18bc1b896d5b19f75347ebe80aa85938", async() => {
                    WriteLiteral(@"
        <div class=""main-div"">
            <div class=""main-batch1"">
                <div class=""item"">
                    <div class=""img-item""><img src=""colorimages/black.png"" /></div>
                    <div class=""input-item""><input type=""radio"" name=""favorite"" value=""Black""> Black</div>
                </div>
                <div class=""item"">
                    <div class=""img-item""><img src=""colorimages/blue.png"" /></div>
                    <div class=""input-item""><input type=""radio"" name=""favorite"" value=""Blue""> Blue</div>
                </div>
                <div class=""item"">
                    <div class=""img-item""><img src=""colorimages/green.png"" /></div>
                    <div class=""input-item""><input type=""radio"" name=""favorite"" value=""Green""> Green</div>
                </div>
                <div class=""item"">
                    <div class=""img-item""><img src=""colorimages/orange.png"" /></div>
                    <div class=""input-item""><input type=""radio"" name=""fav");
                    WriteLiteral(@"orite"" value=""Orange""> Orange</div>
                </div>
            </div>
            <div class=""main-batch2"">
                <div class=""item"">
                    <div class=""img-item""><img src=""colorimages/pink.png"" /></div>
                    <div class=""input-item""><input type=""radio"" name=""favorite"" value=""Pink""> Pink</div>
                </div>
                <div class=""item"">
                    <div class=""img-item""><img src=""colorimages/purple.png"" /></div>
                    <div class=""input-item""><input type=""radio"" name=""favorite"" value=""Purple""> Purple</div>
                </div>
                <div class=""item"">
                    <div class=""img-item""><img src=""colorimages/red.png"" /></div>
                    <div class=""input-item""><input type=""radio"" name=""favorite"" value=""Red""> Red</div>
                </div>
                <div class=""item"">
                    <div class=""img-item""><img src=""colorimages/yellow.png"" /></div>
                    <div clas");
                    WriteLiteral("s=\"input-item\"><input type=\"radio\" name=\"favorite\" value=\"Yellow\"> Yellow</div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <div class=\"submit-batch\">\r\n            <input type=\"submit\" value=\"Submit Poll\" />\r\n        </div>\r\n    ");
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
                WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591