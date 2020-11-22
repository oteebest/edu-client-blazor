using CBTClient.Models.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CBTClient.Util;
using Microsoft.AspNetCore.Components;
using CBTClient.Models;

namespace CBTClient.Component
{
    public partial class QuestionManager
    {
        
        public QuestionManagerModel question { get; set; }

        [Parameter]
        public List<SubjectResponseModel> SubjectList { get; set; }

        [Parameter]
        public List<DifficultLevelResponseModel> DifficultytList { get; set; }

        [Parameter]
        public string QuestionType { get; set; }

        [Parameter]
        public string QuestionId { get; set; }

        [Parameter]
        public EventCallback<QuestionManagerModel> OnSubmitCallBack { get; set; }

        private void SwitchMode(Utility.QuestionState mode)
        {
            question.State = mode;

            StateHasChanged();
        }

        private async Task HandleSubmit(QuestionManagerModel question)
        {
            await OnSubmitCallBack.InvokeAsync(question);
        }

        private void HandleChange()
        {

        }

        private void AddOption()
        {

        }


  

        protected override Task OnInitializedAsync()
        {
            question = new QuestionManagerModel
            {
                QuestionType = QuestionType,
                State = Utility.QuestionState.Question
                
            };

            // set default options
            if (string.IsNullOrEmpty(QuestionId))
            {
                question.Options.AddRange(new List<QuestionManagerOptionsModel> {
                        new QuestionManagerOptionsModel {IsDefault = true, TemporaryId = 1 , Text = "choice #1"  },
                        new QuestionManagerOptionsModel {IsDefault = true, TemporaryId = 2 , Text = "choice #2" },
                        new QuestionManagerOptionsModel {IsDefault = true, TemporaryId = 3 , Text = "choice #3" } });
            }
            
            return base.OnInitializedAsync();
        }

        private void RemoveOption(int optionId)
        {

        }
    }
}
