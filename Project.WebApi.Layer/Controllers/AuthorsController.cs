using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Project.Business.Layer;
using Project.Data.Layer;
using Project.Business.Layer.Models;

namespace Project.WebApi.Layer.Controllers
{
    public class AuthorsController : ApiController
    {
        private AuthorDuties AD;
        public AuthorsController()
            {
             AD = new AuthorDuties();
        }


        public IEnumerable<AuthorModel>Get()
        {

            return AD.GetAllAuthors();


        }
        public AuthorModel Get(string id)
        {
            return AD.GetAuthorByName(id);
        }

        public void  Post([FromBody]AuthorModel NewAuthor)
        {
            AD.addAuthor(NewAuthor);
        }
       
 
        public void Delete(int id)
        {
            AD.RemoveAuthor(id);
        }

        public void PUT([FromBody]AuthorModel X,int ID)
        {
            AD.UpdateAuthor(ID, X);
        }
    }
}
