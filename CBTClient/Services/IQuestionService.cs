using CBTClient.Models;
using CBTClient.Models.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CBTClient.Services
{
    public interface IQuestionService
    {
        Task<QuestionResponseModel> CreateQuestion(QuestionRequestModel model);

        Task<QuestionResponseModel> UpdateQuestion(string Id, QuestionRequestModel model);

    }
}
