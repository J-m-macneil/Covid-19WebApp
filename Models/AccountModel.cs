using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstProjectWebApp.Models
{
    public class AccountModel
    {
            
            //Set name's to go above form entries.
            [Required]
            [StringLength(20, MinimumLength =3)]
            [DisplayName("Username:")]
            public string UserName { get; set; }

            [Required]
            [DataType(DataType.Date)]
            [DisplayName("Date of birth:")]
            public DateTime UserDob { get; set; }

            [Required]
            [DataType(DataType.EmailAddress)]
            [DisplayName("Users email address:")]
            public string UserEmailAddress { get; set; }

            [Required]
            [DataType(DataType.Password)]
            [DisplayName("Password:")]
            public string UserPassword { get; set; }
           
    }
}
