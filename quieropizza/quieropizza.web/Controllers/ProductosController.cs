using quieropizza.web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace quieropizza.web.Controllers
{
    public class ProductosController : Controller
    {
        // GET: Productos
        public ActionResult Index()
        {
            var Producto1 = new ProductoModel();
            Producto1.Id = 1;
            Producto1.Descripcion = "Pizza 6 Quesos";

            var Producto2 = new ProductoModel();
            Producto2.Id = 2;
            Producto2.Descripcion = "Pizza 4 Estaciones";

            var Producto3 = new ProductoModel();
            Producto3.Id = 3;
            Producto3.Descripcion = "Pizza jamon y Queso";

            var listadeProductos = new List<ProductoModel>();
            listadeProductos.Add(Producto1);
            listadeProductos.Add(Producto2);
            listadeProductos.Add(Producto3);


            return View(listadeProductos);
        }
    }
}