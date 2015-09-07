using System.Collections.Generic;
using System.Linq;
using TestingDemo.Models;

namespace TestingDemo.Tests
{
	class FakeRepository : IUserRepository
	{
		public List<User> Users = new List<User>();

		public bool DidSubmitChanges = false;

		public void Add(User user)
		{
			this.Users.Add(user);
		}

		public User FetchByLoginName(string loginName)
		{
			return this.Users.FirstOrDefault(x => x.LoginName == loginName);
		}

		public void SubmitChanges()
		{
			this.DidSubmitChanges = true;
		}
	}
}
