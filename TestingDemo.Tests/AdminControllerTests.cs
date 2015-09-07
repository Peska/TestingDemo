using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestingDemo.Controllers;
using TestingDemo.Models;

namespace TestingDemo.Tests
{
	[TestClass]
	public class AdminControllerTests
	{
		[TestMethod]
		public void CanChangeLoginName()
		{
			// Arrange
			User user = new User() { LoginName = "Bob" };

			FakeRepository repository = new FakeRepository();
			repository.Add(user);

			AdminController target = new AdminController(repository);

			string oldLogin = user.LoginName;
			string newLogin = "Joe";

			// Action
			target.ChangeLoginName(oldLogin, newLogin);

			// Assert
			Assert.AreEqual(newLogin, user.LoginName);
			Assert.IsTrue(repository.DidSubmitChanges);
		}
	}
}
