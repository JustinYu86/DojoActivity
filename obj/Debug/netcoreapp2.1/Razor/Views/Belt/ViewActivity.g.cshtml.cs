#pragma checksum "C:\Users\ytk\Desktop\CSharpBelt\Views\Belt\ViewActivity.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "96994267d2e8734f10897327a8988d222d0b2c23"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Belt_ViewActivity), @"mvc.1.0.view", @"/Views/Belt/ViewActivity.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Belt/ViewActivity.cshtml", typeof(AspNetCore.Views_Belt_ViewActivity))]
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
#line 1 "C:\Users\ytk\Desktop\CSharpBelt\Views\_ViewImports.cshtml"
using CSharpBelt;

#line default
#line hidden
#line 2 "C:\Users\ytk\Desktop\CSharpBelt\Views\_ViewImports.cshtml"
using CSharpBelt.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"96994267d2e8734f10897327a8988d222d0b2c23", @"/Views/Belt/ViewActivity.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d8fc45ca57f482f0e439930ed604d9b20ad5fb5", @"/Views/_ViewImports.cshtml")]
    public class Views_Belt_ViewActivity : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Dashboard>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(18, 148, true);
            WriteLiteral("\r\n<h1>Dojo Activity Center</h1>\r\n\r\n<a style=\"float: right\" href=\"/Dashboard\"> Home</a>\r\n<a style=\"float: right\" href=\"/logout\">Logout  |</a>\r\n<hr>\r\n");
            EndContext();
#line 8 "C:\Users\ytk\Desktop\CSharpBelt\Views\Belt\ViewActivity.cshtml"
 foreach(var item in Model.allActivities)
{

#line default
#line hidden
            BeginContext(212, 8, true);
            WriteLiteral("    <h1>");
            EndContext();
            BeginContext(221, 10, false);
#line 10 "C:\Users\ytk\Desktop\CSharpBelt\Views\Belt\ViewActivity.cshtml"
   Write(item.Title);

#line default
#line hidden
            EndContext();
            BeginContext(231, 7, true);
            WriteLiteral("</h1>\r\n");
            EndContext();
#line 12 "C:\Users\ytk\Desktop\CSharpBelt\Views\Belt\ViewActivity.cshtml"
                     if(Model.User.UserId == item.UserId)
                    {

#line default
#line hidden
            BeginContext(338, 26, true);
            WriteLiteral("                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 364, "\"", 395, 2);
            WriteAttributeValue("", 371, "/delete/", 371, 8, true);
#line 14 "C:\Users\ytk\Desktop\CSharpBelt\Views\Belt\ViewActivity.cshtml"
WriteAttributeValue("", 379, item.ActivityId, 379, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(396, 13, true);
            WriteLiteral(">Delete</a>\r\n");
            EndContext();
#line 15 "C:\Users\ytk\Desktop\CSharpBelt\Views\Belt\ViewActivity.cshtml"
                    }

#line default
#line hidden
#line 15 "C:\Users\ytk\Desktop\CSharpBelt\Views\Belt\ViewActivity.cshtml"
                     
                    bool contained = false;
                    

#line default
#line hidden
#line 17 "C:\Users\ytk\Desktop\CSharpBelt\Views\Belt\ViewActivity.cshtml"
                     foreach(var i in item.Participants)
                    {
                        if(Model.User.UserId == i.ParticipatingUsers.UserId)
                        {
                            contained = true;
                        }
                    }

#line default
#line hidden
#line 24 "C:\Users\ytk\Desktop\CSharpBelt\Views\Belt\ViewActivity.cshtml"
                     if(contained == true && Model.User.UserId != item.UserId)
                    {

#line default
#line hidden
            BeginContext(863, 26, true);
            WriteLiteral("                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 889, "\"", 919, 2);
            WriteAttributeValue("", 896, "/leave/", 896, 7, true);
#line 26 "C:\Users\ytk\Desktop\CSharpBelt\Views\Belt\ViewActivity.cshtml"
WriteAttributeValue("", 903, item.ActivityId, 903, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(920, 12, true);
            WriteLiteral(">Leave</a>\r\n");
            EndContext();
#line 27 "C:\Users\ytk\Desktop\CSharpBelt\Views\Belt\ViewActivity.cshtml"
                    }

#line default
#line hidden
#line 28 "C:\Users\ytk\Desktop\CSharpBelt\Views\Belt\ViewActivity.cshtml"
                     if(contained == false && item.UserId != Model.User.UserId)
                    {

#line default
#line hidden
            BeginContext(1059, 26, true);
            WriteLiteral("                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1085, "\"", 1114, 2);
            WriteAttributeValue("", 1092, "/join/", 1092, 6, true);
#line 30 "C:\Users\ytk\Desktop\CSharpBelt\Views\Belt\ViewActivity.cshtml"
WriteAttributeValue("", 1098, item.ActivityId, 1098, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1115, 11, true);
            WriteLiteral(">Join</a>\r\n");
            EndContext();
#line 31 "C:\Users\ytk\Desktop\CSharpBelt\Views\Belt\ViewActivity.cshtml"
                    }

#line default
#line hidden
            BeginContext(1167, 16, true);
            WriteLiteral("<h3>Coordinator:");
            EndContext();
            BeginContext(1184, 19, false);
#line 33 "C:\Users\ytk\Desktop\CSharpBelt\Views\Belt\ViewActivity.cshtml"
           Write(item.User.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(1203, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(1205, 18, false);
#line 33 "C:\Users\ytk\Desktop\CSharpBelt\Views\Belt\ViewActivity.cshtml"
                                Write(item.User.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(1223, 8, true);
            WriteLiteral("</h3> \r\n");
            EndContext();
            BeginContext(1233, 16, true);
            WriteLiteral("<h3>Description:");
            EndContext();
            BeginContext(1250, 16, false);
#line 35 "C:\Users\ytk\Desktop\CSharpBelt\Views\Belt\ViewActivity.cshtml"
           Write(item.Description);

#line default
#line hidden
            EndContext();
            BeginContext(1266, 16, true);
            WriteLiteral("</h3>\r\n<p></p>\r\n");
            EndContext();
            BeginContext(1284, 24, true);
            WriteLiteral("<h3>Participants:</h3>\r\n");
            EndContext();
#line 39 "C:\Users\ytk\Desktop\CSharpBelt\Views\Belt\ViewActivity.cshtml"
     foreach(var i in item.Participants)
    {

#line default
#line hidden
            BeginContext(1357, 7, true);
            WriteLiteral("    <p>");
            EndContext();
            BeginContext(1365, 30, false);
#line 41 "C:\Users\ytk\Desktop\CSharpBelt\Views\Belt\ViewActivity.cshtml"
  Write(i.ParticipatingUsers.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(1395, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(1397, 29, false);
#line 41 "C:\Users\ytk\Desktop\CSharpBelt\Views\Belt\ViewActivity.cshtml"
                                  Write(i.ParticipatingUsers.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(1426, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 42 "C:\Users\ytk\Desktop\CSharpBelt\Views\Belt\ViewActivity.cshtml"
    }

#line default
#line hidden
#line 42 "C:\Users\ytk\Desktop\CSharpBelt\Views\Belt\ViewActivity.cshtml"
     
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Dashboard> Html { get; private set; }
    }
}
#pragma warning restore 1591
