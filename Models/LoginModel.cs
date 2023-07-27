using System.ComponentModel.DataAnnotations;

namespace InfoTechLabProjeFabrikasi.Models
{
    public class LoginModel
    {
        [Required, Display(Name = "Kulanıcı Adı")]
        public string UserName { get; set; } = "";
        [Required, Display(Name = "Şifre")]
        public string Password { get; set; } = "";
        public bool RememberMe { get; set; }
    }
    public class RegisterUserModel
    {
        [Required, Display(Name = "Kulanıcı Adı")]
        public string UserName { get; set; } = "";
        [Required, Display(Name = "Şifre")]
        public string Password { get; set; } = "";
        [Required, EmailAddress, Display(Name = "E-Posta")]
        public string EMail { get; set; } = "";

    }
}
