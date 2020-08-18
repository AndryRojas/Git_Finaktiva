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
    public class MunicipioDatos
    {
        public List<Municipio> ObtenerMunicipios()
        {
            using (var db = new DbContenido())
            {
                return db.Municipios.ToList();
            }
        }

        public Municipio ObtenerMunicipiosId(int id)
        {
            using (var db = new DbContenido())
            {
                
                Municipio model = db.Municipios.Find(id);                
                return (model);
               
            }
        }

        internal void Crear(Municipio model)
        {
            using (var db = new DbContenido())
            {
                db.Municipios.Add(model);                
                db.SaveChanges();
            }
        }
        
        public Municipio Borrar(int id)
        {
            var model = ObtenerMunicipiosId(id);
            using (var db= new DbContenido()) {                
                db.Municipios.Remove(model);
                db.SaveChanges();
            }
            return model;
        }

        internal void Editar(Municipio model)
        {
                       
                using (var db = new DbContenido())
                {
                    db.Entry(model).State = EntityState.Modified;
                    db.SaveChanges();                
                }
                
            }
        
    }
}