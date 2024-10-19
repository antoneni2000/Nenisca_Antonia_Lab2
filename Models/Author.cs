using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Nenisca_Antonia_Lab2.Models
{
    public class Author
    {
        public int ID { get; set; }
        [Display(Name = "Author's First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Author's Last Name")]
        public string LastName { get; set; }
        public ICollection<Book>? Books { get; set; }
    }
}
