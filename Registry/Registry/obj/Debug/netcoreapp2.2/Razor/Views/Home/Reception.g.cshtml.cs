#pragma checksum "E:\старые файлы\Удгу\дипломная работа\Проэкт\Контрольный\Registry\Registry\Views\Home\Reception.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "20ffc7d83a71ba0c612cec5e70eaf59d977c153e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Reception), @"mvc.1.0.view", @"/Views/Home/Reception.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Reception.cshtml", typeof(AspNetCore.Views_Home_Reception))]
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
#line 1 "E:\старые файлы\Удгу\дипломная работа\Проэкт\Контрольный\Registry\Registry\Views\_ViewImports.cshtml"
using CustomIdentityApp;

#line default
#line hidden
#line 2 "E:\старые файлы\Удгу\дипломная работа\Проэкт\Контрольный\Registry\Registry\Views\_ViewImports.cshtml"
using CustomIdentityApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20ffc7d83a71ba0c612cec5e70eaf59d977c153e", @"/Views/Home/Reception.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e172fd68b6837fba7473ccdb1cc4da8fd1fe778", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Reception : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CustomIdentityApp.Models.Reception>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(71, 8, true);
            WriteLiteral("<html>\r\n");
            EndContext();
            BeginContext(79, 27, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "20ffc7d83a71ba0c612cec5e70eaf59d977c153e4042", async() => {
                BeginContext(85, 14, true);
                WriteLiteral("\r\n    Заявки\r\n");
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
            BeginContext(106, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(108, 569, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "20ffc7d83a71ba0c612cec5e70eaf59d977c153e5237", async() => {
                BeginContext(114, 30, true);
                WriteLiteral("\r\n    <h3> Заявка</h3>\r\n\r\n    ");
                EndContext();
                BeginContext(144, 522, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "20ffc7d83a71ba0c612cec5e70eaf59d977c153e5652", async() => {
                    BeginContext(164, 2, true);
                    WriteLiteral("\r\n");
                    EndContext();
                    BeginContext(228, 42, true);
                    WriteLiteral("        <input type=\"hidden\" name=\"Doctor\"");
                    EndContext();
                    BeginWriteAttribute("value", " value=\"", 270, "\"", 295, 1);
#line 15 "E:\старые файлы\Удгу\дипломная работа\Проэкт\Контрольный\Registry\Registry\Views\Home\Reception.cshtml"
WriteAttributeValue("", 278, ViewBag.DoctorId, 278, 17, false);

#line default
#line hidden
                    EndWriteAttribute();
                    BeginContext(296, 48, true);
                    WriteLiteral(" />\r\n        <input type=\"hidden\" name=\"Patient\"");
                    EndContext();
                    BeginWriteAttribute("value", " value=\"", 344, "\"", 371, 1);
#line 16 "E:\старые файлы\Удгу\дипломная работа\Проэкт\Контрольный\Registry\Registry\Views\Home\Reception.cshtml"
WriteAttributeValue("", 352, User.Identity.Name, 352, 19, false);

#line default
#line hidden
                    EndWriteAttribute();
                    BeginContext(372, 114, true);
                    WriteLiteral(" />\r\n\r\n\r\n\r\n        <p>Дата приёма:</p>\r\n        <input type=\"date\" name=\"ReceptionDate\" value=\"ReceptionDate\" />\r\n");
                    EndContext();
#line 22 "E:\старые файлы\Удгу\дипломная работа\Проэкт\Контрольный\Registry\Registry\Views\Home\Reception.cshtml"
         for (var time = 8; time < 19; time++)
        {


#line default
#line hidden
                    BeginContext(547, 19, true);
                    WriteLiteral("            <button");
                    EndContext();
                    BeginWriteAttribute("value", " value=\"", 566, "\"", 579, 1);
#line 25 "E:\старые файлы\Удгу\дипломная работа\Проэкт\Контрольный\Registry\Registry\Views\Home\Reception.cshtml"
WriteAttributeValue("", 574, time, 574, 5, false);

#line default
#line hidden
                    EndWriteAttribute();
                    BeginContext(580, 27, true);
                    WriteLiteral(" name=\"Time\" tupe=\"submit\">");
                    EndContext();
                    BeginContext(608, 4, false);
#line 25 "E:\старые файлы\Удгу\дипломная работа\Проэкт\Контрольный\Registry\Registry\Views\Home\Reception.cshtml"
                                                       Write(time);

#line default
#line hidden
                    EndContext();
                    BeginContext(612, 14, true);
                    WriteLiteral(".00</button>\r\n");
                    EndContext();
#line 26 "E:\старые файлы\Удгу\дипломная работа\Проэкт\Контрольный\Registry\Registry\Views\Home\Reception.cshtml"
            
        }

#line default
#line hidden
                    BeginContext(651, 8, true);
                    WriteLiteral("\r\n\r\n    ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(666, 4, true);
                WriteLiteral("\r\n\r\n");
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
            BeginContext(677, 9, true);
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CustomIdentityApp.Models.Reception>> Html { get; private set; }
    }
}
#pragma warning restore 1591