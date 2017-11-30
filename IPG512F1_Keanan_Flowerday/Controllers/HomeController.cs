using IPG512F1_Keanan_Flowerday.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IPG512F1_Keanan_Flowerday.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home

       

		public ActionResult Login()
		{
            if ((User)Session["User"] == null)
            {
                Session["IsLoggedIn"] = false;
            }
			return View();
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Login(UserLogin _user)
		{
			if (ModelState.IsValid)
			{
				using (PizzatoriumDB db = new PizzatoriumDB())
				{
					User obj = db.Users.Where(a => a.Username.Equals(_user.Username) && a.Password.Equals(_user.Password)).FirstOrDefault();
					if (obj != null)
					{
                        Session["User"] = obj;
                        Session["IsLoggedIn"] = true;
                        if (_user.RedirectURL != null)
                        {
                            return Redirect(_user.RedirectURL);
                        }
                        if (((User)Session["User"]).ID == 1)
                        {
                            return RedirectToAction("Index","Admin");
                        }

						return RedirectToAction("Design");
					}
                    Session["IsLoggedIn"] = false;
                }
			}
			return View(_user);
		}

		public ActionResult Design()
		{
			if ((bool)Session["IsLoggedIn"])
			{
				return View();
			}
			else
			{
				return RedirectToAction("Login");
			}
		}
	}
}