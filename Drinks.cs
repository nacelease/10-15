using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace D.I._T.Data
{
    public class Drinks
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DID { get; set; }

        public string DNumber { get; set; }
        public string Flavor { get; set; }
        public string color { get; set; }
    }
}
