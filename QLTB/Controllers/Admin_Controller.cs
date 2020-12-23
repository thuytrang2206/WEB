using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.Entity;
using QLTB.Models;

namespace QLTB.Controllers
{
    public class Admin_Controller : Controller
    {
        QLTB_Model db = new QLTB_Model();
        // GET: Admin_
        public ActionResult Index()
        {
            var model = db.DEVICEs.Where(d => d.IsUsing == true).ToList();
            return View(model);
        }
        public ActionResult Edit(string Id)
        {

            return View();
        }

    }
}