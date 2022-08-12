namespace JsonMessageApi.Models
{
    using System;

    /// <summary>
    /// Bestandsabgleich
    /// </summary>
    public interface IStockReport : IHostMessage
	{
		/// <summary>
		/// ArticleNo 
		/// Artikelnummer
		/// </summary>
		string ArticleNo { get; set; }

		/// <summary>
		/// ActualQty 
		/// Menge
		/// </summary>
		decimal? ActualQty { get; set; }

		/// <summary>
		/// StorageArea 
		/// Lagerbereich eindeutig im kompletten System (Lagernummer) 
		/// </summary>
		string StorageArea { get; set; }

		/// <summary>
		/// LastIncoming 
		/// 
		/// </summary>
		DateTime LastIncoming { get; set; }

		/// <summary>
		/// LastOutgoing 
		/// 
		/// </summary>
		DateTime LastOutgoing { get; set; }

	}
}