using System;

namespace Bifrost.Models {

	public class ConflictResolution {

		public DependencyConflictResolution Dependencies { get; set; }

		public InstallationConflictResolution Install { get; set; }
	}
}
