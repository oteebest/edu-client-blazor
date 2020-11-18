#pragma checksum "C:\OtherProjects\EducationApp\edu-client-cbt-blazor\CBTClient\CBTClient\Component\QuestionForm.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "634dfec5ee518015da8c5b3a37c26efc6097f5af"
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
    public partial class QuestionForm : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 2 "C:\OtherProjects\EducationApp\edu-client-cbt-blazor\CBTClient\CBTClient\Component\QuestionForm.razor"
                  model

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(3, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(4);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(5, "\r\n\r\n    ");
                __builder2.AddMarkupContent(6, @"<div class=""card-header pills-regular"">
        <ul class=""nav nav-pills card-header-pills"" id=""myTab2"" role=""tablist"">
            <li class=""nav-item"">
                <a class=""nav-link active"" id=""card-pills-1"" data-toggle=""tab"" href=""#card-pill-1"" role=""tab"" aria-controls=""card-1"" aria-selected=""true"">
                    Single Choice Question
                </a>
            </li>
            <li class=""nav-item"">
                <a class=""nav-link"" id=""card-pills-2"" data-toggle=""tab"" href=""#card-pill-2"" role=""tab"" aria-controls=""card-2"" aria-selected=""false"">
                    Multiple Choice Question
                </a>
            </li>
        </ul>
    </div>
    ");
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "tab-content");
                __builder2.AddAttribute(9, "id", "myTabContent2");
                __builder2.AddMarkupContent(10, "\r\n        ");
                __builder2.OpenElement(11, "div");
                __builder2.AddAttribute(12, "class", "tab-pane fade show active");
                __builder2.AddAttribute(13, "id", "card-pill-1");
                __builder2.AddAttribute(14, "role", "tabpanel");
                __builder2.AddAttribute(15, "aria-labelledby", "card-tab-1");
                __builder2.AddMarkupContent(16, "\r\n            ");
                __builder2.OpenComponent<CBTClient.Component.QuestionManager>(17);
                __builder2.AddAttribute(18, "PredefinedData", "{predefinedData}");
                __builder2.AddAttribute(19, "QuestionType", "SingleChoice");
                __builder2.AddAttribute(20, "handleSubmit", "{handleSubmit}");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(21, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(22, "\r\n        ");
                __builder2.OpenElement(23, "div");
                __builder2.AddAttribute(24, "class", "tab-pane fade");
                __builder2.AddAttribute(25, "id", "card-pill-2");
                __builder2.AddAttribute(26, "role", "tabpanel");
                __builder2.AddAttribute(27, "aria-labelledby", "card-tab-2");
                __builder2.AddMarkupContent(28, "\r\n            ");
                __builder2.OpenComponent<CBTClient.Component.QuestionManager>(29);
                __builder2.AddAttribute(30, "PredefinedData", "{predefinedData}");
                __builder2.AddAttribute(31, "QuestionType", "MultipleChoice");
                __builder2.AddAttribute(32, "handleSubmit", "{handleSubmit}");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(33, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(34, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(35, "\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591