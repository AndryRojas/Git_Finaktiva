using Finaktiva_AndryRojas.ClasesDatos;
using Finaktiva_AndryRojas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Finaktiva_AndryRojas.Controllers
{
    public class MunicipioController : Controller
    {
        private MunicipioDatos _MinucipioDatos;
        private DbContenido db = new DbContenido();

        public MunicipioController() {
            _MinucipioDatos = new MunicipioDatos();
        }
        // GET: Municipio
        public ActionResult Index()
        {
            var model = _MinucipioDatos.ObtenerMunicipios();
            return View(model);
        }

        // GET: Municipio/Details/5
        public ActionResult Details(int id)
        {
            var model = _MinucipioDatos.ObtenerMunicipiosId(id);
            return View(model);
        }

        // GET: Municipio/Create
        public ActionResult Create()
        {
            
            return View();
        }

        // POST: Municipio/Create
        [HttpPost]
        public ActionResult Create(Municipio model)
        {
            try
            {
                // TODO: Add insert logic here
                if (ModelState.IsValid)
                {
                    _MinucipioDatos.Crear(model);
                    return RedirectToAction("Index");
                }
                
            }
            catch (Exception ex)
            {
                
            }
            return View(model);
        }

        // GET: Municipio/Edit/5
        public ActionResult Edit(int id)
        {
            var model = _MinucipioDatos.ObtenerMunicipiosId(id);
            return View(model);
        }

        // POST: Municipio/Edit/5
        [HttpPost]
        public ActionResult Edit(Municipio model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _MinucipioDatos.Editar(model);
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
            var model = _MinucipioDatos.ObtenerMunicipiosId(Convert.ToInt32(id));
            return View(model);
        }

        // POST: TMunicipios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Municipio _Municipio = db.Municipios.Find(id);
            db.Municipios.Remove(_Municipio);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
