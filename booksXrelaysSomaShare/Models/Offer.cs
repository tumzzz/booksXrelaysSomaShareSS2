using booksXrelaysSomaShare.Validators;

namespace booksXrelaysSomaShare.Models
{
    public class Offer
    {
        public int OfferId { get; set; }

        public decimal OfferPrice { get; set; }

        public int TextbookId { get; set; }

        public string UserId { get; set; }

        [UniversityEmail]
        public string UserEmail { get; set; }

        public bool IsAccepted { get; set; }
    }
}
