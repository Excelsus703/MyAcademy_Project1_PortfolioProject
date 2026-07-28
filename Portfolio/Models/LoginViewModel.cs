using System.ComponentModel.DataAnnotations;

namespace Portfolio.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Kullanıcı Adı Boş Geçilemez!")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Şifre Boş Geçilemez!")]
        public string Password { get; set; }
    }
}
