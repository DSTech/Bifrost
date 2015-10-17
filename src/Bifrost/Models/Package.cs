using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Bifrost.Models {

	public class Package {

		[Key]
		public int Id { get; set; }

        /// <summary>
        /// Package Name
        /// </summary>
        /// <value>
        /// Name
        /// </value>
        [Required]
		public String Name { get; set; }

        /// <summary>
        /// Authors of this Package
        /// </summary>
        /// <value>
        /// The authors.
        /// </value>
        [Required]
		public ICollection<Author> Authors { get; set; }

        /// <summary>
        /// Builds of this Package
        /// i.e. different versions
        /// </summary>
        /// <value>
        /// Builds
        /// </value>
        [Required]
		public ICollection<Build> Builds { get; set; }
	}
}
