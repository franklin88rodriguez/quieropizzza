using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QuieroPizza.Web.Models;

namespace QuieroPizza.Web.Controllers
{
    public class ProductosController : Controller
    {
        // GET: Productos
        public ActionResult Index()
        {

            var producto1 = new ProductoModel();

            producto1.Id = 1;
            producto1.Descripcion = "Pizza de 6 Quesos";

            var producto2 = new ProductoModel();

            producto2.Id = 2;
            producto2.Descripcion = "Pizza de 4 Estaciones";

            var producto3 = new ProductoModel();

            producto3.Id = 3;
            producto3.Descripcion = "Pizza de Jamon y Queso";

            var producto4 = new ProductoModel();

            producto4.Id = 4;
            producto4.Descripcion = "Pizza de hondureña";

            var producto5 = new ProductoModel();

            producto5.Id = 5;
            producto5.Descripcion = "Pizza de Suprema";

            var producto6 = new ProductoModel();

            producto6.Id = 6;
            producto6.Descripcion = "Pizza Orilla de Queso";

            var producto7 = new ProductoModel();

            producto7.Id = 7;
            producto7.Descripcion = "Pizza de Triple Queso";

            var producto8 = new ProductoModel();

            producto8.Id = 8;
            producto8.Descripcion = "Pizza la progreseña";

            var producto9 = new ProductoModel();

            producto9.Id = 9;
            producto9.Descripcion = "Pizza Sencilla";

            var ListaProductos = new List<ProductoModel>();
            ListaProductos.Add(producto1);
            ListaProductos.Add(producto2);
            ListaProductos.Add(producto3);
            ListaProductos.Add(producto4);
            ListaProductos.Add(producto5);
            ListaProductos.Add(producto6);
            ListaProductos.Add(producto7);
            ListaProductos.Add(producto8);
            ListaProductos.Add(producto9);


            return View(ListaProductos);
        }
    }
}