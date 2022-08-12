
namespace JsonMessageApi.Models
{

	/// <summary>
	/// Warenausgangsquittierung an Hostsystem auf Pickebene
	/// </summary>
	public interface IOutgoingGoodsPositionConfirmation : IHostMessage
	{


		/// <summary>
		/// MovementType 
		/// Art der Bewegung
		/// </summary>
		Constants.MovementType? MovementType { get; set; }

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
		/// DestinationRackNo 
		/// Ident of the destination rack
		/// </summary>
		string DestinationRackNo { get; set; }

		/// <summary>
		/// DestinationRackPosition 
		/// Ident of a position at the destination rack
		/// </summary>
		string DestinationRackPosition { get; set; }

		/// <summary>
		/// TrolleyNo 
		/// Ident of a Trolley
		/// </summary>
		string TrolleyNo { get; set; }

		/// <summary>
		/// TubNo 
		/// Ident of the Tub ((Box)
		/// </summary>
		string TubNo { get; set; }

		/// <summary>
		/// Destination 
		/// Packplatz für den ein WA kommissioniert wird (Tub)
		/// </summary>
		string Destination { get; set; }

		/// <summary>
		/// Barcode 
		/// Scanned Barcode placed at article
		/// </summary>
		string Barcode { get; set; }

		/// <summary>
		/// BatchId 
		/// Automatisch durch Combo hinzugefügt.
		/// </summary>
		string BatchId { get; set; }

		/// <summary>
		/// Username 
		/// 
		/// </summary>
		string Username { get; set; }

		/// <summary>
		/// Name 
		/// 
		/// </summary>
		string Name { get; set; }

	}
}