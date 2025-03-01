using System.ComponentModel.DataAnnotations;

namespace GuidedProject1.Models
{
    public class Candidate
    {
        [Required(ErrorMessage ="Email adresi alanı boş bırakılamaz.")]
        public String? Email { get; set; } = String.Empty;
        [Required(ErrorMessage = "Ad alanı boş bırakılamaz.")]
        public String? FirstName { get; set; } = String.Empty;
        [Required(ErrorMessage = "Soyad alanı boş bırakılamaz.")]
        public String? LastName { get; set; } = String.Empty;
        public String? FullName => $"{FirstName} {LastName?.ToUpper()}";
        public int? Age { get; set; }
        public String? SelectedCourse { get; set; } = String.Empty;
        public DateTime ApplyAt { get; set; }

        public Candidate()
        {
            ApplyAt = DateTime.Now;
        }
    }
}
