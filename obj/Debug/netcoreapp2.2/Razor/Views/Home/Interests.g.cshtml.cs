#pragma checksum "/Users/Alexander/Documents/Coding Dojo/C#/Dyno/Views/Home/Interests.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b01a21c107d846c812a8b9e19339476588fb2321"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Interests), @"mvc.1.0.view", @"/Views/Home/Interests.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Interests.cshtml", typeof(AspNetCore.Views_Home_Interests))]
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
#line 1 "/Users/Alexander/Documents/Coding Dojo/C#/Dyno/Views/_ViewImports.cshtml"
using Dyno;

#line default
#line hidden
#line 1 "/Users/Alexander/Documents/Coding Dojo/C#/Dyno/Views/Home/Interests.cshtml"
using Dyno.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b01a21c107d846c812a8b9e19339476588fb2321", @"/Views/Home/Interests.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d8c5e7d436a3cfd4e3863f0bf0b5a39adf887679", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Interests : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Topic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateTopic", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("input-field col s3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(32, 34, true);
            WriteLiteral("\n<!DOCTYPE html>\n<html lang=\"en\">\n");
            EndContext();
            BeginContext(66, 638, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b01a21c107d846c812a8b9e19339476588fb23214981", async() => {
                BeginContext(72, 625, true);
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <style>
        .whiteBG {
            background: white;
        }
        .main {
            margin-top: 15px;
            border-radius: 10px;
            height: 100vh;
            margin-bottom: -85px;
            overflow: auto;
            text-align: center;
        }
        .input2 {
            line-height: 2;
        }
        .btn-success {
            vertical-align: top;
        }
        table {
            margin-top: 4%;
        }
        td {
            line-height: 3;
        }
    </style>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(704, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(705, 1546, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b01a21c107d846c812a8b9e19339476588fb23216770", async() => {
                BeginContext(711, 190, true);
                WriteLiteral("\n    <div class=\"whiteBG main container\">\n        <table class=\"table table-bordered table-hover\">\n            <tr>\n                <th colspan=\"2\">Current Interests:</th>\n            </tr>\n");
                EndContext();
#line 41 "/Users/Alexander/Documents/Coding Dojo/C#/Dyno/Views/Home/Interests.cshtml"
             foreach(var i in @ViewBag.CurrUser.Interests)
            {

#line default
#line hidden
                BeginContext(974, 37, true);
                WriteLiteral("            <tr>\n                <td>");
                EndContext();
                BeginContext(1012, 17, false);
#line 44 "/Users/Alexander/Documents/Coding Dojo/C#/Dyno/Views/Home/Interests.cshtml"
               Write(i.Topic.TopicName);

#line default
#line hidden
                EndContext();
                BeginContext(1029, 6, true);
                WriteLiteral("</td>\n");
                EndContext();
#line 45 "/Users/Alexander/Documents/Coding Dojo/C#/Dyno/Views/Home/Interests.cshtml"
                 if(@ViewBag.CurrUser.Interests.Count > 3)
                {

#line default
#line hidden
                BeginContext(1112, 26, true);
                WriteLiteral("                    <td><a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1138, "\"", 1175, 2);
                WriteAttributeValue("", 1145, "interests/delete/", 1145, 17, true);
#line 47 "/Users/Alexander/Documents/Coding Dojo/C#/Dyno/Views/Home/Interests.cshtml"
WriteAttributeValue("", 1162, i.InterestId, 1162, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1176, 57, true);
                WriteLiteral("><button class=\"btn btn-danger\">Delete</button></a></td>\n");
                EndContext();
#line 48 "/Users/Alexander/Documents/Coding Dojo/C#/Dyno/Views/Home/Interests.cshtml"
                } else {

#line default
#line hidden
                BeginContext(1258, 174, true);
                WriteLiteral("                    <td><button class=\"btn btn-danger\" data-toggle=\"tooltip\" data-placement=\"left\" title=\"Can\'t have less than three interests\" disabled>Delete</button></td>\n");
                EndContext();
#line 50 "/Users/Alexander/Documents/Coding Dojo/C#/Dyno/Views/Home/Interests.cshtml"
                }

#line default
#line hidden
                BeginContext(1450, 18, true);
                WriteLiteral("            </tr>\n");
                EndContext();
#line 52 "/Users/Alexander/Documents/Coding Dojo/C#/Dyno/Views/Home/Interests.cshtml"
            }

#line default
#line hidden
                BeginContext(1482, 27, true);
                WriteLiteral("        </table>\n\n        \n");
                EndContext();
                BeginContext(1714, 35, true);
                WriteLiteral("        <h3>Add Topic</h3>\n        ");
                EndContext();
                BeginContext(1749, 339, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b01a21c107d846c812a8b9e19339476588fb232110011", async() => {
                    BeginContext(1843, 13, true);
                    WriteLiteral("\n            ");
                    EndContext();
                    BeginContext(1856, 44, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b01a21c107d846c812a8b9e19339476588fb232110421", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#line 65 "/Users/Alexander/Documents/Coding Dojo/C#/Dyno/Views/Home/Interests.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.TopicName);

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(1900, 181, true);
                    WriteLiteral("\n            <input class=\"input2\" placeholder=\"Topic Name\" type=\"text\" name=\"TopicName\" required>\n            <button class=\"btn btn-success\" type=\"submit\">Submit</button>\n        ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2088, 156, true);
                WriteLiteral("\n    </div>\n    <script>\n        $(document).ready(function() {\n        $(\"body\").tooltip({ selector: \'[data-toggle=tooltip]\' });\n        });\n    </script>\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2251, 8, true);
            WriteLiteral("\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Topic> Html { get; private set; }
    }
}
#pragma warning restore 1591
