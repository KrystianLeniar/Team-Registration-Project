#pragma checksum "C:\Users\LEGION3\source\repos\TeamRegistration\TeamRegistration\Views\Teams\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7d182744a6e946b51341612a3f471576174e90ef"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Teams_Index), @"mvc.1.0.view", @"/Views/Teams/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Teams/Index.cshtml", typeof(AspNetCore.Views_Teams_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d182744a6e946b51341612a3f471576174e90ef", @"/Views/Teams/Index.cshtml")]
    public class Views_Teams_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TeamRegistration.Models.Teams>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(51, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\LEGION3\source\repos\TeamRegistration\TeamRegistration\Views\Teams\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(94, 158, true);
            WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n<p>\r\n    <a asp-action=\"Create\">Create New</a>\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(253, 44, false);
#line 16 "C:\Users\LEGION3\source\repos\TeamRegistration\TeamRegistration\Views\Teams\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TeamName));

#line default
#line hidden
            EndContext();
            BeginContext(297, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(353, 46, false);
#line 19 "C:\Users\LEGION3\source\repos\TeamRegistration\TeamRegistration\Views\Teams\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.LeaderName));

#line default
#line hidden
            EndContext();
            BeginContext(399, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(455, 46, false);
#line 22 "C:\Users\LEGION3\source\repos\TeamRegistration\TeamRegistration\Views\Teams\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CallNumber));

#line default
#line hidden
            EndContext();
            BeginContext(501, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(557, 48, false);
#line 25 "C:\Users\LEGION3\source\repos\TeamRegistration\TeamRegistration\Views\Teams\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TeamLocation));

#line default
#line hidden
            EndContext();
            BeginContext(605, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 31 "C:\Users\LEGION3\source\repos\TeamRegistration\TeamRegistration\Views\Teams\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(723, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(772, 43, false);
#line 34 "C:\Users\LEGION3\source\repos\TeamRegistration\TeamRegistration\Views\Teams\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.TeamName));

#line default
#line hidden
            EndContext();
            BeginContext(815, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(871, 45, false);
#line 37 "C:\Users\LEGION3\source\repos\TeamRegistration\TeamRegistration\Views\Teams\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.LeaderName));

#line default
#line hidden
            EndContext();
            BeginContext(916, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(972, 45, false);
#line 40 "C:\Users\LEGION3\source\repos\TeamRegistration\TeamRegistration\Views\Teams\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CallNumber));

#line default
#line hidden
            EndContext();
            BeginContext(1017, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1073, 47, false);
#line 43 "C:\Users\LEGION3\source\repos\TeamRegistration\TeamRegistration\Views\Teams\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.TeamLocation));

#line default
#line hidden
            EndContext();
            BeginContext(1120, 75, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <a asp-action=\"Edit\"");
            EndContext();
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1195, "\"", 1223, 1);
#line 46 "C:\Users\LEGION3\source\repos\TeamRegistration\TeamRegistration\Views\Teams\Index.cshtml"
WriteAttributeValue("", 1210, item.TeamsId, 1210, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1224, 52, true);
            WriteLiteral(">Edit</a> |\r\n                <a asp-action=\"Details\"");
            EndContext();
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1276, "\"", 1304, 1);
#line 47 "C:\Users\LEGION3\source\repos\TeamRegistration\TeamRegistration\Views\Teams\Index.cshtml"
WriteAttributeValue("", 1291, item.TeamsId, 1291, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1305, 54, true);
            WriteLiteral(">Details</a> |\r\n                <a asp-action=\"Delete\"");
            EndContext();
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1359, "\"", 1387, 1);
#line 48 "C:\Users\LEGION3\source\repos\TeamRegistration\TeamRegistration\Views\Teams\Index.cshtml"
WriteAttributeValue("", 1374, item.TeamsId, 1374, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1388, 47, true);
            WriteLiteral(">Delete</a>\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 51 "C:\Users\LEGION3\source\repos\TeamRegistration\TeamRegistration\Views\Teams\Index.cshtml"
}

#line default
#line hidden
            BeginContext(1438, 24, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<TeamRegistration.Models.Teams>> Html { get; private set; }
    }
}
#pragma warning restore 1591
