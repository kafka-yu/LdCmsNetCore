#pragma checksum "H:\Git\LdCmsNetCore\LdCms.Web\Views\LogLoginRecord\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "30933e32b40ac3cd3c52aae4abc041801806ea77"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_LogLoginRecord_List), @"mvc.1.0.view", @"/Views/LogLoginRecord/List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/LogLoginRecord/List.cshtml", typeof(AspNetCore.Views_LogLoginRecord_List))]
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
#line 1 "H:\Git\LdCmsNetCore\LdCms.Web\Views\LogLoginRecord\List.cshtml"
using LdCms.EF.DbModels;

#line default
#line hidden
#line 2 "H:\Git\LdCmsNetCore\LdCms.Web\Views\LogLoginRecord\List.cshtml"
using LdCms.Common.Utility;

#line default
#line hidden
#line 3 "H:\Git\LdCmsNetCore\LdCms.Web\Views\LogLoginRecord\List.cshtml"
using LdCms.Common.Extension;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"30933e32b40ac3cd3c52aae4abc041801806ea77", @"/Views/LogLoginRecord/List.cshtml")]
    public class Views_LogLoginRecord_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Ld_Log_LoginRecord>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin/lib/My97DatePicker/4.8/WdatePicker.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin/lib/datatables/1.10.0/jquery.dataTables.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin/lib/laypage/1.2/laypage.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin/static/h-ui.admin/js/H-ui.admin.common.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 5 "H:\Git\LdCmsNetCore\LdCms.Web\Views\LogLoginRecord\List.cshtml"
  
    ViewData["Title"] = "List";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(213, 596, true);
            WriteLiteral(@"<nav class=""breadcrumb""><i class=""Hui-iconfont"">&#xe67f;</i> 首页 <span class=""c-gray en"">&gt;</span> 系统管理 <span class=""c-gray en"">&gt;</span> 日志管理 <a id=""btn_refresh"" class=""btn btn-success radius r"" style=""line-height:1.6em;margin-top:3px"" href=""javascript:location.replace(location.href);"" title=""刷新""><i class=""Hui-iconfont"">&#xe68f;</i></a></nav>
<div class=""page-container"">
    <div class=""text-c"">
        日期范围：
        <input type=""text"" onfocus=""WdatePicker({ maxDate:'#F{$dp.$D(\'datemax\')||\'%y-%M-%d\'}' })"" id=""datemin"" name=""datemin"" class=""input-text Wdate"" style=""width:120px;""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 809, "\"", 833, 1);
