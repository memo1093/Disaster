#pragma checksum "C:\Users\pc\Desktop\Website\Disaster\disaster.webui\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1f00c7049113651f0f8a8777e8492b2f1c011c92"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\pc\Desktop\Website\Disaster\disaster.webui\Views\_ViewImports.cshtml"
using disaster.webui;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\pc\Desktop\Website\Disaster\disaster.webui\Views\_ViewImports.cshtml"
using disaster.webui.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\pc\Desktop\Website\Disaster\disaster.webui\Views\_ViewImports.cshtml"
using disaster.webui.Extensions;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f00c7049113651f0f8a8777e8492b2f1c011c92", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"accf0420dcbb9dc10faa0333f4a6a6d62ef2ff6f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<DisasterModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Disaster", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteDisaster", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\pc\Desktop\Website\Disaster\disaster.webui\Views\Home\Index.cshtml"
  
    ViewData["Title"]="Afet Giriş Sayfası";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Hoşgeldiniz</h1>\r\n    <div>Afet Kontrol Uygulaması</div>\r\n");
#nullable restore
#line 9 "C:\Users\pc\Desktop\Website\Disaster\disaster.webui\Views\Home\Index.cshtml"
     if (Model.Count()<=0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"alert alert-warning\">Kayıtlı afet yok</div>\r\n");
#nullable restore
#line 12 "C:\Users\pc\Desktop\Website\Disaster\disaster.webui\Views\Home\Index.cshtml"
    }else{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <table class=""table"">
            <thead>
                <tr>
                    <th scope=""col"">Afet Seri No</th>
                    <th scope=""col"">Afet Tipi</th>
                    <th scope=""col"">İl</th>
                    <th scope=""col"">İlçe</th>
                    <th scope=""col"">Başlangıç Zamanı</th>
                    <th scope=""col"">Bitiş Zamanı</th>
                    <th scope=""col"">Enlem</th>
                    <th scope=""col"">Boylam</th>
                    <th scope=""col"">Neden</th>
                    <th scope=""col"">Açıklama</th>
                    <th scope=""col"">Etkilenen Alanlar</th>
                    <th scope=""col"">Onay Durumu</th>
                    <th scope=""col"">Ekler</th>
                    <th scope=""col"">İşlemler</th>
                    
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 34 "C:\Users\pc\Desktop\Website\Disaster\disaster.webui\Views\Home\Index.cshtml"
              foreach (var disaster in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 37 "C:\Users\pc\Desktop\Website\Disaster\disaster.webui\Views\Home\Index.cshtml"
               Write(disaster.SerialNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 38 "C:\Users\pc\Desktop\Website\Disaster\disaster.webui\Views\Home\Index.cshtml"
               Write(disaster.DisasterType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 39 "C:\Users\pc\Desktop\Website\Disaster\disaster.webui\Views\Home\Index.cshtml"
               Write(disaster.CityName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 40 "C:\Users\pc\Desktop\Website\Disaster\disaster.webui\Views\Home\Index.cshtml"
               Write(disaster.TownName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 41 "C:\Users\pc\Desktop\Website\Disaster\disaster.webui\Views\Home\Index.cshtml"
               Write(disaster.StartDate.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 42 "C:\Users\pc\Desktop\Website\Disaster\disaster.webui\Views\Home\Index.cshtml"
               Write(disaster.FinishDate.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 43 "C:\Users\pc\Desktop\Website\Disaster\disaster.webui\Views\Home\Index.cshtml"
               Write(disaster.Latitute);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 44 "C:\Users\pc\Desktop\Website\Disaster\disaster.webui\Views\Home\Index.cshtml"
               Write(disaster.Longtitute);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 45 "C:\Users\pc\Desktop\Website\Disaster\disaster.webui\Views\Home\Index.cshtml"
               Write(disaster.Why);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td><a tabindex=\"0\" class=\"btn btn-sm btn-danger\" role=\"button\" data-toggle=\"popover\" data-trigger=\"focus\" title=\"Açıklama\" data-content=\"");
#nullable restore
#line 46 "C:\Users\pc\Desktop\Website\Disaster\disaster.webui\Views\Home\Index.cshtml"
                                                                                                                                                     Write(disaster.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">Açıklama</a></td>\r\n                <td>");
#nullable restore
#line 47 "C:\Users\pc\Desktop\Website\Disaster\disaster.webui\Views\Home\Index.cshtml"
               Write(disaster.AffectedAreas);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 48 "C:\Users\pc\Desktop\Website\Disaster\disaster.webui\Views\Home\Index.cshtml"
               Write(EnumDescriptionExtension.GetDescription(disaster.ApproveState));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n                    <a tabindex=\"1\" class=\"btn btn-sm btn-danger\" role=\"button\" data-toggle=\"popover\" data-trigger=\"focus\" title=\"Ekler\" data-content=\"");
#nullable restore
#line 50 "C:\Users\pc\Desktop\Website\Disaster\disaster.webui\Views\Home\Index.cshtml"
                                                                                                                                                        foreach (var filename in disaster.fileNames){

#line default
#line hidden
#nullable disable
            WriteLiteral("<a");
            BeginWriteAttribute("href", " href=\'", 2271, "\'", 2296, 2);
            WriteAttributeValue("", 2278, "/uploads/", 2278, 9, true);
#nullable restore
#line 50 "C:\Users\pc\Desktop\Website\Disaster\disaster.webui\Views\Home\Index.cshtml"
WriteAttributeValue("", 2287, filename, 2287, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" download>");
#nullable restore
#line 50 "C:\Users\pc\Desktop\Website\Disaster\disaster.webui\Views\Home\Index.cshtml"
                                                                                                                                                                                                                                      Write(filename);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </a>");
#nullable restore
#line 50 "C:\Users\pc\Desktop\Website\Disaster\disaster.webui\Views\Home\Index.cshtml"
                                                                                                                                                                                                                                                         }

#line default
#line hidden
#nullable disable
            WriteLiteral("\">Ekler</a>\r\n                    \r\n                    </td>\r\n\r\n                <td>\r\n                    \r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1f00c7049113651f0f8a8777e8492b2f1c011c9212656", async() => {
                WriteLiteral("Düzenle");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 56 "C:\Users\pc\Desktop\Website\Disaster\disaster.webui\Views\Home\Index.cshtml"
                                                                     WriteLiteral(disaster.DisasterId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1f00c7049113651f0f8a8777e8492b2f1c011c9215154", async() => {
                WriteLiteral("\r\n                    <input type=\"hidden\" name=\"disasterId\"");
                BeginWriteAttribute("value", " value=\"", 2731, "\"", 2759, 1);
#nullable restore
#line 58 "C:\Users\pc\Desktop\Website\Disaster\disaster.webui\Views\Home\Index.cshtml"
WriteAttributeValue("", 2739, disaster.DisasterId, 2739, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                    <button type=\"submit\" class=\"btn btn-danger btn-sm\">Sil</button>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </td>\r\n\r\n\r\n\r\n            </tr>\r\n");
#nullable restore
#line 66 "C:\Users\pc\Desktop\Website\Disaster\disaster.webui\Views\Home\Index.cshtml"
            

            
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n        </table>\r\n");
#nullable restore
#line 72 "C:\Users\pc\Desktop\Website\Disaster\disaster.webui\Views\Home\Index.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    \r\n       \r\n    \r\n    <p>Learn about <a href=\"https://docs.microsoft.com/aspnet/core\">building Web apps with ASP.NET Core</a>.</p>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<DisasterModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
