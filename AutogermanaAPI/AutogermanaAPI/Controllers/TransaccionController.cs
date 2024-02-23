using AutogermanaAPI.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AutogermanaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransaccionController : ControllerBase
    {
        private readonly DataContext _context;

        public TransaccionController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Transaccion>>> GetTransaccion()
        {
            var fechaVenta = DateTime.Now;

            return Ok(await _context.Transacciones.ToListAsync());
        }

        [HttpPost]
        public async Task<ActionResult<List<Transaccion>>> CreateTransaccion(Transaccion transaccion)
        {
            _context.Transacciones.Add(transaccion);
            await _context.SaveChangesAsync();

            return Ok(await _context.Transacciones.ToListAsync());
        }
        [HttpPut]
        public async Task<ActionResult<List<Transaccion>>> UpdateTransaccion(Transaccion transaccion)
        {
            var dbTransaccion = await _context.Transacciones.FindAsync(transaccion.TransaccionID);
            if (dbTransaccion == null)
                return BadRequest("No se encontro la Transaccion.");

            dbTransaccion.TransaccionID = transaccion.TransaccionID;
            dbTransaccion.FechaVenta = transaccion.FechaVenta;
            dbTransaccion.PrecioVenta = transaccion.PrecioVenta;

            await _context.SaveChangesAsync();

            return Ok(await _context.Transacciones.ToListAsync());
        }

        [HttpDelete("{TransaccionID}")]
        public async Task<ActionResult<List<Transaccion>>> DeleteTransaccion(int TransaccionID)
        {
            var dbTransaccion = await _context.Transacciones.FindAsync(TransaccionID);
            if (dbTransaccion == null)
                return BadRequest("No se encontro la Transaccion.");

            _context.Transacciones.Remove(dbTransaccion);

            await _context.SaveChangesAsync();

            return Ok(await _context.Transacciones.ToListAsync());
        }

    }
}
