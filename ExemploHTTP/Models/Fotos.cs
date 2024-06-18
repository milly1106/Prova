using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploHTTP.Models
{
    public class Fotos
    {

       

        private int id;
        public int Id { get => Id; set => Id = value; }
        public int albumId { get; set; }
        public string Title { get; set; }
        public string url { get; set; }
        public string thumbnailUrl { get; set; }




    }
}
