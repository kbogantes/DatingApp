using System.ComponentModel.DataAnnotations;

namespace API.DTOs
{
    public class RegisterDto
    {
        [Required] //Valida que el campo del objeto tenga un valor requerido
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
    }
}