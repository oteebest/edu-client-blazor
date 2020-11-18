#pragma checksum "C:\OtherProjects\EducationApp\edu-client-cbt-blazor\CBTClient\CBTClient\Component\PagingTemplate.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b4c7b69e88d29e7cbd384ad6046d71ea28620460"
// <auto-generated/>
#pragma warning disable 1591
namespace CBTClient.Component
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\OtherProjects\EducationApp\edu-client-cbt-blazor\CBTClient\CBTClient\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\OtherProjects\EducationApp\edu-client-cbt-blazor\CBTClient\CBTClient\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\OtherProjects\EducationApp\edu-client-cbt-blazor\CBTClient\CBTClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\OtherProjects\EducationApp\edu-client-cbt-blazor\CBTClient\CBTClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\OtherProjects\EducationApp\edu-client-cbt-blazor\CBTClient\CBTClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\OtherProjects\EducationApp\edu-client-cbt-blazor\CBTClient\CBTClient\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\OtherProjects\EducationApp\edu-client-cbt-blazor\CBTClient\CBTClient\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\OtherProjects\EducationApp\edu-client-cbt-blazor\CBTClient\CBTClient\_Imports.razor"
using CBTClient;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\OtherProjects\EducationApp\edu-client-cbt-blazor\CBTClient\CBTClient\_Imports.razor"
using CBTClient.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\OtherProjects\EducationApp\edu-client-cbt-blazor\CBTClient\CBTClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\OtherProjects\EducationApp\edu-client-cbt-blazor\CBTClient\CBTClient\_Imports.razor"
using CBTClient.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\OtherProjects\EducationApp\edu-client-cbt-blazor\CBTClient\CBTClient\_Imports.razor"
using CBTClient.Models.Request;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\OtherProjects\EducationApp\edu-client-cbt-blazor\CBTClient\CBTClient\_Imports.razor"
using CBTClient.Models.Response;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\OtherProjects\EducationApp\edu-client-cbt-blazor\CBTClient\CBTClient\_Imports.razor"
using CBTClient.Component;

#line default
#line hidden
#nullable disable
    public partial class PagingTemplate : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "nav");
            __builder.AddAttribute(1, "aria-label", "Page navigation example");
            __builder.AddMarkupContent(2, "\r\n\r\n    ");
            __builder.OpenElement(3, "ul");
            __builder.AddAttribute(4, "class", "pagination justify-content-center");
            __builder.AddMarkupContent(5, "\r\n\r\n");
#nullable restore
#line 6 "C:\OtherProjects\EducationApp\edu-client-cbt-blazor\CBTClient\CBTClient\Component\PagingTemplate.razor"
         if (PagerEnablePrevious)
        {
            if (PageNumberParam - 1 == PagerStartIndex)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(6, "                ");
            __builder.OpenElement(7, "li");
            __builder.AddAttribute(8, "class", "page-item");
            __builder.AddAttribute(9, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 10 "C:\OtherProjects\EducationApp\edu-client-cbt-blazor\CBTClient\CBTClient\Component\PagingTemplate.razor"
                                                (() => LoadData(PageNumberParam - 1, true))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(10, "\r\n                    ");
            __builder.AddMarkupContent(11, "<a class=\"page-link\">Previous</a>\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n");
#nullable restore
#line 13 "C:\OtherProjects\EducationApp\edu-client-cbt-blazor\CBTClient\CBTClient\Component\PagingTemplate.razor"
            }
            else
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(13, "                ");
            __builder.OpenElement(14, "li");
            __builder.AddAttribute(15, "class", "page-item");
            __builder.AddAttribute(16, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 16 "C:\OtherProjects\EducationApp\edu-client-cbt-blazor\CBTClient\CBTClient\Component\PagingTemplate.razor"
                                                (() => LoadData(PageNumberParam - 1, false))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(17, "\r\n                    ");
            __builder.AddMarkupContent(18, "<a class=\"page-link\">Previous</a>\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n");
#nullable restore
#line 19 "C:\OtherProjects\EducationApp\edu-client-cbt-blazor\CBTClient\CBTClient\Component\PagingTemplate.razor"
            }

        }
        else
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(20, "            ");
            __builder.AddMarkupContent(21, "<li class=\"page-item disabled\">\r\n                <span class=\"page-link\">Previous</span>\r\n            </li>\r\n");
