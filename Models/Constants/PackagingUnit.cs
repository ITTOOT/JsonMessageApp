namespace JsonMessageApi.Models.Constants
{
    public enum PackagingUnit
	{
		/// <summary>
		///   pieces.
		/// </summary>
		Pcs,

		/// <summary>
		///   meter
		/// </summary>
		M,

		/// <summary>
		///   millimeter
		/// </summary>
		MM,

		/// <summary>
		///   used for OrdersMiniload to retrieve a le from shelf and put it to the output lane
		/// </summary>
		Pack
	}
}