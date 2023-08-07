#pragma checksum "C:\Users\fatih\Documents\Code\CSharp\HotelProject\Frontend\HotelProject.WebUI\Views\AdminContact\Sendbox.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "08cfb7d32934c9e271c503a66e954b4c4a2eb566"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdminContact_Sendbox), @"mvc.1.0.view", @"/Views/AdminContact/Sendbox.cshtml")]
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
#line 1 "C:\Users\fatih\Documents\Code\CSharp\HotelProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\fatih\Documents\Code\CSharp\HotelProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\fatih\Documents\Code\CSharp\HotelProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Models.Staff;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\fatih\Documents\Code\CSharp\HotelProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Models.Testimonial;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\fatih\Documents\Code\CSharp\HotelProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.DTOs.HotelServiceDTO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\fatih\Documents\Code\CSharp\HotelProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.DTOs.AppUserDTO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\fatih\Documents\Code\CSharp\HotelProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.DTOs.LoginDTO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\fatih\Documents\Code\CSharp\HotelProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.DTOs.AboutDTO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\fatih\Documents\Code\CSharp\HotelProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.DTOs.RoomDTO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\fatih\Documents\Code\CSharp\HotelProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.DTOs.StaffDTO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\fatih\Documents\Code\CSharp\HotelProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.DTOs.SubscribeDTO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\fatih\Documents\Code\CSharp\HotelProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.DTOs.BookingDTO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\fatih\Documents\Code\CSharp\HotelProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.DTOs.TestimonialDTO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\fatih\Documents\Code\CSharp\HotelProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.DTOs.ContactDTO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\fatih\Documents\Code\CSharp\HotelProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.DTOs.GuestDTO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\fatih\Documents\Code\CSharp\HotelProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Models.Mail;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"08cfb7d32934c9e271c503a66e954b4c4a2eb566", @"/Views/AdminContact/Sendbox.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a8c852eb7ada5d7f0bf8ac265b7256724cffb3c4", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_AdminContact_Sendbox : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ResultSendMessageDTO>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\fatih\Documents\Code\CSharp\HotelProject\Frontend\HotelProject.WebUI\Views\AdminContact\Sendbox.cshtml"
  
    ViewData["Title"] = "Sendbox";
    Layout = "~/Views/AdminLayout/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""email-left-box"">
    <a href=""/AdminContact/AddSendMessage/"" class=""btn btn-primary btn-block"">Yeni Mesaj Oluştur</a>

    <div class=""mail-list mt-4"">
        <a href=""/AdminContact/Inbox/"" class=""list-group-item border-0 text-primary p-r-0""><i class=""fa fa-inbox font-18 align-middle mr-2""></i> <b>Gelen Kutusu</b> <span class=""badge badge-primary badge-sm float-right m-t-5"">100</span> </a>

        <a href=""/AdminContact/Sendbox/"" class=""list-group-item border-0 text-info p-r-0""><i class=""fa fa-paper-plane font-18 align-middle mr-2""></i><b> Giden Kutusu</b><span class=""badge badge-info badge-sm float-right m-t-5"">100</span> </a>

        <a href=""#"" class=""list-group-item border-0 text-danger p-r-0""><i class=""fa fa-star-o font-18 align-middle mr-2""></i><b> Önemli</b> <span class=""badge badge-danger badge-sm float-right m-t-5"">50</span> </a>

        <a href=""#"" class=""list-group-item border-0 text-warning p-r-0""><i class=""mdi mdi-file-document-box font-18 align-middle mr-2""></i><b>Tas");
            WriteLiteral(@"laklar</b> <span class=""badge badge-warning badge-sm float-right m-t-5"">18</span> </a>

        <a href=""#"" class=""list-group-item border-0 text-dark p-r-0""><i class=""fa fa-trash font-18 align-middle mr-2""></i><b>Çöp Kutusu</b><span class=""badge badge-dark badge-sm float-right m-t-5"">36</span></a>
    </div>

    <h5 class=""mt-5 m-b-10"">Kategoriler</h5>
    ");
#nullable restore
#line 24 "C:\Users\fatih\Documents\Code\CSharp\HotelProject\Frontend\HotelProject.WebUI\Views\AdminContact\Sendbox.cshtml"
Write(await Html.PartialAsync("SideBarAdminContactCategoryPartial"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
</div>
<div class=""email-right-box"">
    <div role=""toolbar"" class=""toolbar"">
        <div class=""btn-group"">
            <button aria-expanded=""false"" data-toggle=""dropdown"" class=""btn btn-dark dropdown-toggle"" type=""button"">
                Gelen Mesajlar <span class=""caret m-l-5""></span>
            </button>
        </div>
    </div>
    <div class=""email-list m-t-15"">
");
#nullable restore
#line 35 "C:\Users\fatih\Documents\Code\CSharp\HotelProject\Frontend\HotelProject.WebUI\Views\AdminContact\Sendbox.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"message\">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 2079, "\"", 2143, 2);
            WriteAttributeValue("", 2086, "/AdminContact/MessageDetailsBySendbox/", 2086, 38, true);
#nullable restore
#line 38 "C:\Users\fatih\Documents\Code\CSharp\HotelProject\Frontend\HotelProject.WebUI\Views\AdminContact\Sendbox.cshtml"
WriteAttributeValue("", 2124, item.SendMessageID, 2124, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                    <div class=""col-mail col-mail-1"">
                        <div class=""email-checkbox"">
                            <input type=""checkbox"" id=""chk2"">
                            <label class=""toggle"" for=""chk2""></label>
                        </div><span class=""star-toggle ti-star""></span>
                    </div>
                    <div class=""col-mail col-mail-2"">
                        <div class=""subject""><b>Konu: ");
#nullable restore
#line 46 "C:\Users\fatih\Documents\Code\CSharp\HotelProject\Frontend\HotelProject.WebUI\Views\AdminContact\Sendbox.cshtml"
                                                 Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b> Alıcı: ");
#nullable restore
#line 46 "C:\Users\fatih\Documents\Code\CSharp\HotelProject\Frontend\HotelProject.WebUI\Views\AdminContact\Sendbox.cshtml"
                                                                        Write(item.ReceiverName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                        <div class=\"date\">");
#nullable restore
#line 47 "C:\Users\fatih\Documents\Code\CSharp\HotelProject\Frontend\HotelProject.WebUI\Views\AdminContact\Sendbox.cshtml"
                                      Write(((DateTime)item.Date).ToString("dd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    </div>\r\n                </a>\r\n            </div>\r\n");
#nullable restore
#line 51 "C:\Users\fatih\Documents\Code\CSharp\HotelProject\Frontend\HotelProject.WebUI\Views\AdminContact\Sendbox.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ResultSendMessageDTO>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591