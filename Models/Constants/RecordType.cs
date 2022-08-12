namespace JsonMessageApi.Models.Constants
{
    /// <summary>
    ///   enums used to specify message types and positions in messages
    /// </summary>
    public enum RecordType
	{
		CreateMaterialMaster,
		IncomingGoods,
		IncomingGoodsPosition,
		IncomingGoodsConfirmation,
		OutgoingGoods,
		OutgoingGoodsPosition,
		OutgoingGoodsConfirmation,
		OutgoingGoodsPositionConfirmation,

		/// <summary>
		///   correction to quantities unrelated to movements requested by the ERP system.
		/// </summary>
		QuantityCorrection,
		DeleteMaterialMaster,

		/// <summary>
		///   Signal to the ERP system that a particular order is started
		/// </summary>
		OrderStart,
		Undefined,
		/// <summary>
		/// request a cancellation of an outgoing goods order
		/// </summary>
		CancelRequest,
		/// <summary>
		/// the response to <see cref="CancelRequest"/>.
		/// </summary>
		CancelRequestReply,
		StockReport,
		TubAssignment,
		PickCancelation
	}
}