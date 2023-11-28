using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Model
{
    public class projectModel
    {
        [Key]
        public int id { get; set; }

        public string name { get; set; }

        public string client { get; set; }

        public int budget { get; set; }

        public DateTime startDate { get; set; }

        public DateTime endDate { get; set; }   

        public string country { get; set; }

        public string status { get; set; }

    }
}
