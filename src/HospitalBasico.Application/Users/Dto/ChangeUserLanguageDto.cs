using System.ComponentModel.DataAnnotations;

namespace HospitalBasico.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}