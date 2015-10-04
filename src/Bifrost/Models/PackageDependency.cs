using System;

namespace Bifrost.Models {

	public class PackageDependency {
		public String Name { get; set; }
		public VersionSpec Version { get; set; }
		public PackageSide Side { get; set; }
	}
}
