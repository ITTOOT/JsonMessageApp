namespace JsonMessageApi.Models
{
    /// <summary>
    /// Position
    /// hostMessage.Description
    /// </summary>
    public interface IOutgoingGoodsPosition : IHostMessage
	{
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
        /// MovementType 
        /// Art der Bewegung
        /// </summary>
        Constants.MovementType? MovementType { get; set; }

		/// <summary>
		/// ArticleNo 
		/// Artikelnummer
		/// </summary>
		string ArticleNo { get; set; }

		/// <summary>
		/// LotNo 
		/// Charge
		/// </summary>
		string LotNo { get; set; }

		/// <summary>
		/// TargetQty 
		/// Menge
		/// </summary>
		decimal? TargetQty { get; set; }

		/// <summary>
		/// Client 
		/// Der Besitzer eines Bestandes oder der eines Artikels
		/// </summary>
		string Client { get; set; }

		/// <summary>
		/// Variant 
		/// Variante des Artikels 
		/// </summary>
		string Variant { get; set; }

	}


}