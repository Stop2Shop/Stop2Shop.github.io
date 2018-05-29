using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace Stop2ShopPL.Models
{
    public class UserLogin
    {
        [ScaffoldColumn(false)]
        public int UserType { get; set; }
        [Required(ErrorMessage ="Please enter Email Id")]
        [DataType(DataType.EmailAddress,ErrorMessage ="Please enter a valid Email Id")]
        public String EmailId { get; set; }
        [Required(ErrorMessage = "Please enter Email Id")]
        public string Password { get; set; }
    }
}