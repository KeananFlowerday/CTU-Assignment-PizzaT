using IPG512F1_Keanan_Flowerday.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IPG512F1_Keanan_Flowerday.Controllers
{
    [UserAuth(RequiredRoles = new int[] {1})]
	public class AdminController : Controller
	{
		public ActionResult Index()
		{
			ViewBag.MyText = "WTF";
			PizzatoriumDB db = new PizzatoriumDB();


			ViewBag.User = db.Users.ToList();
			return View();
		}

		

		public ActionResult AddUser()
		{

			return View();
		}
		[HttpPost]
		public ActionResult AddUser(User _user)
		{
			if (_user == null)
			{
				throw new ArgumentNullException(nameof(_user));
			}

			PizzatoriumDB db = new PizzatoriumDB();
            _user.Roles = new List<int> {0};
			db.Users.Add(_user);

			db.SaveChanges();
			return RedirectToAction("ListUsers");
		}

		public ActionResult ListUsers()
		{
			PizzatoriumDB db = new PizzatoriumDB();

			return View(db.Users.Where(u => u.ID != 1));
		}

		public ActionResult Delete(int? id)
		{
			if (id != 1)
			{
				PizzatoriumDB db = new PizzatoriumDB();
				List<User> _list = db.Users.ToList();
				User _user = _list.Single(u => u.ID == id);
				db.Users.Remove(_user);
				db.SaveChanges();
			}


			return RedirectToAction("ListUsers");
		}

		public ActionResult EditUser(int? id)
		{
			if (id != 1)
			{
				PizzatoriumDB db = new PizzatoriumDB();
				List<User> _list = db.Users.ToList();
				User _user = _list.Single(u => u.ID == id);
				return View(_user);
			}
			else return RedirectToAction("ListUsers");

		}

		[HttpPost]
		public ActionResult EditUser(int? id, User _user)
		{
			if (id != 1)
			{
				PizzatoriumDB db = new PizzatoriumDB();
				db.Users.Single(u => u.ID == id).Update(_user);

				db.SaveChanges();

			}
			return RedirectToAction("ListUsers");

		}
		public ActionResult UserDetails(int? id)
		{
			if (id != 1)
			{
				PizzatoriumDB db = new PizzatoriumDB();
				List<User> _list = db.Users.ToList();
				User _user = _list.Single(u => u.ID == id);
				return View(_user);
			}
			else return RedirectToAction("ListUsers");
		}

	}
}