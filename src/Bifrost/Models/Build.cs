using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Bifrost.Models {

	public class Build {

		[Key]
		public int Id { get; set; }

		/// <summary>
		/// This is the Name of the Parent Package.
		/// </summary>
		/// <value>
		/// The package name.
		/// </value>
		[Required] 
		public String Package { get; set; }

		/// <summary>
		/// This Build's version number.
		/// </summary>
		/// <value>
		/// The version.
		/// </value>
		[Required]
		public Version Version { get; set; }

		//Should this be a required Field?
		public String GivenVersion { get; set; }

		//I'm assuming this is required
		[Required]
		public String Arch { get; set; }

		//Assumed Requires
		[Required] 
		public String Platform { get; set; }

		public PackageSide Side { get; set; } = PackageSide.Universal;

		//Assuming required
		public ICollection<InterfaceProvision> Interfaces { get; set; }

		/// <summary>
		/// Dependencies on other packages, assuming not required.
		/// Assumed not required due to possibility of no dependencies.
		/// </summary>
		/// <value>
		/// The dependencies.
		/// </value>
		public DependencySpec Dependencies { get; set; }

		/// <summary>
		/// Conflicts with other packages, assuming not required.
		/// Assuming not required due to possibility of no conflicts.
		/// </summary>
		/// <value>
		/// The conflicts.
		/// </value>
		public ICollection<PackageConflict> Conflicts { get; set; }

		/// <summary>
		/// What are hashes in this context?
		/// Should they be required?
		/// What are they hashes of?
		/// </summary>
		/// <value>
		/// The hashes.
		/// </value>
		public ICollection<String> Hashes { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether this <see cref="Build" /> is stable.
		/// Assuming this is Required.
		/// </summary>
		/// <value>
		/// {D255958A-8513-4226-94B9-080D98F904A1}  <c>true</c> if stable; otherwise, <c>false</c>.
		/// </value>
		public bool Stable { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether this <see cref="Build" /> is recommended.
		/// Assuming this is not required.
		/// </summary>
		/// <value>
		/// {D255958A-8513-4226-94B9-080D98F904A1}  <c>true</c> if recommended; otherwise, <c>false</c>.
		/// </value>
		public bool? Recommended { get; set; }
	}
}
