namespace JsonMessageApi.Models
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Um einen Warenausgang auszulösen, müssen der StoreWare Warenausgangspositionen mit den erforderlichen Artikeln übermittelt werden. Die einzelnen Warenausgangspositionen eines Auftrags werden mit Warenausgangsnachricht, der übergeordnet die Warenausgangspositionen mit der Auftragsnummer zusammenhält. 
    /// </summary>
    public interface IOutgoingGoods : IHostMessage
	{


		/// <summary>
		/// StorageArea 
		/// Lagerbereich eindeutig im kompletten System (Lagernummer) 
		/// </summary>
		string StorageArea { get; set; }

		/// <summary>
		/// OutgoingGoodsNo 
		/// Warenausgangsnummer
		/// </summary>
		string OutgoingGoodsNo { get; set; }

		/// <summary>
		/// Destination 
		/// Packplatz für den ein WA kommissioniert wird (Tub)
		/// </summary>
		string Destination { get; set; }

        /// <summary>
        /// MovementType 
        /// Art der Bewegung
        /// </summary>
        Constants.MovementType? MovementType { get; set; }

        /// <summary>
        /// DispositionType 
        /// ‚Manual‘ = Auftrag wird durch Benutzer  manuell in der StoreWare gestartet. ‚Automatic‘ = Auftrag wird automatisch  gestartet, sobald der nächste Auftrag  kommissioniert werden kann
        /// </summary>
        Constants.DispositionType? DispositionType { get; set; }

		/// <summary>
		/// Priority 
		/// Priorität zur Abarbeitung. 1 = höchste Priorität Wenn nicht übermittelt wird 1 als Default Wert gesetzt
		/// </summary>
		int? Priority { get; set; }

		/// <summary>
		/// PriorityDate 
		/// Bildet zusammen mit Priority die Priorität. Wenn nicht übermittelt wird aktuelles Datum gesetzt
		/// </summary>
		DateTime? PriorityDate { get; set; }

		/// <summary>
		/// BatchId 
		/// Automatisch durch Combo hinzugefügt.
		/// </summary>
		string BatchId { get; set; }

		/// <summary>
		/// BatchPriority 
		/// Übergeordnete Priorität des gesamten Batch
		/// </summary>
		int? BatchPriority { get; set; }

		/// <summary>
		/// BatchPriorityTime 
		/// Übergeordnetes Prioritäts-Datum des gesamten Batch
		/// </summary>
		DateTime? BatchPriorityTime { get; set; }

		/// <summary>
		/// Module 
		/// Modulnummer
		/// </summary>
		string Module { get; set; }

		/// <summary>
		/// Client 
		/// Der Besitzer eines Bestandes oder der eines Artikels
		/// </summary>
		string Client { get; set; }

		/// <summary>
		/// OrderType 
		/// Auftragstyp
		/// </summary>
		string OrderType { get; set; }

		/// <summary>
		/// OutgoingGoods Positions 
		/// Um einen Warenausgang auszulösen, müssen der StoreWare Warenausgangspositionen mit den erforderlichen Artikeln übermittelt werden. Die einzelnen Warenausgangspositionen eines Auftrags werden mit Warenausgangsnachricht, der übergeordnet die Warenausgangspositionen mit der Auftragsnummer zusammenhält. 
		/// </summary>
		List<OutgoingGoodsPosition> Positions { get; }
	}
}