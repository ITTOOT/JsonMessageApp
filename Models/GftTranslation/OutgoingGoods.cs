namespace JsonMessageApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
	using System.Diagnostics.CodeAnalysis;
	using System.Xml.Serialization;

    using Microsoft.EntityFrameworkCore;

    using Newtonsoft.Json;

    [Serializable()]
	[JsonObject(MemberSerialization.OptIn)]
	public partial class OutgoingGoods : HostMessage, IOutgoingGoods
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
        /// </summary>
        [XmlAttribute]
		[JsonProperty]
		public string StorageArea { get; set; }

		/// <summary>
		/// OutgoingGoodsNo 
		/// </summary>
		[XmlAttribute]
		[JsonProperty]
		public string OutgoingGoodsNo { get; set; }

		/// <summary>
		/// Destination 
		/// </summary>
		[XmlAttribute]
		[JsonProperty]
		public string Destination { get; set; }

		/// <summary>
		/// MovementType 
		/// </summary>
		[XmlAttribute]
		[JsonProperty]
		public Constants.MovementType? MovementType { get; set; }

		/// <summary>
		/// DispositionType 
		/// </summary>
		[XmlAttribute]
		[JsonProperty]
		public Constants.DispositionType? DispositionType { get; set; }

		/// <summary>
		/// Priority 
		/// </summary>
		[XmlAttribute]
		[JsonProperty]
		public int? Priority { get; set; }

		/// <summary>
		/// PriorityDate 
		/// </summary>
		[XmlAttribute]
		[JsonProperty]
		public DateTime? PriorityDate { get; set; }

		/// <summary>
		/// BatchId 
		/// </summary>
		[XmlAttribute]
		[JsonProperty]
		public string BatchId { get; set; }

		/// <summary>
		/// BatchPriority 
		/// </summary>
		[XmlAttribute]
		[JsonProperty]
		public int? BatchPriority { get; set; }

		/// <summary>
		/// BatchPriorityTime 
		/// </summary>
		[XmlAttribute]
		[JsonProperty]
		public DateTime? BatchPriorityTime { get; set; }

		/// <summary>
		/// Module 
		/// </summary>
		[XmlAttribute]
		[JsonProperty]
		public string Module { get; set; }

		/// <summary>
		/// Client 
		/// </summary>
		[XmlAttribute]
		[JsonProperty]
		public string Client { get; set; }

		/// <summary>
		/// OrderType 
		/// </summary>
		[XmlAttribute]
		[JsonProperty]
		public string OrderType { get; set; }

		/// <summary>
		/// OutgoingGoodsPositions
		/// </summary>
		[XmlElement("OutgoingGoodsPosition")]
		[JsonProperty]
		public List<OutgoingGoodsPosition> Positions { get; set; }

	}
}