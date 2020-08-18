using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Finaktiva_AndryRojas.Models;
using System.Web.Mvc;
using System.Net;
using System.Data.Entity;
namespace Finaktiva_AndryRojas.ClasesDatos
{
    public class RegionDatos
    {
        public List<Region> ObtenerRegions()
        {
            using (var db = new DbContenido())
            {
                return db.Regions.ToList();
            }
        }

        public Region ObtenerRegionsId(int id)
        {
            using (var db = new DbContenido())
            {

                Region model = db.Regions.Find(id);
                return (model);

            }
        }

        internal void Crear(Region model)
        {
            using (var db = new DbContenido())
            {
                db.Regions.Add(model);
                db.SaveChanges();
            }
        }

        public Region Borrar(int id)
        {
            var model = ObtenerRegionsId(id);
            using (var db = new DbContenido())
            {
                db.Regions.Remove(model);
                db.SaveChanges();
            }
            return model;
        }

        internal void Editar(Region model)
        {

            using (var db = new DbContenido())
            {
                db.Entry(model).State = EntityState.Modified;
                db.SaveChanges();
            }

        }

    }
}