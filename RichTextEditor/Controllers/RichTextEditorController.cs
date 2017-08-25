using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RichTextEditor.Controllers
{
    public class RichTextEditorController : Controller
    {
        //
        // GET: /Default1/

        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Index(FormCollection fc)
        {
            var content = fc["editor"];

            return View();
        }

    }
}
