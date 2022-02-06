using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace mvcTesztApp.Models
{
    /// <summary>
    /// tpalee
    /// </summary>
    public class ApplicationType
    {
        [Key]
        [DisplayName("Azon")]
        public int id { get; set; }
        
        [DisplayName("Név")]
        [Required]
        public string Name { get; set; }


    }
}
