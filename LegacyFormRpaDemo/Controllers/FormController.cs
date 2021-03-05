using LegacyFormRpaDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LegacyFormRpaDemo.Controllers
{
    public class FormController : Controller
    {
        // GET: Form
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(CreateForm createForm)
        {
            var model = new SubmittedForm()
            {
                SubmissionId = $"{DateTime.Now.Year}-{this.GenerateRandomNo()}",
                FormDetails = createForm
            };

            return View("Submitted", model);
        }

        private int GenerateRandomNo()
        {
            int _min = 1000;
            int _max = 9999;
            Random _rdm = new Random();
            return _rdm.Next(_min, _max);
        }
    }
}