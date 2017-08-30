using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Business.Layer.Models
{
    public class BookModel
    {
        public int Id { get; set; }
        public string BookName { get; set; }
        public int AuthorId { get; set; }
        public DateTime PublishDate { get; set; }
        public string ISBN { get; set; }
    }
}
