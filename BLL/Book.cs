using System;
namespace LibraryManager.BLL
{
    public class Book : Item
    {   
        public String ISBN { get; set; }

        public Person author { get; set; }

        public Book(String title, int barcode, String ISBN, Person author) : base(title, barcode,author)
        {
            this.ISBN = ISBN;
            this.author = author;
            
        }
    }
}
