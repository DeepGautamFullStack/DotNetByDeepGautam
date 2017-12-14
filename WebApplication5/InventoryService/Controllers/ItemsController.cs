using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using InventoryService.Models;
using System.Web.Http.Cors;

namespace InventoryService.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class ItemsController : ApiController
    {
        private InventoryServiceContext db = new InventoryServiceContext();

        // GET: api/Items
        public IQueryable<Item> GetItems()
        {
            return db.Items;
        }

        // GET: api/Items/5
        [ResponseType(typeof(Item))]
        public async Task<IHttpActionResult> GetItem(int id)
        {
            Item item = await db.Items.FindAsync(id);
            if (item == null)
            {
                return NotFound();
            }

            return Ok(item);
        }

        // PUT: api/Items/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutItem(int id, Item item)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != item.Id)
            {
                return BadRequest();
            }

            db.Entry(item).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ItemExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Ok(item);
        }

        // POST: api/Items
        [ResponseType(typeof(Item))]
        public async Task<IHttpActionResult> PostItem(Item item)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Items.Add(item);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = item.Id }, item);
        }

        // DELETE: api/Items/5
        [ResponseType(typeof(Item))]
        public async Task<IHttpActionResult> DeleteItem(int id)
        {
            Item item = await db.Items.FindAsync(id);
            if (item == null)
            {
                return NotFound();
            }

            db.Items.Remove(item);
            await db.SaveChangesAsync();

            return Ok(item);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ItemExists(int id)
        {
            return db.Items.Count(e => e.Id == id) > 0;
        }
    }
}