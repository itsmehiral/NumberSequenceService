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
            SequenceResponseModel resp = _client.GetSequences(model);
            return View("Result", resp);
        }
      
    }
}