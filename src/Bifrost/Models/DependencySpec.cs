using System;

namespace Bifrost.Models {

	public class DependencySpec {

		public PackageDependency[] Packages { get; set; }

		public InterfaceDependency[] Interfaces { get; set; }
	}
}
