using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Project.Business.Layer;
using Project.Business.Layer.Models;

namespace Project.WebApi.Layer.Controllers
{
    public class BooksController : ApiController
    {
        public IEnumerable<BookModel> Get()
        {
            BookActions BA = new BookActions();

            return BA.GetAllBooks();
        }
        public BookModel Get(string id)
        {
            BookActions BA = new BookActions();
            return BA.GetBooksByAuthorName(id);
        }
    }
}
            