#line 13 "H:\Git\LdCmsNetCore\LdCms.Web\Views\LogLoginRecord\List.cshtml"
WriteAttributeValue("", 817, ViewBag.datemin, 817, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(834, 196, true);
            WriteLiteral(" />\r\n        -\r\n        <input type=\"text\" onfocus=\"WdatePicker({ minDate:\'#F{$dp.$D(\\\'datemin\\\')}\',maxDate:\'%y-%M-%d\' })\" id=\"datemax\" name=\"datemax\" class=\"input-text Wdate\" style=\"width:120px;\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1030, "\"", 1054, 1);
#line 15 "H:\Git\LdCmsNetCore\LdCms.Web\Views\LogLoginRecord\List.cshtml"
WriteAttributeValue("", 1038, ViewBag.datemax, 1038, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1055, 199, true);
            WriteLiteral(" />\r\n        <select id=\"clientId\" name=\"clientId\" class=\"select\" style=\"width:100px; height:31px;vertical-align: middle;\">\r\n            <option value=\"\">全部状态</option>\r\n            <option value=\"1\" ");
            EndContext();
            BeginContext(1256, 41, false);
#line 18 "H:\Git\LdCmsNetCore\LdCms.Web\Views\LogLoginRecord\List.cshtml"
                          Write(ViewBag.ClientID == "1" ? "selected" : "");

#line default
#line hidden
            EndContext();
            BeginContext(1298, 45, true);
            WriteLiteral(">Web</option>\r\n            <option value=\"2\" ");
            EndContext();
            BeginContext(1345, 41, false);
#line 19 "H:\Git\LdCmsNetCore\LdCms.Web\Views\LogLoginRecord\List.cshtml"
                          Write(ViewBag.ClientID == "2" ? "selected" : "");

#line default
#line hidden
            EndContext();
            BeginContext(1387, 43, true);
            WriteLiteral(">M</option>\r\n            <option value=\"3\" ");
            EndContext();
            BeginContext(1432, 41, false);
#line 20 "H:\Git\LdCmsNetCore\LdCms.Web\Views\LogLoginRecord\List.cshtml"
                          Write(ViewBag.ClientID == "3" ? "selected" : "");

#line default
#line hidden
            EndContext();
            BeginContext(1474, 44, true);
            WriteLiteral(">WX</option>\r\n            <option value=\"4\" ");
            EndContext();
            BeginContext(1520, 41, false);
#line 21 "H:\Git\LdCmsNetCore\LdCms.Web\Views\LogLoginRecord\List.cshtml"
                          Write(ViewBag.ClientID == "4" ? "selected" : "");

#line default
#line hidden
            EndContext();
            BeginContext(1562, 152, true);
            WriteLiteral(">App</option>\r\n        </select>\r\n        <input type=\"text\" class=\"input-text\" style=\"width:350px\" placeholder=\"帐号、姓名、IP地址\" id=\"keyword\" name=\"keyword\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1714, "\"", 1738, 1);
#line 23 "H:\Git\LdCmsNetCore\LdCms.Web\Views\LogLoginRecord\List.cshtml"
WriteAttributeValue("", 1722, ViewBag.keyword, 1722, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1739, 554, true);
            WriteLiteral(@" />
        <button type=""submit"" class=""btn btn-success radius"" id=""search"" name=""search"" onclick=""$.mainu.search()""><i class=""Hui-iconfont"">&#xe665;</i> 搜日志</button>
    </div>
    <div class=""cl pd-5 bg-1 bk-gray mt-20"">
        <span class=""l"">
            <a href=""javascript:;"" onclick=""$.mainu.deleteBatch()"" class=""btn btn-danger radius""><i class=""Hui-iconfont"">&#xe6e2;</i> 批量删除</a>
            <a href=""javascript:;"" onclick=""$.mainu.deleteAll()"" class=""btn btn-danger radius""><i class=""Hui-iconfont"">&#xe6e2;</i> 清空日志</a>
            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2293, "\"", 2319, 1);
#line 30 "H:\Git\LdCmsNetCore\LdCms.Web\Views\LogLoginRecord\List.cshtml"
WriteAttributeValue("", 2300, Url.Action("list"), 2300, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2320, 133, true);
            WriteLiteral(" class=\"btn btn-primary radius\"><i class=\"Hui-iconfont\">&#xe667;</i> 日志列表</a>\r\n        </span>\r\n        <span class=\"r\">共有数据：<strong>");
            EndContext();
            BeginContext(2454, 13, false);
#line 32 "H:\Git\LdCmsNetCore\LdCms.Web\Views\LogLoginRecord\List.cshtml"
                                Write(ViewBag.Count);

#line default
#line hidden
            EndContext();
            BeginContext(2467, 801, true);
            WriteLiteral(@"</strong> 条</span>
    </div>
    <div class=""mt-20"">
        <table class=""table table-border table-bordered table-hover table-bg table-sort"">
            <thead>
                <tr class=""text-c"">
                    <th width=""25""><input type=""checkbox"" name="""" value=""""></th>
                    <th width=""60"">序号</th>
                    <th width=""80"">公司编号</th>
                    <th width=""80"">工号</th>
                    <th width=""80"">姓名</th>
                    <th width=""80"">客户端</th>
                    <th width=""120"">IP地址</th>
                    <th width="""">描述</th>
                    <th width=""70"">结果</th>
                    <th width=""120"">操作时间</th>
                    <th width=""80"">操作</th>
                </tr>
            </thead>
            <tbody>
");
            EndContext();
#line 52 "H:\Git\LdCmsNetCore\LdCms.Web\Views\LogLoginRecord\List.cshtml"
                 if (Model != null)
                {
                    foreach (var m in Model)
                    {

#line default
#line hidden
            BeginContext(3393, 109, true);
            WriteLiteral("                        <tr class=\"text-c\">\r\n                            <td><input type=\"checkbox\" name=\"id\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 3502, "\"", 3515, 1);
#line 57 "H:\Git\LdCmsNetCore\LdCms.Web\Views\LogLoginRecord\List.cshtml"
WriteAttributeValue("", 3510, m.ID, 3510, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3516, 40, true);
            WriteLiteral("></td>\r\n                            <td>");
            EndContext();
            BeginContext(3557, 4, false);
#line 58 "H:\Git\LdCmsNetCore\LdCms.Web\Views\LogLoginRecord\List.cshtml"
                           Write(m.ID);

#line default
#line hidden
            EndContext();
            BeginContext(3561, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(3601, 11, false);
#line 59 "H:\Git\LdCmsNetCore\LdCms.Web\Views\LogLoginRecord\List.cshtml"
                           Write(m.CompanyID);

#line default
#line hidden
            EndContext();
            BeginContext(3612, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(3653, 55, false);
#line 60 "H:\Git\LdCmsNetCore\LdCms.Web\Views\LogLoginRecord\List.cshtml"
                            Write(Html.Raw(Utility.Highlight(m.Account, ViewBag.keyword)));

#line default
#line hidden
            EndContext();
            BeginContext(3709, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(3750, 56, false);
#line 61 "H:\Git\LdCmsNetCore\LdCms.Web\Views\LogLoginRecord\List.cshtml"
                            Write(Html.Raw(Utility.Highlight(m.NickName, ViewBag.keyword)));

#line default
#line hidden
            EndContext();
            BeginContext(3807, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(3847, 12, false);
#line 62 "H:\Git\LdCmsNetCore\LdCms.Web\Views\LogLoginRecord\List.cshtml"
                           Write(m.ClientName);

#line default
#line hidden
            EndContext();
            BeginContext(3859, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(3899, 11, false);
#line 63 "H:\Git\LdCmsNetCore\LdCms.Web\Views\LogLoginRecord\List.cshtml"
                           Write(m.IpAddress);

#line default
#line hidden
            EndContext();
            BeginContext(3910, 54, true);
            WriteLiteral("</td>\r\n                            <td class=\"text-l\">");
            EndContext();
            BeginContext(3965, 13, false);
#line 64 "H:\Git\LdCmsNetCore\LdCms.Web\Views\LogLoginRecord\List.cshtml"
                                          Write(m.Description);

#line default
#line hidden
            EndContext();
            BeginContext(3978, 57, true);
            WriteLiteral("</td>\r\n                            <td class=\"td-status\">");
            EndContext();
            BeginContext(4037, 149, false);
#line 65 "H:\Git\LdCmsNetCore\LdCms.Web\Views\LogLoginRecord\List.cshtml"
                                              Write(m.IsResult.ToBool() ? Html.Raw("<span class='label label-success radius'>成功</span>") : Html.Raw("<span class='label label-defaunt radius'>失败</span>"));

#line default
#line hidden
            EndContext();
            BeginContext(4187, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(4228, 77, false);
#line 66 "H:\Git\LdCmsNetCore\LdCms.Web\Views\LogLoginRecord\List.cshtml"
                            Write(m.CreateDate.HasValue ? m.CreateDate.Value.ToString("yyyy-MM-dd HH:mm") : "-");

#line default
#line hidden
            EndContext();
            BeginContext(4306, 124, true);
            WriteLiteral("</td>\r\n                            <td class=\"td-manage\">\r\n                                <a title=\"删除\" href=\"javascript:;\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 4430, "\"", 4468, 3);
            WriteAttributeValue("", 4440, "$.mainu.delete(this,\'", 4440, 21, true);
#line 68 "H:\Git\LdCmsNetCore\LdCms.Web\Views\LogLoginRecord\List.cshtml"
WriteAttributeValue("", 4461, m.ID, 4461, 5, false);

#line default
#line hidden
            WriteAttributeValue("", 4466, "\')", 4466, 2, true);
            EndWriteAttribute();
            BeginContext(4469, 117, true);
            WriteLiteral(" class=\"ml-5\" style=\"text-decoration:none\">删除</a>\r\n                            </td>\r\n                        </tr>\r\n");
            EndContext();
#line 71 "H:\Git\LdCmsNetCore\LdCms.Web\Views\LogLoginRecord\List.cshtml"
                    }
                }

#line default
#line hidden
            BeginContext(4628, 120, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n<div class=\"pt-30\" style=\"width:100%; height:60px;\"></div>\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(4827, 34, true);
                WriteLiteral("\r\n    <!--请在下方写此页面业务相关的脚本-->\r\n    ");
                EndContext();
                BeginContext(4861, 92, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6631485095434e6bb857350279aa94a8", async() => {
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
                BeginContext(4953, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(4959, 101, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0a42b77fde2c4e99a7a3eda4293f33de", async() => {
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
                BeginContext(5060, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(5066, 81, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "031b978c37024598ad8ae46f6d6c0de7", async() => {
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
                BeginContext(5147, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(5153, 96, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "92e65b157fae4182b75b7430f87ad712", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5249, 1850, true);
                WriteLiteral(@"
    <script type=""text/javascript"">
            (function ($) {
                $.mainu = {
                    init: function () {
                        $('.table-sort').dataTable({
                            ""aaSorting"": [[1, ""desc""]],//默认第几个排序
                            ""bStateSave"": true,//状态保存
                            ""aoColumnDefs"": [
                              { ""orderable"": false, ""aTargets"": [0, 10] }// 制定列不参与排序
                            ],
                            ""aLengthMenu"": [10, 25, 50, 100]
                        });
                    },
                    search: function () {
                        var dateMin = $(""input[name='datemin']"").val();
                        var dateMax = $(""input[name='datemax']"").val();
                        var clientId = $(""select[name='clientId']"").val();
                        var keyword = $(""input[name='keyword']"").val();
                        if (keyword == """") {
                            if (dateMin == """" |");
                WriteLiteral(@"| dateMax == """") {
                                layer.alert('日期范围不能空', { icon: 5 });
                                return;
                            }
                        }
                        var params = {
                            dateMin: dateMin,
                            dateMax: dateMax,
                            clientId: clientId,
                            keyword: keyword
                        };
                        var url = ""?"" + urlEncodes(params);
                        window.location.href = url;
                    },
                    delete: function (obj, id) {
                        layer.confirm('确认要删除吗？', function (index) {
                            $.ajax({
                                type: 'POST',
                                url: '");
                EndContext();
                BeginContext(7100, 20, false);
#line 126 "H:\Git\LdCmsNetCore\LdCms.Web\Views\LogLoginRecord\List.cshtml"
                                 Write(Url.Action("Delete"));

#line default
#line hidden
                EndContext();
                BeginContext(7120, 1858, true);
                WriteLiteral(@"',
                                data: { id: id },
                                dataType: 'json',
                                success: function (result) {
                                    var state = result.state;
                                    var message = result.message;
                                    if (state == ""success"") {
                                        $(obj).parents(""tr"").remove();
                                        layer.msg('已删除!', { icon: 1, time: 1000 });
                                    } else {
                                        layer.msg(message, { icon: 5, time: 1000 });
                                    }
                                },
                                error: function (XMLHttpRequest, textStatus, errorThrown) {
                                    if (XMLHttpRequest.status != 200) {
                                        layer.alert(""系统错误！"", { icon: 5 });
                                    }
                  ");
                WriteLiteral(@"              }
                            });
                        });
                    },
                    deleteBatch: function () {
                        layer.confirm('确认要删除吗？', function (index) {
                            var arrId = [];
                            $(""input:checkbox[name='id']:checked"").each(function () {
                                //alert($(this).val());
                                arrId.push($(this).val());
                            });
                            if (arrId.length == 0) {
                                layer.msg('请选择需要删除日志！', { icon: 5, time: 2000 });
                                return;
                            }
                            $.ajax({
                                type: 'POST',
                                url: '");
                EndContext();
                BeginContext(8979, 25, false);
#line 160 "H:\Git\LdCmsNetCore\LdCms.Web\Views\LogLoginRecord\List.cshtml"
                                 Write(Url.Action("DeleteBatch"));

#line default
#line hidden
                EndContext();
                BeginContext(9004, 1338, true);
                WriteLiteral(@"',
                                data: { arrid: arrId },
                                dataType: 'json',
                                success: function (result) {
                                    var state = result.state;          //错误代码
                                    var message = result.message;        //错误说明
                                    if (state == ""success"") {
                                        window.location.replace(location.href);
                                    } else {
                                        layer.msg(message, { icon: 5, time: 1000 });
                                    }
                                },
                                error: function (XMLHttpRequest, textStatus, errorThrown) {
                                    if (XMLHttpRequest.status != 200) {
                                        layer.alert(""系统错误！"", { icon: 5 });
                                    }
                                }
                       ");
                WriteLiteral(@"     });
                        });
                    },
                    deleteAll: function () {
                        layer.confirm('确认要清空系统日志吗？保留最近三天日志。', function (index) {
                            $.ajax({
                                type: 'POST',
                                url: '");
                EndContext();
                BeginContext(10343, 23, false);
#line 184 "H:\Git\LdCmsNetCore\LdCms.Web\Views\LogLoginRecord\List.cshtml"
                                 Write(Url.Action("DeleteAll"));

#line default
#line hidden
                EndContext();
                BeginContext(10366, 1230, true);
                WriteLiteral(@"',
                                data: { id: 0 },
                                dataType: 'json',
                                success: function (result) {
                                    var state = result.state;          //错误代码
                                    var message = result.message;        //错误说明
                                    if (state == ""success"") {
                                        window.location.replace(location.href);
                                    } else {
                                        layer.msg(message, { icon: 5, time: 1000 });
                                    }
                                },
                                error: function (XMLHttpRequest, textStatus, errorThrown) {
                                    if (XMLHttpRequest.status != 200) {
                                        layer.alert(""系统错误！"", { icon: 5 });
                                    }
                                }
                            })");
                WriteLiteral(";\r\n                        });\r\n                    }\r\n                };\r\n                $(function () {\r\n                    $.mainu.init();\r\n                });\r\n            })(jQuery);\r\n    </script>\r\n");
                EndContext();
            }
            );
            BeginContext(11599, 4, true);
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Ld_Log_LoginRecord>> Html { get; private set; }
    }
}
#pragma warning restore 1591
