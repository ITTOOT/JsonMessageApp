namespace JsonMessageApi.Models
{
    /// <summary>
    /// 
    /// </summary>
    public interface IPickCancelation : IHostMessage
	{
		/// <summary>
		/// BatchId 
		/// Automatisch durch Combo hinzugefügt.
		/// </summary>
		string BatchId { get; set; }

		/// <summary>
		/// OutgoingGoodsNo 
		/// Warenausgangsnummer
		/// </summary>
		string OutgoingGoodsNo { get; set; }

		/// <summary>
		/// PositionNo 
		/// Position des übermittelten Warenein- oder ausgangs
		/// </summary>
		string PositionNo { get; set; }

		/// <summary>
		/// ArticleNo 
		/// Artikelnummer
		/// </summary>
		string ArticleNo { get; set; }

		/// <summary>
		/// CancelQty 
		/// 
		/// </summary>
		decimal CancelQty { get; set; }

		/// <summary>
		/// ReasonCode 
		/// 
		/// </summary>
		string ReasonCode { get; set; }

	}
}