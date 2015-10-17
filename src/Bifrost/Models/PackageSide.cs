namespace Bifrost.Models {

    /// <summary>
    /// Defines an enumeration for which side of the application the package is for
    /// i.e. is the package used by the Server, the application client, or both
    /// </summary>
    public enum PackageSide {
		Client,
		Server,
		Universal,
	}
}
