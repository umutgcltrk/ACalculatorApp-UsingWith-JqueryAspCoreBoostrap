#pragma checksum "C:\Users\gcltr\source\repos\Calculator\Calculator\Views\List\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a2c4ff58c6fa488531740e09012da9f44f3e76ca"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_List_Index), @"mvc.1.0.view", @"/Views/List/Index.cshtml")]
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
#line 1 "C:\Users\gcltr\source\repos\Calculator\Calculator\Views\_ViewImports.cshtml"
using Calculator;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\gcltr\source\repos\Calculator\Calculator\Views\List\Index.cshtml"
using Calculator.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a2c4ff58c6fa488531740e09012da9f44f3e76ca", @"/Views/List/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"25c9aefe488587b7ec0bf416a8f02fe7761a75ef", @"/Views/_ViewImports.cshtml")]
    public class Views_List_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Calculator>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\gcltr\source\repos\Calculator\Calculator\Views\List\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h3>Geçmiş işlemleri listele</h3>\r\n\r\n");
#nullable restore
#line 10 "C:\Users\gcltr\source\repos\Calculator\Calculator\Views\List\Index.cshtml"
 using (Html.BeginForm("Index", "List", FormMethod.Get))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p class=\"mb-0\">\r\n        Aranacak Tarih : ");
#nullable restore
#line 13 "C:\Users\gcltr\source\repos\Calculator\Calculator\Views\List\Index.cshtml"
                    Write(Html.TextBox("p"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <input type=\"submit\" class=\"btn btn-primary\" value=\"Ara\" />\r\n    </p>\r\n");
#nullable restore
#line 16 "C:\Users\gcltr\source\repos\Calculator\Calculator\Views\List\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<table class=""table"">
    <tr>
        <th scope=""col"">ID</th>
        <th scope=""col"">1.Sayı</th>
        <th scope=""col"">Operator</th>
        <th scope=""col"">2.Sayı</th>
        <th scope=""col"">Sonuç</th>
        <th scope=""col"">Oluşturulma Tarihi</th>
    </tr>
");
#nullable restore
#line 26 "C:\Users\gcltr\source\repos\Calculator\Calculator\Views\List\Index.cshtml"
     foreach(var item in Model){

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\r\n        <td scope=\"row\">");
#nullable restore
#line 28 "C:\Users\gcltr\source\repos\Calculator\Calculator\Views\List\Index.cshtml"
                   Write(item.CalculatorId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 29 "C:\Users\gcltr\source\repos\Calculator\Calculator\Views\List\Index.cshtml"
       Write(item.Number1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 30 "C:\Users\gcltr\source\repos\Calculator\Calculator\Views\List\Index.cshtml"
       Write(item.Operator);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 31 "C:\Users\gcltr\source\repos\Calculator\Calculator\Views\List\Index.cshtml"
       Write(item.Number2);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 32 "C:\Users\gcltr\source\repos\Calculator\Calculator\Views\List\Index.cshtml"
       Write(item.Result);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 33 "C:\Users\gcltr\source\repos\Calculator\Calculator\Views\List\Index.cshtml"
       Write(item.CreateTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n");
#nullable restore
#line 35 "C:\Users\gcltr\source\repos\Calculator\Calculator\Views\List\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n<a href=\"/Calculator/Index\"><button type=\"button\" class=\"btn btn-primary btn-lg btn-block\">Hesap Makinesini Kullanmak İçin TIKLA !</button></a>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Calculator>> Html { get; private set; }
    }
}
#pragma warning restore 1591
