using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace D.I._T.Data
    
{
    public class Foods
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int FID { get; set; }
        public string Type { get; set; }
        public int DID { get; set; }
        [ForeignKey("DID")]
        public Drinks drink { get; set; }
    }
}
