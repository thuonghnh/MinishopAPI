#pragma checksum "C:\Users\hoang\Downloads\WebService\WebService\WebService\WebClient\Areas\Administrator\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "96ffd3fbc15c4a1fcf42897fff93ae16e72cc206"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Administrator_Views_Product_Index), @"mvc.1.0.view", @"/Areas/Administrator/Views/Product/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Administrator/Views/Product/Index.cshtml", typeof(AspNetCore.Areas_Administrator_Views_Product_Index))]
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
#line 1 "C:\Users\hoang\Downloads\WebService\WebService\WebService\WebClient\Areas\Administrator\Views\_ViewImports.cshtml"
using DTO;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"96ffd3fbc15c4a1fcf42897fff93ae16e72cc206", @"/Areas/Administrator/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d0f9e30f068eca4a4f95ecaef724208d83a99b9c", @"/Areas/Administrator/Views/_ViewImports.cshtml")]
    public class Areas_Administrator_Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Product>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\hoang\Downloads\WebService\WebService\WebService\WebClient\Areas\Administrator\Views\Product\Index.cshtml"
  
    ViewData["Title"] = "ManagerProduct";

#line default
#line hidden
            BeginContext(72, 474, true);
            WriteLiteral(@"    <link href=""/css/style.css"" rel=""stylesheet"" />
<h2>Manager Product</h2>
<a href=""/administrator/product/create"">Create</a>
<table>
    <thead>
        <tr>
            <th>Id</th>
            <th>CategoryId</th>
            <th>Name</th>
            <th>Description</th>
            <th>Price</th>
            <th>Quantity</th>
            <th>ImageUrl</th>
            <th>Edit</th>
            <th>Delete</th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 23 "C:\Users\hoang\Downloads\WebService\WebService\WebService\WebClient\Areas\Administrator\Views\Product\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(595, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(634, 7, false);
#line 26 "C:\Users\hoang\Downloads\WebService\WebService\WebService\WebClient\Areas\Administrator\Views\Product\Index.cshtml"
               Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(641, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(669, 15, false);
#line 27 "C:\Users\hoang\Downloads\WebService\WebService\WebService\WebClient\Areas\Administrator\Views\Product\Index.cshtml"
               Write(item.CategoryId);

#line default
#line hidden
            EndContext();
            BeginContext(684, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(712, 9, false);
#line 28 "C:\Users\hoang\Downloads\WebService\WebService\WebService\WebClient\Areas\Administrator\Views\Product\Index.cshtml"
               Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(721, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(749, 16, false);
#line 29 "C:\Users\hoang\Downloads\WebService\WebService\WebService\WebClient\Areas\Administrator\Views\Product\Index.cshtml"
               Write(item.Description);

#line default
#line hidden
            EndContext();
            BeginContext(765, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(793, 10, false);
#line 30 "C:\Users\hoang\Downloads\WebService\WebService\WebService\WebClient\Areas\Administrator\Views\Product\Index.cshtml"
               Write(item.Price);

#line default
#line hidden
            EndContext();
            BeginContext(803, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(831, 13, false);
#line 31 "C:\Users\hoang\Downloads\WebService\WebService\WebService\WebClient\Areas\Administrator\Views\Product\Index.cshtml"
               Write(item.Quantity);

#line default
#line hidden
            EndContext();
            BeginContext(844, 29, true);
            WriteLiteral("</td>\r\n                <td>\r\n");
            EndContext();
#line 33 "C:\Users\hoang\Downloads\WebService\WebService\WebService\WebClient\Areas\Administrator\Views\Product\Index.cshtml"
                     if (item.ImageUrl != null)
                    {

#line default
#line hidden
            BeginContext(945, 28, true);
            WriteLiteral("                        <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 973, "\"", 1001, 2);
            WriteAttributeValue("", 979, "/upload/", 979, 8, true);
#line 35 "C:\Users\hoang\Downloads\WebService\WebService\WebService\WebClient\Areas\Administrator\Views\Product\Index.cshtml"
WriteAttributeValue("", 987, item.ImageUrl, 987, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1002, 17, true);
            WriteLiteral(" width=\"200\" />\r\n");
            EndContext();
#line 36 "C:\Users\hoang\Downloads\WebService\WebService\WebService\WebClient\Areas\Administrator\Views\Product\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(1042, 67, true);
            WriteLiteral("                </td>\r\n                <td>\r\n                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1109, "\"", 1152, 2);
            WriteAttributeValue("", 1116, "/administrator/product/edit/", 1116, 28, true);
#line 39 "C:\Users\hoang\Downloads\WebService\WebService\WebService\WebClient\Areas\Administrator\Views\Product\Index.cshtml"
WriteAttributeValue("", 1144, item.Id, 1144, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1153, 152, true);
            WriteLiteral(">\r\n                        <img src=\"/images/edit.png\" />\r\n                    </a>\r\n                </td>\r\n                <td>\r\n                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1305, "\"", 1350, 2);
            WriteAttributeValue("", 1312, "/administrator/product/delete/", 1312, 30, true);
#line 44 "C:\Users\hoang\Downloads\WebService\WebService\WebService\WebClient\Areas\Administrator\Views\Product\Index.cshtml"
WriteAttributeValue("", 1342, item.Id, 1342, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1351, 128, true);
            WriteLiteral(">\r\n                        <img src=\"/images/trash.png\" />\r\n                    </a>\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 49 "C:\Users\hoang\Downloads\WebService\WebService\WebService\WebClient\Areas\Administrator\Views\Product\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1490, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
