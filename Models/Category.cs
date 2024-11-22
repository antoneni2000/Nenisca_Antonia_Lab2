using Nenisca_Antonia_Lab2.Pages.Books;

namespace Nenisca_Antonia_Lab2.Models
{
    public class Category
    {
        public int ID { get; set; }

        public string CategoryName { get; set; }

        public ICollection<BookCategory>? BookCategories { get; set; }
    }
}
