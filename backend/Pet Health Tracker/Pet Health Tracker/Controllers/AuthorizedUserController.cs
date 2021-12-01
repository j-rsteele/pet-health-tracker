using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pet_Health_Tracker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pet_Health_Tracker.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class AuthorizedUserController : ControllerBase
	{
		private PetTrackerContext _db;

		public AuthorizedUserController(PetTrackerContext db)
		{
			this._db = db;
		}

		[HttpGet]
		public ActionResult<List<AuthorizedUser>> Get()
		{
			return _db.AuthorizedUsers.ToList();
		}

		[HttpGet("{id}")]
		public ActionResult<AuthorizedUser> Get(int id)
		{
			return _db.AuthorizedUsers.Find(id);
		}

		[HttpPost]
		public ActionResult<AuthorizedUser> Post([FromBody] AuthorizedUser AuthorizedUser)
		{

			_db.AuthorizedUsers.Add(AuthorizedUser);
			_db.SaveChanges();

			return AuthorizedUser;  // determined by what the front end wants to direct us to
		}

		[HttpPut("{id}")]
		public ActionResult<IEnumerable<AuthorizedUser>> Put(int id, [FromBody] AuthorizedUser AuthorizedUser)
		{
			if (AuthorizedUser.Id == id)
			{
				_db.AuthorizedUsers.Update(AuthorizedUser);
				_db.SaveChanges();
			}

			return _db.AuthorizedUsers.ToList();
		}

		[HttpDelete("{id}")]
		public ActionResult<List<AuthorizedUser>> Delete(int id)
		{
			var AuthorizedUser = _db.AuthorizedUsers.Find(id);
			_db.AuthorizedUsers.Remove(AuthorizedUser);
			_db.SaveChanges();

			return _db.AuthorizedUsers.ToList();
		}
	}
}
