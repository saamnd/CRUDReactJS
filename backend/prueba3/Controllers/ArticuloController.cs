using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using prueba3.Context;
using prueba3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace prueba3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticuloController : ControllerBase
    {
        private readonly AppDBContext context;
        public ArticuloController(AppDBContext context)
        {
            this.context = context;
        }

        // GET: api/<ArticuloController>
        [HttpGet]
        public IEnumerable<Articulos> Get()
        {
            return context.articulos.ToList();
        }

        // GET api/<ArticuloController>/5
        [HttpGet("{id}", Name ="GetArticulo")]
        public Articulos Get(int id)
        {
            var articulo = context.articulos.FirstOrDefault(i => i.id == id);
            return articulo;
        }

        // POST api/<ArticuloController>
        [HttpPost]
        public ActionResult Post([FromBody] Articulos articulo)
        {
            context.articulos.Add(articulo);
            context.SaveChanges();
            return CreatedAtRoute("GetArticulo", new { id = articulo.id }, articulo);
        }

        // PUT api/<ArticuloController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Articulos articulo)
        {
            if (articulo.id == id)
            {
                context.Entry(articulo).State = EntityState.Modified;
                context.SaveChanges();
                return CreatedAtRoute("GetArticulo", new {id = articulo.id }, articulo);
            }
            else
            {
                return BadRequest();
            }

        }

        // DELETE api/<ArticuloController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var articulo = context.articulos.FirstOrDefault(i => i.id == id);
            if (articulo!=null)
            {
                context.articulos.Remove(articulo);
                context.SaveChanges();
                return Ok(id);
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
