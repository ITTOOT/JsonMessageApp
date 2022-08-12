namespace JsonMessageApi.Models
{
    /// <summary>
    /// Diese Nachricht wird gesendet um einen Materialstamm anzulegen oder zum aktualisieren eines vorhandenen Materialstamms.
    /// </summary>
    public interface ICreateMaterialMaster : IHostMessage
	{
		/// <summary>
		/// ArticleNo 
		/// Artikelnummer
		/// </summary>
		string ArticleNo { get; set; }

		/// <summary>
		/// Description 
		/// Artikelbeschreibung
		/// </summary>
		string Description { get; set; }

        /// <summary>
        /// PackagingUnit 
        /// Verpackungseinheit (VE). Stk, Pack, m, mm. Default Wert Stk
        /// </summary>
        Constants.PackagingUnit? PackagingUnit { get; set; }

		/// <summary>
		/// IsLotNoRequired 
		/// True = Charge muss beim WE vorhanden sein 
		/// </summary>
		bool? IsLotNoRequired { get; set; }

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

		/// <summary>
		/// StorageArea 
		/// Lagerbereich eindeutig im kompletten System (Lagernummer) 
		/// </summary>
		string StorageArea { get; set; }

		/// <summary>
		/// Subdescription1 
		/// Weitere Artikelbeschreibungen
		/// </summary>
		string Subdescription1 { get; set; }

		/// <summary>
		/// Subdescription2 
		/// Weitere Artikelbeschreibungen
		/// </summary>
		string Subdescription2 { get; set; }

		/// <summary>
		/// Subdescription3 
		/// Weitere Artikelbeschreibungen
		/// </summary>
		string Subdescription3 { get; set; }

		/// <summary>
		/// Subdescription4 
		/// Weitere Artikelbeschreibungen
		/// </summary>
		string Subdescription4 { get; set; }

		/// <summary>
		/// AbcArea 
		/// Der bevorzugte Bereich in den ein Artikel eingelagert werden sollte.
		/// </summary>
		string AbcArea { get; set; }

	}
}