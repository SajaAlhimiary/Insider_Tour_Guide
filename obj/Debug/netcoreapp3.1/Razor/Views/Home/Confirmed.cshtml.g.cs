#pragma checksum "/Users/saja/Documents/CodingDojo/CSharp/Project/Final Project/RTInsiderTourGuide-Zaid/Views/Home/Confirmed.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "73c6a68545ebf52faf7375a65e11ef76423dc13c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Confirmed), @"mvc.1.0.view", @"/Views/Home/Confirmed.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"73c6a68545ebf52faf7375a65e11ef76423dc13c", @"/Views/Home/Confirmed.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8874b0b419974924cf310dba7596ea851544849e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Confirmed : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<link href=""https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css"" rel=""stylesheet"" 
        integrity=""sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC"" crossorigin=""anonymous"">
        
<div class=""card center1 mb-5"">
    <div>
        <h1>Booking Completed!</h1>
        <img class=""img1"" src=""/images/icon2.jpg"" alt=""check"">
        <h4>Thank You!</h4>
        <h6>You will be redirected to your dashboard in 4 seconds</h6>
        <h6>If you are not redirected click the button below</h6>
        <button class=""btn btn-success btn-lg mt-2 btnHover"" type=""submit"">GO TO HOMEPAGE</button>
    </div>
</div>

<script type=""text/javascript"">
    window.setTimeout(() => {
        window.location.href='/UserDashboard';
    }, 4000);
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
