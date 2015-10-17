using System;
using System.ComponentModel.DataAnnotations;

namespace Bifrost.Models {

	public class Author {

        [Key]
        public int Id { get; set; }

        [Required]
        public String Name { get; set; }

        [Required]
		public String Email { get; set; }

		public override string ToString() {
			var nameExists = !String.IsNullOrWhiteSpace(Name);
			var emailExists = !String.IsNullOrWhiteSpace(Email);
			if (nameExists) {
				if (emailExists) {
					return $"{Name} <{Email}>";
				} else {
					return Name;
				}
			} else {
				if (emailExists) {
					return $"<{Email}>";
				} else {
					return "";
				}
			}
		}
	}
}
