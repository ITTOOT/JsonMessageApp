namespace JsonMessageApi.Models
{
    /// <summary>
    /// Diese Nachricht wird verwendet, um einen Artikel aus dem Artikelstamm der StoreWare zu löschen.
    /// </summary>
    public interface IDeleteMaterialMaster : IHostMessage
	{
		/// <summary>
		/// ArticleNo 
		/// Artikelnummer
		/// </summary>
		string ArticleNo { get; set; }

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