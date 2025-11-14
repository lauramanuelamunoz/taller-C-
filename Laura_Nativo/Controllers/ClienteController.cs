using CRUDNativo.Data;
using CRUDNativo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CRUDNativo.Controllers
{
    public class ClienteController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ClienteController(ApplicationDbContext context)
        {
            _context = context;
        }

        // Método GET: Listar clientes
        public ActionResult Index()
        {
            IEnumerable<Cliente> listaClientes = _context.Clientes;
            return View(listaClientes);
        }

        // Método GET: Crear cliente
        public ActionResult Create()
        {
            return View();
        }

        // Método POST: Crear cliente
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                _context.Clientes.Add(cliente);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cliente);
        }

        // Método GET: Editar cliente
        public IActionResult Edite(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var cliente = _context.Clientes.Find(id);
            if (cliente == null)
            {
                return NotFound();
            }

            return View(cliente);
        }

        // Método POST: Editar cliente
        [HttpPost]
        public IActionResult Edite(Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                _context.Clientes.Update(cliente);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cliente);
        }

        // Método GET: Eliminar cliente
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var cliente = _context.Clientes.Find(id);
            if (cliente == null)
            {
                return NotFound();
            }

            return View(cliente);
        }

        // Método POST: Eliminar cliente
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var cliente = _context.Clientes.Find(id);
            if (cliente == null)
            {
                return NotFound();
            }

            _context.Clientes.Remove(cliente);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
