#pragma checksum "C:\Users\remoto\Desktop\Torre\TorreWebapp\TorreWebapp\Views\Person\Results.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ea92d496ca591edbac952d797a8f773bcb67a446"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Person_Results), @"mvc.1.0.view", @"/Views/Person/Results.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea92d496ca591edbac952d797a8f773bcb67a446", @"/Views/Person/Results.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e8cb076d8f05cf8a8e1b614a1ca9e0b7e4e42489", @"/Views/_ViewImports.cshtml")]
    public class Views_Person_Results : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TorreWebapp.Models.Result>>
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
#line 3 "C:\Users\remoto\Desktop\Torre\TorreWebapp\TorreWebapp\Views\Person\Results.cshtml"
  
    ViewData["Title"] = "Results";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Results</h1>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ea92d496ca591edbac952d797a8f773bcb67a4463722", async() => {
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
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 12 "C:\Users\remoto\Desktop\Torre\TorreWebapp\TorreWebapp\Views\Person\Results.cshtml"
Write(Html.ValidationMessage("CustomError"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 17 "C:\Users\remoto\Desktop\Torre\TorreWebapp\TorreWebapp\Views\Person\Results.cshtml"
           Write(Html.DisplayNameFor(model => model.picture));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 20 "C:\Users\remoto\Desktop\Torre\TorreWebapp\TorreWebapp\Views\Person\Results.cshtml"
           Write(Html.DisplayNameFor(model => model.name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 23 "C:\Users\remoto\Desktop\Torre\TorreWebapp\TorreWebapp\Views\Person\Results.cshtml"
           Write(Html.DisplayNameFor(model => model.remoter));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 26 "C:\Users\remoto\Desktop\Torre\TorreWebapp\TorreWebapp\Views\Person\Results.cshtml"
           Write(Html.DisplayNameFor(model => model.skills));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 29 "C:\Users\remoto\Desktop\Torre\TorreWebapp\TorreWebapp\Views\Person\Results.cshtml"
           Write(Html.DisplayNameFor(model => model.username));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 32 "C:\Users\remoto\Desktop\Torre\TorreWebapp\TorreWebapp\Views\Person\Results.cshtml"
           Write(Html.DisplayNameFor(model => model.compensations));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 38 "C:\Users\remoto\Desktop\Torre\TorreWebapp\TorreWebapp\Views\Person\Results.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 1070, "\"", 1119, 1);
#nullable restore
#line 42 "C:\Users\remoto\Desktop\Torre\TorreWebapp\TorreWebapp\Views\Person\Results.cshtml"
WriteAttributeValue("", 1076, Html.DisplayFor(modelItem => item.picture), 1076, 43, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1120, "\"", 1166, 1);
#nullable restore
#line 42 "C:\Users\remoto\Desktop\Torre\TorreWebapp\TorreWebapp\Views\Person\Results.cshtml"
WriteAttributeValue("", 1126, Html.DisplayFor(modelItem => item.name), 1126, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"100\" height=\"80\">\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 45 "C:\Users\remoto\Desktop\Torre\TorreWebapp\TorreWebapp\Views\Person\Results.cshtml"
               Write(Html.DisplayFor(modelItem => item.name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 48 "C:\Users\remoto\Desktop\Torre\TorreWebapp\TorreWebapp\Views\Person\Results.cshtml"
               Write(Html.DisplayFor(modelItem => item.remoter));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    <ul>\r\n");
#nullable restore
#line 52 "C:\Users\remoto\Desktop\Torre\TorreWebapp\TorreWebapp\Views\Person\Results.cshtml"
                         foreach (var org in item.skills)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li>");
#nullable restore
#line 54 "C:\Users\remoto\Desktop\Torre\TorreWebapp\TorreWebapp\Views\Person\Results.cshtml"
                           Write(org.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 55 "C:\Users\remoto\Desktop\Torre\TorreWebapp\TorreWebapp\Views\Person\Results.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </ul>\r\n                </td>\r\n\r\n                <td>\r\n                    ");
#nullable restore
#line 60 "C:\Users\remoto\Desktop\Torre\TorreWebapp\TorreWebapp\Views\Person\Results.cshtml"
               Write(Html.DisplayFor(modelItem => item.username));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 63 "C:\Users\remoto\Desktop\Torre\TorreWebapp\TorreWebapp\Views\Person\Results.cshtml"
               Write(Html.Raw(@item.compensations.compensation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 67 "C:\Users\remoto\Desktop\Torre\TorreWebapp\TorreWebapp\Views\Person\Results.cshtml"
               Write(Html.ActionLink("Details", "Details", new { userName = item.username }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 70 "C:\Users\remoto\Desktop\Torre\TorreWebapp\TorreWebapp\Views\Person\Results.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ea92d496ca591edbac952d797a8f773bcb67a44611151", async() => {
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
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<TorreWebapp.Models.Result>> Html { get; private set; }
    }
}
#pragma warning restore 1591
