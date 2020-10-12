using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Threading.Tasks;

namespace CBTClient.Models.Response
{

    public class PredefinedDataResponseModel : ResponseModelBase
    {
        public PredefinedResponseModel data { get; set; }
    }

    public class PredefinedResponseModel
    {
        public IEnumerable<SubjectResponseModel> subjects { get; set; } = Enumerable.Empty<SubjectResponseModel>();

        public IEnumerable<DifficultLevelResponseModel> difficultyLevels { get; set; } = Enumerable.Empty<DifficultLevelResponseModel>();
    }


    public class SubjectResponseModel
    {
       
        public string Id { get; set; }
        public string Name { get; set; }
    }

    public class DifficultLevelResponseModel
    {
       
        public string Id { get; set; }
        public string Name { get; set; }
    }
}
