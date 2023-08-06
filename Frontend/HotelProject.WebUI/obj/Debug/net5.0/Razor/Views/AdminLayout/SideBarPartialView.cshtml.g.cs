#pragma checksum "C:\Users\fatih\Documents\Code\CSharp\HotelProject\Frontend\HotelProject.WebUI\Views\AdminLayout\SideBarPartialView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "08c555811153cf1d4f0e451f97ad465da3ba3078"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdminLayout_SideBarPartialView), @"mvc.1.0.view", @"/Views/AdminLayout/SideBarPartialView.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"08c555811153cf1d4f0e451f97ad465da3ba3078", @"/Views/AdminLayout/SideBarPartialView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"95af8a1fc70e705e39138561069b43b6951462f9", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_AdminLayout_SideBarPartialView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""nk-sidebar"">
    <div class=""nk-nav-scroll"">
        <ul class=""metismenu"" id=""menu"">

            <hr />
            <li>
                <a href=""/staff/index"" aria-expanded=""false"">
                    <i class=""icon-notebook menu-icon""></i><span class=""nav-text"">Personeller</span>
                </a>
            </li>
            <li>
                <a href=""/testimonial/index"" aria-expanded=""false"">
                    <i class=""icon-lock menu-icon""></i><span class=""nav-text"">Referanslar</span>
                </a>
            </li>
            <li>
                <a href=""/hotelservice/index"" aria-expanded=""false"">
                    <i class=""icon-clock menu-icon""></i><span class=""nav-text"">Hizmetler</span>
                </a>
            </li>
            <li>
                <a href=""/adminabout/index"" aria-expanded=""false"">
                    <i class=""icon-clock menu-icon""></i><span class=""nav-text"">Hakkımızda</span>
                </a>

            </l");
            WriteLiteral("i>\r\n        </ul>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
