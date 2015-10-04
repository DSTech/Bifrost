using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Bifrost.Models {

	public class Package {

		[Key]
		public int Id { get; set; }

		[Required]
		public String Name { get; set; }

		[Required]
		public ICollection<Author> Authors { get; set; }

		[Required]
		public ICollection<Build> Builds { get; set; }
	}
}
