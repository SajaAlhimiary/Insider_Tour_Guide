#pragma checksum "/Users/saja/Documents/CodingDojo/CSharp/Project/Final Project/RTInsiderTourGuide-Zaid/Views/Home/Payment.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "795c101b11c2b635cb66a3c39dc57dfd8ee841dc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Payment), @"mvc.1.0.view", @"/Views/Home/Payment.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"795c101b11c2b635cb66a3c39dc57dfd8ee841dc", @"/Views/Home/Payment.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8874b0b419974924cf310dba7596ea851544849e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Payment : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Booking>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<main class=\"container\">\n    <div class=\"card\">\n        <div class=\"card-body\">\n            <div class=\"row\">\n                <div class=\"col-md-7\">\n                    <div class=\"left border p-2\">\n                        <p");
            BeginWriteAttribute("class", " class=\"", 241, "\"", 249, 0);
            EndWriteAttribute();
            WriteLiteral(@">All fields are required*</p>
                        <h5>Confirm order and pay</h5>
                        <div class=""row""> 
                            <span class=""header"">CREDIT OR DEBIT CARD</span>
                            <div class=""icons""> 
                                <img src=""https://img.icons8.com/color/48/000000/visa.png"" /> 
                                <img src=""https://img.icons8.com/color/48/000000/mastercard-logo.png"" /> 
                                <img src=""https://img.icons8.com/color/48/000000/maestro.png"" /> 
                            </div>
                        </div>
                        <div class=""row"">
                            <div class=""col-12 mt-3"">
                                <label>Name on Card:</label> 
                                <input type=""text"" class=""col-12"" placeholder=""Jason Brady""> 
                            </div>
                        </div>
                        <div class=""row mt-2"">
                            <div class=""");
            WriteLiteral(@"col-6"">
                                <span>Card Number:</span> 
                                <input class=""col-10"" type=""text"" placeholder=""0125 6780 4567 9909"">  
                            </div>
                            <div class=""col-3"">
                                <span>Expiry date:</span> 
                                <input class=""col-10"" type=""text"" placeholder=""MM/YY""> 
                            </div>
                            <div class=""col-3"">
                                <span>CVV:</span> 
                                <input class=""col-10"" type=""text"" placeholder=""255"">  
                            </div>
                        </div>

                        <br>
                        <h5><b>BILLING ADDRESS:</b></h5>
                        

                        <div class=""row"">
                            <div class=""col-6"">
                                <span>Street Address:</span> <br> 
                                <input class=""col-10"" type=""text"" p");
            WriteLiteral(@"laceholder=""john "">  
                            </div>

                            <div class=""col-6"">
                                <span>City:</span> <br>
                                <input class=""col-10"" type=""text"" placeholder=""San Diego"">  
                            </div>
                        </div>

                        <div class=""row mt-2"">
                            <div class=""col-6"">
                                <span >State/Province:</span> <br> 
                                <input class=""col-10"" type=""text"" placeholder=""California"">  
                            </div>

                            <div class=""col-6"">
                                <span>Zip CODE:</span> <br>
                                <input class=""col-10"" type=""text"" placeholder=""92101"">  
                            </div>

                            <div class=""row mt-5 mb-3"">
                                <div class=""col-12 position-relative"">
                                    ");
#nullable restore
#line 69 "/Users/saja/Documents/CodingDojo/CSharp/Project/Final Project/RTInsiderTourGuide-Zaid/Views/Home/Payment.cshtml"
                               Write(Html.ActionLink("Confirm the Payment", "Confirmed", "Home", @Model, new { @class= "pay"} ));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </div>
                            </div>
                        </div>
                    </div>
                </div>

                <div class=""col-md-5 space"">
                    <div class=""right border p-2"">
                        <h5>");
#nullable restore
#line 78 "/Users/saja/Documents/CodingDojo/CSharp/Project/Final Project/RTInsiderTourGuide-Zaid/Views/Home/Payment.cshtml"
                       Write(ViewBag.selectedTour.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n                        <br>\n                        <div class=\"row item\">\n                            <p class=\"col-6 align-self-center\"><b>Travel Date :</b>   ");
#nullable restore
#line 81 "/Users/saja/Documents/CodingDojo/CSharp/Project/Final Project/RTInsiderTourGuide-Zaid/Views/Home/Payment.cshtml"
                                                                                 Write(ViewBag.selectedTour.Date.Date.ToString("MMM dd yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                            <p class=\"col-6 align-self-center\"><b>Duration :</b>   ");
#nullable restore
#line 82 "/Users/saja/Documents/CodingDojo/CSharp/Project/Final Project/RTInsiderTourGuide-Zaid/Views/Home/Payment.cshtml"
                                                                              Write(ViewBag.selectedTour.Duration);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Day/s</p>\n                        </div>\n\n                        <div class=\"row item mb-3\">\n                            <p class=\"col-6 align-self-center\"><b>Adult :</b>  ");
#nullable restore
#line 86 "/Users/saja/Documents/CodingDojo/CSharp/Project/Final Project/RTInsiderTourGuide-Zaid/Views/Home/Payment.cshtml"
                                                                          Write(Model.NumberOfAdults);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                            <p class=\"col-6 align-self-center\"><b>Children :</b>   ");
#nullable restore
#line 87 "/Users/saja/Documents/CodingDojo/CSharp/Project/Final Project/RTInsiderTourGuide-Zaid/Views/Home/Payment.cshtml"
                                                                              Write(Model.NumberOfChildern);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                        </div>
                    </div>
                    <div class=""row item pt-3 mb-3 pb-2 bg-light right border"">
                        <h4 class=""col-6 align-self-center""><b>Total Price :</b></h4>
                        <h4 class=""col-6 align-self-center""><b>$");
#nullable restore
#line 92 "/Users/saja/Documents/CodingDojo/CSharp/Project/Final Project/RTInsiderTourGuide-Zaid/Views/Home/Payment.cshtml"
                                                           Write(ViewBag.TotalPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></h4>\n                    </div>\n                </div>\n            </div>\n        </div>\n    </div>\n</main>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Booking> Html { get; private set; }
    }
}
#pragma warning restore 1591
