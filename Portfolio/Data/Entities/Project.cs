using System.ComponentModel.DataAnnotations;

namespace Portfolio.Data.Entities
{
    public class Project
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Görsel Url Boş Geçilemez !")]
        public string ImageUrl { get; set; }

        [Required(ErrorMessage = "Proje Adı Boş Geçilemez !")]
        [MinLength(3, ErrorMessage = "Proje Adı En Az 3 Karakter Olmalıdır !")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Proje Açıklaması Boş Geçilemez !")]
        [MaxLength(250, ErrorMessage = "Proje Açıklaması En Fazla 100 Karakter Olmalıdır !")]
        public string Description { get; set; }

        [Required(ErrorMessage = "GitHub Url Boş Geçilemez !")]
        public string GitHubUrl { get; set; }

        public bool IsDone { get; set; }


        public List<ProjectTechStack>? ProjectTechStacks { get; set; }
    }
}
