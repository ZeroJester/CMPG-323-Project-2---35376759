#pragma checksum "C:\Users\Marcel\Desktop\GithubRepo\CMPG-323-Project-2---35376759\Project2-35376759\Project2-35376759\Views\Zones\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cf2744a08103c9e45307ec85ad7a760900adb684"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Zones_Index), @"mvc.1.0.view", @"/Views/Zones/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf2744a08103c9e45307ec85ad7a760900adb684", @"/Views/Zones/Index.cshtml")]
    #nullable restore
    public class Views_Zones_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Project2_35376759.Models.Zone>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Marcel\Desktop\GithubRepo\CMPG-323-Project-2---35376759\Project2-35376759\Project2-35376759\Views\Zones\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    <a asp-action=\"Create\">Create New</a>\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Users\Marcel\Desktop\GithubRepo\CMPG-323-Project-2---35376759\Project2-35376759\Project2-35376759\Views\Zones\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ZoneName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\Marcel\Desktop\GithubRepo\CMPG-323-Project-2---35376759\Project2-35376759\Project2-35376759\Views\Zones\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ZoneDescription));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Users\Marcel\Desktop\GithubRepo\CMPG-323-Project-2---35376759\Project2-35376759\Project2-35376759\Views\Zones\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DateCreated));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 28 "C:\Users\Marcel\Desktop\GithubRepo\CMPG-323-Project-2---35376759\Project2-35376759\Project2-35376759\Views\Zones\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 31 "C:\Users\Marcel\Desktop\GithubRepo\CMPG-323-Project-2---35376759\Project2-35376759\Project2-35376759\Views\Zones\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ZoneName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 34 "C:\Users\Marcel\Desktop\GithubRepo\CMPG-323-Project-2---35376759\Project2-35376759\Project2-35376759\Views\Zones\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ZoneDescription));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 37 "C:\Users\Marcel\Desktop\GithubRepo\CMPG-323-Project-2---35376759\Project2-35376759\Project2-35376759\Views\Zones\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.DateCreated));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <a asp-action=\"Edit\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1000, "\"", 1027, 1);
#nullable restore
#line 40 "C:\Users\Marcel\Desktop\GithubRepo\CMPG-323-Project-2---35376759\Project2-35376759\Project2-35376759\Views\Zones\Index.cshtml"
WriteAttributeValue("", 1015, item.ZoneId, 1015, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a> |\r\n                <a asp-action=\"Details\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1080, "\"", 1107, 1);
#nullable restore
#line 41 "C:\Users\Marcel\Desktop\GithubRepo\CMPG-323-Project-2---35376759\Project2-35376759\Project2-35376759\Views\Zones\Index.cshtml"
WriteAttributeValue("", 1095, item.ZoneId, 1095, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Details</a> |\r\n                <a asp-action=\"Delete\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1162, "\"", 1189, 1);
#nullable restore
#line 42 "C:\Users\Marcel\Desktop\GithubRepo\CMPG-323-Project-2---35376759\Project2-35376759\Project2-35376759\Views\Zones\Index.cshtml"
WriteAttributeValue("", 1177, item.ZoneId, 1177, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 45 "C:\Users\Marcel\Desktop\GithubRepo\CMPG-323-Project-2---35376759\Project2-35376759\Project2-35376759\Views\Zones\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Project2_35376759.Models.Zone>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591