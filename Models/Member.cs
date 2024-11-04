using System.ComponentModel.DataAnnotations;

namespace Marian_Melisa_Lab2.Models
{
    public class Member
    {
        public int ID { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set;}
        public string? Address { get; set; }

        public string Email { get; set; } //enfored; cannot be null
        public string? Phone { get; set; } //? = not enforced; can be null

        [Display(Name="Full Name")]
        public string? FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }
        public ICollection<Borrowing>? Borrowings { get; set; }
    }
}
