#pragma checksum "C:\Users\BIG\Desktop\all_ok\NewsParser\NewsParser\Views\News\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c159db35f7aefb9761f542bd408d7b4206b00aec"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_News_Index), @"mvc.1.0.view", @"/Views/News/Index.cshtml")]
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
#line 1 "C:\Users\BIG\Desktop\all_ok\NewsParser\NewsParser\Views\_ViewImports.cshtml"
using NewsParser;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\BIG\Desktop\all_ok\NewsParser\NewsParser\Views\_ViewImports.cshtml"
using NewsParser.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c159db35f7aefb9761f542bd408d7b4206b00aec", @"/Views/News/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c41aa36a9d7850b9f11cdf2402aebd6b64b1f0b3", @"/Views/_ViewImports.cshtml")]
    public class Views_News_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IList<NewsParser.Models.News>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form pb-5"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\BIG\Desktop\all_ok\NewsParser\NewsParser\Views\News\Index.cshtml"
  
    ViewBag.Title = "News";
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"container\">\r\n    <div class=\"row\">\r\n        <div class=\"col\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c159db35f7aefb9761f542bd408d7b4206b00aec4256", async() => {
                WriteLiteral("\r\n                <div class=\"form-group\">\r\n                    <label for=\"from\">From:</label>\r\n                    <input class=\"form-control\" type=\"datetime-local\"");
                BeginWriteAttribute("min", " min=\"", 373, "\"", 392, 1);
#nullable restore
#line 13 "C:\Users\BIG\Desktop\all_ok\NewsParser\NewsParser\Views\News\Index.cshtml"
WriteAttributeValue("", 379, ViewBag.From, 379, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("max", " max=\"", 393, "\"", 410, 1);
#nullable restore
#line 13 "C:\Users\BIG\Desktop\all_ok\NewsParser\NewsParser\Views\News\Index.cshtml"
WriteAttributeValue("", 399, ViewBag.To, 399, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"from\" id=\"from\" required/>\r\n\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <label for=\"to\">To:</label>\r\n                    <input class=\"form-control\" type=\"datetime-local\"");
                BeginWriteAttribute("min", " min=\"", 632, "\"", 651, 1);
#nullable restore
#line 18 "C:\Users\BIG\Desktop\all_ok\NewsParser\NewsParser\Views\News\Index.cshtml"
WriteAttributeValue("", 638, ViewBag.From, 638, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("max", " max=\"", 652, "\"", 669, 1);
#nullable restore
#line 18 "C:\Users\BIG\Desktop\all_ok\NewsParser\NewsParser\Views\News\Index.cshtml"
WriteAttributeValue("", 658, ViewBag.To, 658, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"to\" id=\"to\" required/>\r\n                </div>\r\n                ");
#nullable restore
#line 20 "C:\Users\BIG\Desktop\all_ok\NewsParser\NewsParser\Views\News\Index.cshtml"
           Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                <button class=\"btn btn-outline-primary\" type=\"button\" id=\"filter\" name=\"filter\">Найти</button>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n        <div class=\"col-6\">\r\n            <div class=\"container\" id=\"content\">\r\n");
#nullable restore
#line 26 "C:\Users\BIG\Desktop\all_ok\NewsParser\NewsParser\Views\News\Index.cshtml"
                 foreach (var news in @Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div class=""row mt-2"">
                        <div class=""col-sm"">
                            <div class=""card"">
                                <div class=""card-body"">
                                    <h5 class=""card-title"">
                                        ");
#nullable restore
#line 33 "C:\Users\BIG\Desktop\all_ok\NewsParser\NewsParser\Views\News\Index.cshtml"
                                   Write(news.Theme);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </h5>\r\n                                    <p class=\"card-text\">\r\n                                        ");
#nullable restore
#line 36 "C:\Users\BIG\Desktop\all_ok\NewsParser\NewsParser\Views\News\Index.cshtml"
                                   Write(news.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </p>\r\n                                </div>\r\n                                <div class=\"card-footer\">\r\n                                    ");
#nullable restore
#line 40 "C:\Users\BIG\Desktop\all_ok\NewsParser\NewsParser\Views\News\Index.cshtml"
                               Write(news.NewsDate.Value.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 45 "C:\Users\BIG\Desktop\all_ok\NewsParser\NewsParser\Views\News\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div> \r\n        </div>\r\n         <div class=\"col\">\r\n             ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c159db35f7aefb9761f542bd408d7b4206b00aec10006", async() => {
                WriteLiteral("\r\n                 <div class=\"form-group\">\r\n                     <label for=\"from\">Текст:</label>\r\n                     <input class=\"form-control\"  name=\"from\" id=\"search_text\" required/>\r\n                 </div>\r\n                 ");
#nullable restore
#line 54 "C:\Users\BIG\Desktop\all_ok\NewsParser\NewsParser\Views\News\Index.cshtml"
            Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                 <button class=\"btn btn-outline-primary\" type=\"button\" id=\"search\" name=\"search\">Найти по тексту</button>\r\n             ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
             
             <h4>Топ 10 часто встречающихся слов по всем новостям</h4>
             <table class=""table"">
                 <tr>
                     <th>Слово</th>
                     <th>Кол-во совпадений</th>
                 </tr>
                 <tbody id=""rate"">
                    <tr>
                     
                    </tr>
                 </tbody>
             </table>
         </div>
    </div>
</div>

<script src=""js/NewsFilter.js""></script>
<script src=""js/NewsSearch.js""></script>
<script src=""js/NewsTopTenWords.js""></script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IList<NewsParser.Models.News>> Html { get; private set; }
    }
}
#pragma warning restore 1591
