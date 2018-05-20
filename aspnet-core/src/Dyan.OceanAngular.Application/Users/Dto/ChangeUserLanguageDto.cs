using System.ComponentModel.DataAnnotations;

namespace Dyan.OceanAngular.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}