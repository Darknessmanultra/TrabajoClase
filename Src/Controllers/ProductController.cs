using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TrabajoClases.Src.Data;
using TrabajoClases.Src.DTOs;
using TrabajoClases.Src.Models;

namespace TrabajoClases.Src.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly ApiDbContext _context;

        public ProductController(ApiDbContext context)
        {
            _context=context;
        }

        [HttpGet]
        public async Task<ActionResult<Producto>> GetProducto()
        {
            var producto= await _context.Productos.FindAsync();
            if (producto!=null)
            {
                return Ok(producto);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPost]
        public async Task<ActionResult<Producto>> CrearProducto([FromBody] ProductoDto dto,int tiendita)
        {
            var red= await _context.Tiendas.FindAsync(tiendita);
            if(red==null)
            {
                return BadRequest();
            }
            var produceme= new Producto
            {
                TiendaId=tiendita,
                Nombre=dto.Nombre,
                Precio=dto.Precio,
            };
            
            _context.Productos.Add(produceme);
            await _context.SaveChangesAsync();
            return Created();
        }
    }
}