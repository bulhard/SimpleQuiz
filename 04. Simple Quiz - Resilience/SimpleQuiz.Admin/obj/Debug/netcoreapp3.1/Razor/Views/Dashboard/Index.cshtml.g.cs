#pragma checksum "G:\Personal\Training\Microservices\SimpleQuiz\SimpleQuiz\04. Simple Quiz - Resilience\SimpleQuiz.Admin\Views\Dashboard\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "62b1502f3e706a25c99db6a2cb121174f27ad0b2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dashboard_Index), @"mvc.1.0.view", @"/Views/Dashboard/Index.cshtml")]
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
#line 1 "G:\Personal\Training\Microservices\SimpleQuiz\SimpleQuiz\04. Simple Quiz - Resilience\SimpleQuiz.Admin\Views\_ViewImports.cshtml"
using SimpleQuiz.Admin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\Personal\Training\Microservices\SimpleQuiz\SimpleQuiz\04. Simple Quiz - Resilience\SimpleQuiz.Admin\Views\_ViewImports.cshtml"
using SimpleQuiz.Admin.Infrastructure;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "G:\Personal\Training\Microservices\SimpleQuiz\SimpleQuiz\04. Simple Quiz - Resilience\SimpleQuiz.Admin\Views\_ViewImports.cshtml"
using SimpleQuiz.Admin.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "G:\Personal\Training\Microservices\SimpleQuiz\SimpleQuiz\04. Simple Quiz - Resilience\SimpleQuiz.Admin\Views\_ViewImports.cshtml"
using SimpleQuiz.Admin.Models.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "G:\Personal\Training\Microservices\SimpleQuiz\SimpleQuiz\04. Simple Quiz - Resilience\SimpleQuiz.Admin\Views\_ViewImports.cshtml"
using SimpleQuiz.Admin.Models.Quizzes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "G:\Personal\Training\Microservices\SimpleQuiz\SimpleQuiz\04. Simple Quiz - Resilience\SimpleQuiz.Admin\Views\_ViewImports.cshtml"
using SimpleQuiz.Admin.Models.People;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"62b1502f3e706a25c99db6a2cb121174f27ad0b2", @"/Views/Dashboard/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"165ed462a00df7b7f5c76556d62864e1bee97106", @"/Views/_ViewImports.cshtml")]
    public class Views_Dashboard_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<QuizzesAndStatsOutputModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "People", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Quizzes", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "G:\Personal\Training\Microservices\SimpleQuiz\SimpleQuiz\04. Simple Quiz - Resilience\SimpleQuiz.Admin\Views\Dashboard\Index.cshtml"
   ViewData["Title"] = "Dashboard"; 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-lg-4 offset-lg-4"">
        <h2>Dashboard</h2>
    </div>
</div>

<table class=""table table-striped table-bordered"">
    <thead>
        <tr>
            <th scope=""col"">Title</th>
            <th scope=""col"">URL</th>
        </tr>
    </thead>
    <tbody>
        <tr>
            <td>People</td>
            <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "62b1502f3e706a25c99db6a2cb121174f27ad0b25832", async() => {
                WriteLiteral("GO ->");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>Quizzes</td>\r\n            <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "62b1502f3e706a25c99db6a2cb121174f27ad0b27278", async() => {
                WriteLiteral("GO ->");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n        </tr>\r\n    </tbody>\r\n</table>\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-lg-4 offset-lg-4\">\r\n        <h2>Quizzes Gateway Demo Data</h2>\r\n    </div>\r\n</div>\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-6\">\r\n        Statistics.TotalPeople = ");
#nullable restore
#line 38 "G:\Personal\Training\Microservices\SimpleQuiz\SimpleQuiz\04. Simple Quiz - Resilience\SimpleQuiz.Admin\Views\Dashboard\Index.cshtml"
                            Write(Model.Statistics.TotalPeople);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"col-6\">\r\n        Statistics.TotalQuizzes = ");
#nullable restore
#line 41 "G:\Personal\Training\Microservices\SimpleQuiz\SimpleQuiz\04. Simple Quiz - Resilience\SimpleQuiz.Admin\Views\Dashboard\Index.cshtml"
                             Write(Model.Statistics.TotalQuizzes);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    </div>
</div>
<div class=""row"">
    <hr />
</div>

<table class=""table table-striped table-bordered"">
    <thead>
        <tr>
            <th scope=""col"">ID</th>
            <th scope=""col"">First name</th>
            <th scope=""col"">Last name</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 57 "G:\Personal\Training\Microservices\SimpleQuiz\SimpleQuiz\04. Simple Quiz - Resilience\SimpleQuiz.Admin\Views\Dashboard\Index.cshtml"
         foreach (var person in Model.Quizzes)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 60 "G:\Personal\Training\Microservices\SimpleQuiz\SimpleQuiz\04. Simple Quiz - Resilience\SimpleQuiz.Admin\Views\Dashboard\Index.cshtml"
               Write(person.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 61 "G:\Personal\Training\Microservices\SimpleQuiz\SimpleQuiz\04. Simple Quiz - Resilience\SimpleQuiz.Admin\Views\Dashboard\Index.cshtml"
               Write(person.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 62 "G:\Personal\Training\Microservices\SimpleQuiz\SimpleQuiz\04. Simple Quiz - Resilience\SimpleQuiz.Admin\Views\Dashboard\Index.cshtml"
               Write(person.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 64 "G:\Personal\Training\Microservices\SimpleQuiz\SimpleQuiz\04. Simple Quiz - Resilience\SimpleQuiz.Admin\Views\Dashboard\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<QuizzesAndStatsOutputModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
