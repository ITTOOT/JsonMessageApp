namespace JsonMessageApi.Models.Constants
{
    public enum MovementType
	{
		/// <summary>
		/// if the movement is initiated by the ERP system
		/// </summary>
		OutgoingPlanned,

		/// <summary>
		/// if the movement is initiated by WMS.
		/// </summary>
		OutgoingUnplanned,

		/// <summary>
		/// Consolidating positions of two LEs into one
		/// </summary>
		Consolidation,

		/// <summary>
		/// Manual counting the actual amount of stored goods
		/// </summary>
		Stocktaking,

		/// <summary>
		/// Visual inspection of goods by a user
		/// </summary>
		VisualControl,

		/// <summary>
		/// Moving goods from one LE to another
		/// </summary>
		InternalTransfer,

		/// <summary>
		/// Incoming movement as ordered by ERP system
		/// </summary>
		IncomingPlanned,
		/// <summary>
		/// Incoming movement initiated by a user 
		/// </summary>
		IncomingUnplanned,

		/// <summary>
		/// movement is initiated by the ERP system
		/// </summary>
		Delivery,

		/// <summary>
		/// movement is initiated by the ERP system
		/// </summary>
		Production,

		/// <summary>
		/// In the case of an error or missing information-
		/// </summary>
		Undefined
	}
}
