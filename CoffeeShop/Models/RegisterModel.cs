using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CoffeeShop.Models
{
    public class RegisterModel
    {
        public string FirstName { get; set; }
        public string EmailAddress { get; set; }
    }
}