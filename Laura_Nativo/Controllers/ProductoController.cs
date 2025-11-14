using CRUDNativo.Data;
using CRUDNativo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CRUDNativo.Controllers
{
    public class ProductoController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProductoController(ApplicationDbContext context)
        {
            _context = context;
        }

        // Método GET: Listar productos
        public IActionResult Index()
        {
            IEnumerable<Producto> listaProductos = _context.Productos;
            return View(listaProductos);
        }

        // Método GET: Crear producto
        public IActionResult Create()
        {
            return View();
        }

        // Método POST: Crear producto
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Producto producto)
        {
            if (ModelState.IsValid)
            {
                _context.Productos.Add(producto);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(producto);
        }

        // Método GET: Editar producto
        public IActionResult Edite(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var producto = _context.Productos.Find(id);
            if (producto == null)
            {
                return NotFound();
            }

            return View(producto);
        }

        // Método POST: Editar producto
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edite(Producto producto)
        {
            if (ModelState.IsValid)
            {
                _context.Productos.Update(producto);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(producto);
        }

        // Método GET: Eliminar producto
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var producto = _context.Productos.Find(id);
            if (producto == null)
            {
                return NotFound();
            }

            return View(producto);
        }

        // Método POST: Eliminar producto
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var producto = _context.Productos.Find(id);
            if (producto == null)
            {
                return NotFound();
            }

            _context.Productos.Remove(producto);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
