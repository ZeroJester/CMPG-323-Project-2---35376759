#pragma checksum "C:\Users\Marcel\Desktop\GithubRepo\CMPG-323-Project-2---35376759\Project2-35376759\Project2-35376759\Views\Categories\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f7e4226b3eb568c8713bac0021563196a88c2ab2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Categories_Edit), @"mvc.1.0.view", @"/Views/Categories/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f7e4226b3eb568c8713bac0021563196a88c2ab2", @"/Views/Categories/Edit.cshtml")]
    #nullable restore
    public class Views_Categories_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Project2_35376759.Models.Category>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Marcel\Desktop\GithubRepo\CMPG-323-Project-2---35376759\Project2-35376759\Project2-35376759\Views\Categories\Edit.cshtml"
  
    ViewData["Title"] = "Edit";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Edit</h1>

<h4>Category</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Edit"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <input type=""hidden"" asp-for=""CategoryId"" />
            <div class=""form-group"">
                <label asp-for=""CategoryName"" class=""control-label""></label>
                <input asp-for=""CategoryName"" class=""form-control"" />
                <span asp-validation-for=""CategoryName"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""CategoryDescription"" class=""control-label""></label>
                <input asp-for=""CategoryDescription"" class=""form-control"" />
                <span asp-validation-for=""CategoryDescription"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""DateCreated"" class=""control-label""></label>
                <input asp-for=""DateCre");
            WriteLiteral(@"ated"" class=""form-control"" />
                <span asp-validation-for=""DateCreated"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Save"" class=""btn btn-primary"" />
            </div>
        </form>
    </div>
</div>

<div>
    <a asp-action=""Index"">Back to List</a>
</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 43 "C:\Users\Marcel\Desktop\GithubRepo\CMPG-323-Project-2---35376759\Project2-35376759\Project2-35376759\Views\Categories\Edit.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Project2_35376759.Models.Category> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
