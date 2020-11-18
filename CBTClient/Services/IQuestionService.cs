using CBTClient.Models;
using CBTClient.Models.Request;
using CBTClient.Models.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CBTClient.Services
{
    public interface IQuestionService
    {
        Task<ResponseModelBase> CreateQuestion(QuestionRequestModel model);

        Task<ResponseModelBase> UpdateQuestion(string Id, QuestionRequestModel model);

        Task<QuestionListResponseModel> GetQuestions(int pageSize = 10, int pageNumber = 1,string subjectId = "", string difficultyLevelId = "");
    }
}
