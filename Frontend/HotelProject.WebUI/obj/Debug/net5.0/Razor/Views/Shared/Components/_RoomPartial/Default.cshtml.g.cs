#pragma checksum "C:\Users\fatih\Documents\Code\CSharp\HotelProject\Frontend\HotelProject.WebUI\Views\Shared\Components\_RoomPartial\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "af01e1b6920fc2cca3784b9f2f994ebf8aad0231"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components__RoomPartial_Default), @"mvc.1.0.view", @"/Views/Shared/Components/_RoomPartial/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af01e1b6920fc2cca3784b9f2f994ebf8aad0231", @"/Views/Shared/Components/_RoomPartial/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a8c852eb7ada5d7f0bf8ac265b7256724cffb3c4", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components__RoomPartial_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ResultRoomDTO>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""container-xxl py-5"">
    <div class=""container"">
        <div class=""text-center wow fadeInUp"" data-wow-delay=""0.1s"">
            <h6 class=""section-title text-center text-primary text-uppercase"">Odalarımız</h6>
            <h1 class=""mb-5"">Explore Our <span class=""text-primary text-uppercase"">Rooms</span></h1>
        </div>
        <div class=""row g-4"">
");
#nullable restore
#line 9 "C:\Users\fatih\Documents\Code\CSharp\HotelProject\Frontend\HotelProject.WebUI\Views\Shared\Components\_RoomPartial\Default.cshtml"
             foreach (var item in Model)
            {
                
            

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-lg-4 col-md-6 wow fadeInUp\" data-wow-delay=\"0.3s\">\r\n                <div class=\"room-item shadow rounded overflow-hidden\">\r\n                    <div class=\"position-relative\">\r\n                        <img class=\"img-fluid\"");
            BeginWriteAttribute("src", " src=\"", 742, "\"", 768, 1);
#nullable restore
#line 16 "C:\Users\fatih\Documents\Code\CSharp\HotelProject\Frontend\HotelProject.WebUI\Views\Shared\Components\_RoomPartial\Default.cshtml"
WriteAttributeValue("", 748, item.RoomCoverImage, 748, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 769, "\"", 775, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <small class=\"position-absolute start-0 top-100 translate-middle-y bg-primary text-white rounded py-1 px-3 ms-4\">$");
#nullable restore
#line 17 "C:\Users\fatih\Documents\Code\CSharp\HotelProject\Frontend\HotelProject.WebUI\Views\Shared\Components\_RoomPartial\Default.cshtml"
                                                                                                                                     Write(item.RoomPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("/Night</small>\r\n                    </div>\r\n                    <div class=\"p-4 mt-2\">\r\n                        <div class=\"d-flex justify-content-between mb-3\">\r\n                            <h5 class=\"mb-0\">");
#nullable restore
#line 21 "C:\Users\fatih\Documents\Code\CSharp\HotelProject\Frontend\HotelProject.WebUI\Views\Shared\Components\_RoomPartial\Default.cshtml"
                                        Write(item.RoomTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h5>
                            <div class=""ps-2"">
                                <small class=""fa fa-star text-primary""></small>
                                <small class=""fa fa-star text-primary""></small>
                                <small class=""fa fa-star text-primary""></small>
                                <small class=""fa fa-star text-primary""></small>
                                <small class=""fa fa-star text-primary""></small>
                            </div>
                        </div>
                        <div class=""d-flex mb-3"">
                            <small class=""border-end me-3 pe-3""><i class=""fa fa-bed text-primary me-2""></i>");
#nullable restore
#line 31 "C:\Users\fatih\Documents\Code\CSharp\HotelProject\Frontend\HotelProject.WebUI\Views\Shared\Components\_RoomPartial\Default.cshtml"
                                                                                                      Write(item.RoomBedCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Bed</small>\r\n                            <small class=\"border-end me-3 pe-3\"><i class=\"fa fa-bath text-primary me-2\"></i>");
#nullable restore
#line 32 "C:\Users\fatih\Documents\Code\CSharp\HotelProject\Frontend\HotelProject.WebUI\Views\Shared\Components\_RoomPartial\Default.cshtml"
                                                                                                       Write(item.RoomBathCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Bath</small>\r\n                            <small><i class=\"fa fa-wifi text-primary me-2\"></i>Wifi</small>\r\n                        </div>\r\n                        <p class=\"text-body mb-3\">");
#nullable restore
#line 35 "C:\Users\fatih\Documents\Code\CSharp\HotelProject\Frontend\HotelProject.WebUI\Views\Shared\Components\_RoomPartial\Default.cshtml"
                                             Write(item.RoomDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                        <div class=""d-flex justify-content-between"">
                            <a class=""btn btn-sm btn-primary rounded py-2 px-4"" href=""/Booking/Index"">Detayları Gör</a>
                                <a class=""btn btn-sm btn-dark rounded py-2 px-4"" href=""/Booking/Index"">Rezervasyon Yap</a>
                        </div>
                    </div>
                </div>
            </div>
");
#nullable restore
#line 43 "C:\Users\fatih\Documents\Code\CSharp\HotelProject\Frontend\HotelProject.WebUI\Views\Shared\Components\_RoomPartial\Default.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ResultRoomDTO>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
