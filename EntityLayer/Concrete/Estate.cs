using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Estate
    {
        [Key]
        public int EstateID { get; set; }
        public decimal EstateSquareMeter { get; set; }
        public string EstateCity { get; set; }
        public string EstateTown { get; set; }
        public string EstateType { get; set; }
        public decimal EstatePrice { get; set; }
    }
}
