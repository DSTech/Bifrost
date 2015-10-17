using System;
using System.ComponentModel.DataAnnotations;

namespace Bifrost.Models {

    /// <summary>
    /// Defines a Package Dependency
    /// i.e. a specific build of a package that another package depends on
    /// </summary>
    public class PackageDependency {

        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Name of the depended upon package.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        [Required]
        public String Name { get; set; }

        /// <summary>
        /// Version specification of the depended upon package.
        /// Defines min and max versions.
        /// </summary>
        /// <value>
        /// The version specification.
        /// </value>
        [Required]
        public VersionSpec Version { get; set; }

        [Required]
		public PackageSide Side { get; set; }
	}
}
