using Manager_Client.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;
using System.Web.Mvc;

using Manager_Client.DAO;

namespace Manager_Client.Controllers
{
    public class User1Controller : Controller
    {
        // GET: User1
        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
		public ActionResult Register(RegisterMoodel model )
		{
            if(ModelState.IsValid)
			{
                var dao = new UserDao();
                if(dao.CheckUserName(model.UserName))
				{
                    ModelState.AddModelError("", "Tên đăng nhập đã tồn tại");
				}
                else
				{
                    var user = new User();
                    user.Name = model.Name;
                    user.Password = model.Password;
                    user.Status = true;
                   
                  

				}                    
                
			}
            return View(model);
        }
       
    }
}