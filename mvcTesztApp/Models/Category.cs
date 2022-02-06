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
    public class Category
    {
        [Key]
        [DisplayName("Azon")]
        public int id { get; set; }

        [DisplayName("Név")]
        [Required]
        public string Name { get; set; }

        [DisplayName("Sorrend")]
        [Required]
        [Range(1,int.MaxValue,ErrorMessage ="Nagyobb legyen, mint 0!")]
        public int DisplayOrder { get; set; }

    }
}
