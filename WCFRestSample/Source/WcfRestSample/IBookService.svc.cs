using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Activation;
using Swaggerator.Attributes;

namespace WcfRestSample
{
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    [Swaggerated("/IBookService.svc", "A RESTful WCF Service")]
    public class BookService : IBookService
    {
        //public List<Book> GetBooksList()
        //{
        //    using (SampleDbEntities entities = new SampleDbEntities())
        //    {
        //        return entities.Books.ToList();
        //    }
        //}

        public Plan GetPlanById(string id)
        {
            //try
            //{
            //    int bookId = Convert.ToInt32(id);

            //    using (SampleDbEntities entities = new SampleDbEntities())
            //    {
            //        return entities.Books.SingleOrDefault(book => book.ID == bookId);
            //    }
            //}
            //catch
            //{
            //    throw new FaultException("Something went wrong");
            //}

            return new Plan {Name = "Hi Frank", Id = Convert.ToInt32(id)};
        }

        //public void AddBook(string name)
        //{
        //    using (SampleDbEntities entities = new SampleDbEntities())
        //    {
        //        Book book = new Book { BookName = name };
        //        entities.Books.AddObject(book);
        //        entities.SaveChanges();
        //    }
        //}

        //public void Add(RequestData Book)
        //{
        //    using (SampleDbEntities entities = new SampleDbEntities())
        //    {
        //        Book book = new Book {BookName = Book.Name};
        //        entities.Books.AddObject(book);
        //        entities.SaveChanges();
        //    }
        //}

        public void UpdateBook(string id, string name)
        {
            //try
            //{
            //    int bookId = Convert.ToInt32(id);

            //    using (SampleDbEntities entities = new SampleDbEntities())
            //    {
            //        Book book = entities.Books.SingleOrDefault(b => b.ID == bookId);
            //        book.BookName = name;
            //        entities.SaveChanges();
            //    }
            //}
            //catch
            //{
            //    throw new FaultException("Something went wrong");
            //}




        }

        //public void DeleteBook(string id)
        //{
        //    try
        //    {
        //        int bookId = Convert.ToInt32(id);

        //        using (SampleDbEntities entities = new SampleDbEntities())
        //        {
        //            Book book = entities.Books.SingleOrDefault(b => b.ID == bookId);
        //            entities.Books.DeleteObject(book);
        //            entities.SaveChanges();
        //        }
        //    }
        //    catch
        //    {
        //        throw new FaultException("Something went wrong");
        //    }
        //}

        //[Description("Get Book Names")]
        public List<string> GetBooksNames()
        {
            //using (SampleDbEntities entities = new SampleDbEntities())
            //{
            //    return entities.Books.Select(book => book.BookName).ToList();
            //}

            var books = new List<Book> {new Book {BookName = "ABC"}, new Book { BookName = "DEF"}};
            return books.Select(book => book.BookName).ToList();
        }
    }

    public class Plan
    {
        public string Name { get; set; }
        public int Id { get; set; } 
    }
}
