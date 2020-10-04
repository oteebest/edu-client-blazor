using CBTClient.Models;
using CBTClient.Models.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CBTClient.Services
{
    public interface IAssessmentService
    {
        Task<AssessmentResponseModel> CreateAssessment(AssessmentRequestModel model);

        Task<AssessmentResponseModel> UpdateAssessment(string Id, AssessmentRequestModel model);

        Task<List<QuestionResponseModel>> GetAssesments();

    }
}
