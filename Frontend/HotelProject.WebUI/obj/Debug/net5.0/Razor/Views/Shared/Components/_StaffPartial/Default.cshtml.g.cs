#pragma checksum "C:\Users\fatih\Documents\Code\CSharp\HotelProject\Frontend\HotelProject.WebUI\Views\Shared\Components\_StaffPartial\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "41778ece87e05e6b4340171deeacf63adf39ee61"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components__StaffPartial_Default), @"mvc.1.0.view", @"/Views/Shared/Components/_StaffPartial/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"41778ece87e05e6b4340171deeacf63adf39ee61", @"/Views/Shared/Components/_StaffPartial/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b03d9128025d8c5cb2b4401064c27aff938883b", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components__StaffPartial_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ResultStaffDTO>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""container-xxl py-5"">
    <div class=""container"">
        <div class=""text-center wow fadeInUp"" data-wow-delay=""0.1s"">
            <h6 class=""section-title text-center text-primary text-uppercase"">Ekip</h6>
            <h1 class=""mb-5"">Explore Our <span class=""text-primary text-uppercase"">Staffs</span></h1>
        </div>
        <div class=""row g-4"">
");
#nullable restore
#line 10 "C:\Users\fatih\Documents\Code\CSharp\HotelProject\Frontend\HotelProject.WebUI\Views\Shared\Components\_StaffPartial\Default.cshtml"
         foreach (var item in Model)
            {
                
            

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-lg-3 col-md-6 wow fadeInUp\" data-wow-delay=\"0.1s\">\r\n                <div class=\"rounded shadow overflow-hidden\">\r\n                    <div class=\"position-relative\">\r\n                        <img class=\"img-fluid\"");
            BeginWriteAttribute("src", " src=\"", 726, "\"", 748, 1);
#nullable restore
#line 17 "C:\Users\fatih\Documents\Code\CSharp\HotelProject\Frontend\HotelProject.WebUI\Views\Shared\Components\_StaffPartial\Default.cshtml"
WriteAttributeValue("", 732, item.StaffImage, 732, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 749, "\"", 755, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <div class=\"position-absolute start-50 top-100 translate-middle d-flex align-items-center\">\r\n                            <a class=\"btn btn-square btn-primary mx-1\"");
            BeginWriteAttribute("href", " href=\"", 946, "\"", 953, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fab fa-facebook-f\"></i></a>\r\n                            <a class=\"btn btn-square btn-primary mx-1\"");
            BeginWriteAttribute("href", " href=\"", 1064, "\"", 1071, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fab fa-twitter\"></i></a>\r\n                            <a class=\"btn btn-square btn-primary mx-1\"");
            BeginWriteAttribute("href", " href=\"", 1179, "\"", 1186, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fab fa-instagram\"></i></a>\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"text-center p-4 mt-3\">\r\n                        <h5 class=\"fw-bold mb-0\">");
#nullable restore
#line 25 "C:\Users\fatih\Documents\Code\CSharp\HotelProject\Frontend\HotelProject.WebUI\Views\Shared\Components\_StaffPartial\Default.cshtml"
                                            Write(item.StaffFirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 25 "C:\Users\fatih\Documents\Code\CSharp\HotelProject\Frontend\HotelProject.WebUI\Views\Shared\Components\_StaffPartial\Default.cshtml"
                                                                 Write(item.StaffLastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                        <small>");
#nullable restore
#line 26 "C:\Users\fatih\Documents\Code\CSharp\HotelProject\Frontend\HotelProject.WebUI\Views\Shared\Components\_StaffPartial\Default.cshtml"
                          Write(item.StaffTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 30 "C:\Users\fatih\Documents\Code\CSharp\HotelProject\Frontend\HotelProject.WebUI\Views\Shared\Components\_StaffPartial\Default.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ResultStaffDTO>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
