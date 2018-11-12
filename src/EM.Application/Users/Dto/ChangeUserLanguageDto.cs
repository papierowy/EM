using System.ComponentModel.DataAnnotations;

namespace EM.Users.Dto
{
   public class ChangeUserLanguageDto
   {
      [Required] public string LanguageName { get; set; }
   }
}