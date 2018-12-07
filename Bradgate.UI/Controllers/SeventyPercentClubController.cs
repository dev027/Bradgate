using System.Web.Mvc;
using Bradgate.SeventyClub.Interface;
using Bradgate.SeventyClub.Service;
using Bradgate.UI.ViewModels.SeventyPercentClub;

namespace Bradgate.UI.Controllers
{
    public partial class SeventyPercentClubController : Controller
    {
        private readonly ISeventyClubService _service = new SeventyClubService();

        // GET: SeventyPercentClub
        /// <summary>
        /// Index
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Bradgate.SeventyClub.Domain.Exceptions.SeventyClubServiceException"></exception>
        public virtual ActionResult Index()
        {
            var holders = _service.GetPamLeesonTrophyHolders();

            var model = new HoldersViewModel(holders);

            return View(model);
        }
    }
}