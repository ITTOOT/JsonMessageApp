namespace JsonMessageApi.Models
{
    /// <summary>
    /// 
    /// </summary>
    public interface ITubAssignment : IHostMessage
	{
		/// <summary>
		/// StorageArea 
		/// Lagerbereich eindeutig im kompletten System (Lagernummer) 
		/// </summary>
		string StorageArea { get; set; }

		/// <summary>
		/// TubNo 
		/// Ident of the Tub ((Box)
		/// </summary>
		string TubNo { get; set; }

		/// <summary>
		/// TrolleyNo 
		/// Ident of a Trolley
		/// </summary>
		string TrolleyNo { get; set; }

		/// <summary>
		/// Destination 
		/// Packplatz für den ein WA kommissioniert wird (Tub)
		/// </summary>
		string Destination { get; set; }

		/// <summary>
		/// BatchId 
		/// Automatisch durch Combo hinzugefügt.
		/// </summary>
		string BatchId { get; set; }

	}
}