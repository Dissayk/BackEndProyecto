using BackEndProyecto.Data;
using BackEndProyecto.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BackEndProyecto.Controllers
{

    [Route("[controller]/[action]")]

    public class ProductController : ControllerBase
    {

        private readonly CompanyApiContext _context;

        public ProductController(CompanyApiContext context)
        {
            _context = context;
        }


        //Product

        [HttpGet]

        public async Task<IActionResult> ConsultProduct()
        {
            return Ok(await _context.Product.ToListAsync());
        }

        [HttpPost]
        public async Task<IActionResult> AddProduct(Product Product) //Task --> Se recomienda usar Task y no void, ya que minimiza los accidentes en .NET en asincronos IActionResult --> es una clase abstracta que tiene una lista de funciones
        {
            _context.Product.Add(Product);
            await _context.SaveChangesAsync();
            return Ok(Product);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateProduct(Product Product)
        {
            _context.Update(Product);
            await _context.SaveChangesAsync();
            return Ok(Product);

        }

        [HttpDelete]
        public async Task<IActionResult> DeleteProduct(Product Product)
        {
            _context.Remove(Product);
            await _context.SaveChangesAsync();
            return Ok(Product);
        }
    }
}
