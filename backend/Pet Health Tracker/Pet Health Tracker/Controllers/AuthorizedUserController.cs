using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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

		[Route("Login")]
		[HttpPost]
		public async Task<ActionResult<AuthorizedUser>> Login([FromBody] AuthorizedUser authorizedUser)
		{
			var user = await _db.AuthorizedUsers.Where(a => a.Username == authorizedUser.Username && a.Password == EncryptPassword(authorizedUser.Password)).FirstOrDefaultAsync();
			if (user == null)
			{
				return NotFound();
			}
			else
			{
				user.Password = "";
				return user;
			}
		}

		[HttpGet]
		public async Task<ActionResult<IEnumerable<AuthorizedUser>>> GetAuthorizedUser()
		{
			List<AuthorizedUser> authorizedUsers = await _db.AuthorizedUsers.ToListAsync();
			foreach ( AuthorizedUser authorizedUser in authorizedUsers)
			{
				authorizedUser.Password = "";
				authorizedUser.Username = "";
			}
			return authorizedUsers;
		}

		[HttpGet("{id}")]
		public async Task<ActionResult<AuthorizedUser>> GetAuthorizedUser(int id)
		{
			var authorizedUser = await _db.AuthorizedUsers.FindAsync(id);

			if (authorizedUser == null)
			{
				return NotFound();
			}

			//account.Password = "";

			return authorizedUser;
		}

		[HttpPut("{id}")]
		public async Task<IActionResult> PutAccount(int id, [FromBody] AuthorizedUser authorizedUser)
		{
			if (id != authorizedUser.Id)
			{
				return BadRequest();
			}

			_db.Entry(authorizedUser).State = EntityState.Modified;
			//account.Password = EncryptPassword(account.Password);

			try
			{
				await _db.SaveChangesAsync();
			}
			catch (DbUpdateConcurrencyException)
			{
				if (!AccountExists(id))
				{
					return NotFound();
				}
				else
				{
					throw;
				}
			}

			return NoContent();
		}

		private bool AccountExists(int id)
		{
			return _db.AuthorizedUsers.Any(e => e.Id == id);
		}
		[HttpPost]
		public async Task<ActionResult<AuthorizedUser>> PostAccount([FromBody] AuthorizedUser authorizedUser)
		{
			var user = await _db.AuthorizedUsers.Where(a => a.Username == authorizedUser.Username).FirstOrDefaultAsync();
			if (user != null)
			{
				return UnprocessableEntity();
			}
			else
			{
				authorizedUser.Password = EncryptPassword(authorizedUser.Password);
				_db.AuthorizedUsers.Add(authorizedUser);
				await _db.SaveChangesAsync();


				authorizedUser.Password = "";
				return CreatedAtAction("GetAccount", new { id = authorizedUser.Id }, authorizedUser);
			}
		}

		[HttpDelete("{id}")]
		public async Task<IActionResult> DeleteAccount(int id)
		{
			var authorizedUser = await _db.AuthorizedUsers.FindAsync(id);
			if (authorizedUser == null)
			{
				return NotFound();
			}

			_db.AuthorizedUsers.Remove(authorizedUser);
			await _db.SaveChangesAsync();

			return NoContent();
		}

		private string EncryptPassword(string password)
		{
			//var hash = "";
			//do encryption

			System.Security.Cryptography.HashAlgorithm sha = System.Security.Cryptography.SHA256.Create();
			byte[] hash = sha.ComputeHash(System.Text.Encoding.ASCII.GetBytes(password));

			//hash.ToString();

			return System.Text.Encoding.Default.GetString(hash);

		}

		private string VerifyPassword(string hash, string password)
		{
			//var password = "";

			if (EncryptPassword(password) == hash)
				return password;
			else
				return "";

		}
}
