using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Manager_Client.Models
{
	public class RegisterMoodel
	{
		[Key]
		public long ID { set; get; }

		[Display(Name ="Họ và Tên")]
		[Required(ErrorMessage ="Yêu cầu nhập họ và tên người dùng")]
		public string Name { set; get; }
		[Display(Name = "Tài Khoản")]
		[Required(ErrorMessage = "Yêu cầu nhập tên đăng nhập")]
		public string UserName { set; get; }
		[Display(Name = "Mật khẩu")]
		[Required(ErrorMessage = "Yêu cầu nhập mật khẩu")]
		[StringLength(20,MinimumLength =6,ErrorMessage ="Độ dài mật khẩu ít nhất 6 kí tự")]
		public string Password { set; get; }
		[Display(Name = "ID")]
		public string GroupID { set; get; }

	}
}