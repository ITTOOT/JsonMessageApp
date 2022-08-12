namespace JsonMessageApi.Models
{
    /// <summary>
    /// Wird eine Mengenkorrektur vorgenommen, so werden die Mengenänderungen dem übergeordneten System mit der Korrekturbuchung mitgeteilt.
    /// </summary>
    public interface IQuantityCorrection : IHostMessage
	{
		/// <summary>
		/// StorageArea 
		/// Lagerbereich eindeutig im kompletten System (Lagernummer) 
		/// </summary>
		string StorageArea { get; set; }

		/// <summary>
		/// ArticleNo 
		/// Artikelnummer
		/// </summary>
		string ArticleNo { get; set; }

        /// <summary>
        /// MovementType 
        /// Art der Bewegung
        /// </summary>
        Constants.MovementType? MovementType { get; set; }

		/// <summary>
		/// TargetQty 
		/// Menge
		/// </summary>
		decimal? TargetQty { get; set; }

		/// <summary>
		/// ActualQty 
		/// Menge
		/// </summary>
		decimal? ActualQty { get; set; }

		/// <summary>
		/// Barcode 
		/// Scanned Barcode placed at article
		/// </summary>
		string Barcode { get; set; }

		/// <summary>
		/// ReasonCode 
		/// 
		/// </summary>
		string ReasonCode { get; set; }

		/// <summary>
		/// Username 
		/// 
		/// </summary>
		string Username { get; set; }

	}
}