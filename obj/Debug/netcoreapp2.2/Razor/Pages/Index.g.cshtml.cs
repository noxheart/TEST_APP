#pragma checksum "C:\Users\danie\Documents\ObjectProgÖvningar\TEST APP\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0980a59c08fd002f0970ac99c8f2b42909a3e5ee"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(TEST_APP.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Index.cshtml", typeof(TEST_APP.Pages.Pages_Index), null)]
namespace TEST_APP.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\danie\Documents\ObjectProgÖvningar\TEST APP\Pages\_ViewImports.cshtml"
using TEST_APP;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0980a59c08fd002f0970ac99c8f2b42909a3e5ee", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"50b98de05454a7c7c84609cfb055ee73caeb06fc", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\danie\Documents\ObjectProgÖvningar\TEST APP\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";
    var sayHello = "Hello World";
    string[] arr = {"Windows", "IOS", "Linux"};
    Random rnd = new Random();
    int randomNr = rnd.Next(1,21);
    

#line default
#line hidden
            BeginContext(229, 69, true);
            WriteLiteral("\r\n<div class=\"text-center\" style=\"background-color:white;\">\r\n    <hl>");
            EndContext();
            BeginContext(299, 8, false);
#line 13 "C:\Users\danie\Documents\ObjectProgÖvningar\TEST APP\Pages\Index.cshtml"
   Write(sayHello);

#line default
#line hidden
            EndContext();
            BeginContext(307, 14, true);
            WriteLiteral("</hl>\r\n    <p>");
            EndContext();
            BeginContext(322, 12, false);
#line 14 "C:\Users\danie\Documents\ObjectProgÖvningar\TEST APP\Pages\Index.cshtml"
  Write(DateTime.Now);

#line default
#line hidden
            EndContext();
            BeginContext(334, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 15 "C:\Users\danie\Documents\ObjectProgÖvningar\TEST APP\Pages\Index.cshtml"
     foreach(var item in Model.Food)
    {

#line default
#line hidden
            BeginContext(385, 12, true);
            WriteLiteral("        <li>");
            EndContext();
            BeginContext(398, 4, false);
#line 17 "C:\Users\danie\Documents\ObjectProgÖvningar\TEST APP\Pages\Index.cshtml"
       Write(item);

#line default
#line hidden
            EndContext();
            BeginContext(402, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 18 "C:\Users\danie\Documents\ObjectProgÖvningar\TEST APP\Pages\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(416, 7, true);
            WriteLiteral("    <p>");
            EndContext();
            BeginContext(424, 8, false);
#line 19 "C:\Users\danie\Documents\ObjectProgÖvningar\TEST APP\Pages\Index.cshtml"
  Write(randomNr);

#line default
#line hidden
            EndContext();
            BeginContext(432, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 20 "C:\Users\danie\Documents\ObjectProgÖvningar\TEST APP\Pages\Index.cshtml"
     if(randomNr > 10)
    {

#line default
#line hidden
            BeginContext(469, 19, true);
            WriteLiteral("        <p>Ja</p>\r\n");
            EndContext();
#line 23 "C:\Users\danie\Documents\ObjectProgÖvningar\TEST APP\Pages\Index.cshtml"
    }
    else
    {

#line default
#line hidden
            BeginContext(512, 20, true);
            WriteLiteral("        <p>nej</p>\r\n");
            EndContext();
#line 27 "C:\Users\danie\Documents\ObjectProgÖvningar\TEST APP\Pages\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(539, 313, true);
            WriteLiteral(@"    <p>Learn about <a href=""https://images.hdsydsvenskan.se/980x588/IQNWo8HvGS5b8HwFbiAP8wbLctY.jpg"">building Web apps with ASP.NET Core</a>.</p>
    <img src=""img/red_hawk.jpg"" alt=""Hawk"" width=""348"" height=""410"">  
    <p style=""color:violet;"">Waddup brewski</p>
</div>
<div id=""header"">
    <p>yobro</p>
");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
