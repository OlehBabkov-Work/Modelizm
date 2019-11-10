using System;;

namespace Moselizm.BLL.DTO
{
	public class UserDTO
	{
		public int Id { get; set; }
		public string Email { get; set; }
		public string Login { get; set; }
		public string Password { get; set; }
		public bool IsAdmin { get; set; }
		public DateTime DateTimeLogged { get; set; }
	}
}
