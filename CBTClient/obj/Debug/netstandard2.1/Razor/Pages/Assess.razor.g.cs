#pragma checksum "C:\OtherProjects\EducationApp\edu-client-cbt-blazor\CBTClient\CBTClient\Pages\Assess.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2fe086d66bd83930f75a4ba7f8dd6a4116393816"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/asses")]
    public partial class Assess : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<CBTClient.Shared.PageHeader>(0);
            __builder.AddAttribute(1, "PageHeaderTile", "Assessments");
            __builder.CloseComponent();
            __builder.AddMarkupContent(2, "\r\n\r\n");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "row");
            __builder.AddMarkupContent(5, "\r\n    ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "col-xl-12 col-lg-12 col-md-12 col-sm-12 col-12");
            __builder.AddMarkupContent(8, "\r\n\r\n        ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "card");
            __builder.AddMarkupContent(11, "\r\n            ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "card-header");
            __builder.AddMarkupContent(14, "\r\n\r\n                ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", true);
            __builder.AddMarkupContent(17, "\r\n                    ");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "form-row");
            __builder.AddMarkupContent(20, "\r\n                        ");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "col-7");
            __builder.AddMarkupContent(23, "\r\n                            ");
            __builder.OpenElement(24, "input");
            __builder.AddAttribute(25, "placeholder", "Search name");
            __builder.AddAttribute(26, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 14 "C:\OtherProjects\EducationApp\edu-client-cbt-blazor\CBTClient\CBTClient\Pages\Assess.razor"
                                                                       Search

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(27, "class", "form-control");
            __builder.AddAttribute(28, "value", 
#nullable restore
#line 14 "C:\OtherProjects\EducationApp\edu-client-cbt-blazor\CBTClient\CBTClient\Pages\Assess.razor"
                                                                                                            SearchText

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n                        ");
            __builder.OpenElement(31, "div");
            __builder.AddAttribute(32, "class", "col");
            __builder.AddMarkupContent(33, "\r\n                        ");
            __builder.OpenElement(34, "button");
            __builder.AddAttribute(35, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 17 "C:\OtherProjects\EducationApp\edu-client-cbt-blazor\CBTClient\CBTClient\Pages\Assess.razor"
                                          ShowModal

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(36, "class", "btn btn-primary btn-sm float-right");
            __builder.AddAttribute(37, "id", "btnCreate");
            __builder.AddContent(38, "Create Assessment");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n                       \r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n            ");
            __builder.OpenElement(44, "div");
            __builder.AddAttribute(45, "class", "card-body");
            __builder.AddMarkupContent(46, "\r\n                ");
            __builder.OpenElement(47, "div");
            __builder.AddAttribute(48, "class", "table-responsive");
            __builder.AddMarkupContent(49, "\r\n                    ");
            __builder.OpenElement(50, "table");
            __builder.AddAttribute(51, "class", "table table-striped table-bordered first");
            __builder.AddMarkupContent(52, "\r\n                        ");
            __builder.AddMarkupContent(53, @"<thead>
                            <tr>
                                <th scope=""col"">Name</th>
                                <th scope=""col"">Duration</th>
                                <th scope=""col"">Created</th>
                                <th scope=""col""></th>
                                <th scope=""col""></th>
                            </tr>
                        </thead>
                        ");
            __builder.OpenElement(54, "tbody");
            __builder.AddMarkupContent(55, "\r\n\r\n");
#nullable restore
#line 37 "C:\OtherProjects\EducationApp\edu-client-cbt-blazor\CBTClient\CBTClient\Pages\Assess.razor"
                             foreach (var assessment in ClientAssessments)
                            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(56, "                                ");
            __builder.OpenElement(57, "tr");
            __builder.AddMarkupContent(58, "\r\n\r\n                                    ");
            __builder.OpenElement(59, "td");
            __builder.AddContent(60, 
#nullable restore
#line 41 "C:\OtherProjects\EducationApp\edu-client-cbt-blazor\CBTClient\CBTClient\Pages\Assess.razor"
                                         assessment.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n                                    ");
            __builder.OpenElement(62, "td");
            __builder.AddContent(63, 
#nullable restore
#line 42 "C:\OtherProjects\EducationApp\edu-client-cbt-blazor\CBTClient\CBTClient\Pages\Assess.razor"
                                         assessment.Duration

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\r\n                                    ");
            __builder.OpenElement(65, "td");
            __builder.AddContent(66, 
#nullable restore
#line 43 "C:\OtherProjects\EducationApp\edu-client-cbt-blazor\CBTClient\CBTClient\Pages\Assess.razor"
                                         assessment.CreatedOn.ToString("dd/MM/yyyy")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n                                    ");
            __builder.OpenElement(68, "td");
            __builder.AddMarkupContent(69, "\r\n                                        ");
            __builder.OpenElement(70, "button");
            __builder.AddAttribute(71, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 45 "C:\OtherProjects\EducationApp\edu-client-cbt-blazor\CBTClient\CBTClient\Pages\Assess.razor"
                                                          (() => OpenForEdit(assessment.Id))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(72, "class", "btn btn-primary btn-xs");
            __builder.AddContent(73, "Edit");
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n                                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(75, "\r\n                                    ");
            __builder.OpenElement(76, "td");
            __builder.AddMarkupContent(77, "\r\n                                        ");
            __builder.OpenElement(78, "button");
            __builder.AddAttribute(79, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 48 "C:\OtherProjects\EducationApp\edu-client-cbt-blazor\CBTClient\CBTClient\Pages\Assess.razor"
                                                          (() => ConfirmDelete(assessment.Id))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(80, "class", "btn btn-danger btn-xs");
            __builder.AddContent(81, "Delete");
            __builder.CloseElement();
            __builder.AddMarkupContent(82, "\r\n                                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(83, "\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(84, "\r\n");
#nullable restore
#line 51 "C:\OtherProjects\EducationApp\edu-client-cbt-blazor\CBTClient\CBTClient\Pages\Assess.razor"
                            }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(85, "\r\n\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(86, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(87, "\r\n                    ");
            __builder.OpenComponent<CBTClient.Component.ConfirmDialog>(88);
            __builder.AddAttribute(89, "ConfirmationTitle", "Delete Assessment");
            __builder.AddAttribute(90, "ConfirmationChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 56 "C:\OtherProjects\EducationApp\edu-client-cbt-blazor\CBTClient\CBTClient\Pages\Assess.razor"
                                                                                                                   DeleteItem

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(91, "ConfirmationMessage", "Are you sure you want to delete this entry?");
            __builder.AddComponentReferenceCapture(92, (__value) => {
#nullable restore
#line 56 "C:\OtherProjects\EducationApp\edu-client-cbt-blazor\CBTClient\CBTClient\Pages\Assess.razor"
                                         ConfirmDialog = (CBTClient.Component.ConfirmDialog)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(93, "\r\n                    ");
            __builder.OpenComponent<CBTClient.Component.FormWrapper>(94);
            __builder.AddAttribute(95, "Title", "Assessment");
            __builder.AddAttribute(96, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(97, "\r\n                        ");
                __builder2.OpenComponent<CBTClient.Component.AssForm>(98);
                __builder2.AddAttribute(99, "model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<CBTClient.Models.Response.AssessmentItem>(
#nullable restore
#line 58 "C:\OtherProjects\EducationApp\edu-client-cbt-blazor\CBTClient\CBTClient\Pages\Assess.razor"
                                         AssessmentItem

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(100, "OnCloseCallBack", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 58 "C:\OtherProjects\EducationApp\edu-client-cbt-blazor\CBTClient\CBTClient\Pages\Assess.razor"
                                                                                                 HandleClose

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(101, "OnSubmitCallBack", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<CBTClient.Models.Response.AssessmentItem>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<CBTClient.Models.Response.AssessmentItem>(this, 
#nullable restore
#line 58 "C:\OtherProjects\EducationApp\edu-client-cbt-blazor\CBTClient\CBTClient\Pages\Assess.razor"
                                                                                                                                HandleSubmit

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddComponentReferenceCapture(102, (__value) => {
#nullable restore
#line 58 "C:\OtherProjects\EducationApp\edu-client-cbt-blazor\CBTClient\CBTClient\Pages\Assess.razor"
                                                                AssessmentForm = (CBTClient.Component.AssForm)__value;

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(103, "\r\n                    ");
            }
            ));
            __builder.AddComponentReferenceCapture(104, (__value) => {
#nullable restore
#line 57 "C:\OtherProjects\EducationApp\edu-client-cbt-blazor\CBTClient\CBTClient\Pages\Assess.razor"
                                       ModalForm = (CBTClient.Component.FormWrapper)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(105, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(106, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(107, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(108, "\r\n\r\n\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(109, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591