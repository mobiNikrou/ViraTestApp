#pragma checksum "C:\Users\rezazade-kh\Desktop\Nikrou_Jobs\.Net_WebApp_Projects\ViraTestApp\Views\Home\TestHistory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fe1deda23536995dcc4e01a089112e1598ac3bc4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_TestHistory), @"mvc.1.0.view", @"/Views/Home/TestHistory.cshtml")]
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
#line 1 "C:\Users\rezazade-kh\Desktop\Nikrou_Jobs\.Net_WebApp_Projects\ViraTestApp\Views\_ViewImports.cshtml"
using ViraTestApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\rezazade-kh\Desktop\Nikrou_Jobs\.Net_WebApp_Projects\ViraTestApp\Views\_ViewImports.cshtml"
using ViraTestApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe1deda23536995dcc4e01a089112e1598ac3bc4", @"/Views/Home/TestHistory.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3694dfb81377858ed11f9a2e9a9f1bfe335fcd7b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_TestHistory : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ViraTestApp.Models.TestingResult>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\rezazade-kh\Desktop\Nikrou_Jobs\.Net_WebApp_Projects\ViraTestApp\Views\Home\TestHistory.cshtml"
  
    ViewData["Title"] = "Test History";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Test History</h1>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 13 "C:\Users\rezazade-kh\Desktop\Nikrou_Jobs\.Net_WebApp_Projects\ViraTestApp\Views\Home\TestHistory.cshtml"
           Write(Html.DisplayNameFor(model => model.TestCheck1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Users\rezazade-kh\Desktop\Nikrou_Jobs\.Net_WebApp_Projects\ViraTestApp\Views\Home\TestHistory.cshtml"
           Write(Html.DisplayNameFor(model => model.TestCheck2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\rezazade-kh\Desktop\Nikrou_Jobs\.Net_WebApp_Projects\ViraTestApp\Views\Home\TestHistory.cshtml"
           Write(Html.DisplayNameFor(model => model.TestCheck3));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                Actions\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 28 "C:\Users\rezazade-kh\Desktop\Nikrou_Jobs\.Net_WebApp_Projects\ViraTestApp\Views\Home\TestHistory.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 31 "C:\Users\rezazade-kh\Desktop\Nikrou_Jobs\.Net_WebApp_Projects\ViraTestApp\Views\Home\TestHistory.cshtml"
           Write(Html.DisplayFor(modelItem => item.TestCheck1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 34 "C:\Users\rezazade-kh\Desktop\Nikrou_Jobs\.Net_WebApp_Projects\ViraTestApp\Views\Home\TestHistory.cshtml"
           Write(Html.DisplayFor(modelItem => item.TestCheck2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 37 "C:\Users\rezazade-kh\Desktop\Nikrou_Jobs\.Net_WebApp_Projects\ViraTestApp\Views\Home\TestHistory.cshtml"
           Write(Html.DisplayFor(modelItem => item.TestCheck3));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 40 "C:\Users\rezazade-kh\Desktop\Nikrou_Jobs\.Net_WebApp_Projects\ViraTestApp\Views\Home\TestHistory.cshtml"
           Write(Html.ActionLink("Details", "","","",new { @class= "btn btn-warning" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 41 "C:\Users\rezazade-kh\Desktop\Nikrou_Jobs\.Net_WebApp_Projects\ViraTestApp\Views\Home\TestHistory.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new{id=item.Id} ,new { @class= "btn btn-danger"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 42 "C:\Users\rezazade-kh\Desktop\Nikrou_Jobs\.Net_WebApp_Projects\ViraTestApp\Views\Home\TestHistory.cshtml"
           Write(Html.ActionLink("Run Test", "Delete", new{id=item.Id} ,new { @class= "btn btn-light"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            \r\n        </tr>\r\n");
#nullable restore
#line 46 "C:\Users\rezazade-kh\Desktop\Nikrou_Jobs\.Net_WebApp_Projects\ViraTestApp\Views\Home\TestHistory.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ViraTestApp.Models.TestingResult>> Html { get; private set; }
    }
}
#pragma warning restore 1591