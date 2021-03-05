using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Principal;
using System.Web;

namespace LegacyFormRpaDemo.Models
{
    public class SubmittedForm
    {
        public string SubmissionId { get; set; }

        public CreateForm FormDetails { get; set; }
    }
}