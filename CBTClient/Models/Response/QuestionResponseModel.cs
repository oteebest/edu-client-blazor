using CBTClient.Models.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CBTClient.Models.Response
{
    public class QuestionResponseModel : QuestionRequestModel
    {   
        public string DifficultyLevel { get; set; }
        public string Subject { get; set; }
    }

}
