namespace JsonMessageApi.Models
{
    /// <summary>
    /// Stornoanfrage von Host
    /// </summary>
    public interface ICancelRequest : IHostMessage
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

	}
}