using CBTClient.Models.Response;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CBTClient.Component
{
    public partial class QuestionForm
    {
       
        [Parameter]
        public EventCallback OnCloseCallBack { get; set; }

        public FormWrapper modalForm { get; set; }

        [Parameter]
        public QuestionItem model { get; set; } = new QuestionItem();

        [Parameter]
        public EventCallback<QuestionItem> OnSubmitCallBack { get; set; }


        public async Task HandleSubmit()
        {
            await OnSubmitCallBack.InvokeAsync(model);
        }

        private void HandleInvalidSubmit()
        {
            Console.WriteLine("There are invalid submit. Review your entries");
        }

        protected override Task OnInitializedAsync()
        {
            return base.OnInitializedAsync();
        }

        public void CloseModal()
        {
            OnCloseCallBack.InvokeAsync(null);
        }

        public void ResetForm()
        {
           
        }
    }
}
