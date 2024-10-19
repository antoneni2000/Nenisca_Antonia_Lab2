using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Policy;

namespace Nenisca_Antonia_Lab2.Models
{
    public class Book
    {
        public int ID { get; set; }

        [Display(Name ="Book Title")] //in loc de title vrem sa apara book title, modul in care dorim sa afisam numele unui camp
        public string Title { get; set; }

        public int? AuthorID { get; set; }
        public Author? Author { get; set; }

        [Column(TypeName ="decimal(6,2)")]
        public decimal Price {  get; set; }

        //adaugam o noua proprietate pentru clasa
        [DataType(DataType.Date)]
        public DateTime PublishingDate { get; set; }

        public int? PublisherID { get; set; }
        public Publisher? Publisher { get; set; } //navigation property

       
    }
}
