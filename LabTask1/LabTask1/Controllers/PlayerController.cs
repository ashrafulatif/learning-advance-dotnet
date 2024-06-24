using LabTask1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LabTask1.ViewModel;

namespace LabTask1.Controllers
{
    public class PlayerController : Controller
    {
        // GET: Player
        public ActionResult PlayerInfo()
        {
            var player = new Player()
            {
                Id = 1,
                Name = "Ronaldo",
                Salary = 50000
            };
            var playe2 = new Player()
            {
                Id = 2,
                Name = "Ronaldo",
                Salary = 50000
            };
            var playe3 = new Player()
            {
                Id = 3,
                Name = "Ronaldo",
                Salary = 50000
            };

            return View(player);
        }
        public ActionResult Staff()
        {
            var staff = new Staff()
            {
                Id = 1,
                Name = "Sirius",
                Position = "GroundsMan"
            };
            return View(staff);
        }
        public ActionResult Stadium()
        {
            var stadium = new Stadium()
            {
                Location = "Mirpur",
                Capacity = 35000
                
            };
            return View(stadium);
        }

        //show all information
        public ActionResult ShowAllInfo()
        {
            //player
            var player1 = new Player()
            {
                Id = 1,
                Name = "Ronaldo",
                Salary = 50000
            };
            var player2 = new Player()
            {
                Id = 2,
                Name = "Messi",
                Salary = 50000
            };
            //stadium info
            var info1 = new Stadium()
            {
                Location = "Mirpur",
                Capacity = 35000

            };
            var info2 = new Stadium()
            {
                Location = "Sylhet",
                Capacity = 36000

            };
            //Staff
            var User1 = new Staff() {Id=1, Name = "Bruce",Position="Manager" };
            var User2 = new Staff() { Id = 2, Name = "clerk", Position = "Grounds-Man" };

            var viewModel = new SampleViewModel()
            {
                Player = new List<Player>() { player1, player2 },
                Staff = new List<Staff>() { User1, User2 },
                Stadium = new List<Stadium>() { info1, info2 }

            };
            return View(viewModel);
        }


    }
}