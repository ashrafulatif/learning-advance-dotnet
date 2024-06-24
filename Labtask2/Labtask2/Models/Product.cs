using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Labtask2.Models
{
    public class Product
    {

        [Required]
        [Display(Name = "Enter your id: ")]
        public int Id { get; set; }

        [Display(Name = "Enter your Name: ")]
        [DataType(DataType.Text)]
        [Required]
        [MaxLength(30, ErrorMessage = "Username cannot exceed 20 characters")]
        public string Name { get; set; }

        [Display(Name = "Enter the price:")]
        [Required]
        [StringLength(30)]
        public int Price { get; set; }

        [Display(Name = "Enter the Quality: ")]
        [DataType(DataType.Text)]
        public string Quality { get; set; }
        [Required]
        [Display(Name = "Enter the catagory: ")]
        public string Catagory { get; set; }

        [Display(Name = "Date of Birth: ")]
        [DataType(DataType.Date)]
        public DateTime ProductionDate { get; set; }
        [Required]
        [Display(Name = "Please enter phone number")]
        [DataType(DataType.PhoneNumber)]
        public string HelpLIne { get; set; }
        [Display(Name = "select disposablity: ")]
        [Required]
        public bool IsDisposable { get; set; }

        [Display(Name = "Support Email: ")]
        [EmailAddress, Required]
        [DataType(DataType.EmailAddress)]
        public string SupportEmail { get; set; }


    }
}