#pragma checksum "C:\Users\14039\source\repos\ASP_NET_Core_MVC_Lab2\ASP_NET_Core_MVC_Lab1\Views\Leases\MySlips.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "352a406cddd0eac0ef20966d4ad7be9eae4e1bcf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Leases_MySlips), @"mvc.1.0.view", @"/Views/Leases/MySlips.cshtml")]
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
#line 1 "C:\Users\14039\source\repos\ASP_NET_Core_MVC_Lab2\ASP_NET_Core_MVC_Lab1\Views\_ViewImports.cshtml"
using ASP_NET_Core_MVC_Lab1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\14039\source\repos\ASP_NET_Core_MVC_Lab2\ASP_NET_Core_MVC_Lab1\Views\_ViewImports.cshtml"
using ASP_NET_Core_MVC_Lab1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"352a406cddd0eac0ef20966d4ad7be9eae4e1bcf", @"/Views/Leases/MySlips.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d6c4e0154fd0ff353f7461f444c4851e12ed387", @"/Views/_ViewImports.cshtml")]
    public class Views_Leases_MySlips : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DbEntities_Class_Library.LeaseSlipViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\14039\source\repos\ASP_NET_Core_MVC_Lab2\ASP_NET_Core_MVC_Lab1\Views\Leases\MySlips.cshtml"
  
    ViewData["Title"] = "MySlips";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container"">
    <h1 class=""text-center text-primary"">My Slips: <i class=""fas fa-ship ml-2""></i></h1>

    <table id=""mySlipsTable"" class=""table table-bordered table-striped table-hover 
           justify-content-center text-center"">
        <thead style=""position:sticky; top:0"" class=""bg-white text-primary"">
            <tr>
                <th>
                    ");
#nullable restore
#line 15 "C:\Users\14039\source\repos\ASP_NET_Core_MVC_Lab2\ASP_NET_Core_MVC_Lab1\Views\Leases\MySlips.cshtml"
               Write(Html.DisplayNameFor(model => model.LeaseID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 18 "C:\Users\14039\source\repos\ASP_NET_Core_MVC_Lab2\ASP_NET_Core_MVC_Lab1\Views\Leases\MySlips.cshtml"
               Write(Html.DisplayNameFor(model => model.SlipID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 21 "C:\Users\14039\source\repos\ASP_NET_Core_MVC_Lab2\ASP_NET_Core_MVC_Lab1\Views\Leases\MySlips.cshtml"
               Write(Html.DisplayNameFor(model => model.Width));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 24 "C:\Users\14039\source\repos\ASP_NET_Core_MVC_Lab2\ASP_NET_Core_MVC_Lab1\Views\Leases\MySlips.cshtml"
               Write(Html.DisplayNameFor(model => model.Length));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 27 "C:\Users\14039\source\repos\ASP_NET_Core_MVC_Lab2\ASP_NET_Core_MVC_Lab1\Views\Leases\MySlips.cshtml"
               Write(Html.DisplayNameFor(model => model.DockName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 30 "C:\Users\14039\source\repos\ASP_NET_Core_MVC_Lab2\ASP_NET_Core_MVC_Lab1\Views\Leases\MySlips.cshtml"
               Write(Html.DisplayNameFor(model => model.WaterService));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 33 "C:\Users\14039\source\repos\ASP_NET_Core_MVC_Lab2\ASP_NET_Core_MVC_Lab1\Views\Leases\MySlips.cshtml"
               Write(Html.DisplayNameFor(model => model.ElectricalService));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 36 "C:\Users\14039\source\repos\ASP_NET_Core_MVC_Lab2\ASP_NET_Core_MVC_Lab1\Views\Leases\MySlips.cshtml"
               Write(Html.DisplayNameFor(model => model.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 39 "C:\Users\14039\source\repos\ASP_NET_Core_MVC_Lab2\ASP_NET_Core_MVC_Lab1\Views\Leases\MySlips.cshtml"
               Write(Html.DisplayNameFor(model => model.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 42 "C:\Users\14039\source\repos\ASP_NET_Core_MVC_Lab2\ASP_NET_Core_MVC_Lab1\Views\Leases\MySlips.cshtml"
               Write(Html.DisplayNameFor(model => model.Phone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 45 "C:\Users\14039\source\repos\ASP_NET_Core_MVC_Lab2\ASP_NET_Core_MVC_Lab1\Views\Leases\MySlips.cshtml"
               Write(Html.DisplayNameFor(model => model.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n");
            WriteLiteral("            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 51 "C:\Users\14039\source\repos\ASP_NET_Core_MVC_Lab2\ASP_NET_Core_MVC_Lab1\Views\Leases\MySlips.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 55 "C:\Users\14039\source\repos\ASP_NET_Core_MVC_Lab2\ASP_NET_Core_MVC_Lab1\Views\Leases\MySlips.cshtml"
                   Write(Html.DisplayFor(modelItem => item.LeaseID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 58 "C:\Users\14039\source\repos\ASP_NET_Core_MVC_Lab2\ASP_NET_Core_MVC_Lab1\Views\Leases\MySlips.cshtml"
                   Write(Html.DisplayFor(modelItem => item.SlipID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 61 "C:\Users\14039\source\repos\ASP_NET_Core_MVC_Lab2\ASP_NET_Core_MVC_Lab1\Views\Leases\MySlips.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Width));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 64 "C:\Users\14039\source\repos\ASP_NET_Core_MVC_Lab2\ASP_NET_Core_MVC_Lab1\Views\Leases\MySlips.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Length));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 67 "C:\Users\14039\source\repos\ASP_NET_Core_MVC_Lab2\ASP_NET_Core_MVC_Lab1\Views\Leases\MySlips.cshtml"
                   Write(Html.DisplayFor(modelItem => item.DockName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 70 "C:\Users\14039\source\repos\ASP_NET_Core_MVC_Lab2\ASP_NET_Core_MVC_Lab1\Views\Leases\MySlips.cshtml"
                   Write(Html.DisplayFor(modelItem => item.WaterService));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 73 "C:\Users\14039\source\repos\ASP_NET_Core_MVC_Lab2\ASP_NET_Core_MVC_Lab1\Views\Leases\MySlips.cshtml"
                   Write(Html.DisplayFor(modelItem => item.ElectricalService));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 76 "C:\Users\14039\source\repos\ASP_NET_Core_MVC_Lab2\ASP_NET_Core_MVC_Lab1\Views\Leases\MySlips.cshtml"
                   Write(Html.DisplayFor(modelItem => item.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 79 "C:\Users\14039\source\repos\ASP_NET_Core_MVC_Lab2\ASP_NET_Core_MVC_Lab1\Views\Leases\MySlips.cshtml"
                   Write(Html.DisplayFor(modelItem => item.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 82 "C:\Users\14039\source\repos\ASP_NET_Core_MVC_Lab2\ASP_NET_Core_MVC_Lab1\Views\Leases\MySlips.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Phone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 85 "C:\Users\14039\source\repos\ASP_NET_Core_MVC_Lab2\ASP_NET_Core_MVC_Lab1\Views\Leases\MySlips.cshtml"
                   Write(Html.DisplayFor(modelItem => item.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>                   \r\n                </tr>\r\n");
#nullable restore
#line 88 "C:\Users\14039\source\repos\ASP_NET_Core_MVC_Lab2\ASP_NET_Core_MVC_Lab1\Views\Leases\MySlips.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DbEntities_Class_Library.LeaseSlipViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
