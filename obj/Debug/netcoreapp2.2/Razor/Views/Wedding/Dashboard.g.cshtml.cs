#pragma checksum "/Users/ryan/Desktop/coding_dojo/C_Sharp/orm/WeddingPlanner/Views/Wedding/Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "41240e1c901bb89bfb01b12a08da0eb100b7cbaf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MyApp.Namespace.Wedding.Views_Wedding_Dashboard), @"mvc.1.0.view", @"/Views/Wedding/Dashboard.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Wedding/Dashboard.cshtml", typeof(MyApp.Namespace.Wedding.Views_Wedding_Dashboard))]
namespace MyApp.Namespace.Wedding
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 2 "/Users/ryan/Desktop/coding_dojo/C_Sharp/orm/WeddingPlanner/Views/Wedding/Dashboard.cshtml"
using WeddingPlanner.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"41240e1c901bb89bfb01b12a08da0eb100b7cbaf", @"/Views/Wedding/Dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc1d1eb37dc6f0d82250bf784d7ea6a0b75ca51c", @"/Views/_ViewImports.cshtml")]
    public class Views_Wedding_Dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Wedding>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "NavPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 212, true);
            WriteLiteral("<link rel=\"stylesheet\" href=\"https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css\" integrity=\"sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T\" crossorigin=\"anonymous\">\n");
            EndContext();
            BeginContext(262, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(263, 27, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "41240e1c901bb89bfb01b12a08da0eb100b7cbaf3705", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(290, 111, true);
            WriteLiteral("</partial>\n<h1 class=\"mt-4\">Welcome to the Wedding Planner</h1>\n<div class=\"mt-5 mx-2\">\n<h5>You have RSVP\'d to ");
            EndContext();
            BeginContext(402, 31, false);
#line 8 "/Users/ryan/Desktop/coding_dojo/C_Sharp/orm/WeddingPlanner/Views/Wedding/Dashboard.cshtml"
                  Write(ViewBag.LiveUser.Weddings.Count);

#line default
#line hidden
            EndContext();
            BeginContext(433, 279, true);
            WriteLiteral(@" weddings</h5>
<table class=""table table-bordered table-hover"">
    <thead class=""table-danger"">
    <tr>
        <td class=""couple"">Couple</td>
        <td class=""day"">Date</td>
        <td>Guest(s)</td>
        <td class=""action"">Action</td>
    </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 19 "/Users/ryan/Desktop/coding_dojo/C_Sharp/orm/WeddingPlanner/Views/Wedding/Dashboard.cshtml"
         foreach (Wedding w in @Model)
        {

#line default
#line hidden
            BeginContext(761, 48, true);
            WriteLiteral("        <tr>\n            <td>\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 809, "\"", 837, 2);
            WriteAttributeValue("", 816, "/wedding/", 816, 9, true);
#line 23 "/Users/ryan/Desktop/coding_dojo/C_Sharp/orm/WeddingPlanner/Views/Wedding/Dashboard.cshtml"
WriteAttributeValue("", 825, w.WeddingId, 825, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(838, 40, true);
            WriteLiteral(" class=\"text-info\">\n                    ");
            EndContext();
            BeginContext(879, 11, false);
#line 24 "/Users/ryan/Desktop/coding_dojo/C_Sharp/orm/WeddingPlanner/Views/Wedding/Dashboard.cshtml"
               Write(w.WedderOne);

#line default
#line hidden
            EndContext();
            BeginContext(890, 3, true);
            WriteLiteral(" & ");
            EndContext();
            BeginContext(894, 11, false);
#line 24 "/Users/ryan/Desktop/coding_dojo/C_Sharp/orm/WeddingPlanner/Views/Wedding/Dashboard.cshtml"
                              Write(w.WedderTwo);

#line default
#line hidden
            EndContext();
            BeginContext(905, 56, true);
            WriteLiteral("\n                </a>\n            </td>\n            <td>");
            EndContext();
            BeginContext(962, 10, false);
#line 27 "/Users/ryan/Desktop/coding_dojo/C_Sharp/orm/WeddingPlanner/Views/Wedding/Dashboard.cshtml"
           Write(w.Ceremony);

#line default
#line hidden
            EndContext();
            BeginContext(972, 22, true);
            WriteLiteral("</td>\n            <td>");
            EndContext();
            BeginContext(995, 14, false);
#line 28 "/Users/ryan/Desktop/coding_dojo/C_Sharp/orm/WeddingPlanner/Views/Wedding/Dashboard.cshtml"
           Write(w.Guests.Count);

#line default
#line hidden
            EndContext();
            BeginContext(1009, 23, true);
            WriteLiteral("</td>\n            <td>\n");
            EndContext();
#line 30 "/Users/ryan/Desktop/coding_dojo/C_Sharp/orm/WeddingPlanner/Views/Wedding/Dashboard.cshtml"
                 if (@w.UserId == @ViewBag.LiveUser.UserId)
                {

#line default
#line hidden
            BeginContext(1110, 22, true);
            WriteLiteral("                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1132, "\"", 1159, 2);
            WriteAttributeValue("", 1139, "/delete/", 1139, 8, true);
#line 32 "/Users/ryan/Desktop/coding_dojo/C_Sharp/orm/WeddingPlanner/Views/Wedding/Dashboard.cshtml"
WriteAttributeValue("", 1147, w.WeddingId, 1147, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1160, 78, true);
            WriteLiteral(" class=\"text-danger\">\n                        Delete\n                    </a>\n");
            EndContext();
#line 35 "/Users/ryan/Desktop/coding_dojo/C_Sharp/orm/WeddingPlanner/Views/Wedding/Dashboard.cshtml"
                }
                else if (@w.Guests.Any(g => g.UserId == @ViewBag.LiveUser.UserId))
                {

#line default
#line hidden
            BeginContext(1357, 22, true);
            WriteLiteral("                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1379, "\"", 1407, 2);
            WriteAttributeValue("", 1386, "/leaving/", 1386, 9, true);
#line 38 "/Users/ryan/Desktop/coding_dojo/C_Sharp/orm/WeddingPlanner/Views/Wedding/Dashboard.cshtml"
WriteAttributeValue("", 1395, w.WeddingId, 1395, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1408, 80, true);
            WriteLiteral(" class=\"text-warning\">\n                        Un-RSVP\n                    </a>\n");
            EndContext();
#line 41 "/Users/ryan/Desktop/coding_dojo/C_Sharp/orm/WeddingPlanner/Views/Wedding/Dashboard.cshtml"
                }
                else
                {

#line default
#line hidden
            BeginContext(1545, 22, true);
            WriteLiteral("                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1567, "\"", 1594, 2);
            WriteAttributeValue("", 1574, "/accept/", 1574, 8, true);
#line 44 "/Users/ryan/Desktop/coding_dojo/C_Sharp/orm/WeddingPlanner/Views/Wedding/Dashboard.cshtml"
WriteAttributeValue("", 1582, w.WeddingId, 1582, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1595, 77, true);
            WriteLiteral(" class=\"text-success\">\n                        RSVP\n                    </a>\n");
            EndContext();
#line 47 "/Users/ryan/Desktop/coding_dojo/C_Sharp/orm/WeddingPlanner/Views/Wedding/Dashboard.cshtml"
                }

#line default
#line hidden
            BeginContext(1690, 32, true);
            WriteLiteral("            </td>\n        </tr>\n");
            EndContext();
#line 50 "/Users/ryan/Desktop/coding_dojo/C_Sharp/orm/WeddingPlanner/Views/Wedding/Dashboard.cshtml"
        }

#line default
#line hidden
            BeginContext(1732, 28, true);
            WriteLiteral("    </tbody>\n</table>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Wedding>> Html { get; private set; }
    }
}
#pragma warning restore 1591
