
namespace Fisher.Bookstore.Models
{
    public class Book
    {
        public int BookId { get; set; }

        public string Title { get; set; }

        public Author Author { get; set; }

        public void SellBook()
        {
            //business logic
        }
    }
}