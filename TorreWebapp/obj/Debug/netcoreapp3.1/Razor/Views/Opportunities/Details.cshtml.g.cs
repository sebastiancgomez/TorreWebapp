#pragma checksum "C:\Users\remoto\Desktop\Torre\TorreWebapp\TorreWebapp\Views\Opportunities\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1062ff64a9ce2d4531fe4b7770bc0fc04075c316"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Opportunities_Details), @"mvc.1.0.view", @"/Views/Opportunities/Details.cshtml")]
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
#line 1 "C:\Users\remoto\Desktop\Torre\TorreWebapp\TorreWebapp\Views\_ViewImports.cshtml"
using TorreWebapp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\remoto\Desktop\Torre\TorreWebapp\TorreWebapp\Views\_ViewImports.cshtml"
using TorreWebapp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1062ff64a9ce2d4531fe4b7770bc0fc04075c316", @"/Views/Opportunities/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e8cb076d8f05cf8a8e1b614a1ca9e0b7e4e42489", @"/Views/_ViewImports.cshtml")]
    public class Views_Opportunities_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TorreWebapp.Models.JobOpportunity.JobDetail>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\remoto\Desktop\Torre\TorreWebapp\TorreWebapp\Views\Opportunities\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Job Detail</h4>\r\n    <div>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1062ff64a9ce2d4531fe4b7770bc0fc04075c3163826", async() => {
                WriteLiteral("Back to Search");
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
            WriteLiteral("\r\n    </div>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 18 "C:\Users\remoto\Desktop\Torre\TorreWebapp\TorreWebapp\Views\Opportunities\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.objective));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 21 "C:\Users\remoto\Desktop\Torre\TorreWebapp\TorreWebapp\Views\Opportunities\Details.cshtml"
       Write(Html.DisplayFor(model => model.objective));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 24 "C:\Users\remoto\Desktop\Torre\TorreWebapp\TorreWebapp\Views\Opportunities\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.organizations));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            <ul>\r\n");
#nullable restore
#line 28 "C:\Users\remoto\Desktop\Torre\TorreWebapp\TorreWebapp\Views\Opportunities\Details.cshtml"
                 foreach (var organization in Model.organizations)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li>\r\n                        ");
