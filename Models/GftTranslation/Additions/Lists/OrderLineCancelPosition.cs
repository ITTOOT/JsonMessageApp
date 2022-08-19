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
	public partial class OrderLineCancelPosition : HostMessage, IOutgoingGoodsPosition
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
        /// OutgoingGoodsNo 
        /// Warenausgangsnummer
        /// </summary>
        [XmlAttribute]
		[JsonProperty]
		public string OutgoingGoodsNo { get; set; }
		/// <summary>
		/// PositionNo 
		/// Position des übermittelten Warenein- oder ausgangs
		/// </summary>
		[XmlAttribute]
		[JsonProperty]
		public string PositionNo { get; set; }
		/// <summary>
		/// MovementType 
		/// Art der Bewegung
		/// </summary>
		[XmlAttribute]
		[JsonProperty]
		public Constants.MovementType? MovementType { get; set; }
		/// <summary>
		/// ArticleNo 
		/// Artikelnummer
		/// </summary>
		[XmlAttribute]
		[JsonProperty]
		public string ArticleNo { get; set; }
		/// <summary>
		/// LotNo 
		/// Charge
		/// </summary>
		[XmlAttribute]
		[JsonProperty]
		public string LotNo { get; set; }
		/// <summary>
		/// TargetQty 
		/// Menge
		/// </summary>
		[XmlAttribute]
		[JsonProperty]
		public decimal? TargetQty { get; set; }
		/// <summary>
		/// Client 
		/// Der Besitzer eines Bestandes oder der eines Artikels
		/// </summary>
		[XmlAttribute]
		[JsonProperty]
		public string Client { get; set; }
		/// <summary>
		/// Variant 
		/// Variante des Artikels 
		/// </summary>
		[XmlAttribute]
		[JsonProperty]
		public string Variant { get; set; }

	}
}