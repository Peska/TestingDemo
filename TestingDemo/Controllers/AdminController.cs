using System.Web.Mvc;
using TestingDemo.Models;

namespace TestingDemo.Controllers
{
	public class AdminController : Controller
    {
		private IUserRepository repository;

		public AdminController(IUserRepository repository)
		{
			this.repository = repository;
		}

		public ActionResult ChangeLoginName(string oldName, string newName)
		{
			User user = repository.FetchByLoginName(oldName);

			user.LoginName = newName;
			repository.SubmitChanges();

			return View();
		}

		public ActionResult Index()
        {
            return View();
        }
    }
}