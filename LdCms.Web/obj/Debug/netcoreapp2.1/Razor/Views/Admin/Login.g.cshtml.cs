#pragma checksum "F:\代码服务器\Github\LdCmsNetCore\LdCms.Web\Views\Admin\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7fe3a9e57a31bf9053ee379ca45bca8913e9ec08"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Login), @"mvc.1.0.view", @"/Views/Admin/Login.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/Login.cshtml", typeof(AspNetCore.Views_Admin_Login))]
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
#line 1 "F:\代码服务器\Github\LdCmsNetCore\LdCms.Web\Views\Admin\Login.cshtml"
using LdCms.Web.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7fe3a9e57a31bf9053ee379ca45bca8913e9ec08", @"/Views/Admin/Login.cshtml")]
    public class Views_Admin_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SiteConfig>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin/static/h-ui.admin/css/H-ui.login.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin/lib/jquery.validation/1.14.0/jquery.validate.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin/lib/jquery.validation/1.14.0/validate-methods.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin/lib/jquery.validation/1.14.0/messages_zh.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "F:\代码服务器\Github\LdCmsNetCore\LdCms.Web\Views\Admin\Login.cshtml"
  
    ViewData["Title"] = Model.Title;
    ViewData["Keywords"] = Model.Keywords;
    ViewData["Description"] = Model.Description;

#line default
#line hidden
            BeginContext(184, 226, true);
            WriteLiteral("<input type=\"hidden\" id=\"TenantId\" name=\"TenantId\" value=\"\" />\r\n<div class=\"header\"></div>\r\n<div class=\"loginWraper\">\r\n    <div id=\"loginform\" class=\"loginBox\">\r\n        <form id=\"form\" name=\"form\" class=\"form form-horizontal\"");
            EndContext();
            BeginWriteAttribute("action", " action=\"", 410, "\"", 475, 1);
#line 12 "F:\代码服务器\Github\LdCmsNetCore\LdCms.Web\Views\Admin\Login.cshtml"
WriteAttributeValue("", 419, Url.Action("login",new { companyid = Model.CompanyID }), 419, 56, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(476, 1018, true);
            WriteLiteral(@" method=""post"">
            <div class=""row cl"">
                <label class=""form-label col-xs-3""><i class=""Hui-iconfont"">&#xe60d;</i></label>
                <div class=""formControls col-xs-8"">
                    <input id=""username"" name=""username"" type=""text"" placeholder=""账户"" class=""input-text size-L"" value="""">
                </div>
            </div>
            <div class=""row cl"">
                <label class=""form-label col-xs-3""><i class=""Hui-iconfont"">&#xe60e;</i></label>
                <div class=""formControls col-xs-8"">
                    <input id=""password"" name=""password"" type=""password"" placeholder=""密码"" class=""input-text size-L"" value="""">
                </div>
            </div>
            <div class=""row cl"">
                <div class=""formControls col-xs-8 col-xs-offset-3"">
                    <input id=""verifyCode"" name=""verifyCode"" class=""input-text size-L"" type=""text"" placeholder=""验证码"" value="""" style=""width:150px;"">
                    <img id=""verifyCodeSrc""");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1494, "\"", 1533, 1);
#line 28 "F:\代码服务器\Github\LdCmsNetCore\LdCms.Web\Views\Admin\Login.cshtml"
WriteAttributeValue("", 1500, Url.Action("index","VerifyCode"), 1500, 33, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1534, 990, true);
            WriteLiteral(@">
                    <a id=""kanbuq"" href=""javascript:;"" onclick=""$.mainu.verifyCode()"">看不清，换一张</a>
                </div>
            </div>
            <div class=""row cl"">
                <div class=""formControls col-xs-8 col-xs-offset-3"">
                    <label for=""online"">
                        <input type=""checkbox"" name=""online"" id=""online"" value=""1"">
                        使我保持登录状态
                    </label>
                </div>
            </div>
            <div class=""row cl"">
                <div class=""formControls col-xs-8 col-xs-offset-3"">
                    <input name="""" type=""submit"" class=""btn btn-success radius size-L"" value=""&nbsp;登&nbsp;&nbsp;&nbsp;&nbsp;录&nbsp;"">
                    <input name="""" type=""reset"" class=""btn btn-default radius size-L"" value=""&nbsp;取&nbsp;&nbsp;&nbsp;&nbsp;消&nbsp;"">
                </div>
            </div>
        </form>
    </div>
</div>
<div class=""footer"">Copyright by LdCms V1.0</div>
");
            EndContext();
            DefineSection("css", async() => {
                BeginContext(2597, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(2603, 93, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "061e1182761a46849ec83ca5a0e0feeb", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2696, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            DefineSection("scripts", async() => {
                BeginContext(2718, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(2724, 102, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a4b9b6ed8ee145599522ad71154242fa", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2826, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(2832, 103, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "45b753bdf370453f93d43462e2adbdc9", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2935, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(2941, 98, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9cdf9cdad44744898faf44617e01e57f", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3039, 1661, true);
                WriteLiteral(@"
    <script type=""text/javascript"">
        (function ($) {
            $.mainu = {
                init: function () {
                    setTimeout(function () {
                        var code = $.cookie('VerifyCode');
                        var url = ""/verifycode/get"";
                        var data = { code: encodeURI(code) };
                        $.get(url, data, function (data) {
                            $(""#username"").val(""admin"");
                            $(""#password"").val(""admin"");
                            $('#online').attr(""checked"", true);
                            $(""#verifyCode"").val(data);
                        });
                    }, 1000);
                },
                verifyCode: function () {
                    var indexTime = (new Date()).getTime();
                    var codeSrc = ""/verifycode/index?s="" + indexTime;
                    $(""#verifyCodeSrc"").attr({ src: codeSrc });
                },
                formSubmit: function ");
                WriteLiteral(@"() {
                    var options = {
                        cache: false,
                        error: function (XMLHttpRequest, textStatus, errorThrown) {
                            if (XMLHttpRequest.status != 200) {
                                layer.alert('系统忙！', { icon: 5 });
                            }
                        },
                        success: function (result) {
                            var state = result.state;
                            var message = result.message;
                            if (state == ""success"") {
                                window.location.href = '");
                EndContext();
                BeginContext(4701, 27, false);
#line 95 "F:\代码服务器\Github\LdCmsNetCore\LdCms.Web\Views\Admin\Login.cshtml"
                                                   Write(Url.Action("index","admin"));

#line default
#line hidden
                EndContext();
                BeginContext(4728, 432, true);
                WriteLiteral(@"';
                            } else {
                                layer.alert(message, { icon: 5 });
                            }
                        }
                    };
                    $(""#form"").ajaxForm(options);
                }
            };
            $(function () {
                $.mainu.init();
                $.mainu.formSubmit();
            });
        })(jQuery);
    </script>
");
                EndContext();
            }
            );
            BeginContext(5163, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SiteConfig> Html { get; private set; }
    }
}
#pragma warning restore 1591
