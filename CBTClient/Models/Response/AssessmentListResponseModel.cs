﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CBTClient.Models.Request;

namespace CBTClient.Models.Response
{  
    public class AssessmentListResponseModel : ResponseModelBase
    {
        public List<AssessmentItem> data { get; set; }        

    }

  
}
