#pragma checksum "F:\代码服务器\GIT\LdCmsNetCore\LdCms.Web\Views\SysRole\Add.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e57426adbe9bf33331beacd0698a01ee13468b6f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SysRole_Add), @"mvc.1.0.view", @"/Views/SysRole/Add.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/SysRole/Add.cshtml", typeof(AspNetCore.Views_SysRole_Add))]
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
#line 1 "F:\代码服务器\GIT\LdCmsNetCore\LdCms.Web\Views\SysRole\Add.cshtml"
using LdCms.EF.DbModels;

#line default
#line hidden
#line 2 "F:\代码服务器\GIT\LdCmsNetCore\LdCms.Web\Views\SysRole\Add.cshtml"
using LdCms.Common.Utility;

#line default
#line hidden
#line 3 "F:\代码服务器\GIT\LdCmsNetCore\LdCms.Web\Views\SysRole\Add.cshtml"
using LdCms.Common.Extension;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e57426adbe9bf33331beacd0698a01ee13468b6f", @"/Views/SysRole/Add.cshtml")]
    public class Views_SysRole_Add : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Ld_Sys_Function>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin/lib/jquery.validation/1.14.0/jquery.validate.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin/lib/jquery.validation/1.14.0/validate-methods.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin/lib/jquery.validation/1.14.0/messages_zh.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 5 "F:\代码服务器\GIT\LdCmsNetCore\LdCms.Web\Views\SysRole\Add.cshtml"
  
    ViewData["Title"] = "Add";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(209, 47, true);
            WriteLiteral("\r\n\r\n<article class=\"page-container\">\r\n    <form");
            EndContext();
            BeginWriteAttribute("action", " action=\"", 256, "\"", 284, 1);
