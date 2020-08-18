using Finaktiva_AndryRojas.ClasesDatos;
using Finaktiva_AndryRojas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Finaktiva_AndryRojas.Controllers
{
    public class RegionController : Controller
    {
        private RegionDatos _RegionDatos;
        private DbContenido db = new DbContenido();
        public RegionController()
        {
            _RegionDatos = new RegionDatos();
        }
        // GET: Region
        public ActionResult Index()
        {
            var model = _RegionDatos.ObtenerRegions();
            return View(model);
        }

        // GET: Region/Details/5
        public ActionResult Details(int id)
        {
            var model = _RegionDatos.ObtenerRegionsId(id);
            return View(model);
        }

        // GET: Region/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Region/Create
        [HttpPost]
        public ActionResult Create(Region model)
        {
            try
            {
                // TODO: Add insert logic here
                if (ModelState.IsValid)
                {
                    _RegionDatos.Crear(model);
                    return RedirectToAction("Index");
                }

            }
            catch (Exception ex)
            {

            }
            return View(model);
        }

        // GET: Region/Edit/5
        public ActionResult Edit(int id)
        {
            var model = _RegionDatos.ObtenerRegionsId(id);
            return View(model);
        }

        // POST: Region/Edit/5
        [HttpPost]
        public ActionResult Edit(Region model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _RegionDatos.Editar(model);
                    return RedirectToAction("Index");
                }
            }
            catch
            {

            }
            return View(model);
        }

        // GET: Municipio/Delete/5
        public ActionResult Delete(int? id)
        {
            var model = _RegionDatos.ObtenerRegionsId(Convert.ToInt32(id));
            return View(model);
        }

        // POST: TMunicipios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Region _Region = db.Regions.Find(id);
            db.Regions.Remove(_Region);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
