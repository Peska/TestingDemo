using System;

namespace TestingDemo.Models
{
	public interface IUserRepository
	{
		void Add(User user);
		User FetchByLoginName(string loginName);
		void SubmitChanges();
	}
}