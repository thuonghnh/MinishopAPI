#pragma checksum "C:\Users\hoang\Downloads\WebService\WebService\WebService\WebClient\Views\Home\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "20a61a318fbaa5ae998c0ff8de24355690b65fd8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Detail), @"mvc.1.0.view", @"/Views/Home/Detail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Detail.cshtml", typeof(AspNetCore.Views_Home_Detail))]
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
#line 1 "C:\Users\hoang\Downloads\WebService\WebService\WebService\WebClient\Views\_ViewImports.cshtml"
using DTO;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20a61a318fbaa5ae998c0ff8de24355690b65fd8", @"/Views/Home/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"75616952ad48f557dea3eb4b5ab9331af75af777", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Product>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/cart/create"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "ViewCategory", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\hoang\Downloads\WebService\WebService\WebService\WebClient\Views\Home\Detail.cshtml"
  
    Layout = "_LayoutHome";
    ViewData["Title"] = "Detail";

#line default
#line hidden
            BeginContext(87, 74, true);
            WriteLiteral("\r\n<div>\r\n    <table>\r\n        <tr>\r\n            <td>\r\n                <h2>");
            EndContext();
            BeginContext(162, 10, false);
#line 11 "C:\Users\hoang\Downloads\WebService\WebService\WebService\WebClient\Views\Home\Detail.cshtml"
               Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(172, 54, true);
            WriteLiteral("</h2>\r\n                <div>\r\n                    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 226, "\"", 255, 2);
            WriteAttributeValue("", 232, "/upload/", 232, 8, true);
#line 13 "C:\Users\hoang\Downloads\WebService\WebService\WebService\WebClient\Views\Home\Detail.cshtml"
WriteAttributeValue("", 240, Model.ImageUrl, 240, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(256, 101, true);
            WriteLiteral(" style=\"width:250px\"/>\r\n                </div>\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(357, 435, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "20a61a318fbaa5ae998c0ff8de24355690b65fd85549", async() => {
                BeginContext(399, 59, true);
                WriteLiteral("\r\n                    <input type=\"hidden\" name=\"productid\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 458, "\"", 475, 1);
#line 18 "C:\Users\hoang\Downloads\WebService\WebService\WebService\WebClient\Views\Home\Detail.cshtml"
WriteAttributeValue("", 466, Model.Id, 466, 9, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(476, 309, true);
                WriteLiteral(@" />
                    <input type=""number"" name=""quantity"" value=""1"" min=""1"" max=""10"" style=""font-size:20px; width:10%; border: 1px solid #808080""/>
                    <button style=""border-radius:4px; font-size:20px; padding: 3px 10px; background-color: LightSalmon;"">Add Cart</button>
                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(792, 31, true);
            WriteLiteral("\r\n                <p>Price: <b>");
            EndContext();
            BeginContext(824, 42, false);
#line 22 "C:\Users\hoang\Downloads\WebService\WebService\WebService\WebClient\Views\Home\Detail.cshtml"
                        Write(Html.FormatValue(Model.Price, "{0:$#,##}"));

#line default
#line hidden
            EndContext();
            BeginContext(866, 39, true);
            WriteLiteral("</b></p>\r\n                <p>Quantity: ");
            EndContext();
            BeginContext(906, 14, false);
#line 23 "C:\Users\hoang\Downloads\WebService\WebService\WebService\WebClient\Views\Home\Detail.cshtml"
                        Write(Model.Quantity);

#line default
#line hidden
            EndContext();
            BeginContext(920, 38, true);
            WriteLiteral("</p>\r\n                <p>Description: ");
            EndContext();
            BeginContext(959, 17, false);
#line 24 "C:\Users\hoang\Downloads\WebService\WebService\WebService\WebClient\Views\Home\Detail.cshtml"
                           Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(976, 104, true);
            WriteLiteral("</p>\r\n            </td>\r\n        </tr>\r\n    </table>\r\n</div>\r\n<div>\r\n    <h3>Product Relation</h3>\r\n    ");
            EndContext();
            BeginContext(1080, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "20a61a318fbaa5ae998c0ff8de24355690b65fd89412", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#line 31 "C:\Users\hoang\Downloads\WebService\WebService\WebService\WebClient\Views\Home\Detail.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = Model.Relation;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1134, 8, true);
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
