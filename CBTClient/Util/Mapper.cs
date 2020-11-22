using CBTClient.Models;
using CBTClient.Models.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CBTClient.Util
{
    public static class Mapper
    {

        public static QuestionItem Map(this QuestionManagerModel model)
        {
            return new QuestionItem { };
        }

    }
}
