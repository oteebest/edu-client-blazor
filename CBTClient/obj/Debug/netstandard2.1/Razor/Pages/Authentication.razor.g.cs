#pragma checksum "C:\OtherProjects\EducationApp\edu-client-cbt-blazor\CBTClient\CBTClient\Pages\Authentication.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2c3c7568203cc9520635e297a0f3ad27cd35765a"
// <auto-generated/>
#pragma warning disable 1591
namespace CBTClient.Pages
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
#nullable restore
#line 2 "C:\OtherProjects\EducationApp\edu-client-cbt-blazor\CBTClient\CBTClient\Pages\Authentication.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/authentication/{action}")]
    public partial class Authentication : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.WebAssembly.Authentication.RemoteAuthenticatorView>(0);
            __builder.AddAttribute(1, "Action", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 3 "C:\OtherProjects\EducationApp\edu-client-cbt-blazor\CBTClient\CBTClient\Pages\Authentication.razor"
                                      Action

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "LoggingIn", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(3, "\r\n            ");
                __builder2.AddMarkupContent(4, "<h1>We\'re logging you in, please wait...</h1>\r\n        ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 9 "C:\OtherProjects\EducationApp\edu-client-cbt-blazor\CBTClient\CBTClient\Pages\Authentication.razor"
      
    [Parameter] public string Action { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
