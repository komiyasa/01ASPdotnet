using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using FileUploader.Controllers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CVWebApp.Controllers
{
    public class HelloFormController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Upload(FormCollection formCollection)
        {
            var fileName = string.Empty;

            if (Request != null)
            {
                HttpPostedFileBase file = Request.Files["uploadFile"];

                // 処理
            }
            return View();
        }
    }
}