using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Project.Business.Layer.Models;
using Project.Data.Layer;


namespace Project.Business.Layer
{
    public class BookActions
    {   
        //    Declaring local variables 

        private LibraryDataEntities dataEntity;
        private Book DataBaseBook;
        private List<Book> DataBaseBookList;
        private BookModel LocalBookModel;
       // private Author DBAuthor;
        private List<BookModel> LocalBookModelList = new List<BookModel>();

    
        //    BookActions Constructor 

        public  BookActions()
        {
            dataEntity = new LibraryDataEntities();
        }

        // book action methods

        public IEnumerable<BookModel> GetAllBooks()
        {   
           DataBaseBookList =  dataEntity.Books.ToList();   
            
            foreach(Book value in DataBaseBookList)
            {
                LocalBookModel = new BookModel();
                LocalBookModel.AuthorId =(int)value.AuthorId;
                LocalBookModel.BookName = value.BookName;
                LocalBookModel.Id = value.Id;
                LocalBookModel.ISBN = value.ISBN;
                LocalBookModel.PublishDate = (DateTime)value.PublishDate;
                LocalBookModelList.Add(LocalBookModel);
            }

            return LocalBookModelList;
        }
        public BookModel GetBooksByAuthorName(string Name)
        {
            int id;
            LocalBookModel = new BookModel();
            id = dataEntity.Authors.ToList().FirstOrDefault(athr => athr.AuthorName == Name).Id;
            DataBaseBook = dataEntity.Books.ToList().FirstOrDefault(book => book.AuthorId == id);
            LocalBookModel.Id = DataBaseBook.Id;
            LocalBookModel.AuthorId = (int)DataBaseBook.AuthorId;
            LocalBookModel.BookName = DataBaseBook.BookName;
            LocalBookModel.ISBN = DataBaseBook.ISBN;
            LocalBookModel.PublishDate = (DateTime)DataBaseBook.PublishDate; 

            return LocalBookModel; 

        }
    }
}
