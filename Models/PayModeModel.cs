using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

//using System.Runtime.CompilerServices;

namespace Supermarket_mvp.Models
{
    internal class PayModeModel
    {
        [DisplayName("Pay mode Id")]
        public int Id { get; set; }

        [DisplayName("Pay mode Name")]
        [Required(ErrorMessage = "pay mode name is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "pay mode observation must be between 3 and 200 characters")]
        public string Name { get; set; }


        [DisplayName("Pay mode Name")]
        [Required(ErrorMessage = "pay mode name is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "pay mode observation must be between 3 and 200 characters")]
        public string Observation { get; set; }
    }
}
