#pragma checksum "C:\Games_Forum\Games_Forum\Games_Forum\Views\Post\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "69a99334d2984c95e99c40d4f51981c738493267"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Post_Index), @"mvc.1.0.view", @"/Views/Post/Index.cshtml")]
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
#line 1 "C:\Games_Forum\Games_Forum\Games_Forum\Views\_ViewImports.cshtml"
using Games_Forum;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Games_Forum\Games_Forum\Games_Forum\Views\_ViewImports.cshtml"
using Games_Forum.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"69a99334d2984c95e99c40d4f51981c738493267", @"/Views/Post/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f451ff8e5f9f417dea7c8a904c66ac5683e437e", @"/Views/_ViewImports.cshtml")]
    public class Views_Post_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Games_Forum.Models.Post.PostIndexModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<h1>");
#nullable restore
#line 3 "C:\Games_Forum\Games_Forum\Games_Forum\Views\Post\Index.cshtml"
Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n\n<div>\n    Author: ");
#nullable restore
#line 6 "C:\Games_Forum\Games_Forum\Games_Forum\Views\Post\Index.cshtml"
       Write(Model.AuthorName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" (");
#nullable restore
#line 6 "C:\Games_Forum\Games_Forum\Games_Forum\Views\Post\Index.cshtml"
                          Write(Model.AuthorRating);

#line default
#line hidden
#nullable disable
            WriteLiteral(")\n    Created: ");
#nullable restore
#line 7 "C:\Games_Forum\Games_Forum\Games_Forum\Views\Post\Index.cshtml"
        Write(Model.Created);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n</div>\n\n<div>\n    ");
#nullable restore
#line 11 "C:\Games_Forum\Games_Forum\Games_Forum\Views\Post\Index.cshtml"
Write(Model.PostContent);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n</div>\n\n");
#nullable restore
#line 14 "C:\Games_Forum\Games_Forum\Games_Forum\Views\Post\Index.cshtml"
 if (@Model.Replies.Any())
{
    foreach (var reply in Model.Replies) 
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div>\n            <div>\n                Reply Author: ");
#nullable restore
#line 20 "C:\Games_Forum\Games_Forum\Games_Forum\Views\Post\Index.cshtml"
                         Write(reply.AuthorName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                Reply Created: ");
#nullable restore
#line 21 "C:\Games_Forum\Games_Forum\Games_Forum\Views\Post\Index.cshtml"
                          Write(reply.Created);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </div>\n            <div>\n                ");
#nullable restore
#line 24 "C:\Games_Forum\Games_Forum\Games_Forum\Views\Post\Index.cshtml"
           Write(reply.ReplyContent);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </div>\n        </div>\n");
#nullable restore
#line 27 "C:\Games_Forum\Games_Forum\Games_Forum\Views\Post\Index.cshtml"
    }
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Games_Forum.Models.Post.PostIndexModel> Html { get; private set; }
    }
}
#pragma warning restore 1591