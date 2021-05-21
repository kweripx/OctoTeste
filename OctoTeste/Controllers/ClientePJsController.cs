using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OctoTeste.Data;
using OctoTeste.Models;

namespace OctoTeste.Controllers
{
    public class ClientePJsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ClientePJsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ClientePJs
        public async Task<IActionResult> Index(
        string sortOrder,
        string currentFilter,
        string searchString,
        int? pageNumber)
        {
            ViewData["CurrentSort"] = sortOrder;
            ViewData["NameSortParm"] = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewData["DateSortParm"] = sortOrder == "Date" ? "date_desc" : "Date";

            if (searchString != null)
            {
                pageNumber = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            ViewData["CurrentFilter"] = searchString;

            var clientesP = from s in _context.ClientesPJ
                            select s;
            if (!String.IsNullOrEmpty(searchString))
            {
                clientesP = clientesP.Where(s => s.Nome.Contains(searchString)
                                       || s.Nome.Contains(searchString));
            }
            switch (sortOrder)
            {
                case "name_desc":
                    clientesP = clientesP.OrderByDescending(s => s.Nome);
                    break;
                case "Date":
                    clientesP = clientesP.OrderBy(s => s.dataNascimento);
                    break;
                case "date_desc":
                    clientesP = clientesP.OrderByDescending(s => s.dataNascimento);
                    break;
                default:
                    clientesP = clientesP.OrderBy(s => s.Nome);
                    break;
            }

            int pageSize = 3;
            return View(await PaginatedList<ClientePJ>.CreateAsync(clientesP.AsNoTracking(), pageNumber ?? 1, pageSize));
        }

        // GET: ClientePJs/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clientePJ = await _context.ClientesPJ
                .FirstOrDefaultAsync(m => m.Id == id);
            if (clientePJ == null)
            {
                return NotFound();
            }

            return View(clientePJ);
        }

        // GET: ClientePJs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ClientePJs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Nome,Cnpj,dataNascimento,Telefone,tipoTelefone,Cep,Endereco,tipoEndereco,Numero,Id")] ClientePJ clientePJ)
        {
            if (ModelState.IsValid)
            {
                clientePJ.Id = Guid.NewGuid();
                _context.Add(clientePJ);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(clientePJ);
        }

        // GET: ClientePJs/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clientePJ = await _context.ClientesPJ.FindAsync(id);
            if (clientePJ == null)
            {
                return NotFound();
            }
            return View(clientePJ);
        }

        // POST: ClientePJs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Nome,Cnpj,dataNascimento,Telefone,tipoTelefone,Cep,Endereco,tipoEndereco,Numero,Id")] ClientePJ clientePJ)
        {
            if (id != clientePJ.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(clientePJ);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ClientePJExists(clientePJ.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(clientePJ);
        }

        // GET: ClientePJs/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clientePJ = await _context.ClientesPJ
                .FirstOrDefaultAsync(m => m.Id == id);
            if (clientePJ == null)
            {
                return NotFound();
            }

            return View(clientePJ);
        }

        // POST: ClientePJs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var clientePJ = await _context.ClientesPJ.FindAsync(id);
            _context.ClientesPJ.Remove(clientePJ);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ClientePJExists(Guid id)
        {
            return _context.ClientesPJ.Any(e => e.Id == id);
        }
    }
}
