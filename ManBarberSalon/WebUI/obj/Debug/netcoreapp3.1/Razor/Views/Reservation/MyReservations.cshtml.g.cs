#pragma checksum "C:\Users\erayc\Desktop\Code Archive\Projeler\ManBarberSalon\WebUI\Views\Reservation\MyReservations.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5255294c7b6abd72aff8ff9ca22447c404eab118"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Reservation_MyReservations), @"mvc.1.0.view", @"/Views/Reservation/MyReservations.cshtml")]
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
#line 1 "C:\Users\erayc\Desktop\Code Archive\Projeler\ManBarberSalon\WebUI\Views\_ViewImports.cshtml"
using WebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\erayc\Desktop\Code Archive\Projeler\ManBarberSalon\WebUI\Views\_ViewImports.cshtml"
using WebUI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5255294c7b6abd72aff8ff9ca22447c404eab118", @"/Views/Reservation/MyReservations.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"43d8308283e147aceb640f85e77cb8c039e61219", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Reservation_MyReservations : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ReservationDetailListViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CancelReservation", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Reservation", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "C:\Users\erayc\Desktop\Code Archive\Projeler\ManBarberSalon\WebUI\Views\Reservation\MyReservations.cshtml"
  
    Layout = "ReservationLayout";
    ViewData["Title"] = "Randevularım";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"

<div class=""inner-banner"" id=""home"">
    <div class=""inner-banner-overlay"">
        <div class=""container"">
        </div>
    </div>
</div>

<div class=""breadcrumb-agile"">
    <div class=""container"">
        <ol class=""breadcrumb"">
            <li class=""breadcrumb-item"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5255294c7b6abd72aff8ff9ca22447c404eab1185950", async() => {
                WriteLiteral("Anasayfa");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </li>\r\n            <li class=\"breadcrumb-item active\" aria-current=\"page\">Randevularım</li>\r\n        </ol>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
#nullable restore
#line 28 "C:\Users\erayc\Desktop\Code Archive\Projeler\ManBarberSalon\WebUI\Views\Reservation\MyReservations.cshtml"
  
    int count = 1;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container table-responsive"" style=""padding-top: 50px;"">
    <table class=""table table-borderless"">
        <thead>
            <tr>
                <th>#</th>
                <th>Personel</th>
                <th>Yapılacak iş</th>
                <th>Tarih</th>
                <th>Saat</th>
                <th>Durum</th>
                <th>İptal Edilme Tarihi</th>
                <th>İptal et</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 47 "C:\Users\erayc\Desktop\Code Archive\Projeler\ManBarberSalon\WebUI\Views\Reservation\MyReservations.cshtml"
             foreach (var details in Model.ReservationDetails)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 50 "C:\Users\erayc\Desktop\Code Archive\Projeler\ManBarberSalon\WebUI\Views\Reservation\MyReservations.cshtml"
                   Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 51 "C:\Users\erayc\Desktop\Code Archive\Projeler\ManBarberSalon\WebUI\Views\Reservation\MyReservations.cshtml"
                   Write(details.EmployeeFirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 51 "C:\Users\erayc\Desktop\Code Archive\Projeler\ManBarberSalon\WebUI\Views\Reservation\MyReservations.cshtml"
                                              Write(details.EmployeeLastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 52 "C:\Users\erayc\Desktop\Code Archive\Projeler\ManBarberSalon\WebUI\Views\Reservation\MyReservations.cshtml"
                   Write(details.Menu);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 53 "C:\Users\erayc\Desktop\Code Archive\Projeler\ManBarberSalon\WebUI\Views\Reservation\MyReservations.cshtml"
                   Write(details.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 54 "C:\Users\erayc\Desktop\Code Archive\Projeler\ManBarberSalon\WebUI\Views\Reservation\MyReservations.cshtml"
                   Write(details.Time);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 55 "C:\Users\erayc\Desktop\Code Archive\Projeler\ManBarberSalon\WebUI\Views\Reservation\MyReservations.cshtml"
                     if (details.StatusId == 1)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td class=\"table-success\">");
#nullable restore
#line 57 "C:\Users\erayc\Desktop\Code Archive\Projeler\ManBarberSalon\WebUI\Views\Reservation\MyReservations.cshtml"
                                             Write(details.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td></td>\r\n                        <td>\r\n                            <button type=\"button\" class=\"btn btn-warning\" data-toggle=\"modal\" onclick=\"cancelreservationmodelshow(event)\" data-reservation-id=\"");
#nullable restore
#line 60 "C:\Users\erayc\Desktop\Code Archive\Projeler\ManBarberSalon\WebUI\Views\Reservation\MyReservations.cshtml"
                                                                                                                                                          Write(details.ReservationId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                                İptal Et\r\n                            </button>\r\n                        </td>\r\n");
#nullable restore
#line 64 "C:\Users\erayc\Desktop\Code Archive\Projeler\ManBarberSalon\WebUI\Views\Reservation\MyReservations.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td class=\"table-danger\">");
#nullable restore
#line 67 "C:\Users\erayc\Desktop\Code Archive\Projeler\ManBarberSalon\WebUI\Views\Reservation\MyReservations.cshtml"
                                            Write(details.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 68 "C:\Users\erayc\Desktop\Code Archive\Projeler\ManBarberSalon\WebUI\Views\Reservation\MyReservations.cshtml"
                       Write(details.CanceledDate.Value.ToString("g"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td></td>\r\n");
#nullable restore
#line 70 "C:\Users\erayc\Desktop\Code Archive\Projeler\ManBarberSalon\WebUI\Views\Reservation\MyReservations.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tr>\r\n");
#nullable restore
#line 72 "C:\Users\erayc\Desktop\Code Archive\Projeler\ManBarberSalon\WebUI\Views\Reservation\MyReservations.cshtml"
                count++;
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </tbody>
    </table>
</div>


<div class=""modal fade"" id=""cancelreservation"" tabindex=""-1"" role=""dialog"" aria-labelledby=""cancelreservationlabel"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5255294c7b6abd72aff8ff9ca22447c404eab11813718", async() => {
                WriteLiteral(@"
                <div class=""modal-header"">
                    <h5 class=""modal-title"" id=""cancelreservationlabel"">Randevu İptal</h5>
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                        <span aria-hidden=""true"">&times;</span>
                    </button>
                </div>
                <div class=""modal-body"">
                    Randevuyu iptal etmek üzeresiniz emin misiniz ?
                </div>
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Kapat</button>
                    <button name=""reservationId"" id=""selectedreservationId"" type=""submit"" class=""btn btn-primary"">İptal Et</button>
                </div>
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

        </div>
    </div>
</div>

                
<script type=""text/javascript"">

    function cancelreservationmodelshow(event) {

        $('#selectedreservationId').val($(event.target).data('reservation-id'));
        $('#cancelreservation').modal('show');
    }
</script>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ReservationDetailListViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
