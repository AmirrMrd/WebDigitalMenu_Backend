using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using Web_MenuDigital.Models;
using Web_MenuDigital.Services;

namespace Web_MenuDigital.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "")]
    public class BranchController : ApiController
    {

        // GET: api/Branch
        [HttpGet]
        public List<Branch> GetAllBranches()
        {
            BranchCrudService crud = new BranchCrudService();
            return crud.GetAllBranches();
        }

        // GET: api/Branch/5
        [HttpGet]
        public Branch GetBranchById(int branchId)
        {
            BranchCrudService crud = new BranchCrudService();
            return crud.GetBranchById(branchId);
        }

        // POST: api/Branch
        [HttpPost]
        public IHttpActionResult CreateBranch(Branch value)
        {
            if(value == null)
            {
                return NotFound();
            }
            else
            {
                BranchCrudService crud = new BranchCrudService();
                crud.CreateBranch(value);
                return Ok(value);
            }
            
        }

        // PUT: api/Branch/5
        public Branch Put(int id,[FromBody]string value)
        {
            BranchCrudService crud = new BranchCrudService();
            return crud.UpdateBranch(id , value);
        }

        // DELETE: api/Branch/5
        public void Delete(int id)
        {
        }
    }
}
