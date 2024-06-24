using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Labtask2.Models;
namespace Labtask2.Controllers
{
    public class ProductController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult DisplayProduct()
        {
            var p1 = new Product()
            {
                Id = 1,
                Name = "Nimbus2000",
                Price = 1000,
                Quality = "Good",
                Catagory = "Primium",
                ProductionDate = DateTime.Now,
                HelpLIne = "017066736",
                IsDisposable = true,
                SupportEmail = "ashraful@gmail.com"

            };
            var p2 = new Product()
            {
                Id = 2,
                Name = "Nimbus2000",
                Price = 2000,
                Quality = "Good",
                Catagory = "Primium",
                ProductionDate = DateTime.Now,
                HelpLIne = "019066736",
                IsDisposable = true,
                SupportEmail = "ashraful@gmail.com"

            };
            return View(p1);
        }

        public ActionResult DisplayProductLoosely()
        {
            var p1 = new Product()
            {
                Id = 1,
                Name = "Nimbus2000",
                Price = 1000,
                Quality = "Good",
                Catagory = "Primium",
                ProductionDate = DateTime.Now,
                HelpLIne = "017066736",
                IsDisposable = true,
                SupportEmail = "ashraful@gmail.com"

            };
            var p2 = new Product()
            {
                Id = 2,
                Name = "Nimbus2000",
                Price = 2000,
                Quality = "Good",
                Catagory = "Primium",
                ProductionDate = DateTime.Now,
                HelpLIne = "019066736",
                IsDisposable = true,
                SupportEmail = "ashraful@gmail.com"

            };
            return View(p1);
        }

        public ActionResult DisplayProductTemplateType ()
        {
            var p1 = new Product()
            {
                Id = 1,
                Name = "Nimbus4000",
                Price = 1000,
                Quality = "Good",
                Catagory = "Primium",
                ProductionDate = DateTime.Now,
                HelpLIne = "017066736",
                IsDisposable = true,
                SupportEmail = "ashraful@gmail.com"

            };
            var p2 = new Product()
            {
                Id = 2,
                Name = "Nimbus5000",
                Price = 2000,
                Quality = "Good",
                Catagory = "Primium",
                ProductionDate = DateTime.Now,
                HelpLIne = "019066736",
                IsDisposable = true,
                SupportEmail = "ashraful@gmail.com"

            };
            return View(p1);
        }


    }

}