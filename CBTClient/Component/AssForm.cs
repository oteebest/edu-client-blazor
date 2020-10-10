using CBTClient.Models.Request;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CBTClient.Component
{
    public partial class AssForm
    {

        public AssessmentRequestModel model { get; set; } = new AssessmentRequestModel();

        [Parameter]
        public EventCallback<AssessmentRequestModel> OnSubmitCallBack { get; set; }
        
        [Parameter]
        public EventCallback OnCloseCallBack { get; set; }

        public FormWrapper modalForm { get; set; }

        public async Task HandleSubmit()
        {
           await OnSubmitCallBack.InvokeAsync(model);
        }

        protected override Task OnInitializedAsync()
        {
            return base.OnInitializedAsync();
        }

        public void CloseModal()
        {
            OnCloseCallBack.InvokeAsync(null);
        }

    }
}
