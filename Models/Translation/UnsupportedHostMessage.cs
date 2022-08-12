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
	public partial class UnsupportedHostMessage : HostMessage
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
        /// ArticleNo Artikelnummer
        /// </summary>
        [XmlAttribute]
		[JsonProperty]
		public string ArticleNo { get; set; }
		/// <summary>
		/// Variant Variante des Artikels 
		/// </summary>
		[XmlAttribute]
		[JsonProperty]
		public string Variant { get; set; }
		/// <summary>
		/// Description Artikelbeschreibung
		/// </summary>
		[XmlAttribute]
		[JsonProperty]
		public string Description { get; set; }
		/// <summary>
		/// Warning Text, der zusätzlich hervorgehoben angezeigt wird. Beispielsweise Gefahrgut, Chemie
		/// </summary>
		[XmlAttribute]
		[JsonProperty]
		public string Warning { get; set; }
		/// <summary>
		/// PackagingUnit Verpackungseinheit (VE). Stk, Pack, m, mm. Default Wert Stk
		/// </summary>
		[XmlAttribute]
		[JsonProperty]
		public Constants.PackagingUnit? PackagingUnit { get; set; }
		/// <summary>
		/// PackagingQty Verpackungsmenge
		/// </summary>
		[XmlAttribute]
		[JsonProperty]
		public decimal? PackagingQty { get; set; }
		/// <summary>
		/// IsLotNoRequired True = Charge muss beim WE vorhanden sein 
		/// </summary>
		[XmlAttribute]
		[JsonProperty]
		public bool? IsLotNoRequired { get; set; }
		/// <summary>
		/// IsExpirationDateRequired True = Mindesthaltbarkeit muss beim WE vorhanden sein
		/// </summary>
		[XmlAttribute]
		[JsonProperty]
		public bool? IsExpirationDateRequired { get; set; }
		/// <summary>
		/// Weight Gewicht in Gramm
		/// </summary>
		[XmlAttribute]
		[JsonProperty]
		public int? Weight { get; set; }
		/// <summary>
		/// Length Länge im mm 
		/// </summary>
		[XmlAttribute]
		[JsonProperty]
		public int? Length { get; set; }
		/// <summary>
		/// Width Breite in mm 
		/// </summary>
		[XmlAttribute]
		[JsonProperty]
		public int? Width { get; set; }
		/// <summary>
		/// Height Höhe in mm
		/// </summary>
		[XmlAttribute]
		[JsonProperty]
		public int? Height { get; set; }
		/// <summary>
		/// ImageFileNameArticle Dateiname für ein Artikelbild
		/// </summary>
		[XmlAttribute]
		[JsonProperty]
		public string ImageFileNameArticle { get; set; }
		/// <summary>
		/// ImageFileNamePackingInstructions Dateiname für ein Bild für eine Packanleitung für den Wareneingang 
		/// </summary>
		[XmlAttribute]
		[JsonProperty]
		public string ImageFileNamePackingInstructions { get; set; }
		/// <summary>
		/// StorageArea Lagerbereich eindeutig im kompletten System (Lagernummer) 
		/// </summary>
		[XmlAttribute]
		[JsonProperty]
		public string StorageArea { get; set; }
		/// <summary>
		/// IncomingGoodsNo Ladungsträger (Barcode ohne Richtungskennung) 
		/// </summary>
		[XmlAttribute]
		[JsonProperty]
		public string IncomingGoodsNo { get; set; }
		/// <summary>
		/// MovementType Art der Bewegung
		/// </summary>
		[XmlAttribute]
		[JsonProperty]
		public Constants.MovementType? MovementType { get; set; }
		/// <summary>
		/// LotNo Charge
		/// </summary>
		[XmlAttribute]
		[JsonProperty]
		public string LotNo { get; set; }
		/// <summary>
		/// ExpirationDate Mindesthaltbarkeitsdatum
		/// </summary>
		[XmlAttribute]
		[JsonProperty]
		public DateTime? ExpirationDate { get; set; }
		/// <summary>
		/// SpecialStockNo Sonderbestandsnummer
		/// </summary>
		[XmlAttribute]
		[JsonProperty]
		public string SpecialStockNo { get; set; }
		/// <summary>
		/// SpecialStockIndicator Sonderbestandskennzeichen
		/// </summary>
		[XmlAttribute]
		[JsonProperty]
		public string SpecialStockIndicator { get; set; }
		/// <summary>
		/// FiFo First-in-first-out: eventuel von der Dispostrategie benutzt (e.g. älteres Material wird bevorzugt)
		/// </summary>
		[XmlAttribute]
		[JsonProperty]
		public DateTime? FiFo { get; set; }
		/// <summary>
		/// TargetQty Menge
		/// </summary>
		[XmlAttribute]
		[JsonProperty]
		public decimal? TargetQty { get; set; }
		/// <summary>
		/// ActualQty Menge
		/// </summary>
		[XmlAttribute]
		[JsonProperty]
		public decimal? ActualQty { get; set; }
		/// <summary>
		/// OutgoingGoodsNo Warenausgangsnummer
		/// </summary>
		[XmlAttribute]
		[JsonProperty]
		public string OutgoingGoodsNo { get; set; }
		/// <summary>
		/// Destination Packplatz für den ein WA kommissioniert wird (Tub)
		/// </summary>
		[XmlAttribute]
		[JsonProperty]
		public string Destination { get; set; }
		/// <summary>
		/// DispositionType ‚Manual‘ = Auftrag wird durch Benutzer  manuell in der StoreWare gestartet. ‚Automatic‘ = Auftrag wird automatisch  gestartet, sobald der nächste Auftrag  kommissioniert werden kann
		/// </summary>
		[XmlAttribute]
		[JsonProperty]
		public Constants.DispositionType? DispositionType { get; set; }
		/// <summary>
		/// Priority Priorität zur Abarbeitung. 1 = höchste Priorität Wenn nicht übermittelt wird 1 als Default Wert gesetzt
		/// </summary>
		[XmlAttribute]
		[JsonProperty]
		public int? Priority { get; set; }
		/// <summary>
		/// PriorityDate Bildet zusammen mit Priority die Priorität. Wenn nicht übermittelt wird aktuelles Datum gesetzt
		/// </summary>
		[XmlAttribute]
		[JsonProperty]
		public DateTime? PriorityDate { get; set; }
		/// <summary>
		/// PositionNo Position des übermittelten Warenein- oder ausgangs
		/// </summary>
		[XmlAttribute]
		[JsonProperty]
		public string PositionNo { get; set; }
		/// <summary>
		/// CorrectionQty Korrekturmenge, Wert negativ = weniger als geführter Bestand Wert positiv = mehr als geführter Bestand
		/// </summary>
		[XmlAttribute]
		[JsonProperty]
		public decimal? CorrectionQty { get; set; }
		/// <summary>
		/// AbcArea Der bevorzugte Bereich in den ein Artikel eingelagert werden sollte.
		/// </summary>
		[XmlAttribute]
		[JsonProperty]
		public string AbcArea { get; set; }
		/// <summary>
		/// BatchId Automatisch durch Combo hinzugefügt.
		/// </summary>
		[XmlAttribute]
		[JsonProperty]
		public string BatchId { get; set; }
		/// <summary>
		/// Client Der Besitzer eines Bestandes oder der eines Artikels
		/// </summary>
		[XmlAttribute]
		[JsonProperty]
		public string Client { get; set; }
		/// <summary>
		/// IsCanceled Auftrag storniert J/N
		/// </summary>
		[XmlAttribute]
		[JsonProperty]
		public bool? IsCanceled { get; set; }
		/// <summary>
		/// Workstation Die Workstation an welcher Auftrag kommissioniert werden soll
		/// </summary>
		[XmlAttribute]
		[JsonProperty]
		public string Workstation { get; set; }
		/// <summary>
		/// TrolleyNo Ident of a Trolley
		/// </summary>
		[XmlAttribute]
		[JsonProperty]
		public string TrolleyNo { get; set; }
		/// <summary>
		/// TubNo Ident of the Tub ((Box)
		/// </summary>
		[XmlAttribute]
		[JsonProperty]
		public string TubNo { get; set; }
		/// <summary>
		/// DestinationRackNo Ident of the destination rack
		/// </summary>
		[XmlAttribute]
		[JsonProperty]
		public string DestinationRackNo { get; set; }
		/// <summary>
		/// DestinationRackPosition Ident of a position at the destination rack
		/// </summary>
		[XmlAttribute]
		[JsonProperty]
		public string DestinationRackPosition { get; set; }
		/// <summary>
		/// Barcode Scanned Barcode placed at article
		/// </summary>
		[XmlAttribute]
		[JsonProperty]
		public string Barcode { get; set; }
		/// <summary>
		/// BatchPriority Übergeordnete Priorität des gesamten Batch
		/// </summary>
		[XmlAttribute]
		[JsonProperty]
		public int? BatchPriority { get; set; }
		/// <summary>
		/// BatchPriorityTime Übergeordnetes Prioritäts-Datum des gesamten Batch
		/// </summary>
		[XmlAttribute]
		[JsonProperty]
		public DateTime? BatchPriorityTime { get; set; }
		/// <summary>
		/// Module Modulnummer
		/// </summary>
		[XmlAttribute]
		[JsonProperty]
		public string Module { get; set; }
		/// <summary>
		/// Subdescription1 Weitere Artikelbeschreibungen
		/// </summary>
		[XmlAttribute]
		[JsonProperty]
		public string Subdescription1 { get; set; }
		/// <summary>
		/// Subdescription2 Weitere Artikelbeschreibungen
		/// </summary>
		[XmlAttribute]
		[JsonProperty]
		public string Subdescription2 { get; set; }
		/// <summary>
		/// Subdescription3 Weitere Artikelbeschreibungen
		/// </summary>
		[XmlAttribute]
		[JsonProperty]
		public string Subdescription3 { get; set; }
		/// <summary>
		/// Subdescription4 Weitere Artikelbeschreibungen
		/// </summary>
		[XmlAttribute]
		[JsonProperty]
		public string Subdescription4 { get; set; }
		/// <summary>
		/// Username 
		/// </summary>
		[XmlAttribute]
		[JsonProperty]
		public string Username { get; set; }
		/// <summary>
		/// ReasonCode 
		/// </summary>
		[XmlAttribute]
		[JsonProperty]
		public string ReasonCode { get; set; }
		/// <summary>
		/// BonusActivity 
		/// </summary>
		[XmlAttribute]
		[JsonProperty]
		public string BonusActivity { get; set; }
		/// <summary>
		/// OrderType Auftragstyp
		/// </summary>
		[XmlAttribute]
		[JsonProperty]
		public string OrderType { get; set; }
		/// <summary>
		/// LastIncoming 
		/// </summary>
		[XmlAttribute]
		[JsonProperty]
		public DateTime LastIncoming { get; set; }
		/// <summary>
		/// LastOutgoing 
		/// </summary>
		[XmlAttribute]
		[JsonProperty]
		public DateTime LastOutgoing { get; set; }
		/// <summary>
		/// CancelQty 
		/// </summary>
		[XmlAttribute]
		[JsonProperty]
		public decimal CancelQty { get; set; }
	}
}