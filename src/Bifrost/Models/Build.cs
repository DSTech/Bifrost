using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Bifrost.Models {

	public class Build {

		[Key]
		public int Id { get; set; }


		public String Package { get; set; }

		public Version Version { get; set; }

		public String GivenVersion { get; set; }

		public String Arch { get; set; }

		public String Platform { get; set; }

		public PackageSide Side { get; set; } = PackageSide.Universal;

		public ICollection<InterfaceProvision> Interfaces { get; set; }

		public DependencySpec Dependencies { get; set; }

		public ICollection<PackageConflict> Conflicts { get; set; }

		public ICollection<String> Hashes { get; set; }

		public bool Stable { get; set; }

		public bool Recommended { get; set; }
	}
}
