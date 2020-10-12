using CBTClient.Models.Response;
using CBTClient.Services;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CBTClient.Pages
{
    public partial class Questions
    {

        [Inject]
        private IQuestionService _questionService { get; set; }

        [Inject]
        private IDataService _dataService { get; set; }

        
        public PredefinedDataResponseModel Data { get; set; }

        public List<QuestionResponseModel> QuestionCol { get; set; } = new List<QuestionResponseModel>();

        protected override async Task OnInitializedAsync()
        {
             Data = await _dataService.GetPredefinedData();

        }
    }
}
