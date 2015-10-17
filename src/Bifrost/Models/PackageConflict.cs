using System;
using System.ComponentModel.DataAnnotations;

namespace Bifrost.Models {

	public class PackageConflict {

        [Key]
        public int Id { get; set; }

        public ConflictCondition Condition { get; set; }

		public ConflictResolution Resolution { get; set; }
	}
}
