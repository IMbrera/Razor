#pragma checksum "E:\stud\Razor - 3\Razor\razor\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3651d3bda14b88b34425e26148e8aef2dbc21a53"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "E:\stud\Razor - 3\Razor\razor\Views\_ViewImports.cshtml"
using razor.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3651d3bda14b88b34425e26148e8aef2dbc21a53", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a6b30d601c56f2dac43ed062c4eca2879e10f590", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Products[]>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "E:\stud\Razor - 3\Razor\razor\Views\Home\Index.cshtml"
  
    ViewBag.Title = "Product Name";

#line default
#line hidden
            BeginContext(63, 197, true);
            WriteLiteral("<table>\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                Name\r\n            </th>\r\n            <th>\r\n                Price\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 17 "E:\stud\Razor - 3\Razor\razor\Views\Home\Index.cshtml"
         foreach (Products p in Model)
        {

#line default
#line hidden
            BeginContext(311, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(350, 6, false);
#line 20 "E:\stud\Razor - 3\Razor\razor\Views\Home\Index.cshtml"
               Write(p.Name);

#line default
#line hidden
            EndContext();
            BeginContext(356, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(385, 15, false);
#line 21 "E:\stud\Razor - 3\Razor\razor\Views\Home\Index.cshtml"
                Write($"{p.Price:C2}");

#line default
#line hidden
            EndContext();
            BeginContext(401, 26, true);
            WriteLiteral("</td>\r\n            </tr>\r\n");
            EndContext();
#line 23 "E:\stud\Razor - 3\Razor\razor\Views\Home\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(438, 613, true);
            WriteLiteral(@"    </tbody>
</table>





<!--
<div data-productid=""Model.ProductID""
       data-stocklevel=""ViewBag.StockLevel"">
      <p>Product Name: Model.Name</p>
      <p>Product Price: ($""{ Model.Price: C2}"")</p>
      <p>
          Stock Level: if (ViewBag.StockLevel == 0)
          {
              :Out of Stock
          }
          else if (ViewBag.StockLevel > 0 && ViewBag.StockLevel <= 3)
          {
              <b>Low stock (ViewBag.StockLevel</b>
          }
          else
          {
              : ViewBag.StockLevel in Stock
          }
      </p>
          </div>
     -->
 ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Products[]> Html { get; private set; }
    }
}
#pragma warning restore 1591
