using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ParcialLuciaSosa.Models
{
   public enum Category
    {
        Europe=10,
        Asia=20,
        Americas=30,
        Africa=40,
        Oceania=50
    }
    public enum Pais
    { Colombia=10,
        Estonia=20,
        Albania=30,
        Andorra=40,
        Austria=50

    }
    public enum Option
    {   spa=10,
        eng=20

    }
    public class Countrie
    {

        [Key]
        public string alpha3Code { get; set; }

        [Required(ErrorMessage ="You must enter the field {0}")]
        [StringLength(20,ErrorMessage ="The field {0} must contain betwen {2} and {1} characters",MinimumLength =2)]
        public Category region { get; set; }

        [Required(ErrorMessage = "You must enter the field {0}")]
        [StringLength(20, ErrorMessage = "The field {0} must contain betwen {2} and {1} characters", MinimumLength = 2)]
        
        public Pais name { get; set; }


        public int area { get; set; }

        [Required(ErrorMessage = "You must enter the field {0}")]
        public int callingCodes { get; set; }

        [Required(ErrorMessage = "You must enter the field {0}")]
        public Option languajes { get; set; }

        [EmailAddress]
        public string flag { get; set; }
    }
}