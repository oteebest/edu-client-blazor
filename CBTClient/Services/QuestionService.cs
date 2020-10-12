using CBTClient.Models;
using CBTClient.Models.Request;
using CBTClient.Models.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace CBTClient.Services
{
    public class QuestionService : IQuestionService
    {
        private readonly HttpClient _httpClient;

        public QuestionService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public Task<QuestionResponseModel> CreateQuestion(QuestionRequestModel model)
        {
            throw new NotImplementedException();
        }

        public Task<QuestionResponseModel> UpdateQuestion(string Id, QuestionRequestModel model)
        {
            throw new NotImplementedException();
        }
    }
}
