using CBTClient.Models.Request;
using CBTClient.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CBTClient.Models.Response
{
    public class QuestionItem : QuestionRequestModel
    {
        public string Id { get; set; }
        public DateTimeOffset CreatedOn { get; set; }
        public Utility.QuestionState State { get;  set; }
    }

}