#nullable restore
#line 31 "C:\Users\remoto\Desktop\Torre\TorreWebapp\TorreWebapp\Views\Opportunities\Details.cshtml"
                   Write(organization.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </li>\r\n");
#nullable restore
#line 33 "C:\Users\remoto\Desktop\Torre\TorreWebapp\TorreWebapp\Views\Opportunities\Details.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </ul>\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 37 "C:\Users\remoto\Desktop\Torre\TorreWebapp\TorreWebapp\Views\Opportunities\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.strengths));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            <ul>\r\n");
#nullable restore
#line 41 "C:\Users\remoto\Desktop\Torre\TorreWebapp\TorreWebapp\Views\Opportunities\Details.cshtml"
                 foreach (var str in Model.strengths)
                {
                    string strenght = $"{str.name}: {str.experience}";

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li>\r\n                        ");
#nullable restore
#line 45 "C:\Users\remoto\Desktop\Torre\TorreWebapp\TorreWebapp\Views\Opportunities\Details.cshtml"
                   Write(strenght);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </li>\r\n");
#nullable restore
#line 47 "C:\Users\remoto\Desktop\Torre\TorreWebapp\TorreWebapp\Views\Opportunities\Details.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </ul>\r\n        </dd>\r\n");
#nullable restore
#line 50 "C:\Users\remoto\Desktop\Torre\TorreWebapp\TorreWebapp\Views\Opportunities\Details.cshtml"
         if (!(Model.compensation == null) && Model.compensation.visible)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 53 "C:\Users\remoto\Desktop\Torre\TorreWebapp\TorreWebapp\Views\Opportunities\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.compensation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n");
#nullable restore
#line 55 "C:\Users\remoto\Desktop\Torre\TorreWebapp\TorreWebapp\Views\Opportunities\Details.cshtml"
             if (Model.compensation.data == null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <dd class=\"col-sm-10\">\r\n");
#nullable restore
#line 58 "C:\Users\remoto\Desktop\Torre\TorreWebapp\TorreWebapp\Views\Opportunities\Details.cshtml"
                      
                        string compensation = $"{Model.compensation.minAmount}{Model.compensation.currency} - {Model.compensation.maxAmount}{Model.compensation.currency} {Model.compensation.periodicity} ";
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
#nullable restore
#line 61 "C:\Users\remoto\Desktop\Torre\TorreWebapp\TorreWebapp\Views\Opportunities\Details.cshtml"
               Write(compensation);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n");
#nullable restore
#line 63 "C:\Users\remoto\Desktop\Torre\TorreWebapp\TorreWebapp\Views\Opportunities\Details.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <dd class=\"col-sm-10\">\r\n");
#nullable restore
#line 67 "C:\Users\remoto\Desktop\Torre\TorreWebapp\TorreWebapp\Views\Opportunities\Details.cshtml"
                      
                        string compensation = $"{Model.compensation.data.minAmount}{Model.compensation.data.currency} - {Model.compensation.data.maxAmount}{Model.compensation.data.currency} {Model.compensation.data.periodicity} ";
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
#nullable restore
#line 70 "C:\Users\remoto\Desktop\Torre\TorreWebapp\TorreWebapp\Views\Opportunities\Details.cshtml"
               Write(compensation);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n");
#nullable restore
#line 72 "C:\Users\remoto\Desktop\Torre\TorreWebapp\TorreWebapp\Views\Opportunities\Details.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 72 "C:\Users\remoto\Desktop\Torre\TorreWebapp\TorreWebapp\Views\Opportunities\Details.cshtml"
             
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 75 "C:\Users\remoto\Desktop\Torre\TorreWebapp\TorreWebapp\Views\Opportunities\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.deadline));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 78 "C:\Users\remoto\Desktop\Torre\TorreWebapp\TorreWebapp\Views\Opportunities\Details.cshtml"
       Write(Html.DisplayFor(model => model.deadline));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 81 "C:\Users\remoto\Desktop\Torre\TorreWebapp\TorreWebapp\Views\Opportunities\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.completion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 84 "C:\Users\remoto\Desktop\Torre\TorreWebapp\TorreWebapp\Views\Opportunities\Details.cshtml"
       Write(Html.DisplayFor(model => model.completion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 87 "C:\Users\remoto\Desktop\Torre\TorreWebapp\TorreWebapp\Views\Opportunities\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.created));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 90 "C:\Users\remoto\Desktop\Torre\TorreWebapp\TorreWebapp\Views\Opportunities\Details.cshtml"
       Write(Html.DisplayFor(model => model.created));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 93 "C:\Users\remoto\Desktop\Torre\TorreWebapp\TorreWebapp\Views\Opportunities\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.crawled));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 96 "C:\Users\remoto\Desktop\Torre\TorreWebapp\TorreWebapp\Views\Opportunities\Details.cshtml"
       Write(Html.DisplayFor(model => model.crawled));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 99 "C:\Users\remoto\Desktop\Torre\TorreWebapp\TorreWebapp\Views\Opportunities\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.opportunity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 102 "C:\Users\remoto\Desktop\Torre\TorreWebapp\TorreWebapp\Views\Opportunities\Details.cshtml"
       Write(Html.DisplayFor(model => model.opportunity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 105 "C:\Users\remoto\Desktop\Torre\TorreWebapp\TorreWebapp\Views\Opportunities\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.active));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 108 "C:\Users\remoto\Desktop\Torre\TorreWebapp\TorreWebapp\Views\Opportunities\Details.cshtml"
       Write(Html.DisplayFor(model => model.active));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 111 "C:\Users\remoto\Desktop\Torre\TorreWebapp\TorreWebapp\Views\Opportunities\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.stableOn));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 114 "C:\Users\remoto\Desktop\Torre\TorreWebapp\TorreWebapp\Views\Opportunities\Details.cshtml"
       Write(Html.DisplayFor(model => model.stableOn));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 117 "C:\Users\remoto\Desktop\Torre\TorreWebapp\TorreWebapp\Views\Opportunities\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 120 "C:\Users\remoto\Desktop\Torre\TorreWebapp\TorreWebapp\Views\Opportunities\Details.cshtml"
       Write(Html.DisplayFor(model => model.status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TorreWebapp.Models.JobOpportunity.JobDetail> Html { get; private set; }
    }
}
#pragma warning restore 1591
