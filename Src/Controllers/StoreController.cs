using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TrabajoClases.Src.Data;
using TrabajoClases.Src.DTOs;
using TrabajoClases.Src.Models;

namespace TrabajoClases.Src.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StoreController : ControllerBase
    {
        private readonly ApiDbContext _context;

        public StoreController(ApiDbContext context)
        {
            _context=context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Tienda>>> GetTiendas()
        {
            var lista= await _context.Tiendas.Include(s=>s.productos).ToListAsync();
            return Ok(lista);
        }

        [HttpPost]
        public async Task<ActionResult<Tienda>> CrearTienda([FromBody] TiendaDto dto)
        {
            var tienda = new Tienda
            {
                Nombre=dto.Nombre,
                Ciudad=dto.Ciudad
            };
            _context.Tiendas.Add(tienda);
            await _context.SaveChangesAsync();
            return Created();
        }
    }
}