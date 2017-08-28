using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Data.Layer;
using Project.Business.Layer;
using Project.Business.Layer.Models;


namespace Project.Business.Layer
{
    public class AuthorDuties
    {
        private LibraryDataEntities LDEntity;
        private List<AuthorModel> ListAuthors;
        private List<Author> ListDbAuthor;
        private AuthorModel AuthModel;
        private Author DBauthor;

        public AuthorDuties()
        {
            LDEntity = new LibraryDataEntities();
        }

        public IEnumerable<AuthorModel> GetAllAuthors()
        {
            ListAuthors = new List<AuthorModel>();
            ListDbAuthor = new List<Author>();

            ListDbAuthor =  LDEntity.Authors.ToList();

            foreach(Author auth in ListDbAuthor)
            {
                AuthModel = new AuthorModel();
                AuthModel.Id = auth.Id;
                AuthModel.AuthorName = auth.AuthorName;
                AuthModel.Email = auth.Email;
                AuthModel.Phone = auth.Phone;
                ListAuthors.Add(AuthModel);
            }
            return ListAuthors;
        }

        public AuthorModel GetAuthorByName(string _name)
        {

           DBauthor = LDEntity.Authors.ToList().FirstOrDefault(athr => athr.AuthorName == _name );

            AuthModel = new AuthorModel();
            AuthModel.Id = DBauthor.Id;
            AuthModel.AuthorName = DBauthor.AuthorName;
            AuthModel.Email = DBauthor.Email;
            AuthModel.Phone = DBauthor.Phone;
            return    AuthModel;
        }
        public void addAuthor(AuthorModel newauthor)
        {
            DBauthor = new Author();
            DBauthor.AuthorName = newauthor.AuthorName;
            DBauthor.Id = newauthor.Id;
            DBauthor.Email = newauthor.Email;
            DBauthor.Phone = newauthor.Phone;

            LDEntity.Authors.Add(DBauthor);
            LDEntity.SaveChanges();
        }
        public void RemoveAuthor(int ID)

        {
                DBauthor = new Author();
                DBauthor = LDEntity.Authors.FirstOrDefault(athr => athr.Id == ID);

                LDEntity.Authors.Remove(DBauthor);
                LDEntity.SaveChanges();

        }
        public void UpdateAuthor(int ID, AuthorModel X)
        {
            DBauthor = new Author();
            DBauthor = LDEntity.Authors.FirstOrDefault(athr => athr.Id == ID);

            LDEntity.Entry(DBauthor).CurrentValues.SetValues(X);
            LDEntity.SaveChanges();
        }
    }
}
