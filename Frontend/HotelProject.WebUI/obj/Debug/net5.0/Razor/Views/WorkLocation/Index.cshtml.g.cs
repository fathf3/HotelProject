#pragma checksum "C:\Users\fatih\Documents\Code\CSharp\HotelProject\Frontend\HotelProject.WebUI\Views\WorkLocation\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9845c92722c069a81c5ca0ef2931725ec01ca835"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_WorkLocation_Index), @"mvc.1.0.view", @"/Views/WorkLocation/Index.cshtml")]
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
using HotelProject.WebUI.DTOs.WorkLocationDTO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\fatih\Documents\Code\CSharp\HotelProject\Frontend\HotelProject.WebUI\Views\_ViewImports.cshtml"
using HotelProject.WebUI.Models.Mail;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9845c92722c069a81c5ca0ef2931725ec01ca835", @"/Views/WorkLocation/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b03d9128025d8c5cb2b4401064c27aff938883b", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_WorkLocation_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ResultWorkLocationDto>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\fatih\Documents\Code\CSharp\HotelProject\Frontend\HotelProject.WebUI\Views\WorkLocation\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/AdminLayout/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<table class=\"table table-bordered\">\r\n    <tr>\r\n        <th>#</th>\r\n        <th>Lokasyon Adı</th>\r\n        <th>Şehir</th>\r\n        <th>Sil</th>\r\n        <th>Güncelle</th>\r\n    </tr>\r\n");
#nullable restore
#line 16 "C:\Users\fatih\Documents\Code\CSharp\HotelProject\Frontend\HotelProject.WebUI\Views\WorkLocation\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 19 "C:\Users\fatih\Documents\Code\CSharp\HotelProject\Frontend\HotelProject.WebUI\Views\WorkLocation\Index.cshtml"
           Write(item.WorkLocationID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 20 "C:\Users\fatih\Documents\Code\CSharp\HotelProject\Frontend\HotelProject.WebUI\Views\WorkLocation\Index.cshtml"
           Write(item.WorkLocationName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 21 "C:\Users\fatih\Documents\Code\CSharp\HotelProject\Frontend\HotelProject.WebUI\Views\WorkLocation\Index.cshtml"
           Write(item.WorkLocationCity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 527, "\"", 587, 2);
            WriteAttributeValue("", 534, "/WorkLocation/DeleteWorkLocation/", 534, 33, true);
#nullable restore
#line 22 "C:\Users\fatih\Documents\Code\CSharp\HotelProject\Frontend\HotelProject.WebUI\Views\WorkLocation\Index.cshtml"
WriteAttributeValue("", 567, item.WorkLocationID, 567, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn mb-1 btn-rounded btn-outline-danger\">Sil</a></td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 669, "\"", 729, 2);
            WriteAttributeValue("", 676, "/WorkLocation/UpdateWorkLocation/", 676, 33, true);
#nullable restore
#line 23 "C:\Users\fatih\Documents\Code\CSharp\HotelProject\Frontend\HotelProject.WebUI\Views\WorkLocation\Index.cshtml"
WriteAttributeValue("", 709, item.WorkLocationID, 709, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn mb-1 btn-rounded btn-outline-success\">Güncelle</a></td>\r\n        </tr>\r\n");
#nullable restore
#line 25 "C:\Users\fatih\Documents\Code\CSharp\HotelProject\Frontend\HotelProject.WebUI\Views\WorkLocation\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n<a href=\"/AdminRoom/AddRoom/\" class=\"btn mb-1 btn-rounded btn-outline-info\">Yeni Lokasyon Girişi</a>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ResultWorkLocationDto>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
