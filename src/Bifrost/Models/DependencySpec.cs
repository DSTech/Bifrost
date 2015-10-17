using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Bifrost.Models {

	public class DependencySpec {

		[Key]
		public int Id { get; set; }

		/// <summary>
		/// Packages that are depended upon by this build
		/// </summary>
		/// <value>
		/// The packages.
		/// </value>
		public ICollection<PackageDependency> Packages { get; set; }

		/// <summary>
		/// Gets or sets the interfaces.
		/// </summary>
		/// <value>
		/// The interfaces.
		/// </value>
		public ICollection<InterfaceDependency> Interfaces { get; set; }
	}
}
