using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CBTClient.Models.Response
{  
    public class AssessmentResponseModel : AssessmentRequestModel
    {
        public string Id { get; set; }
        public DateTimeOffset CreatedOn { get; set; }


    }
}
