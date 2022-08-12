namespace JsonMessageApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Xml.Serialization;

    using Microsoft.EntityFrameworkCore;

    using Newtonsoft.Json;

    [Serializable()]
	[JsonObject(MemberSerialization.OptIn)]
	public partial class IncomingGoodsPosition : HostMessage // , IIncomingGoodsPosition
    {
        public static Func<IHostMessage, bool> OnHandle;

        public override bool Handle()
        {
            if (OnHandle == null)
            {
                throw new NotImplementedException($"{nameof(OnHandle)} was not set in Class {nameof(OrderStart)}");
            }
            else
            {
                return OnHandle.Invoke(this);
            }
        }

        /// <summary>
        /// StorageArea 
        /// Lagerbereich eindeutig im kompletten System (Lagernummer) 
        /// </summary>
        [XmlAttribute]
		[JsonProperty]
		public string StorageArea { get; set; }
		/// <summary>
		/// IncomingGoodsNo 
		/// Ladungsträger (Barcode ohne Richtungskennung) 
		/// </summary>
		[XmlAttribute]
		[JsonProperty]
		public string IncomingGoodsNo { get; set; }
		/// <summary>
		/// PositionNo 
		/// Automatisch durch Combo hinzugefügt.
		/// </summary>
		[XmlAttribute]
		[JsonProperty]
		public string PositionNo { get; set; }
		/// <summary>
		/// ArticleNo Artikelnummer
		/// Artikelnummer
		/// </summary>
		[XmlAttribute]
		[JsonProperty]
		public string ArticleNo { get; set; }
		/// <summary>
		/// LotNo Charge
		/// Charge
		/// </summary>
		[XmlAttribute]
		[JsonProperty]
		public string LotNo { get; set; }
		/// <summary>
		/// Variant 
		/// Variante des Artikels 
		/// </summary>
		[XmlAttribute]
		[JsonProperty]
		public string Variant { get; set; }
		/// <summary>
		/// ExpirationDate Chargennummer
		/// Mindesthaltbarkeitsdatum
		/// </summary>
		[XmlAttribute]
		[JsonProperty]
		public DateTime? ExpirationDate { get; set; }
		/// <summary>
		/// SpecialStockNo Sonderbestandsnummer
		/// Sonderbestandsnummer
		/// </summary>
		[XmlAttribute]
		[JsonProperty]
		public string SpecialStockNo { get; set; }
		/// <summary>
		/// SpecialStockIndicator Sonderbestandskennzeichen
		/// Sonderbestandskennzeichen
		/// </summary>
		[XmlAttribute]
		[JsonProperty]
		public string SpecialStockIndicator { get; set; }
		/// <summary>
		/// FiFo DateTime
		/// First-in-first-out: eventuel von der Dispostrategie benutzt (e.g. älteres Material wird bevorzugt)
		/// </summary>
		[XmlAttribute]
		[JsonProperty]
		public DateTime? FiFo { get; set; }
		/// <summary>
		/// TargetQty Einzulagernde Menge
		/// Menge
		/// </summary>
		[XmlAttribute]
		[JsonProperty]
		public decimal? TargetQty { get; set; }

	}
}