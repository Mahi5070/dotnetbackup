using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TruYum_APP.Models
{
	public class MenuItems
	{
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public double Price { get; set; }
        public bool IsActive { get; set; }
        public bool FreeDelivery { get; set; }

        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set; }


    }
}