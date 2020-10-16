using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Login.Models
{
    public class UserLogin
    {
        int id;
        string usernanme;
        string email;
        string password;
        string repassword;

        [Key]
        public int Id { get => id; set => id = value; }
        [Required(ErrorMessage = "Username Is Required")]
        public string Usernanme { get => usernanme; set => usernanme = value; }
        [Required(ErrorMessage = "Email Is Required")]
        public string Email { get => email; set => email = value; }
        [Required(ErrorMessage = "Password Is Required")]
        public string Password { get => password; set => password = value; }
        [Required(ErrorMessage = "Re Password Is Required")]
        public string Repassword { get => repassword; set => repassword = value; }
    }
}
