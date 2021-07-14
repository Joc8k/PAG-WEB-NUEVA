using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using PAG.WEB___NUEVA.Models;

namespace PAG.WEB___NUEVA.Controllers
{
    public class BaseDeDatosController : Controller
    {
        // GET: BaseDeDatos
        public ActionResult Index()
        {
            return View();
        }

        private ApplicationDbContext BD = new ApplicationDbContext();

        public ActionResult Leer()
        {

            var query = from p in BD.Datos select p;

            return (Json(query.ToList()));
        }
        [HttpPost]
        public ActionResult LeerProductos()
        {


            var query = from p in BD.Productos
                        join fab in BD.Fabricantes on p.codigo_fabricante equals fab.codigo
                        join cat in BD.Categoria on p.codigo_categoria equals cat.codigo
                        select new
                        {


                            p.codigo,
                            categoria = cat.nombre,
                            fab.marca,
                            p.nombre,
                            p.descripcion,
                            p.precio,
                            p.stock,
                            p.url


                        };


            return (Json(query.ToList()));



        }
        [HttpPost]
        public ActionResult LeerProducts()
        {


            var query = from p in BD.Productos
                        join fab in BD.Fabricantes on p.codigo_fabricante equals fab.codigo
                        join cat in BD.Categoria on p.codigo_categoria equals cat.codigo
                        select new
                        {


                            p.codigo,
                            categoria = cat.nombre,
                            fab.marca,
                            p.nombre,
                            p.descripcion,
                            p.precio,
                            p.stock,
                            p.url


                        };


            return (Json(query.ToList()));



        }



    }



}
