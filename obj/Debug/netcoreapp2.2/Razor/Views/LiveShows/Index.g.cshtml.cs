#pragma checksum "C:\Users\Fsa\source\repos\LiveMusicFinder\LiveMusicFinder\Views\LiveShows\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fac9bafb976142659cc3dad8f71b01d48ddfb231"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_LiveShows_Index), @"mvc.1.0.view", @"/Views/LiveShows/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/LiveShows/Index.cshtml", typeof(AspNetCore.Views_LiveShows_Index))]
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
#line 1 "C:\Users\Fsa\source\repos\LiveMusicFinder\LiveMusicFinder\Views\_ViewImports.cshtml"
using LiveMusicFinder;

#line default
#line hidden
#line 2 "C:\Users\Fsa\source\repos\LiveMusicFinder\LiveMusicFinder\Views\_ViewImports.cshtml"
using LiveMusicFinder.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fac9bafb976142659cc3dad8f71b01d48ddfb231", @"/Views/LiveShows/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4af8193addc0d866172d78002b2d69843e49be7f", @"/Views/_ViewImports.cshtml")]
    public class Views_LiveShows_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<LiveMusicFinder.Models.LiveShow>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(53, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Fsa\source\repos\LiveMusicFinder\LiveMusicFinder\Views\LiveShows\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(96, 29, true);
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(125, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fac9bafb976142659cc3dad8f71b01d48ddfb2314767", async() => {
                BeginContext(148, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(162, 94, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 256, "\"", 325, 1);
#line 16 "C:\Users\Fsa\source\repos\LiveMusicFinder\LiveMusicFinder\Views\LiveShows\Index.cshtml"
WriteAttributeValue("", 263, Url.Action("Index","LiveShows", new { sortOrder = "Artist" }), 263, 62, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(326, 23, true);
            WriteLiteral(">\r\n                    ");
            EndContext();
            BeginContext(350, 42, false);
#line 17 "C:\Users\Fsa\source\repos\LiveMusicFinder\LiveMusicFinder\Views\LiveShows\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Artist));

#line default
#line hidden
            EndContext();
            BeginContext(392, 79, true);
            WriteLiteral("\r\n                </a>\r\n            </th>\r\n            <th>\r\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 471, "\"", 539, 1);
#line 21 "C:\Users\Fsa\source\repos\LiveMusicFinder\LiveMusicFinder\Views\LiveShows\Index.cshtml"
WriteAttributeValue("", 478, Url.Action("Index","LiveShows", new { sortOrder = "Venue" }), 478, 61, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(540, 23, true);
            WriteLiteral(">\r\n                    ");
            EndContext();
            BeginContext(564, 41, false);
#line 22 "C:\Users\Fsa\source\repos\LiveMusicFinder\LiveMusicFinder\Views\LiveShows\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Venue));

#line default
#line hidden
            EndContext();
            BeginContext(605, 79, true);
            WriteLiteral("\r\n                </a>\r\n            </th>\r\n            <th>\r\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 684, "\"", 755, 1);
#line 26 "C:\Users\Fsa\source\repos\LiveMusicFinder\LiveMusicFinder\Views\LiveShows\Index.cshtml"
WriteAttributeValue("", 691, Url.Action("Index","LiveShows", new { sortOrder = "ShowDate" }), 691, 64, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(756, 23, true);
            WriteLiteral(">\r\n                    ");
            EndContext();
            BeginContext(780, 44, false);
#line 27 "C:\Users\Fsa\source\repos\LiveMusicFinder\LiveMusicFinder\Views\LiveShows\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.ShowDate));

#line default
#line hidden
            EndContext();
            BeginContext(824, 79, true);
            WriteLiteral("\r\n                </a>\r\n            </th>\r\n            <th>\r\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 903, "\"", 975, 1);
#line 31 "C:\Users\Fsa\source\repos\LiveMusicFinder\LiveMusicFinder\Views\LiveShows\Index.cshtml"
WriteAttributeValue("", 910, Url.Action("Index","LiveShows", new { sortOrder = "EnteredBy" }), 910, 65, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(976, 23, true);
            WriteLiteral(">\r\n                    ");
            EndContext();
            BeginContext(1000, 45, false);
#line 32 "C:\Users\Fsa\source\repos\LiveMusicFinder\LiveMusicFinder\Views\LiveShows\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.EnteredBy));

#line default
#line hidden
            EndContext();
            BeginContext(1045, 108, true);
            WriteLiteral("\r\n                </a>\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 39 "C:\Users\Fsa\source\repos\LiveMusicFinder\LiveMusicFinder\Views\LiveShows\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(1202, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1263, 41, false);
#line 43 "C:\Users\Fsa\source\repos\LiveMusicFinder\LiveMusicFinder\Views\LiveShows\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Artist));

#line default
#line hidden
            EndContext();
            BeginContext(1304, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1372, 40, false);
#line 46 "C:\Users\Fsa\source\repos\LiveMusicFinder\LiveMusicFinder\Views\LiveShows\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Venue));

#line default
#line hidden
            EndContext();
            BeginContext(1412, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1480, 43, false);
#line 49 "C:\Users\Fsa\source\repos\LiveMusicFinder\LiveMusicFinder\Views\LiveShows\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.ShowDate));

#line default
#line hidden
            EndContext();
            BeginContext(1523, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1591, 44, false);
#line 52 "C:\Users\Fsa\source\repos\LiveMusicFinder\LiveMusicFinder\Views\LiveShows\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.EnteredBy));

#line default
#line hidden
            EndContext();
            BeginContext(1635, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1702, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fac9bafb976142659cc3dad8f71b01d48ddfb23112109", async() => {
                BeginContext(1750, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 55 "C:\Users\Fsa\source\repos\LiveMusicFinder\LiveMusicFinder\Views\LiveShows\Index.cshtml"
                                              WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1761, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 56 "C:\Users\Fsa\source\repos\LiveMusicFinder\LiveMusicFinder\Views\LiveShows\Index.cshtml"
                     if (User.Identity.IsAuthenticated && User.Identity.Name == item.EnteredBy)
                    {

#line default
#line hidden
            BeginContext(1883, 65, true);
            WriteLiteral("                        <span> |</span>\r\n                        ");
            EndContext();
            BeginContext(1948, 53, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fac9bafb976142659cc3dad8f71b01d48ddfb23114871", async() => {
                BeginContext(1993, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 59 "C:\Users\Fsa\source\repos\LiveMusicFinder\LiveMusicFinder\Views\LiveShows\Index.cshtml"
                                               WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2001, 41, true);
            WriteLiteral("<span> |</span>\r\n                        ");
            EndContext();
            BeginContext(2042, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fac9bafb976142659cc3dad8f71b01d48ddfb23117253", async() => {
                BeginContext(2089, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 60 "C:\Users\Fsa\source\repos\LiveMusicFinder\LiveMusicFinder\Views\LiveShows\Index.cshtml"
                                                 WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2099, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 61 "C:\Users\Fsa\source\repos\LiveMusicFinder\LiveMusicFinder\Views\LiveShows\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(2124, 42, true);
            WriteLiteral("                </td>\r\n            </tr>\r\n");
            EndContext();
#line 64 "C:\Users\Fsa\source\repos\LiveMusicFinder\LiveMusicFinder\Views\LiveShows\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(2177, 24, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<LiveMusicFinder.Models.LiveShow>> Html { get; private set; }
    }
}
#pragma warning restore 1591
