using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace booksXrelaysSomaShare.Models
{
    public class Textbook
    {
        [Key]
        [Required(ErrorMessage = "Please Enter Textbook ID")]
        public int TextBookID { get; set; } 
        [Required(ErrorMessage = "Please Enter Textbook Title")]

        public string Title { get; set; }
        [Required(ErrorMessage = "Please Enter Textbook Author")]

        public string Author  { get; set; }
        [Required(ErrorMessage = "Please Enter Textbook Description")]

        public string Description { get; set; }
        [Required(ErrorMessage = "Please Enter Textbook ISBN")]

        public string ISBN { get; set; }
        [Required(ErrorMessage = "Please Enter Module For Textbook")]

        public string Module { get; set; }
        [Required(ErrorMessage = "Please Enter Textbook Price")]
        [Range(50, 1000)]

        public Decimal Price { get; set; }
        [Required(ErrorMessage = "Please Enter Date of Textbook Listing")] 

        public DateTime ListingDate { get; set; }


    }
}
