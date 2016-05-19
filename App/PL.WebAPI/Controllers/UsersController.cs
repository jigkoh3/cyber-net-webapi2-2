using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using DAL.Data;
using DAL.Entity.Models;
using BLL.Service;
namespace PL.WebAPI.Controllers
{
    public class UsersController : ApiController
    {
        private readonly IUsersService _UsersService;

		public UsersController(IUsersService UsersService)
		{
			_UsersService = UsersService;
		}

        // GET: api/Users
        public IQueryable<Users> GetUsers()
        {
            return _UsersService.GetUsers();
        }

        // GET: api/Users/5
        [ResponseType(typeof(Users))]
        public IHttpActionResult GetUsers(string id)
        {
            Users users = _UsersService.GetUsers(id);
            if (users == null)
            {
                return NotFound();
            }

            return Ok(users);
        }

        // PUT: api/Users/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutUsers(string id, Users users)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != users.id)
            {
                return BadRequest();
            }


            try
            {
                _UsersService.UpdateUsers(users);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UsersExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Users
        [ResponseType(typeof(Users))]
        public IHttpActionResult PostUsers(Users users)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }


            try
            {
                 _UsersService.CreateUsers(users);
            }
            catch (DbUpdateException)
            {
                if (UsersExists(users.id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = users.id }, users);
        }

        // DELETE: api/Users/5
        [ResponseType(typeof(Users))]
        public IHttpActionResult DeleteUsers(string id)
        {
            Users users =  _UsersService.GetUsers(id);
            if (users == null)
            {
                return NotFound();
            }

            _UsersService.DeleteUsers(id);

            return Ok(users);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                 _UsersService.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool UsersExists(string id)
        {
                        Users users =  _UsersService.GetUsers(id);
            if (users == null)
            {
                return false;
            }
			return true;
        }
    }
}

