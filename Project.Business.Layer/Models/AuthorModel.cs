using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.Business.Layer.Models
{
    public class AuthorModel
    {

        public int Id { get; set; }
        public string AuthorName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}