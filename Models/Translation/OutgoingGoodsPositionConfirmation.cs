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
	public partial class OutgoingGoodsPositionConfirmation : HostMessage, IOutgoingGoodsPositionConfirmation
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
        /// MovementType 
        /// </summary>
        [XmlAttribute]
		[JsonProperty]
		public Constants.MovementType? MovementType { get; set; }

		/// <summary>
		/// OutgoingGoodsNo 
		/// </summary>
		[XmlAttribute]
		[JsonProperty]
		public string OutgoingGoodsNo { get; set; }

		/// <summary>
		/// PositionNo 
		/// </summary>
		[XmlAttribute]
		[JsonProperty]
		public string PositionNo { get; set; }

		/// <summary>
		/// ArticleNo 
		/// </summary>
		[XmlAttribute]
		[JsonProperty]
		public string ArticleNo { get; set; }

		/// <summary>
		/// LotNo 
		/// </summary>
		[XmlAttribute]
		[JsonProperty]
		public string LotNo { get; set; }

		/// <summary>
		/// TargetQty 
		/// </summary>
		[XmlAttribute]
		[JsonProperty]
		public decimal? TargetQty { get; set; }

		/// <summary>
		/// ActualQty 
		/// </summary>
		[XmlAttribute]
		[JsonProperty]
		public decimal? ActualQty { get; set; }

		/// <summary>
		/// StorageArea 
		/// </summary>
		[XmlAttribute]
		[JsonProperty]
		public string StorageArea { get; set; }

		/// <summary>
		/// DestinationRackNo 
		/// </summary>
		[XmlAttribute]
		[JsonProperty]
		public string DestinationRackNo { get; set; }

		/// <summary>
		/// DestinationRackPosition 
		/// </summary>
		[XmlAttribute]
		[JsonProperty]
		public string DestinationRackPosition { get; set; }

		/// <summary>
		/// TrolleyNo 
		/// </summary>
		[XmlAttribute]
		[JsonProperty]
		public string TrolleyNo { get; set; }

		/// <summary>
		/// TubNo 
		/// </summary>
		[XmlAttribute]
		[JsonProperty]
		public string TubNo { get; set; }

		/// <summary>
		/// Destination 
		/// </summary>
		[XmlAttribute]
		[JsonProperty]
		public string Destination { get; set; }

		/// <summary>
		/// Barcode 
		/// </summary>
		[XmlAttribute]
		[JsonProperty]
		public string Barcode { get; set; }

		/// <summary>
		/// BatchId 
		/// </summary>
		[XmlAttribute]
		[JsonProperty]
		public string BatchId { get; set; }

		/// <summary>
		/// Username 
		/// </summary>
		[XmlAttribute]
		[JsonProperty]
		public string Username { get; set; }

		/// <summary>
		/// Name 
		/// </summary>
		[XmlAttribute]
		[JsonProperty]
		public string Name { get; set; }

	}
}