#line 12 "F:\代码服务器\GIT\LdCmsNetCore\LdCms.Web\Views\SysRole\Add.cshtml"
WriteAttributeValue("", 265, Url.Action("Save"), 265, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(285, 1188, true);
            WriteLiteral(@" method=""post"" class=""form form-horizontal"" id=""form-add"">
        <div class=""row cl"">
            <label class=""form-label col-xs-4 col-sm-2""><span class=""c-red"">*</span>角色编号：</label>
            <div class=""formControls col-xs-8 col-sm-9"">
                <input type=""text"" class=""input-text"" value="""" placeholder="""" id=""fRoleId"" name=""fRoleId"">
            </div>
        </div>
        <div class=""row cl"">
            <label class=""form-label col-xs-4 col-sm-2""><span class=""c-red"">*</span>角色名称：</label>
            <div class=""formControls col-xs-8 col-sm-9"">
                <input type=""text"" class=""input-text"" value="""" placeholder="""" id=""fRoleName"" name=""fRoleName"">
            </div>
        </div>
        <div class=""row cl"">
            <label class=""form-label col-xs-4 col-sm-2"">备注：</label>
            <div class=""formControls col-xs-8 col-sm-9"">
                <input type=""text"" class=""input-text"" value="""" placeholder="""" id=""fRemark"" name=""fRemark"">
            </div>
        </div");
            WriteLiteral(">\r\n\r\n        <div class=\"row cl\">\r\n            <label class=\"form-label col-xs-4 col-sm-2\">角色功能：</label>\r\n            <div class=\"formControls col-xs-8 col-sm-9\">\r\n");
            EndContext();
#line 35 "F:\代码服务器\GIT\LdCmsNetCore\LdCms.Web\Views\SysRole\Add.cshtml"
                 foreach (var m in Model)
                {
                    if (m.RankID == 1 && m.FunctionID != "000000")
                    {

#line default
#line hidden
            BeginContext(1626, 149, true);
            WriteLiteral("                        <dl class=\"permission-list\">\r\n                            <dt>\r\n                                <label><input type=\"checkbox\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1775, "\"", 1796, 1);
#line 41 "F:\代码服务器\GIT\LdCmsNetCore\LdCms.Web\Views\SysRole\Add.cshtml"
WriteAttributeValue("", 1783, m.FunctionID, 1783, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1797, 16, true);
            WriteLiteral(" name=\"fFuncId\">");
            EndContext();
            BeginContext(1814, 14, false);
#line 41 "F:\代码服务器\GIT\LdCmsNetCore\LdCms.Web\Views\SysRole\Add.cshtml"
                                                                                              Write(m.FunctionName);

#line default
#line hidden
            EndContext();
            BeginContext(1828, 79, true);
            WriteLiteral("</label>\r\n                            </dt>\r\n                            <dd>\r\n");
            EndContext();
#line 44 "F:\代码服务器\GIT\LdCmsNetCore\LdCms.Web\Views\SysRole\Add.cshtml"
                                 foreach (var m1 in Model.Where(w => w.ParentID == m.FunctionID))
                                {

#line default
#line hidden
            BeginContext(2041, 198, true);
            WriteLiteral("                                    <dl class=\"cl permission-list2\">\r\n                                        <dt>\r\n                                            <label class=\"\"><input type=\"checkbox\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2239, "\"", 2261, 1);
#line 48 "F:\代码服务器\GIT\LdCmsNetCore\LdCms.Web\Views\SysRole\Add.cshtml"
WriteAttributeValue("", 2247, m1.FunctionID, 2247, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2262, 16, true);
            WriteLiteral(" name=\"fFuncId\">");
            EndContext();
            BeginContext(2279, 15, false);
#line 48 "F:\代码服务器\GIT\LdCmsNetCore\LdCms.Web\Views\SysRole\Add.cshtml"
                                                                                                                    Write(m1.FunctionName);

#line default
#line hidden
            EndContext();
            BeginContext(2294, 103, true);
            WriteLiteral("</label>\r\n                                        </dt>\r\n                                        <dd>\r\n");
            EndContext();
#line 51 "F:\代码服务器\GIT\LdCmsNetCore\LdCms.Web\Views\SysRole\Add.cshtml"
                                             foreach (var m2 in Model.Where(w => w.ParentID == m1.FunctionID))
                                            {

#line default
#line hidden
            BeginContext(2556, 86, true);
            WriteLiteral("                                                <label class=\"\"><input type=\"checkbox\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2642, "\"", 2664, 1);
#line 53 "F:\代码服务器\GIT\LdCmsNetCore\LdCms.Web\Views\SysRole\Add.cshtml"
WriteAttributeValue("", 2650, m2.FunctionID, 2650, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2665, 16, true);
            WriteLiteral(" name=\"fFuncId\">");
            EndContext();
            BeginContext(2682, 15, false);
#line 53 "F:\代码服务器\GIT\LdCmsNetCore\LdCms.Web\Views\SysRole\Add.cshtml"
                                                                                                                        Write(m2.FunctionName);

#line default
#line hidden
            EndContext();
            BeginContext(2697, 10, true);
            WriteLiteral("</label>\r\n");
            EndContext();
#line 54 "F:\代码服务器\GIT\LdCmsNetCore\LdCms.Web\Views\SysRole\Add.cshtml"
                                            }

#line default
#line hidden
            BeginContext(2754, 90, true);
            WriteLiteral("                                        </dd>\r\n                                    </dl>\r\n");
            EndContext();
#line 57 "F:\代码服务器\GIT\LdCmsNetCore\LdCms.Web\Views\SysRole\Add.cshtml"
                               }

#line default
#line hidden
            BeginContext(2878, 66, true);
            WriteLiteral("                            </dd>\r\n                        </dl>\r\n");
            EndContext();
#line 60 "F:\代码服务器\GIT\LdCmsNetCore\LdCms.Web\Views\SysRole\Add.cshtml"
                    }
                 }

#line default
#line hidden
            BeginContext(2987, 788, true);
            WriteLiteral(@"            </div>
        </div>
        <div class=""row cl"">
            <label class=""form-label col-xs-4 col-sm-2"">审核：</label>
            <div class=""formControls col-xs-8 col-sm-9 skin-minimal"">
                <div class=""check-box"">
                    <input type=""checkbox"" id=""fState"" name=""fState"" value=""1"" checked=""checked"" />
                    <label for=""checkbox-1"">&nbsp;</label>
                </div>
            </div>
        </div>
        <div class=""row cl"">
            <div class=""col-xs-8 col-sm-9 col-xs-offset-4 col-sm-offset-2"">
                <button type=""submit"" class=""btn btn-success radius"" id=""admin-role-save"" name=""admin-role-save""><i class=""icon-ok""></i> 确定</button>
            </div>
        </div>
    </form>
</article>

");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(3854, 34, true);
                WriteLiteral("\r\n    <!--请在下方写此页面业务相关的脚本-->\r\n    ");
                EndContext();
                BeginContext(3888, 102, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "23bc13d4f0c0402d8761b06f0adef58b", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3990, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(3996, 103, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "25e3d611c4c5485e8c5e98cdf6a1f4ed", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4099, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(4105, 98, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e20e30497fd3411bb6f59ca7441d6090", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4203, 4136, true);
                WriteLiteral(@"
    <script type=""text/javascript"">
        (function ($) {
            $.mainu = {
                init: function () {
                    $('.skin-minimal input').iCheck({
                        checkboxClass: 'icheckbox-blue',
                        radioClass: 'iradio-blue',
                        increaseArea: '20%'
                    });
                    $("".permission-list dt input:checkbox"").click(function () {
                        $(this).closest(""dl"").find(""dd input:checkbox"").prop(""checked"", $(this).prop(""checked""));
                    });
                    $("".permission-list2 dd input:checkbox"").click(function () {
                        var l = $(this).parent().parent().find(""input:checked"").length;
                        var l2 = $(this).parents("".permission-list"").find("".permission-list2 dd"").find(""input:checked"").length;
                        if ($(this).prop(""checked"")) {
                            $(this).closest(""dl"").find(""dt input:checkbox"").prop(""chec");
                WriteLiteral(@"ked"", true);
                            $(this).parents("".permission-list"").find(""dt"").first().find(""input:checkbox"").prop(""checked"", true);
                        }
                        else {
                            if (l == 0) {
                                $(this).closest(""dl"").find(""dt input:checkbox"").prop(""checked"", false);
                            }
                            if (l2 == 0) {
                                $(this).parents("".permission-list"").find(""dt"").first().find(""input:checkbox"").prop(""checked"", false);
                            }
                        }
                    });
                },
                formSubmit: function () {
                    $(""#form-add"").validate({
                        rules: {
                            fRoleId: {
                                required: true,
                                minlength: 3,
                                maxlength: 4
                            },
                      ");
                WriteLiteral(@"      fRoleName: {
                                required: true,
                                minlength: 2,
                                maxlength: 20
                            }
                        },
                        onkeyup: false,
                        focusCleanup: true,
                        success: ""valid"",
                        submitHandler: function (form) {
                            var fState = $(""input[name='fState']"").is(':checked');
                            $(form).ajaxSubmit({
                                type: ""POST"",
                                cache: false,
                                data: { fState: fState },
                                dataType: ""json"",
                                error: function (XMLHttpRequest, textStatus, errorThrown) {
                                    if (XMLHttpRequest.status != 200) {
                                        layer.alert(""POST[FAIL]"", { icon: 5 });
                              ");
                WriteLiteral(@"      }
                                },
                                success: function (result) {
                                    var state = result.state;          //错误代码
                                    var message = result.message;        //错误说明
                                    if (state == ""success"") {
                                        var index = parent.layer.getFrameIndex(window.name);
                                        parent.location.reload();
                                        parent.layer.close(index);
                                    } else {
                                        layer.alert(message, { icon: 5 });
                                    }
                                }
                            });
                        }
                    });
                }
            };
            $(function () {
                $.mainu.init();
                $.mainu.formSubmit();
            });

        })(jQuery);
    </sc");
                WriteLiteral("ript>\r\n    <!--/请在上方写此页面业务相关的脚本-->\r\n\r\n\r\n");
                EndContext();
            }
            );
            BeginContext(8342, 2, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Ld_Sys_Function>> Html { get; private set; }
    }
}
#pragma warning restore 1591
