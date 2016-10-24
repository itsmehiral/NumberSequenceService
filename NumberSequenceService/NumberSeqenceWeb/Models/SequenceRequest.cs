using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NumberSeqenceWeb
{
    public class SequenceRequestModel
    {
        [Required]
        [RegularExpression("([0-9]+)", ErrorMessage = "Please enter valid whole Number")]
        [Range (0,99999, ErrorMessage="Please enter valid whole number")]
        public long InputNumber { get; set; }
    }
}