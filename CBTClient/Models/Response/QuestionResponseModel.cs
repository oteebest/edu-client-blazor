using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CBTClient.Models.Request;

namespace CBTClient.Models.Response
{
    public class QuestionResponseModel : QuestionRequestModel
    {
        public string Id { get; set; }
        public string DifficultyLevel { get; set; }
        public string Subject { get; set; }
    }
}
