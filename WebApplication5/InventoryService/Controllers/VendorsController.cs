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
    public class VendorsController : ApiController
    {
        private InventoryServiceContext dtVendors = new InventoryServiceContext();

        // GET: api/Vendors
        public IQueryable<Vendor> GetVendors()
        {
            //Vendor vendor = new Vendor();
            //vendor.AadharNumber = "ashdashdsahd";
            //vendor.Code = "ABCD";
            //vendor.CompanyAddress = "ashdassfsdfhdsahd";
            //vendor.CompanyLocalName = "ashdasfsdfdsfshdsahd";
            //vendor.CompanyName = "gdfg";
            //vendor.DlNumber = "fsdfs";
            //vendor.FullName = "ashdashdsahd";
            //vendor.LandlineNumber = "ashdashdsahd";
            //vendor.MobileNumber = "ashdashdsahd";
            //vendor.PanNumber = "ashdashdsahd";
            //vendor.Title = "ashdashdsahd";
            //dtVendors.Vendors.Add(vendor);
            // dtVendors.SaveChangesAsync();
            return dtVendors.Vendors;
        }

        // GET: api/Vendors/5
        [ResponseType(typeof(Vendor))]
        public async Task<IHttpActionResult> GetVendor(int id)
        {
            Vendor vendor = await dtVendors.Vendors.FindAsync(id);
            if (vendor == null)
            {
                return NotFound();
            }

            return Ok(vendor);
        }

        // PUT: api/Vendors/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutVendor(int id, Vendor vendor)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != vendor.Id)
            {
                return BadRequest();
            }

            dtVendors.Entry(vendor).State = EntityState.Modified;

            try
            {
                await dtVendors.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VendorExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Ok(vendor);
        }

        // POST: api/Vendors
        [ResponseType(typeof(Vendor))]
        public async Task<IHttpActionResult> PostVendor(Vendor vendor)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            dtVendors.Vendors.Add(vendor);
            await dtVendors.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = vendor.Id }, vendor);
        }

        // DELETE: api/Vendors/5
        [ResponseType(typeof(Vendor))]
        public async Task<IHttpActionResult> DeleteVendor(int id)
        {
            Vendor vendor = await dtVendors.Vendors.FindAsync(id);
            if (vendor == null)
            {
                return NotFound();
            }

            dtVendors.Vendors.Remove(vendor);
            await dtVendors.SaveChangesAsync();

            return Ok(vendor);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                dtVendors.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool VendorExists(int id)
        {
            return dtVendors.Vendors.Count(e => e.Id == id) > 0;
        }
    }
}