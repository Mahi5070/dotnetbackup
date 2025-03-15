using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TruYum_APP.Models
{
	public class UserLogin
	{
        [Required(ErrorMessage ="user id is required")]
        [Display(Name ="User Id")]
        public string UId { get; set; }

        [Required(ErrorMessage ="password is required")]
        [Display(Name ="Password")]
        [DataType(DataType.Password)]
        public string Pwd { get; set; }
    }
}