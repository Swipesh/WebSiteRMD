#pragma checksum "/Users/swipe/RiderProjects/WebSiteRMD/PluralsightASP/Areas/Education/Pages/Materials.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "08de0ac1f0658da57d9f76b91f1eba921f2a598e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Education_Pages_Materials), @"mvc.1.0.razor-page", @"/Areas/Education/Pages/Materials.cshtml")]
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
#line 1 "/Users/swipe/RiderProjects/WebSiteRMD/PluralsightASP/Areas/Education/Pages/_ViewImports.cshtml"
using PluralsightASP.Areas.Education.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/swipe/RiderProjects/WebSiteRMD/PluralsightASP/Areas/Education/Pages/_ViewImports.cshtml"
using PluralsightASP;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"08de0ac1f0658da57d9f76b91f1eba921f2a598e", @"/Areas/Education/Pages/Materials.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb683e81c15224d75f41d5aada438d4cdfbc7046", @"/Areas/Education/Pages/_ViewImports.cshtml")]
    public class Areas_Education_Pages_Materials : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ManageNav", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_StatusMessage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-primary m-0 font-weight-bold"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::LazZiya.ExpressLocalization.TagHelpers.LocalizeAttributesTagHelper __LazZiya_ExpressLocalization_TagHelpers_LocalizeAttributesTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 4 "/Users/swipe/RiderProjects/WebSiteRMD/PluralsightASP/Areas/Education/Pages/Materials.cshtml"
  
    ViewData["Title"] = "Materials";
    ViewData["ActivePage"] = ManageNavPages.Materials;

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"container\">\n    <div class=\"block-heading\">\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("h2", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "08de0ac1f0658da57d9f76b91f1eba921f2a598e4986", async() => {
                WriteLiteral("Курс \"Математическое моделирование\"");
            }
            );
            __LazZiya_ExpressLocalization_TagHelpers_LocalizeAttributesTagHelper = CreateTagHelper<global::LazZiya.ExpressLocalization.TagHelpers.LocalizeAttributesTagHelper>();
            __tagHelperExecutionContext.Add(__LazZiya_ExpressLocalization_TagHelpers_LocalizeAttributesTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __LazZiya_ExpressLocalization_TagHelpers_LocalizeAttributesTagHelper.Localize = true;
            __tagHelperExecutionContext.AddTagHelperAttribute("localize-content", __LazZiya_ExpressLocalization_TagHelpers_LocalizeAttributesTagHelper.Localize, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n    </div>\n\n    <div class=\"row\">\n        <div class=\"col-md-3\">\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "08de0ac1f0658da57d9f76b91f1eba921f2a598e6508", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n        </div>\n        <div class=\"col-md-9\">\n\n\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "08de0ac1f0658da57d9f76b91f1eba921f2a598e7673", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __LazZiya_ExpressLocalization_TagHelpers_LocalizeAttributesTagHelper = CreateTagHelper<global::LazZiya.ExpressLocalization.TagHelpers.LocalizeAttributesTagHelper>();
            __tagHelperExecutionContext.Add(__LazZiya_ExpressLocalization_TagHelpers_LocalizeAttributesTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#nullable restore
#line 20 "/Users/swipe/RiderProjects/WebSiteRMD/PluralsightASP/Areas/Education/Pages/Materials.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = Model.StatusMessage;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __LazZiya_ExpressLocalization_TagHelpers_LocalizeAttributesTagHelper.Localize = true;
            __tagHelperExecutionContext.AddTagHelperAttribute("localize-content", __LazZiya_ExpressLocalization_TagHelpers_LocalizeAttributesTagHelper.Localize, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n            <div class=\"container\">\n                <div class=\"card shadow \">\n                    <div class=\"card-header py-3\">\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("p", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "08de0ac1f0658da57d9f76b91f1eba921f2a598e10038", async() => {
#nullable restore
#line 24 "/Users/swipe/RiderProjects/WebSiteRMD/PluralsightASP/Areas/Education/Pages/Materials.cshtml"
                                                                                 Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            }
            );
            __LazZiya_ExpressLocalization_TagHelpers_LocalizeAttributesTagHelper = CreateTagHelper<global::LazZiya.ExpressLocalization.TagHelpers.LocalizeAttributesTagHelper>();
            __tagHelperExecutionContext.Add(__LazZiya_ExpressLocalization_TagHelpers_LocalizeAttributesTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __LazZiya_ExpressLocalization_TagHelpers_LocalizeAttributesTagHelper.Localize = true;
            __tagHelperExecutionContext.AddTagHelperAttribute("localize-content", __LazZiya_ExpressLocalization_TagHelpers_LocalizeAttributesTagHelper.Localize, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </div>
                    <div class=""card-body"">
                        <ul class=""nav nav-tabs"">
                            <li class=""nav-item"">
                                <a class=""nav-link active"" data-toggle=""tab"" href=""#home"">Лабораторные</a>
                            </li>
                            <li class=""nav-item"">
                                <a class=""nav-link"" data-toggle=""tab"" href=""#menu1"">Книги</a>
                            </li>
                            <li class=""nav-item"">
                                <a class=""nav-link"" data-toggle=""tab"" href=""#menu2"">Ссылки</a>
                            </li>
                        </ul>

                        <!-- Tab panes -->
                        <div class=""tab-content"">
                            <div class=""tab-pane container active"" id=""home"">
                                <ol>
                                    <li>
                                        Динамические системы. Обыкновенное");
            WriteLiteral(@" дифференциальное уравнение и его
                                        решение. Символьное и численное решение.
                                    </li>
                                    <li>
                                        Динамические системы. Обыкновенное дифференциальное уравнение. Особые
                                        точки динамической системы. Качественное исследование.
                                    </li>
                                    <li>
                                        Линейные динамические системы на плоскости. Классификация особых точек.
                                        Фазовый портрет. 3_1 –непрерывные; 3_2-дискретные
                                    </li>
                                    <li>
                                        Нелинейные динамические системы на плоскости. Линеаризация в окрестности
                                        особых точек. Устойчивость.
                                    </li>
                              ");
            WriteLiteral(@"      <li>Событийно-управляемые системы. Маятник с внешней силой.</li>
                                    <li>
                                        Бифуркации на плоскости. Дифференциальные уравнения с полиномиальной правой
                                        частью.
                                    </li>
                                    <li>Колебания в динамических системах. Предельные циклы.</li>
                                    <li>Марковские цепи</li>
                                </ol>
                            </div>
                            <div class=""tab-pane container fade"" id=""menu1"">Список книг</div>
                            <div class=""tab-pane container fade"" id=""menu2"">Ссылки</div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PluralsightASP.Areas.Education.Pages.Materials> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PluralsightASP.Areas.Education.Pages.Materials> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PluralsightASP.Areas.Education.Pages.Materials>)PageContext?.ViewData;
        public PluralsightASP.Areas.Education.Pages.Materials Model => ViewData.Model;
    }
}
#pragma warning restore 1591
