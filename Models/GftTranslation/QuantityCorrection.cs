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
        [JsonProperty("QuantityCorrection")]
        public QuantityCorrection QuantityCorrection { get; set; }
    }

    [Serializable()]
	[JsonObject(MemberSerialization.OptIn)]
	public partial class QuantityCorrection : HostMessage, IQuantityCorrection
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
        //[JsonProperty("StorageArea")]
        public string StorageArea { get; set; }

		/// <summary>
		/// ArticleNo 
		/// </summary>
		[XmlAttribute]
        [JsonProperty]
        //[JsonProperty("ArticleNo")]
        public string ArticleNo { get; set; }

		/// <summary>
		/// MovementType 
		/// </summary>
		[XmlAttribute]
        [JsonProperty]
        //[JsonProperty("Username")]
        public Constants.MovementType? MovementType { get; set; }

		/// <summary>
		/// TargetQty 
		/// </summary>
		[XmlAttribute]
        [JsonProperty]
        //[JsonProperty("TargetQty")]
        public decimal? TargetQty { get; set; }

		/// <summary>
		/// ActualQty 
		/// </summary>
		[XmlAttribute]
        [JsonProperty]
        //[JsonProperty("ActualQty")]
        public decimal? ActualQty { get; set; } // WAS decimal? NEW long?

        /// <summary>
        /// Barcode 
        /// </summary>
        [XmlAttribute]
        [JsonProperty]
        //[JsonProperty("Barcode")]
        public string Barcode { get; set; }

		/// <summary>
		/// ReasonCode 
		/// </summary>
		[XmlAttribute]
        [JsonProperty]
        //[JsonProperty("ReasonCode")]
        public string ReasonCode { get; set; } // WAS string NEW long?

        /// <summary>
        /// Username 
        /// </summary>
        [XmlAttribute]
		[JsonProperty]
        //[JsonProperty("Username")]
        public string Username { get; set; }

	}
}