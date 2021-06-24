using Manager_Client.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Manager_Client.DAO
{
	public class UserDao
	{
		Model1 db = null;

		public UserDao()
		{
			db = new Model1();
		}
		
			
		

		public bool CheckUserName(string usreName)
		{
            return db.Users.Count(x => x.UserName == usreName) > 0;
		}

		
	}
}