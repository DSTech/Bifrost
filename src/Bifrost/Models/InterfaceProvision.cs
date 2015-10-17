using System;
using System.ComponentModel.DataAnnotations;

namespace Bifrost.Models {

	public class InterfaceProvision {

		[Key]
		public int Id { get; set; }

		/// <summary>
		/// Package Name?
		/// Assuming Required?
		/// Gets or sets the name.
		/// </summary>
		/// <value>
		/// The name.
		/// </value>
		public String Name { get; set; }

		/// <summary>
		/// Package Version?
		/// Assuming required? 
		/// Gets or sets the version.
		/// </summary>
		/// <value>
		/// The version.
		/// </value>
		public Version Version { get; set; }
	}
}