#nullable restore
#line 27 "C:\OtherProjects\EducationApp\edu-client-cbt-blazor\CBTClient\CBTClient\Component\PagingTemplate.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(22, "\r\n\r\n");
#nullable restore
#line 30 "C:\OtherProjects\EducationApp\edu-client-cbt-blazor\CBTClient\CBTClient\Component\PagingTemplate.razor"
         for (int j = PagerStartIndex; j <= PagerEndIndex; j++)
        {
            int pageNumber = j + 1;

            if (j == CurrentIndex)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(23, "                ");
            __builder.OpenElement(24, "li");
            __builder.AddAttribute(25, "class", "page-item active");
            __builder.AddMarkupContent(26, "\r\n                    ");
            __builder.OpenElement(27, "a");
            __builder.AddAttribute(28, "class", "page-link");
            __builder.AddContent(29, 
#nullable restore
#line 37 "C:\OtherProjects\EducationApp\edu-client-cbt-blazor\CBTClient\CBTClient\Component\PagingTemplate.razor"
                                          pageNumber

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n");
#nullable restore
#line 39 "C:\OtherProjects\EducationApp\edu-client-cbt-blazor\CBTClient\CBTClient\Component\PagingTemplate.razor"
            }
            else
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(32, "                ");
            __builder.OpenElement(33, "li");
            __builder.AddAttribute(34, "class", "page-item");
            __builder.AddAttribute(35, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 42 "C:\OtherProjects\EducationApp\edu-client-cbt-blazor\CBTClient\CBTClient\Component\PagingTemplate.razor"
                                                (() => LoadData(pageNumber,false) )

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(36, "\r\n                    ");
            __builder.OpenElement(37, "a");
            __builder.AddAttribute(38, "class", "page-link");
            __builder.AddContent(39, 
#nullable restore
#line 43 "C:\OtherProjects\EducationApp\edu-client-cbt-blazor\CBTClient\CBTClient\Component\PagingTemplate.razor"
                                          pageNumber

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n");
#nullable restore
#line 45 "C:\OtherProjects\EducationApp\edu-client-cbt-blazor\CBTClient\CBTClient\Component\PagingTemplate.razor"
            }


        }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(42, "\r\n\r\n\r\n");
#nullable restore
#line 52 "C:\OtherProjects\EducationApp\edu-client-cbt-blazor\CBTClient\CBTClient\Component\PagingTemplate.razor"
         if (PagerEnableNext)
        {
            if (PageNumberParam - 1 == PagerEndIndex)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(43, "                ");
            __builder.OpenElement(44, "li");
            __builder.AddAttribute(45, "class", "page-item");
            __builder.AddAttribute(46, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 56 "C:\OtherProjects\EducationApp\edu-client-cbt-blazor\CBTClient\CBTClient\Component\PagingTemplate.razor"
                                                (() => LoadData(PageNumberParam + 1, true))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(47, "\r\n                    ");
            __builder.AddMarkupContent(48, "<a class=\"page-link\">Next</a>\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n");
#nullable restore
#line 59 "C:\OtherProjects\EducationApp\edu-client-cbt-blazor\CBTClient\CBTClient\Component\PagingTemplate.razor"
            }
            else
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(50, "                ");
            __builder.OpenElement(51, "li");
            __builder.AddAttribute(52, "class", "page-item");
            __builder.AddAttribute(53, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 62 "C:\OtherProjects\EducationApp\edu-client-cbt-blazor\CBTClient\CBTClient\Component\PagingTemplate.razor"
                                                (() => LoadData(PageNumberParam + 1, false))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(54, "\r\n                    ");
            __builder.AddMarkupContent(55, "<a class=\"page-link\">Next</a>\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n");
#nullable restore
#line 65 "C:\OtherProjects\EducationApp\edu-client-cbt-blazor\CBTClient\CBTClient\Component\PagingTemplate.razor"
            }

        }
        else
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(57, "            ");
            __builder.AddMarkupContent(58, "<li class=\"page-item disabled\">\r\n                <a class=\"page-link\" href=\"#\">Next</a>\r\n            </li>\r\n");
#nullable restore
#line 73 "C:\OtherProjects\EducationApp\edu-client-cbt-blazor\CBTClient\CBTClient\Component\PagingTemplate.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(59, "\r\n\r\n\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591