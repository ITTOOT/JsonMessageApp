namespace JsonMessageApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Xml.Serialization;

    using Microsoft.EntityFrameworkCore;

    using Newtonsoft.Json;

    public partial class InterfaceMessage
    {
        [NotMapped]
        [JsonProperty("stockReport")]
        public StockReport stockReport { get; set; }
    }

    [Serializable()]
	[JsonObject(MemberSerialization.OptIn)]
	public partial class StockReport : HostMessage, IStockReport
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
        /// ArticleNo 
        /// </summary>
        [XmlAttribute]
		[JsonProperty]
		public string ArticleNo { get; set; }

		/// <summary>
		/// ActualQty 
		/// </summary>
		[XmlAttribute]
		[JsonProperty]
		public decimal? ActualQty { get; set; } // WAS decimal? NEW long?

        /// <summary>
        /// StorageArea 
        /// </summary>
        [XmlAttribute]
		[JsonProperty]
		public string StorageArea { get; set; }

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

	}
}