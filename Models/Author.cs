using System.ComponentModel.DataAnnotations;

namespace Stoia_Alina_Lab2.Models
{
    public class Author
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ICollection<Book>? Books { get; set; }

        [Display(Name = "Author name")]
        public string FullName => FirstName + " " + LastName;
    }
}
