#pragma checksum "C:\Users\LEGION3\source\repos\TeamRegistration\TeamRegistration\Views\Teams\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "57ab84c9ccfc722a0ffe8f907816d30df474b700"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Teams_Details), @"mvc.1.0.view", @"/Views/Teams/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Teams/Details.cshtml", typeof(AspNetCore.Views_Teams_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57ab84c9ccfc722a0ffe8f907816d30df474b700", @"/Views/Teams/Details.cshtml")]
    public class Views_Teams_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TeamRegistration.Models.Teams>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(38, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\LEGION3\source\repos\TeamRegistration\TeamRegistration\Views\Teams\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(83, 119, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>Teams</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(203, 44, false);
#line 14 "C:\Users\LEGION3\source\repos\TeamRegistration\TeamRegistration\Views\Teams\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TeamName));

#line default
#line hidden
            EndContext();
            BeginContext(247, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(291, 40, false);
#line 17 "C:\Users\LEGION3\source\repos\TeamRegistration\TeamRegistration\Views\Teams\Details.cshtml"
       Write(Html.DisplayFor(model => model.TeamName));

#line default
#line hidden
            EndContext();
            BeginContext(331, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(375, 46, false);
#line 20 "C:\Users\LEGION3\source\repos\TeamRegistration\TeamRegistration\Views\Teams\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.LeaderName));

#line default
#line hidden
            EndContext();
            BeginContext(421, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(465, 42, false);
#line 23 "C:\Users\LEGION3\source\repos\TeamRegistration\TeamRegistration\Views\Teams\Details.cshtml"
       Write(Html.DisplayFor(model => model.LeaderName));

#line default
#line hidden
            EndContext();
            BeginContext(507, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(551, 46, false);
#line 26 "C:\Users\LEGION3\source\repos\TeamRegistration\TeamRegistration\Views\Teams\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CallNumber));

#line default
#line hidden
            EndContext();
            BeginContext(597, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(641, 42, false);
#line 29 "C:\Users\LEGION3\source\repos\TeamRegistration\TeamRegistration\Views\Teams\Details.cshtml"
       Write(Html.DisplayFor(model => model.CallNumber));

#line default
#line hidden
            EndContext();
            BeginContext(683, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(727, 48, false);
#line 32 "C:\Users\LEGION3\source\repos\TeamRegistration\TeamRegistration\Views\Teams\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TeamLocation));

#line default
#line hidden
            EndContext();
            BeginContext(775, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(819, 44, false);
#line 35 "C:\Users\LEGION3\source\repos\TeamRegistration\TeamRegistration\Views\Teams\Details.cshtml"
       Write(Html.DisplayFor(model => model.TeamLocation));

#line default
#line hidden
            EndContext();
            BeginContext(863, 67, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    <a asp-action=\"Edit\"");
            EndContext();
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 930, "\"", 959, 1);
#line 40 "C:\Users\LEGION3\source\repos\TeamRegistration\TeamRegistration\Views\Teams\Details.cshtml"
WriteAttributeValue("", 945, Model.TeamsId, 945, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(960, 65, true);
            WriteLiteral(">Edit</a> |\r\n    <a asp-action=\"Index\">Back to List</a>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TeamRegistration.Models.Teams> Html { get; private set; }
    }
}
#pragma warning restore 1591
