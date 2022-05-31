using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyDatabase.DataAccess.EF.Context;
using MyDatabase.DataAccess.EF.Models;
using MyDatabase.DataAccess.EF.Repositories;
using MyDatabaseWebApps.Models;

namespace MyDatabaseWebApps.Controllers
{
    public class SoccerController : Controller 
    {
        private readonly MydatabaseContext  _context;

        public SoccerController(MydatabaseContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {

            SoccerViewModel model = new SoccerViewModel(_context);
            return View(model);
        }

        [HttpPost]
        public IActionResult Index(int SoccerId, string SoccerTeams, string BestTeamPlayer, short GamesPlayed, short GamesWon, short GamesLost, DateTime DatePlayed)
        {
            SoccerViewModel model = new SoccerViewModel(_context);

            //Soccer Soccer = new(SoccerID, FirstName, LastName, age, Team, Position);
            Soccer soccer = new()
            {
                SoccerId = SoccerId,
                SoccerTeams = SoccerTeams,
                BestTeamPlayer = BestTeamPlayer,
                GamesPlayed = GamesPlayed,
                GamesWon = GamesWon,
                GamesLost = GamesLost,
                DatePlayed = DatePlayed,
            };

            model.SaveSoccer(soccer);
            model.IsActionSuccess = true;
            model.ActionMessage = "Soccer has been saved successfully";

            return View(model);
        }

        public IActionResult Update(int id)
        {
            SoccerViewModel model = new SoccerViewModel(_context, id);

            return View(model);
        }

        public IActionResult Delete(int id)
        {
            SoccerViewModel model = new SoccerViewModel(_context);

            if (id > 0)
            {
                model.RemoveSoccer(id);
            }

            model.IsActionSuccess = true;
            model.ActionMessage = "Soccer has been deleted successfully";
            return View("index", model);
        }
    }
}
