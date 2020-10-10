using CBTClient.Component;
using CBTClient.Models.Request;
using CBTClient.Models.Response;
using CBTClient.Services;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CBTClient.Pages
{
    public partial class Assess
    {
       
        private string searchText = "";

        private string AssessmentId { get; set; }

        public List<AssessmentItem> assessments { get; set; } = new List<AssessmentItem>();

        public List<AssessmentItem> clientAssessments { get; set; } = new List<AssessmentItem>();

        public FormWrapper modalForm { get; set; }

        [Inject]
        public IAssessmentService _assessmentService { get; set; }

        protected override async Task OnInitializedAsync()
        {
            var response = await _assessmentService.GetAssesments();

            if (response.isSuccessful)
            {
                assessments = response.data;

                clientAssessments = assessments.ToList() ;
            }
            else
            {
                Console.Write(response.message);
            }
        }

        private void ShowModal()
        {
            modalForm.ShowModal();
        }

        private async Task HandleSubmit(AssessmentRequestModel model)
        {
            AssessmentResponseModel response;

            if(string.IsNullOrEmpty(AssessmentId))
            {
                response =  await _assessmentService.CreateAssessment(model);
            }
            else
            {
                response = await _assessmentService.UpdateAssessment(AssessmentId, model);
            }

            if(response.isSuccessful)
            {
               var assessmentItem = response.data;

               assessments =  assessments.Prepend(assessmentItem).ToList();

               RefreshAssessments(searchText);
               StateHasChanged();
            }
            else
            {
                Console.WriteLine(response.message);
            }

        }

        private void HandleClose()
        {
            modalForm.HideModal();
        }

        private void Search(ChangeEventArgs e)
        {
            searchText = e.Value.ToString();

            RefreshAssessments(searchText);

        }

        private void RefreshAssessments(string searchText)
        {            

            if (!string.IsNullOrEmpty(searchText))
            {
                clientAssessments = assessments.Where(u => u.Name.Contains(searchText)).ToList();

                StateHasChanged();
            }
            else
            {
                clientAssessments = assessments.ToList();

                StateHasChanged();
            }
        }
    }
}
