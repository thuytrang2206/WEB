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

        [HttpPost]
        public ActionResult Add_Device(DEVICE dev, string submit)
        {
            List<DEVICE> list = db.DEVICEs.ToList();
            DEVICE device = new DEVICE();
            if (submit == "Thêm")
            {
                if(dev != null)
                {
                    dev.DeviceName = dev.DeviceName;
                    db.DEVICEs.Add(dev);
                    db.SaveChanges();
                    dev = null;
                }
                var model = db.DEVICEs.ToList();
                return View("DEVICE", model);
            }
            else if (submit == "Lưu")
            {
                if(dev!= null)
                {
                    var d = db.DEVICEs.SingleOrDefault(x => x.Id == dev.Id);
                    d.DeviceName = dev.DeviceName;
                    db.SaveChanges();
                    dev = null;
                }
            }
            return View();
        }
        public ActionResult Edit(string Id)
        {

            return View();
        }

    }
}