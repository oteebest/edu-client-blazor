using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CBTClient.Models
{
    public class AssessmentRequestModel
    {
        [Required(ErrorMessage = "Enter assessment name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Enter assessment instructions")]
        public string Instructions { get; set; }

        [Required(ErrorMessage = "Enter duration in minutes")]
        public int? Duration { get; set; }
    }
}
