using BackEndProyecto.Data;
using BackEndProyecto.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BackEndProyecto.Controllers
{

    [Route("[controller]/[action]")]

    public class EmployeeController : ControllerBase
    {

        private readonly CompanyApiContext _context;

        public EmployeeController(CompanyApiContext context)
        {
            _context = context;
        }

        // Employee

        [HttpGet]

        public async Task<IActionResult> ConsultEmployees()
        {
            return Ok(await _context.Employee.ToListAsync()); 
        }

        [HttpPost]
        public async Task<IActionResult> AddEmployee(Employee Employee) //Task --> Se recomienda usar Task y no void, ya que minimiza los accidentes en .NET en asincronos IActionResult --> es una clase abstracta que tiene una lista de funciones
        {
            _context.Employee.Add(Employee);
            await _context.SaveChangesAsync();
            return Ok(Employee);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateEmployee(Employee Employee)
        {
            _context.Update(Employee);
            await _context.SaveChangesAsync();
            return Ok(Employee);

        }

        [HttpDelete]
        public async Task<IActionResult> DeleteEmployee(Employee Employee)
        {
            _context.Remove(Employee);
            await _context.SaveChangesAsync();
            return Ok(Employee);
        }

     
    }
}
