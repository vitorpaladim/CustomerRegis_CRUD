using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CustomerRegis.Data;
using CustomerRegis.Models;
using X.PagedList.Extensions;


namespace CustomerRegis.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CustomerController(ApplicationDbContext context)
        {
            _context = context;
        }


        //get post put delete
        //public async task<iactionresult> index(int pag_number = 1, int pag_size = 10)
        //{
        //    var clientes = await _context.customer
        //        .orderby(c => c.id) // ordna manter a consistencia
        //        .skip((pag_number - 1) * pag_size)//pula paginas
        //        .take(pag_size)//quantidade de agina
        //        .tolistasync();

        //    return view(clientes);
        //}
        // PESQUISAR SOBRE
        // syncrono e asycrono
        //  model
        //  task
        //[ValidateAntiForgeryToken
        // 

        // GET: Customer da Index principal
        public async Task<IActionResult> Index(int? page)
        {
            var customers = await _context.Customer.ToListAsync();
           
            //Paginaçãp
            int PageNumber = page ?? 1;
            int PageSize = 10;
                                                // este orderby esta por ordem nome decrescente
            var pagedCustomers = _context.Customer.OrderBy(c => c.Name)
                .ToPagedList(PageNumber, PageSize);
            
            
            return View(pagedCustomers);

           

        }

        // GET: Customer/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Customer/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Name,Email,PhoneNumber, Telefone2, Address")] Customer customer)
        {
            if (ModelState.IsValid)
            {
                _context.Add(customer);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(customer);
        }

        // GET: Customer/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer = await _context.Customer
                .FirstOrDefaultAsync(m => m.Id == id);

            if (customer == null)
            {
                return NotFound();
            }

            return View(customer);
        }




        // GET: Customer/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();
            var customer = await _context.Customer.FindAsync(id);
            if (customer == null) return NotFound();
            return View(customer);
        }

        // POST: Customer/Edit/5 
        // mudar PUT
        [HttpPost]
        public async Task<IActionResult> Edit(int id, Customer customer)
        {
            if (id != customer.Id) return NotFound();

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(customer);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CustomerExists(customer.Id)) return NotFound();
                    else throw;
                }
                return RedirectToAction(nameof(Index));
            }
            return View(customer);
        }

        // GET: Customer/Delete/
        // 
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
            var customer = await _context.Customer.FirstOrDefaultAsync(m => m.Id == id);
            if (customer == null) return NotFound();
            return View(customer);
        }

        // POST: Customer/Delete/5
        // delete
        [HttpPost, ActionName("Delete")]
        
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var customer = await _context.Customer.FindAsync(id);
            if (customer != null)
            {
                _context.Customer.Remove(customer);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }

        private bool CustomerExists(int id)
        {
            return _context.Customer.Any(e => e.Id == id);
        }
    }
}
