using CRUDNativo.Data;
using CRUDNativo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CRUDNativo.Controllers
{
    public class VentaController : Controller
    {
        private readonly ApplicationDbContext _context;

        public VentaController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Listar ventas
        public IActionResult Index()
        {
            var ventas = _context.Ventas
                .Include(v => v.Cliente)
                .Include(v => v.Producto)
                .ToList();

            return View(ventas);
        }

        // GET: Crear venta
        public IActionResult Create()
        {
            ViewBag.Clientes = _context.Clientes.ToList();
            ViewBag.Productos = _context.Productos.ToList();
            return View();
        }

        // POST: Crear venta
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Venta venta)
        {
            if (ModelState.IsValid)
            {
                _context.Ventas.Add(venta);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Clientes = _context.Clientes.ToList();
            ViewBag.Productos = _context.Productos.ToList();
            return View(venta);
        }

        // GET: Editar venta
        public IActionResult Edite(int? id)
        {
            if (id == null || id == 0)
                return NotFound();

            var venta = _context.Ventas.Find(id);
            if (venta == null)
                return NotFound();

            ViewBag.Clientes = _context.Clientes.ToList();
            ViewBag.Productos = _context.Productos.ToList();
            return View(venta);
        }

        // POST: Editar venta
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edite(Venta venta)
        {
            if (ModelState.IsValid)
            {
                _context.Ventas.Update(venta);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Clientes = _context.Clientes.ToList();
            ViewBag.Productos = _context.Productos.ToList();
            return View(venta);
        }

        // GET: Eliminar venta
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
                return NotFound();

            var venta = _context.Ventas
                .Include(v => v.Cliente)
                .Include(v => v.Producto)
                .FirstOrDefault(v => v.VentaId == id);

            if (venta == null)
                return NotFound();

            return View(venta);
        }

        // POST: Eliminar venta
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var venta = _context.Ventas.Find(id);
            if (venta == null)
                return NotFound();

            _context.Ventas.Remove(venta);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
