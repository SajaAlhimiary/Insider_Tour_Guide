#pragma checksum "/Users/saja/Documents/CodingDojo/CSharp/Project/Final Project/RTInsiderTourGuide-Zaid/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1143926ee1d3fb194c3e5dbe376715d49855ea72"
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
#line 1 "/Users/saja/Documents/CodingDojo/CSharp/Project/Final Project/RTInsiderTourGuide-Zaid/Views/_ViewImports.cshtml"
using RTInsiderTourGuide;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/saja/Documents/CodingDojo/CSharp/Project/Final Project/RTInsiderTourGuide-Zaid/Views/_ViewImports.cshtml"
using RTInsiderTourGuide.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/saja/Documents/CodingDojo/CSharp/Project/Final Project/RTInsiderTourGuide-Zaid/Views/_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1143926ee1d3fb194c3e5dbe376715d49855ea72", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8874b0b419974924cf310dba7596ea851544849e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Tour>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<nav class=""navbar navbar-expand-lg navbar-light bg-light"">
    <div class=""container"">
        <a class=""navbar-brand"" href=""/"">Runtime Terror</a>
        <ul class=""navbar-nav"">
            <li class=""nav-item active"">
                <a class=""nav-link"" href=""/"">Home</a>
            </li>
");
#nullable restore
#line 9 "/Users/saja/Documents/CodingDojo/CSharp/Project/Final Project/RTInsiderTourGuide-Zaid/Views/Home/Index.cshtml"
              
              if (Context.Session.GetInt32("userId") != null)
              {

#line default
#line hidden
#nullable disable
            WriteLiteral("                  <li class=\"nav-item\">\n                        <a class=\"nav-link\" href=\"/userdashboard\">My Dashboard</a>\n                  </li>\n");
#nullable restore
#line 15 "/Users/saja/Documents/CodingDojo/CSharp/Project/Final Project/RTInsiderTourGuide-Zaid/Views/Home/Index.cshtml"
              }
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "/Users/saja/Documents/CodingDojo/CSharp/Project/Final Project/RTInsiderTourGuide-Zaid/Views/Home/Index.cshtml"
              
              if (Context.Session.GetInt32("userId") == 1)
              {

#line default
#line hidden
#nullable disable
            WriteLiteral("                  <li class=\"nav-item\">\n                        <a class=\"nav-link\" href=\"/admin\">Admin Dashboard</a>\n                  </li>\n");
#nullable restore
#line 23 "/Users/saja/Documents/CodingDojo/CSharp/Project/Final Project/RTInsiderTourGuide-Zaid/Views/Home/Index.cshtml"
              }
            

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li class=\"nav-item\">\n                <a class=\"nav-link\" href=\"/SearchTours\">Search For Tours</a>\n            </li>\n            <li class=\"nav-item\">\n                <a class=\"nav-link\" href=\"#\">Contact Us</a>\n            </li>\n");
#nullable restore
#line 31 "/Users/saja/Documents/CodingDojo/CSharp/Project/Final Project/RTInsiderTourGuide-Zaid/Views/Home/Index.cshtml"
              
              if (Context.Session.GetInt32("userId") != null)
              {

#line default
#line hidden
#nullable disable
            WriteLiteral("                  <li class=\"login\">\n                    <a class=\"nav-link\" href=\"/logout\">Logout</a>\n                  </li>\n");
#nullable restore
#line 37 "/Users/saja/Documents/CodingDojo/CSharp/Project/Final Project/RTInsiderTourGuide-Zaid/Views/Home/Index.cshtml"
              }
              else
              {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"login\">\n                  <a class=\"nav-link\" href=\"/login\">Login</a>\n                </li>\n");
#nullable restore
#line 43 "/Users/saja/Documents/CodingDojo/CSharp/Project/Final Project/RTInsiderTourGuide-Zaid/Views/Home/Index.cshtml"
              }
            

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </div>
</nav>


