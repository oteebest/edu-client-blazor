using CBTClient.Models.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CBTClient.Util;
using Microsoft.AspNetCore.Components;

namespace CBTClient.Component
{
    public partial class QuestionManager
    {
        public QuestionItem question { get; set; } = new QuestionItem();

        [Parameter]
        public List<SubjectResponseModel> SubjectList { get; set; }

        [Parameter]
        public List<DifficultLevelResponseModel> DifficultytList { get; set; }



        private void SwitchMode(Utility.QuestionState mode)
        {
            question.State = mode;

            StateHasChanged();
        }

        private void HandleSubmit(QuestionItem question)
        {

        }

        private void HandleChange()
        {

        }

        private void AddOption()
        {

        }

    }
}
