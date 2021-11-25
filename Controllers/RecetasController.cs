using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Recetas.Models;

namespace Recetas.Controllers
{
    public class RecetasController : Controller
    {
        private complexEntities db = new complexEntities();
        // GET: Recetas
        public ActionResult Index()
        {
            return View(db.Recetas.ToList());
        }

        public ActionResult Detail()
        {
            return View();
        }

        public ActionResult Detail_Receta(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Receta receta = db.Recetas.Find(id);
            if (receta == null)
            {
                return HttpNotFound();
            }
            return View(receta);
        }
    }
}