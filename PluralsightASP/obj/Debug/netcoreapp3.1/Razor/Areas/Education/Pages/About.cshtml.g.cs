#pragma checksum "/Users/swipe/RiderProjects/WebSiteRMD/PluralsightASP/Areas/Education/Pages/About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5b0c00807c047d902f7be08f5622ee77005fabeb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Education_Pages_About), @"mvc.1.0.razor-page", @"/Areas/Education/Pages/About.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b0c00807c047d902f7be08f5622ee77005fabeb", @"/Areas/Education/Pages/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb683e81c15224d75f41d5aada438d4cdfbc7046", @"/Areas/Education/Pages/_ViewImports.cshtml")]
    public class Areas_Education_Pages_About : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
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
#line 4 "/Users/swipe/RiderProjects/WebSiteRMD/PluralsightASP/Areas/Education/Pages/About.cshtml"
  
    ViewData["Title"] = "About course";
    ViewData["ActivePage"] = ManageNavPages.About;

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"container\">\n    <div class=\"block-heading\">\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("h2", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5b0c00807c047d902f7be08f5622ee77005fabeb4965", async() => {
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
            WriteLiteral("\n        </div>\n    <div class=\"row\">\n        <div class=\"col-md-3\">\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5b0c00807c047d902f7be08f5622ee77005fabeb6489", async() => {
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
            WriteLiteral("\n        </div>\n        <div class=\"col-md-9\">\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5b0c00807c047d902f7be08f5622ee77005fabeb7650", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __LazZiya_ExpressLocalization_TagHelpers_LocalizeAttributesTagHelper = CreateTagHelper<global::LazZiya.ExpressLocalization.TagHelpers.LocalizeAttributesTagHelper>();
            __tagHelperExecutionContext.Add(__LazZiya_ExpressLocalization_TagHelpers_LocalizeAttributesTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#nullable restore
#line 17 "/Users/swipe/RiderProjects/WebSiteRMD/PluralsightASP/Areas/Education/Pages/About.cshtml"
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
            WriteLiteral("\n            <div class=\"container\">\n                <div class=\"card shadow\">\n                    <div class=\"card-header py-3\">\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("p", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5b0c00807c047d902f7be08f5622ee77005fabeb10010", async() => {
#nullable restore
#line 21 "/Users/swipe/RiderProjects/WebSiteRMD/PluralsightASP/Areas/Education/Pages/About.cshtml"
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
                        <div>Программа обучения инженеров-бакалавров высшей школы программной инженерии в
                             области моделирования включает два курса, первый из которых Математическое
                             моделирование.
                             Предполагается, что студент предварительно прослушал курсы: «Математика» («Линейная
                             алгебра», «Математический анализ»), «Численные методы», «Информатика» и знаком с
                             математическими пакетами Maple или Mathematica (дифференцирование, интегрирование,
                             дифференциальные уравнения), Matlab (матричные вычисления, решение
                             дифференциальных уравнений).
                             Основные разделы курса.
                             MМ_1. Моделирование и его роль в исследовании и проектировании. Математические
                             модели. Основные пр");
            WriteLiteral(@"иемы построения математических моделей.
                             MМ_2. Вычислительный эксперимент. Основные этапы: построение модели, исследование
                             модели, определение границ применимости модели. Математические пакеты и среды
                             визуального моделирования.
                             MМ_3. Динамические системы. Качественные методы исследования. Устойчивость
                             динамических систем. Бифуркации. Хаос в динамических системах.
                             MМ_4. Событийно-управляемые динамические системы. Примеры и основные свойства.
                             Формальное описание на языке карт поведения (машин состояния).
                             MM_5. Введение в теорию колебаний. Свободные и вынужденные колебания.
                             MМ_6. Теория массового обслуживания. Марковские случайные процессы. Марковские
                             цепи.
                             MM_7. Вычислительный эксперимент в среде Ra");
            WriteLiteral("nd Model Designer. Создание, отладка,\n                             эксперименты с моделями.</div>\n                    </div>\n                </div>\n            </div>\n        </div>\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PluralsightASP.Areas.Education.Pages.About> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PluralsightASP.Areas.Education.Pages.About> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PluralsightASP.Areas.Education.Pages.About>)PageContext?.ViewData;
        public PluralsightASP.Areas.Education.Pages.About Model => ViewData.Model;
    }
}
#pragma warning restore 1591
