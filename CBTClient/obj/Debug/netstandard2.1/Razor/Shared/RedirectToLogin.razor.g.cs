#pragma checksum "C:\OtherProjects\EducationApp\edu-client-cbt-blazor\CBTClient\CBTClient\Shared\RedirectToLogin.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e5e7efb7d32795f074538627c86173498074b2ea"
// <auto-generated/>
#pragma warning disable 1591
namespace CBTClient.Shared
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
    public partial class RedirectToLogin : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 3 "C:\OtherProjects\EducationApp\edu-client-cbt-blazor\CBTClient\CBTClient\Shared\RedirectToLogin.razor"
       
    protected override void OnInitialized()
    {
        Navigation.NavigateTo($"authentication/login?returnUrl=" +
            $"{Uri.EscapeDataString(Navigation.Uri)}");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager Navigation { get; set; }
    }
}
#pragma warning restore 1591
