#pragma checksum "C:\OtherProjects\EducationApp\edu-client-cbt-blazor\CBTClient\CBTClient\Component\FormWrapper.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c5020d238354ebe8b9cc5e003ff656ca52dc1bdd"
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
    public partial class FormWrapper : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 2 "C:\OtherProjects\EducationApp\edu-client-cbt-blazor\CBTClient\CBTClient\Component\FormWrapper.razor"
 if (Show)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "    ");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "modal fade show");
            __builder.AddAttribute(3, "id", "exampleModal");
            __builder.AddAttribute(4, "tabindex", "-1");
            __builder.AddAttribute(5, "role", "dialog");
            __builder.AddAttribute(6, "aria-labelledby", "exampleModalLabel");
            __builder.AddAttribute(7, "style", "display: block; padding-right: 17px;");
            __builder.AddMarkupContent(8, "\r\n        ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "modal-dialog");
            __builder.AddAttribute(11, "role", "document");
            __builder.AddMarkupContent(12, "\r\n            ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "modal-content");
            __builder.AddMarkupContent(15, "\r\n                ");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "modal-header");
            __builder.AddMarkupContent(18, "\r\n                    ");
            __builder.OpenElement(19, "h5");
            __builder.AddAttribute(20, "class", "modal-title");
            __builder.AddAttribute(21, "id", "exampleModalLabel");
            __builder.AddContent(22, 
#nullable restore
#line 8 "C:\OtherProjects\EducationApp\edu-client-cbt-blazor\CBTClient\CBTClient\Component\FormWrapper.razor"
                                                                    Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n                    ");
            __builder.OpenElement(24, "a");
            __builder.AddAttribute(25, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 9 "C:\OtherProjects\EducationApp\edu-client-cbt-blazor\CBTClient\CBTClient\Component\FormWrapper.razor"
                                 HideModal

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(26, "class", "close");
            __builder.AddAttribute(27, "data-dismiss", "modal");
            __builder.AddAttribute(28, "aria-label", "Close");
            __builder.AddMarkupContent(29, "\r\n                        ");
            __builder.AddMarkupContent(30, "<span aria-hidden=\"true\">×</span>\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n\r\n                ");
            __builder.AddContent(33, 
#nullable restore
#line 14 "C:\OtherProjects\EducationApp\edu-client-cbt-blazor\CBTClient\CBTClient\Component\FormWrapper.razor"
                 ChildContent

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(34, "\r\n\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n");
#nullable restore
#line 19 "C:\OtherProjects\EducationApp\edu-client-cbt-blazor\CBTClient\CBTClient\Component\FormWrapper.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 22 "C:\OtherProjects\EducationApp\edu-client-cbt-blazor\CBTClient\CBTClient\Component\FormWrapper.razor"
       

    public bool Show { get; set; }


    [Parameter]
    public string Title { get; set; }

    [Parameter]
    public RenderFragment ChildContent { get; set; }

    public void ShowModal()
    {
        Show = true;
        StateHasChanged();
    }

    public void HideModal()
    {
        Show = false;
        StateHasChanged();
    }




#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
