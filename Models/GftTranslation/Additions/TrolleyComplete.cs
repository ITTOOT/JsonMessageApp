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
	public partial class TrolleyComplete : HostMessage // , ITubAssignment
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
		public long TrolleyId { get; set; }

		/// <summary>
		/// TubNo 
		/// </summary>
		[XmlAttribute]
		[JsonProperty]
		public string ToteId { get; set; }

        /// <summary>
		/// OutgoingGoodsPositions
		/// </summary>
		[XmlElement("TubPosition")]
        [JsonProperty]
        public List<TubPosition> TubPositions { get; set; }

    }
}