using MessagePack;
using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;

namespace CapMobileWebApp.Models
{
    public class LoginModel
    {

        [System.ComponentModel.DataAnnotations.Key]
        public int UserId { get; set; }

        [Required(ErrorMessage = "Invalid User")]
        public string? Username { get; set; }


        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Invalid User")]

        public string? Apassword { get; set; }




    }
}
