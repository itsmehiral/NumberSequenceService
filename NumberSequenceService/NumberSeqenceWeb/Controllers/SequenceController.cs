using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NumberSeqenceWeb.Controllers
{
    public class SequenceController : Controller
    {
        ServiceManager _client = null;

        public SequenceController()
        {
            _client = new ServiceManager();
        }
        
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult GetSequence(SequenceRequestModel model)
        {
            if (!ModelState.IsValid)
            {
                return Json(new
                {
                    success = false,
                    errors = ModelState.Keys.SelectMany(k => ModelState[k].Errors)
                                    .Select(m => m.ErrorMessage).ToArray()
                });
            }
            SequenceResponseModel resp = _client.GetSequences(model);
            return Json(resp);
            //return View("Result", resp);
        }
      
    }
}