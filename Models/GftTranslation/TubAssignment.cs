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
	public partial class TubAssignment : HostMessage, ITubAssignment
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
		public string StorageArea { get; set; } // WAS string NEW long?

        /// <summary>
        /// TubNo 
        /// </summary>
        [XmlAttribute]
		[JsonProperty]
		public string TubNo { get; set; } // WAS string NEW long?

        /// <summary>
        /// TrolleyNo 
        /// </summary>
        [XmlAttribute]
		[JsonProperty]
		public string TrolleyNo { get; set; } // WAS string NEW long?

        /// <summary>
        /// Destination 
        /// </summary>
        [XmlAttribute]
		[JsonProperty]
		public string Destination { get; set; }

        /// <summary>
        /// BatchId 
        /// </summary>
        [XmlAttribute]
		[JsonProperty]
		public string BatchId { get; set; }

	}
}