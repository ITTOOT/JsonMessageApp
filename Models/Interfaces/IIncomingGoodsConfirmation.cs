namespace JsonMessageApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Xml.Serialization;

    using Microsoft.EntityFrameworkCore;

    using Newtonsoft.Json;

    /// <summary>
    /// Wird Material in eine LE der StoreWare gebucht, so wird dem übergeordneten System eine Wareneingangsmeldung gesendet.
    /// </summary>
    public interface IIncomingGoodsConfirmation : IHostMessage
	{


		/// <summary>
		/// IncomingGoodsNo 
		/// Ladungsträger (Barcode ohne Richtungskennung) 
		/// </summary>
		string IncomingGoodsNo { get; set; }

		/// <summary>
		/// FiFo 
		/// First-in-first-out: eventuel von der Dispostrategie benutzt (e.g. älteres Material wird bevorzugt)
		/// </summary>
		DateTime? FiFo { get; set; }

		/// <summary>
		/// MovementType 
		/// Art der Bewegung
		/// </summary>
		Constants.MovementType? MovementType { get; set; }

		/// <summary>
		/// StorageArea 
		/// Lagerbereich eindeutig im kompletten System (Lagernummer) 
		/// </summary>
		string StorageArea { get; set; }

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
		/// Variant 
		/// Variante des Artikels 
		/// </summary>
		string Variant { get; set; }

	}
}