#pragma checksum "C:\Users\m.dutt\source\repos\OdeToFood\OdeToFood\Views\Restaurants\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "81ac09613d156ce829925c997d4c6a3ef48f178c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Restaurants_Delete), @"mvc.1.0.view", @"/Views/Restaurants/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Restaurants/Delete.cshtml", typeof(AspNetCore.Views_Restaurants_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"81ac09613d156ce829925c997d4c6a3ef48f178c", @"/Views/Restaurants/Delete.cshtml")]
    public class Views_Restaurants_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OdeToFood.Core.Restaurant>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(34, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\m.dutt\source\repos\OdeToFood\OdeToFood\Views\Restaurants\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(78, 171, true);
            WriteLiteral("\r\n<h2>Delete</h2>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Restaurant</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(250, 40, false);
#line 15 "C:\Users\m.dutt\source\repos\OdeToFood\OdeToFood\Views\Restaurants\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(290, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(334, 36, false);
#line 18 "C:\Users\m.dutt\source\repos\OdeToFood\OdeToFood\Views\Restaurants\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(370, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(414, 44, false);
#line 21 "C:\Users\m.dutt\source\repos\OdeToFood\OdeToFood\Views\Restaurants\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Location));

#line default
#line hidden
            EndContext();
            BeginContext(458, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(502, 40, false);
#line 24 "C:\Users\m.dutt\source\repos\OdeToFood\OdeToFood\Views\Restaurants\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Location));

#line default
#line hidden
            EndContext();
            BeginContext(542, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(586, 43, false);
#line 27 "C:\Users\m.dutt\source\repos\OdeToFood\OdeToFood\Views\Restaurants\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Cuisine));

#line default
#line hidden
            EndContext();
            BeginContext(629, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(673, 39, false);
#line 30 "C:\Users\m.dutt\source\repos\OdeToFood\OdeToFood\Views\Restaurants\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Cuisine));

#line default
#line hidden
            EndContext();
            BeginContext(712, 255, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    <form asp-action=\"Delete\">\r\n        <input type=\"hidden\" asp-for=\"Id\" />\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-default\" /> |\r\n        <a asp-action=\"Index\">Back to List</a>\r\n    </form>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OdeToFood.Core.Restaurant> Html { get; private set; }
    }
}
#pragma warning restore 1591
