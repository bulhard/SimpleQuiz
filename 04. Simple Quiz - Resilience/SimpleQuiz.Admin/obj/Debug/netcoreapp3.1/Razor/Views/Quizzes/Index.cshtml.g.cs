#pragma checksum "G:\Personal\Training\Microservices\SimpleQuiz\SimpleQuiz\04. Simple Quiz - Resilience\SimpleQuiz.Admin\Views\Quizzes\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e114e0eee1fcb81eeaa52d8d959319461fffb987"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Quizzes_Index), @"mvc.1.0.view", @"/Views/Quizzes/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e114e0eee1fcb81eeaa52d8d959319461fffb987", @"/Views/Quizzes/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"165ed462a00df7b7f5c76556d62864e1bee97106", @"/Views/_ViewImports.cshtml")]
    public class Views_Quizzes_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<QuizOutputModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "G:\Personal\Training\Microservices\SimpleQuiz\SimpleQuiz\04. Simple Quiz - Resilience\SimpleQuiz.Admin\Views\Quizzes\Index.cshtml"
   ViewData["Title"] = "Quizzes"; 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-lg-4 offset-lg-4"">
        <h2>Quizzes</h2>
    </div>
</div>

<table class=""table table-striped table-bordered"">
    <thead>
        <tr>
            <th scope=""col"">Title</th>
            <th scope=""col"">Description</th>
            <th scope=""col"">Total Questions</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 20 "G:\Personal\Training\Microservices\SimpleQuiz\SimpleQuiz\04. Simple Quiz - Resilience\SimpleQuiz.Admin\Views\Quizzes\Index.cshtml"
         foreach (var quiz in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\r\n    <td>");
#nullable restore
#line 23 "G:\Personal\Training\Microservices\SimpleQuiz\SimpleQuiz\04. Simple Quiz - Resilience\SimpleQuiz.Admin\Views\Quizzes\Index.cshtml"
   Write(quiz.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 24 "G:\Personal\Training\Microservices\SimpleQuiz\SimpleQuiz\04. Simple Quiz - Resilience\SimpleQuiz.Admin\Views\Quizzes\Index.cshtml"
   Write(quiz.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 25 "G:\Personal\Training\Microservices\SimpleQuiz\SimpleQuiz\04. Simple Quiz - Resilience\SimpleQuiz.Admin\Views\Quizzes\Index.cshtml"
   Write(quiz.TotalQuestionsCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n</tr>");
#nullable restore
#line 26 "G:\Personal\Training\Microservices\SimpleQuiz\SimpleQuiz\04. Simple Quiz - Resilience\SimpleQuiz.Admin\Views\Quizzes\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<QuizOutputModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
