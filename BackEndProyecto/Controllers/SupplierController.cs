using BackEndProyecto.Data;
using BackEndProyecto.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BackEndProyecto.Controllers
{

    [Route("[controller]/[action]")]

    public class SupplierController : ControllerBase
    {

        private readonly CompanyApiContext _context;

        public SupplierController(CompanyApiContext context)
        {
            _context = context;
        }


        //Supplier

        [HttpGet]

        public async Task<IActionResult> ConsultSupplier()
        {
            return Ok(await _context.Supplier.ToListAsync());
        }

        [HttpPost]
        public async Task<IActionResult> AddSupplier(Supplier Supplier) //Task --> Se recomienda usar Task y no void, ya que minimiza los accidentes en .NET en asincronos IActionResult --> es una clase abstracta que tiene una lista de funciones
        {
            _context.Supplier.Add(Supplier);
            await _context.SaveChangesAsync();
            return Ok(Supplier);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateSupplier(Supplier Supplier)
        {
            _context.Update(Supplier);
            await _context.SaveChangesAsync();
            return Ok(Supplier);

        }

        [HttpDelete]
        public async Task<IActionResult> DeleteSupplier(Supplier Supplier)
        {
            _context.Remove(Supplier);
            await _context.SaveChangesAsync();
            return Ok(Supplier);
        }
    }
}