<div id=""toursCarousel"" class=""carousel slide container"" data-ride=""carousel"">
    <ol class=""carousel-indicators"">
      <li data-target=""#toursCarousel"" data-slide-to=""0"" class=""active""></li>
      <li data-target=""#toursCarousel"" data-slide-to=""1""></li>
      <li data-target=""#toursCarousel"" data-slide-to=""2""></li>
    </ol>
    <div class=""carousel-inner"">
      <div class=""carousel-item active"">
        <img src=""/images/img1.jpeg"" class=""d-block w-100 carousel-img"">
      </div>
      <div class=""carousel-item"">
        <img src=""/images/img2.png"" class=""d-block w-100 carousel-img"">
      </div>
      <div class=""carousel-item"">
        <img src=""/images/img3.png"" class=""d-block w-100 carousel-img"">
      </div>
    </div>
    <a class=""carousel-control-prev"" href=""#toursCarousel"" role=""button"" data-slide=""prev"">
      <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
      <span class=""sr-only"">Previous</span>
    </a>
    <a class=""carousel-control-next"" href=""#to");
            WriteLiteral(@"ursCarousel"" role=""button"" data-slide=""next"">
      <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
      <span class=""sr-only"">Next</span>
    </a>
    </div>
</div>

<main class=""container body "">
        <h3><u>All Tours:</u></h3>
        <div class=""row"">

");
#nullable restore
#line 81 "/Users/saja/Documents/CodingDojo/CSharp/Project/Final Project/RTInsiderTourGuide-Zaid/Views/Home/Index.cshtml"
            
            foreach (Tour t in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("              <div class=\"col-4 mb-4\">\n                <div class=\"card\">\n                  <a");
            BeginWriteAttribute("href", " href=\"", 2968, "\"", 2990, 2);
            WriteAttributeValue("", 2975, "/tour/", 2975, 6, true);
#nullable restore
#line 86 "/Users/saja/Documents/CodingDojo/CSharp/Project/Final Project/RTInsiderTourGuide-Zaid/Views/Home/Index.cshtml"
WriteAttributeValue("", 2981, t.TourId, 2981, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                    <img");
            BeginWriteAttribute("src", " src=\"", 3017, "\"", 3045, 1);
#nullable restore
#line 87 "/Users/saja/Documents/CodingDojo/CSharp/Project/Final Project/RTInsiderTourGuide-Zaid/Views/Home/Index.cshtml"
WriteAttributeValue("", 3023, t.ImagesOfTour[0].Url, 3023, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top card-img\">\n                  </a>\n                  <div class=\"card-body\">\n                    <h6 class=\"card-title\"><a");
            BeginWriteAttribute("href", " href=\"", 3188, "\"", 3210, 2);
            WriteAttributeValue("", 3195, "/tour/", 3195, 6, true);
#nullable restore
#line 90 "/Users/saja/Documents/CodingDojo/CSharp/Project/Final Project/RTInsiderTourGuide-Zaid/Views/Home/Index.cshtml"
WriteAttributeValue("", 3201, t.TourId, 3201, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 90 "/Users/saja/Documents/CodingDojo/CSharp/Project/Final Project/RTInsiderTourGuide-Zaid/Views/Home/Index.cshtml"
                                                                Write(t.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h6>\n                    <p class=\"text-center price\" >$");
#nullable restore
#line 91 "/Users/saja/Documents/CodingDojo/CSharp/Project/Final Project/RTInsiderTourGuide-Zaid/Views/Home/Index.cshtml"
                                              Write(t.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                    <p>Includes transportation, the mentioned meals, and a tour guide</p>\n                    <p class=\"card-text\">Availability : ");
#nullable restore
#line 93 "/Users/saja/Documents/CodingDojo/CSharp/Project/Final Project/RTInsiderTourGuide-Zaid/Views/Home/Index.cshtml"
                                                   Write(t.Duration);

#line default
#line hidden
#nullable disable
            WriteLiteral(" day/s.</p>\n                    <a");
            BeginWriteAttribute("href", " href=\"", 3485, "\"", 3507, 2);
            WriteAttributeValue("", 3492, "/tour/", 3492, 6, true);
#nullable restore
#line 94 "/Users/saja/Documents/CodingDojo/CSharp/Project/Final Project/RTInsiderTourGuide-Zaid/Views/Home/Index.cshtml"
WriteAttributeValue("", 3498, t.TourId, 3498, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><u>View More...</u></a>\n                  </div>\n                </div>\n              </div>\n");
#nullable restore
#line 98 "/Users/saja/Documents/CodingDojo/CSharp/Project/Final Project/RTInsiderTourGuide-Zaid/Views/Home/Index.cshtml"
            }
          

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </div>\n    </main>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Tour>> Html { get; private set; }
    }
}
#pragma warning restore 1591
