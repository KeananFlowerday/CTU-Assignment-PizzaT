using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IPG512F1_Keanan_Flowerday.Models
{
    public class UserAuth : ActionFilterAttribute
    {

        public int[] RequiredRoles { get; set; }
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            int[] _requiredRoles = RequiredRoles;
            // base.OnActionExecuting(filterContext);
            User _user = (User)filterContext.HttpContext.Session["User"];

            bool _isAuthed = false;
            if (_user == null)
            {
                filterContext.Result = new RedirectResult(string.Format("/Home/Login?RedirectURL={0}", filterContext.HttpContext.Request.Url.AbsolutePath));

            }
            else
            {

                foreach (int _i in RequiredRoles)
                {
                    if (_user.Roles.Contains(_i))
                    {
                        _isAuthed = true;
                    }
                }
                if (_user.ID == 1)
                {
                    _isAuthed = true;
                }

                if (_isAuthed)
                {

                }
                else
                {
                    filterContext.Result = new RedirectResult("/Home");
                }
            }
        }

    }
}